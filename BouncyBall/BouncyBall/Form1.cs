using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BouncyBall
{
    public partial class Form1 : Form
    {
        private Random r = new Random();
        private static bool hasStarted = false;
        private static bool changedDirection = false;
        private static int dx = 0;
        private static int dy = 1;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            int x = r.Next(0, 817);
            int y = r.Next(0, 489);
            if (BallPictureBox.Size.Width + x > 816 - BallPictureBox.Size.Width)
            {
                x = 816 - BallPictureBox.Size.Width - 16;
            }
            else if (-1 * BallPictureBox.Size.Width + x < 0)
            {
                x = BallPictureBox.Size.Width + 16;
            }
            if (BallPictureBox.Size.Height + y > 488 - BallPictureBox.Size.Height)
            {
                y = 488 - BallPictureBox.Size.Height - 32;
            }
            else if (-1 * BallPictureBox.Size.Height + y < 0)
            {
                y = BallPictureBox.Size.Height + 32;
            }
            BallPictureBox.Location = new Point(x, y);
        }

        private void ActionButton_Click(object sender, EventArgs e)
        {
            if (!hasStarted)
            {
                ActionButton.Text = "Change Direction";
                DirectionSettings();
                hasStarted = true;
            }
            else
            {
                changedDirection = true;
            }
            
        }
        private void DirectionSettings()
        {
            Task.Run(() =>
            {
                int direction = 5;
                while (true)
                {
                    if (changedDirection == true)
                    {
                        direction = r.Next(1, 9);
                        changedDirection = false;
                        switch (direction)
                        {
                            case 1:
                                dx = 0;
                                dy = 1;
                                break;
                            case 2:
                                dx = 1;
                                dy = 1;
                                break;
                            case 3:
                                dx = 1;
                                dy = 0;
                                break;
                            case 4:
                                dx = 1;
                                dy = -1;
                                break;
                            case 5:
                                dx = 0;
                                dy = -1;
                                break;
                            case 6:
                                dx = -1;
                                dy = -1;
                                break;
                            case 7:
                                dx = -1;
                                dy = 0;
                                break;
                            case 8:
                                dx = -1;
                                dy = 1;
                                break;
                        }
                    }
                    else
                    {
                        MoveTheBall();
                    }
                    Thread.Sleep(2);
                }
            });
        }
        private void MoveTheBall()
        {
            if (BallPictureBox.Location.X + dx < 0)
            {
                dx = dx * -1;
            }
            else if (BallPictureBox.Location.X + BallPictureBox.Size.Width + 16  > 816)
            {
                dx = dx * -1;
            }
            if (BallPictureBox.Location.Y + dy < 0)
            {
                dy = dy * -1;
            }
            else if (BallPictureBox.Location.Y + BallPictureBox.Size.Height + 32 > 488)
            {
                dy = dy * -1;
            }
            Action<object, object> draw = (x, y) => { BallPictureBox.Location = new Point(BallPictureBox.Location.X + (int)x, BallPictureBox.Location.Y + (int)y); };
            object[] coords = {dx ,dy};
            BallPictureBox.BeginInvoke(draw, coords);
            
        }
    }
}
