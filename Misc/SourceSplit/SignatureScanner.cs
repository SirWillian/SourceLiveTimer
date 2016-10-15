﻿using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Diagnostics;
using System.Globalization;

namespace SourceLiveTimer.SourceSplit
{
    public class SignatureScanner
    {
        private byte[] _memory;
        private Process _process;
        private IntPtr _address;
        private int _size;

        public IntPtr Address
        {
            get { return _address; }
            set {
                _memory = null;
                _address = value;
            }
        }

        public int Size
        {
            get { return _size; }
            set {
                _memory = null;
                _size = value;
            }
        }

        public Process Process
        {
            get { return _process; }
            set {
                _memory = null;
                _process = value;
            }
        }

        public SignatureScanner(Process proc, IntPtr addr, int size)
        {
            if (proc == null)
                throw new ArgumentException();
            if (addr == IntPtr.Zero)
                throw new ArgumentException();
            if (size <= 0)
                throw new ArgumentException();

            _process = proc;
            _address = addr;
            _size = size;
            _memory = new byte[1];
        }

        public IntPtr Scan(SigScanTarget target)
        {
            if (_memory == null || _memory.Length != _size)
            {
                _memory = new byte[_size];

                int read;
                if (!SafeNativeMethods.ReadProcessMemory(_process.Handle, _address, _memory, _size, out read)
                    || read != _size)
                {
                    _memory = null;
                    return IntPtr.Zero;
                }
            }

            foreach (SigScanTarget.Signature sig in target.Signatures)
            {
                IntPtr ptr = this.FindPattern(sig.Pattern, sig.Mask, sig.Offset);
                if (ptr != IntPtr.Zero)
                {
                    if (target.OnFound != null)
                        ptr = target.OnFound(_process, ptr);
                    return ptr;
                }
            }

            return IntPtr.Zero;
        }

        bool MaskCheck(int offset, byte[] sig, bool[] mask)
        {
            for (int i = 0; i < sig.Length; i++)
            {
                if (mask[i])
                    continue;

                if (sig[i] != _memory[offset + i])
                    return false;
            }

            return true;
        }

        IntPtr FindPattern(byte[] sig, bool[] mask, int offset)
        {
            for (int i = 0; i < _memory.Length; i++)
            {
                if (this.MaskCheck(i, sig, mask))
                    return IntPtr.Add(_address, (i + offset));
            }

            return IntPtr.Zero;
        }
    }

    public class SigScanTarget
    {
        public struct Signature
        {
            public byte[] Pattern;
            public bool[] Mask;
            public int Offset;
        }

        public delegate IntPtr OnFoundCallback(Process proc, IntPtr ptr);
        public OnFoundCallback OnFound { get; set; }

        private List<Signature> _sigs;
        public ReadOnlyCollection<Signature> Signatures { get { return _sigs.AsReadOnly(); } }

        public SigScanTarget()
        {
            _sigs = new List<Signature>();
        }

        public void AddSignature(int offset, params string[] signature)
        {
            string sigStr = String.Join(String.Empty, signature).Replace(" ", String.Empty);
            if (sigStr.Length % 2 != 0)
                throw new ArgumentException();

            var sigBytes = new List<byte>();
            var sigMask = new List<bool>();

            for (int i = 0; i < sigStr.Length; i += 2)
            {
                byte b;
                if (Byte.TryParse(sigStr.Substring(i, 2), NumberStyles.HexNumber, null, out b))
                {
                    sigBytes.Add(b);
                    sigMask.Add(false);
                }
                else
                {
                    sigBytes.Add(0);
                    sigMask.Add(true);
                }
            }

            _sigs.Add(new Signature {
                Pattern = sigBytes.ToArray(),
                Mask = sigMask.ToArray(),
                Offset = offset
            });
        }
    }
}
