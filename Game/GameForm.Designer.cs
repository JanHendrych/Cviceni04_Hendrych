namespace Game
{
    partial class GameForm
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.gameListBox = new System.Windows.Forms.ListBox();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.correctLabel = new System.Windows.Forms.ToolStripStatusLabel();
            this.missedLabel = new System.Windows.Forms.ToolStripStatusLabel();
            this.accuracyLabel = new System.Windows.Forms.ToolStripStatusLabel();
            this.difficultyLabel = new System.Windows.Forms.ToolStripStatusLabel();
            this.difficultyProgressBar = new System.Windows.Forms.ToolStripProgressBar();
            this.gameTimer = new System.Windows.Forms.Timer(this.components);
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.novaHraToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.statusStrip1.SuspendLayout();
            this.contextMenuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // gameListBox
            // 
            this.gameListBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gameListBox.Font = new System.Drawing.Font("Segoe UI", 110F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.gameListBox.FormattingEnabled = true;
            this.gameListBox.ItemHeight = 195;
            this.gameListBox.Location = new System.Drawing.Point(0, 0);
            this.gameListBox.MultiColumn = true;
            this.gameListBox.Name = "gameListBox";
            this.gameListBox.Size = new System.Drawing.Size(1202, 233);
            this.gameListBox.TabIndex = 0;
            this.gameListBox.MouseClick += new System.Windows.Forms.MouseEventHandler(this.gameListBox_MouseClick);
            this.gameListBox.KeyDown += new System.Windows.Forms.KeyEventHandler(this.gameListBox_KeyDown_Handler);
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.correctLabel,
            this.missedLabel,
            this.accuracyLabel,
            this.difficultyLabel,
            this.difficultyProgressBar});
            this.statusStrip1.Location = new System.Drawing.Point(0, 211);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(1202, 22);
            this.statusStrip1.TabIndex = 1;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // correctLabel
            // 
            this.correctLabel.Name = "correctLabel";
            this.correctLabel.Size = new System.Drawing.Size(72, 17);
            this.correctLabel.Text = "correctLabel";
            // 
            // missedLabel
            // 
            this.missedLabel.Name = "missedLabel";
            this.missedLabel.Size = new System.Drawing.Size(72, 17);
            this.missedLabel.Text = "missedLabel";
            // 
            // accuracyLabel
            // 
            this.accuracyLabel.Name = "accuracyLabel";
            this.accuracyLabel.Size = new System.Drawing.Size(82, 17);
            this.accuracyLabel.Text = "accuracyLabel";
            // 
            // difficultyLabel
            // 
            this.difficultyLabel.Name = "difficultyLabel";
            this.difficultyLabel.Size = new System.Drawing.Size(859, 17);
            this.difficultyLabel.Spring = true;
            this.difficultyLabel.Text = "Difficulty label";
            this.difficultyLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // difficultyProgressBar
            // 
            this.difficultyProgressBar.Maximum = 800;
            this.difficultyProgressBar.Name = "difficultyProgressBar";
            this.difficultyProgressBar.Size = new System.Drawing.Size(100, 16);
            // 
            // gameTimer
            // 
            this.gameTimer.Enabled = true;
            this.gameTimer.Interval = 800;
            this.gameTimer.Tick += new System.EventHandler(this.gameTimer_Tick_Handler);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.novaHraToolStripMenuItem,
            this.aboutToolStripMenuItem});
            this.contextMenuStrip1.LayoutStyle = System.Windows.Forms.ToolStripLayoutStyle.HorizontalStackWithOverflow;
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(181, 70);
            // 
            // novaHraToolStripMenuItem
            // 
            this.novaHraToolStripMenuItem.Name = "novaHraToolStripMenuItem";
            this.novaHraToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.novaHraToolStripMenuItem.Text = "Nová hra";
            this.novaHraToolStripMenuItem.Click += new System.EventHandler(this.novaHraToolStripMenuItem_Click);
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.aboutToolStripMenuItem.Text = "About";
            // 
            // GameForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1202, 233);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.gameListBox);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "GameForm";
            this.Text = "Game";
            this.MouseClick += new System.Windows.Forms.MouseEventHandler(this.GameForm_MouseClick);
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.contextMenuStrip1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private ListBox gameListBox;
        private StatusStrip statusStrip1;
        private ToolStripStatusLabel correctLabel;
        private ToolStripStatusLabel missedLabel;
        private ToolStripStatusLabel accuracyLabel;
        private ToolStripStatusLabel difficultyLabel;
        private ToolStripProgressBar difficultyProgressBar;
        private System.Windows.Forms.Timer gameTimer;
        private ContextMenuStrip contextMenuStrip1;
        private ToolStripMenuItem novaHraToolStripMenuItem;
        private ToolStripMenuItem aboutToolStripMenuItem;
    }
}