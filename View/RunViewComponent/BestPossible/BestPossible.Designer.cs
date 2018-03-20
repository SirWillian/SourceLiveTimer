using System.Drawing;

namespace SourceLiveTimer.View
{
    partial class BestPossibleUI
    {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.tableLayoutPanel = new System.Windows.Forms.TableLayoutPanel();
            this.bestPossibleTextLabel = new System.Windows.Forms.Label();
            this.bestPossibleTimeLabel = new System.Windows.Forms.Label();
            this.tableLayoutPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel
            // 
            this.tableLayoutPanel.AutoSize = true;
            this.tableLayoutPanel.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.tableLayoutPanel.ColumnCount = 2;
            this.tableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel.Controls.Add(this.bestPossibleTextLabel, 0, 0);
            this.tableLayoutPanel.Controls.Add(this.bestPossibleTimeLabel, 1, 0);
            this.tableLayoutPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel.Margin = new System.Windows.Forms.Padding(0);
            this.tableLayoutPanel.Name = "tableLayoutPanel";
            this.tableLayoutPanel.RowCount = 1;
            this.tableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.tableLayoutPanel.Size = new System.Drawing.Size(162, 30);
            this.tableLayoutPanel.TabIndex = 0;
            // 
            // bestPossibleTextLabel
            // 
            this.bestPossibleTextLabel.AutoSize = true;
            this.bestPossibleTextLabel.BackColor = System.Drawing.Color.Transparent;
            this.bestPossibleTextLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.bestPossibleTextLabel.Font = new System.Drawing.Font("Segoe UI", 8.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bestPossibleTextLabel.ForeColor = System.Drawing.Color.Black;
            this.bestPossibleTextLabel.Location = new System.Drawing.Point(3, 3);
            this.bestPossibleTextLabel.Margin = new System.Windows.Forms.Padding(3);
            this.bestPossibleTextLabel.Name = "bestPossibleTextLabel";
            this.bestPossibleTextLabel.Size = new System.Drawing.Size(75, 24);
            this.bestPossibleTextLabel.TabIndex = 3;
            this.bestPossibleTextLabel.Text = "Best Possible";
            this.bestPossibleTextLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // bestPossibleTimeLabel
            // 
            this.bestPossibleTimeLabel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.bestPossibleTimeLabel.AutoSize = true;
            this.bestPossibleTimeLabel.BackColor = System.Drawing.Color.Transparent;
            this.bestPossibleTimeLabel.Font = new System.Drawing.Font("Segoe UI", 8.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bestPossibleTimeLabel.ForeColor = System.Drawing.Color.Black;
            this.bestPossibleTimeLabel.Location = new System.Drawing.Point(146, 4);
            this.bestPossibleTimeLabel.Margin = new System.Windows.Forms.Padding(0, 4, 4, 4);
            this.bestPossibleTimeLabel.Name = "bestPossibleTimeLabel";
            this.bestPossibleTimeLabel.Size = new System.Drawing.Size(12, 22);
            this.bestPossibleTimeLabel.TabIndex = 3;
            this.bestPossibleTimeLabel.Text = "-";
            this.bestPossibleTimeLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // BestPossibleUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.Controls.Add(this.tableLayoutPanel);
            this.Margin = new System.Windows.Forms.Padding(0);
            this.Name = "BestPossibleUI";
            this.Size = new System.Drawing.Size(162, 30);
            this.tableLayoutPanel.ResumeLayout(false);
            this.tableLayoutPanel.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel;
        private System.Windows.Forms.Label bestPossibleTextLabel;
        private System.Windows.Forms.Label bestPossibleTimeLabel;
    }
}
