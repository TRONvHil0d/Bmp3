using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace bmp32
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void closeBtn_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        bool Move;
        int MoveX, MoveY;

        private void topPanel_MouseDown(object sender, MouseEventArgs e)
        {
            Move = true;
            MoveX = e.X;
            MoveY = e.Y;
        }

        private void topPanel_MouseMove(object sender, MouseEventArgs e)
        {
            if (Move)
            {
                this.SetDesktopLocation(MousePosition.X-MoveX, MousePosition.Y-MoveY);
            }
           
        }

        private void openMusic_Click(object sender, EventArgs e)
        {
             OpenFileDialog openFileDialog = new OpenFileDialog();
             openFileDialog.Filter = "Media Files|*.mp3;";
    
    if (openFileDialog.ShowDialog() == DialogResult.OK)
    {
        axWindowsMediaPlayer1.URL = openFileDialog.FileName;
    }
        }

        private void minimizeBtn_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void topPanel_MouseUp(object sender, MouseEventArgs e)
        {
            Move = false;
        }
    }
}
