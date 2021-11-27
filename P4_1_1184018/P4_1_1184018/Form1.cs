using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace P4_1_1184018
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btn_vs_MouseMove(object sender, MouseEventArgs e)
        {
            btn_vs.Top -= e.Y;
            btn_vs.Left += e.X;
            if (btn_vs.Top < -16 || btn_vs.Top > 160)
                btn_vs.Top = 73;
            if (btn_vs.Left < -64 || btn_vs.Left > 384)
                btn_vs.Left = 160;
        }

        private void btn_csharp_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Correct!");
        }

        private void btn_close_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
