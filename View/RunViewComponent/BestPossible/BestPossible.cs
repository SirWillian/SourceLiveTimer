using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using SourceLiveTimer.Speedrun;
using SourceLiveTimer.Util;

namespace SourceLiveTimer.View
{
    partial class BestPossibleUI : UserControl, RunViewComponent
    {
        private Run run;

        private const int BEST_POSSIBLE_HEIGHT = 20;
        private Font BEST_POSSIBLE_TEXT_FONT = new System.Drawing.Font("Segoe UI", 8.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
        private Font BEST_POSSIBLE_TIME_FONT = new System.Drawing.Font("Segoe UI", 8.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
        private Color BEST_POSSIBLE_TEXT_COLOR = System.Drawing.Color.White;
        private TimeFormatter TIME_FORMATTER = new FancyTimeFormatter("-");

        public BestPossibleUI()
        {
            InitializeComponent();
            this.bestPossibleTextLabel.Font = BEST_POSSIBLE_TEXT_FONT;
            this.bestPossibleTimeLabel.Font = BEST_POSSIBLE_TIME_FONT;
            this.bestPossibleTextLabel.ForeColor = BEST_POSSIBLE_TEXT_COLOR;
            this.bestPossibleTimeLabel.ForeColor = BEST_POSSIBLE_TEXT_COLOR;
            this.tableLayoutPanel.RowStyles[0].Height = BEST_POSSIBLE_HEIGHT;
        }

        public void LoadRun(Run run)
        {
            this.run = run;
            UpdateComponent();
        }

        public void UpdateComponent()
        {
            int? bestPossible = run.GetBestPossible();
            bestPossibleTimeLabel.Text = TIME_FORMATTER.FormatTicks(bestPossible, run.Category.TicksPerSecond);
        }

        public void UnloadRun()
        {
            run = null;
            bestPossibleTimeLabel.Text = TIME_FORMATTER.NullTime;
        }        

    }
}
