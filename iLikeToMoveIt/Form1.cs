using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace iLikeToMoveIt
{
    public partial class Form1 : Form
    {
        Graphics graphics;
        int x = 150;
        int y = 100;
        int dx = 3;
        int dy = 2;
        string mainColor;
        string borderColor;
        public Form1()
        {
            InitializeComponent();
            this.Paint += new PaintEventHandler(paintBall);
            this.DoubleBuffered = true;
        }
        private void paintBall(object sender, PaintEventArgs e)
        {
            graphics = e.Graphics;
            if (borderColor == "red")
            {
                SolidBrush redBallBrush = new SolidBrush(Color.Red);
                graphics.FillEllipse(redBallBrush, x - 5, y - 4, 40, 40);
            }
            else if (borderColor == "green")
            {
                SolidBrush greenBallBrush = new SolidBrush(Color.Green);
                graphics.FillEllipse(greenBallBrush, x - 5, y - 4, 40, 40);
            }
            else if (borderColor == "blue")
            {
                SolidBrush blueBallBrush = new SolidBrush(Color.Blue);
                graphics.FillEllipse(blueBallBrush, x - 5, y - 4, 40, 40);
            }
            else
            {
                SolidBrush redBallBrush = new SolidBrush(Color.Red);
                graphics.FillEllipse(redBallBrush, x - 5, y - 4, 40, 40);
            }
            if (mainColor == "red")
            {
                SolidBrush redBallBrush = new SolidBrush(Color.Red);
                graphics.FillEllipse(redBallBrush, x, y, 30, 30);
            }
            else if (mainColor == "green")
            {
                SolidBrush greenBallBrush = new SolidBrush(Color.Green);
                graphics.FillEllipse(greenBallBrush, x, y, 30, 30);
            }
            else if (mainColor == "blue")
            {
                SolidBrush blueBallBrush = new SolidBrush(Color.Blue);
                graphics.FillEllipse(blueBallBrush, x, y, 30, 30);
            }
            else
            {
                SolidBrush defaultBallBrush = new SolidBrush(Color.Red);
                graphics.FillEllipse(defaultBallBrush, x, y, 30, 30);
            }


        }
        private void MoveBall()
        {
            int newBall_x = x + dx;
            int newBall_y = y + dy;

            if (newBall_x < -5 || newBall_x > this.ClientSize.Width) dx = -dx;
            if (newBall_y < 0 || newBall_y > this.ClientSize.Height) dy = -dy;

            x += dx;
            y += dy;
            Invalidate();
        }
        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            MoveBall();
        }

        private void redToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void redToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            mainColor = "red";
        }

        private void greenToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            mainColor = "green";
        }

        private void blueToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            mainColor = "blue";
        }

        private void redToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            borderColor = "red";
        }

        private void greenToolStripMenuItem_Click(object sender, EventArgs e)
        {
            borderColor = "green";
        }

        private void blueToolStripMenuItem_Click(object sender, EventArgs e)
        {
            borderColor = "blue";
        }

        private void x05ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            timer1.Interval = 50;
        }

        private void x1ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            timer1.Interval = 25;
        }

        private void x2ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            timer1.Interval = 5;
        }
    }
}
