using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace P4_3_1184018
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void txtHuruf_Leave(object sender, EventArgs e)
        {
            if (txtHuruf.Text == "")
            {
                epWrong.SetError(txtHuruf, "");
                epWarning.SetError(txtHuruf, "Huruf tidak boleh kosong !");
                epCorrect.SetError(txtHuruf, "");
            }
            else
            {
                if ((txtHuruf.Text).All(Char.IsLetter))
                {
                    epWarning.SetError(txtHuruf, "");
                    epWrong.SetError(txtHuruf, "");
                    epCorrect.SetError(txtHuruf, "Betul!");
                }
                else
                {
                    epWarning.SetError(txtHuruf, "Inputan hanya boleh huruf!");
                    epWrong.SetError(txtHuruf, "");
                    epCorrect.SetError(txtHuruf, "");
                }
            }
        }

        private void txtAngka_Leave(object sender, EventArgs e)
        {
            if((txtAngka.Text).All(Char.IsNumber))
            {
                epCorrect.SetError(txtAngka, "Betul!");
                epWarning.SetError(txtAngka, "");
                epWrong.SetError(txtAngka, "");
            }
            else
            {
                epCorrect.SetError(txtAngka, "");
                epWrong.SetError(txtAngka, "Input hanya boleh Angka");
                epWarning.SetError(txtAngka, "");
            }
        }

        private void txtEmail_Leave(object sender, EventArgs e)
        {
            if(System.Text.RegularExpressions.Regex.IsMatch(txtEmail.Text, @"^^[^@\s]+@[^@\s]+(\.[^@\s]+)+$"))
            {
                epCorrect.SetError(txtEmail, "Betul!");
                epWarning.SetError(txtEmail, "");
                epWrong.SetError(txtEmail, "");
            }
            else
            {
                epCorrect.SetError(txtEmail, "");
                epWrong.SetError(txtEmail, "Format email salah!\nContoh: a@b.c");
                epWarning.SetError(txtEmail, "");
            }
        }

        int nilai;
        int nilai1;

        private void txtangka1_Leave(object sender, EventArgs e)
        {
            if (Int32.TryParse(txtangka1.Text, out nilai))
            {
                if (nilai > nilai1)
                {
                    epWarning.SetError(txtangka1, "");
                    epCorrect.SetError(txtangka1, "Betul!");
                }
                else
                {
                    epWarning.SetError(txtangka1, "Angka 2 lebih besar daripada Angka 1");
                    epCorrect.SetError(txtangka1, "");
                }
            }
        }

        private void txtangka2_Leave(object sender, EventArgs e)
        {
            if (Int32.TryParse(txtangka2.Text, out nilai1))
            {
                if (nilai > nilai1)
                {
                    epWarning.SetError(txtangka2, "");
                    epCorrect.SetError(txtangka2, "Betul!");
                }
                else
                {
                    epWarning.SetError(txtangka2, "Angka 2 lebih besar daripada Angka 1");
                    epCorrect.SetError(txtangka2, "");
                }
            }
        }
    }
}
