using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace P4_4_1184018
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void tb_nama_Leave(object sender, EventArgs e)
        {
            if (tb_nama.Text == "")
            {
                epWarning.SetError(tb_nama, "Mohon isi Nama");
                epWrong.SetError(tb_nama, "");
                epCorrect.SetError(tb_nama, "");
            }
            else
            {
                if (tb_nama.Text != tb_nama.Text.ToUpper())
                {
                    epWrong.SetError(tb_nama, "Mohon Gunakan Huruf Kapital");
                    epWarning.SetError(tb_nama, "");
                    epCorrect.SetError(tb_nama, "");
                }
                else
                if ((tb_nama.Text).All(Char.IsLetter))
                {
                    epWarning.SetError(tb_nama, "");
                    epWrong.SetError(tb_nama, "");
                    epCorrect.SetError(tb_nama, "Betul");
                }
                else
                {
                    epWrong.SetError(tb_nama, "Maaf inputan hanya boleh huruf");
                    epWarning.SetError(tb_nama, "");
                    epCorrect.SetError(tb_nama, "");
                }
            }
        }

        private void tb_no_Leave(object sender, EventArgs e)
        {
            if (tb_no.Text.Length > 13)
            {
                epWarning.SetError(tb_no, "Maaf tidak boleh lebih dari 13 digit");
                epWrong.SetError(tb_no, "");
                epCorrect.SetError(tb_no, "");
            }
            else if ((tb_no.Text).All(Char.IsNumber))
            {
                epWarning.SetError(tb_no, "");
                epWrong.SetError(tb_no, "");
                epCorrect.SetError(tb_no, "Betul");
            }
            else
            {
                epWrong.SetError(tb_no, "Maaf inputan hanya boleh Angka");
                epWarning.SetError(tb_no, "");
                epCorrect.SetError(tb_no, "");
            }
            if (tb_no.Text == "")
            {
                epWarning.SetError(tb_no, "Mohon isi no telpon");
                epWrong.SetError(tb_no, "");
                epCorrect.SetError(tb_no, "");
            }
        }

        private void tb_email_Leave(object sender, EventArgs e)
        {
            if (tb_email.Text == "")
            {
                epWarning.SetError(tb_email, "Mohon isi Email");
                epWrong.SetError(tb_email, "");
                epCorrect.SetError(tb_email, "");
            }
            else
            {
                if (System.Text.RegularExpressions.Regex.IsMatch(tb_email.Text, @"^^[^@\s]+@[^@\s]+(\.[^@\s]+)+$"))
                {
                    epCorrect.SetError(tb_email, "Betul");
                    epWarning.SetError(tb_email, "");
                    epWrong.SetError(tb_email, "");

                }
                else
                {
                    epCorrect.SetError(tb_email, "");
                    epWarning.SetError(tb_email, "");
                    epWrong.SetError(tb_email, "Format email salah ! \nContoh : a@b.c");
                }
            }
        }

        private void tb_nilai_Leave(object sender, EventArgs e)
        {
            if (tb_nilai.Text.Length > 1)
            {
                epWarning.SetError(tb_nilai, "hanya boleh beri nilai 1-9");
                epWrong.SetError(tb_nilai, "");
                epCorrect.SetError(tb_nilai, "");
            }
            else if ((tb_nilai.Text).All(Char.IsNumber)) //Numeric TextBox
            {
                epWarning.SetError(tb_nilai, "");
                epWrong.SetError(tb_nilai, "");
                epCorrect.SetError(tb_nilai, "Betul!");
            }
            else
            {
                epWrong.SetError(tb_nilai, "Maaf inputan hanya boleh angka");
                epWarning.SetError(tb_nilai, "");
                epCorrect.SetError(tb_nilai, "");
            }
            if (tb_nilai.Text == "")
            {
                epWarning.SetError(tb_nilai, "Mohon isi nilai");
                epWrong.SetError(tb_nilai, "");
                epCorrect.SetError(tb_nilai, "");
            }
            if (tb_nilai.Text != "") //Comparison
            {
                if ((int.Parse(tb_nilai.Text) > 9))
                {
                    epWarning.SetError(tb_nilai, "");
                    epWrong.SetError(tb_nilai, "Maaf nilai mu terlalu besar nih");
                    epCorrect.SetError(tb_nilai, "");
                }
                else { }
            }
        }

        private void tb_mapel_Leave(object sender, EventArgs e)
        {
            if (tb_mapel.Text == "")
            {
                epWarning.SetError(tb_mapel, "Maaf nama tidak boleh kosong");
                epWrong.SetError(tb_mapel, "");
                epCorrect.SetError(tb_mapel, "");
            }
            else
            {
                if (tb_mapel.Text != tb_mapel.Text.ToLower())
                {
                    epWrong.SetError(tb_mapel, "Mohon jangan gunakan Huruf Kapital");
                    epWarning.SetError(tb_mapel, "");
                    epCorrect.SetError(tb_mapel, "");
                }
                else
                if ((tb_mapel.Text).All(Char.IsLetter))
                {
                    epWarning.SetError(tb_mapel, "");
                    epWrong.SetError(tb_mapel, "");
                    epCorrect.SetError(tb_mapel, "Betul");
                }
                else
                {
                    epWrong.SetError(tb_mapel, "Maaf inputan hanya boleh huruf");
                    epWarning.SetError(tb_mapel, "");
                    epCorrect.SetError(tb_mapel, "");
                }
            }
        }

        private void simpan_Click(object sender, EventArgs e)
        {
            MessageBox.Show
                   ("Nama : " + tb_nama.Text +
                   "\nNo HP : " + tb_no.Text +
                   "\nEmail : " + tb_email.Text+
                   "\nNilai : " + tb_nilai.Text +
                   "\nKelas : " + cb_kls.Text +
                   "\nMata Pelajaran : " + tb_mapel.Text,
                   "Berhasil",
                   MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void keluar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
