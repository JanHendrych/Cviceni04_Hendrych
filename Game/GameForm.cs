using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using GameLibrary;

namespace Game
{
    public partial class GameForm : Form
    {
        Random random = new Random();
        Stats stats = new Stats();

        public GameForm()
        {
            InitializeComponent();

            correctLabel.Text = $"Spravne: ";
            missedLabel.Text = $"Spatne: ";
            accuracyLabel.Text = $"Presnost:   %";

            stats.UpdatedStats += UpdatedStatsHandler;

            gameListBox.ContextMenuStrip = contextMenuStrip1;
        }

        private void UpdatedStatsHandler(object sender, UpdatedStatsEventArgs e)
        {
            correctLabel.Text = "Spravne: " + e.Correct.ToString();
            missedLabel.Text = "Spatne: " + e.Missed.ToString();
            accuracyLabel.Text = "Presnost: " + e.Accuracy.ToString() + "%";

            this.Text = "Game | rychlost " + gameTimer.Interval.ToString() + "ms";
        }

        private void gameTimer_Tick_Handler(object sender, EventArgs e)
        {
            if (gameListBox.Items.Count > 6)
            {
                gameTimer.Stop();
                stats.UpdatedStats -= UpdatedStatsHandler;
                gameListBox.Items.Clear();
                gameListBox.Items.Add("Game over!");
                gameListBox.Refresh();
                Thread.Sleep(2500);
            }
            else
            {
                gameListBox.Items.Add((Keys)random.Next(65, 91));
            }
        }

        private void gameListBox_KeyDown_Handler(object sender, KeyEventArgs e)
        {
            if (gameTimer.Enabled)
            {
                if (gameListBox.Items.Contains(e.KeyCode))
                {
                    gameListBox.Items.Remove(e.KeyCode);
                    gameListBox.Refresh();

                    if (gameTimer.Interval > 400)
                    {
                        gameTimer.Interval -= 60;
                    }
                    else if (gameTimer.Interval > 250 && gameTimer.Interval < 400)
                    {
                        gameTimer.Interval -= 15;
                    }
                    else if (gameTimer.Interval > 150 && gameTimer.Interval < 250)
                    {
                        gameTimer.Interval -= 8;
                    }

                    int obtiznost = 800 - gameTimer.Interval;
                    if (obtiznost <= 0)
                    {
                        obtiznost = 0;
                    }
                    if (obtiznost >= 800)
                    {
                        obtiznost = 800;
                    }
                    difficultyProgressBar.Value = obtiznost;

                    stats.Update(true);
                }
                else
                {
                    stats.Update(false);
                }
            } else
            {
                gameTimer.Start();
                gameTimer.Interval = 800;
                stats.UpdatedStats += UpdatedStatsHandler;
                gameListBox.Items.Clear();
                stats.Reset();
                gameListBox.Refresh();
            }
        }

        private void novaHraToolStripMenuItem_Click(object sender, EventArgs e)
        {
            gameTimer.Start();
            stats.Reset();
            gameTimer.Interval = 800;
            stats.UpdatedStats += UpdatedStatsHandler;
            gameListBox.Items.Clear();
            gameListBox.Refresh();
        }

        private void GameForm_MouseClick(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
                contextMenuStrip1.Show(e.X, e.Y);
            }
        }

        private void gameListBox_MouseClick(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
                contextMenuStrip1.Show(e.X, e.Y);
            }
        }
    }
}
