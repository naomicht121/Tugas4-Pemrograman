namespace P4_4_1184018
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.judul = new System.Windows.Forms.Label();
            this.nama = new System.Windows.Forms.Label();
            this.no = new System.Windows.Forms.Label();
            this.email = new System.Windows.Forms.Label();
            this.tb_nama = new System.Windows.Forms.TextBox();
            this.tb_no = new System.Windows.Forms.TextBox();
            this.tb_email = new System.Windows.Forms.TextBox();
            this.tb_mapel = new System.Windows.Forms.TextBox();
            this.tb_nilai = new System.Windows.Forms.TextBox();
            this.kelas = new System.Windows.Forms.Label();
            this.mapel = new System.Windows.Forms.Label();
            this.nilai = new System.Windows.Forms.Label();
            this.simpan = new System.Windows.Forms.Button();
            this.keluar = new System.Windows.Forms.Button();
            this.cb_kls = new System.Windows.Forms.ComboBox();
            this.epCorrect = new System.Windows.Forms.ErrorProvider(this.components);
            this.epWarning = new System.Windows.Forms.ErrorProvider(this.components);
            this.epWrong = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.epCorrect)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.epWarning)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.epWrong)).BeginInit();
            this.SuspendLayout();
            // 
            // judul
            // 
            this.judul.AutoSize = true;
            this.judul.Font = new System.Drawing.Font("Mattone 150", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.judul.Location = new System.Drawing.Point(232, 30);
            this.judul.Name = "judul";
            this.judul.Size = new System.Drawing.Size(146, 20);
            this.judul.TabIndex = 0;
            this.judul.Text = "NILAI RAPOR";
            // 
            // nama
            // 
            this.nama.AutoSize = true;
            this.nama.Location = new System.Drawing.Point(39, 101);
            this.nama.Name = "nama";
            this.nama.Size = new System.Drawing.Size(53, 17);
            this.nama.TabIndex = 1;
            this.nama.Text = "Nama :";
            // 
            // no
            // 
            this.no.AutoSize = true;
            this.no.Location = new System.Drawing.Point(42, 152);
            this.no.Name = "no";
            this.no.Size = new System.Drawing.Size(61, 17);
            this.no.TabIndex = 2;
            this.no.Text = "No. HP :";
            // 
            // email
            // 
            this.email.AutoSize = true;
            this.email.Location = new System.Drawing.Point(42, 203);
            this.email.Name = "email";
            this.email.Size = new System.Drawing.Size(50, 17);
            this.email.TabIndex = 3;
            this.email.Text = "Email :";
            // 
            // tb_nama
            // 
            this.tb_nama.Location = new System.Drawing.Point(109, 96);
            this.tb_nama.Name = "tb_nama";
            this.tb_nama.Size = new System.Drawing.Size(150, 22);
            this.tb_nama.TabIndex = 4;
            this.tb_nama.Leave += new System.EventHandler(this.tb_nama_Leave);
            // 
            // tb_no
            // 
            this.tb_no.Location = new System.Drawing.Point(109, 146);
            this.tb_no.Name = "tb_no";
            this.tb_no.Size = new System.Drawing.Size(150, 22);
            this.tb_no.TabIndex = 5;
            this.tb_no.Leave += new System.EventHandler(this.tb_no_Leave);
            // 
            // tb_email
            // 
            this.tb_email.Location = new System.Drawing.Point(109, 197);
            this.tb_email.Name = "tb_email";
            this.tb_email.Size = new System.Drawing.Size(150, 22);
            this.tb_email.TabIndex = 6;
            this.tb_email.Leave += new System.EventHandler(this.tb_email_Leave);
            // 
            // tb_mapel
            // 
            this.tb_mapel.Location = new System.Drawing.Point(398, 198);
            this.tb_mapel.Name = "tb_mapel";
            this.tb_mapel.Size = new System.Drawing.Size(150, 22);
            this.tb_mapel.TabIndex = 12;
            this.tb_mapel.Leave += new System.EventHandler(this.tb_mapel_Leave);
            // 
            // tb_nilai
            // 
            this.tb_nilai.Location = new System.Drawing.Point(398, 97);
            this.tb_nilai.Name = "tb_nilai";
            this.tb_nilai.Size = new System.Drawing.Size(150, 22);
            this.tb_nilai.TabIndex = 10;
            this.tb_nilai.Leave += new System.EventHandler(this.tb_nilai_Leave);
            // 
            // kelas
            // 
            this.kelas.AutoSize = true;
            this.kelas.Location = new System.Drawing.Point(341, 152);
            this.kelas.Name = "kelas";
            this.kelas.Size = new System.Drawing.Size(51, 17);
            this.kelas.TabIndex = 9;
            this.kelas.Text = "Kelas :";
            // 
            // mapel
            // 
            this.mapel.AutoSize = true;
            this.mapel.Location = new System.Drawing.Point(281, 203);
            this.mapel.Name = "mapel";
            this.mapel.Size = new System.Drawing.Size(111, 17);
            this.mapel.TabIndex = 8;
            this.mapel.Text = "Mata Pelajaran :";
            // 
            // nilai
            // 
            this.nilai.AutoSize = true;
            this.nilai.Location = new System.Drawing.Point(349, 102);
            this.nilai.Name = "nilai";
            this.nilai.Size = new System.Drawing.Size(43, 17);
            this.nilai.TabIndex = 7;
            this.nilai.Text = "Nilai :";
            // 
            // simpan
            // 
            this.simpan.Location = new System.Drawing.Point(389, 283);
            this.simpan.Name = "simpan";
            this.simpan.Size = new System.Drawing.Size(98, 23);
            this.simpan.TabIndex = 13;
            this.simpan.Text = "Tampilkan";
            this.simpan.UseVisualStyleBackColor = true;
            this.simpan.Click += new System.EventHandler(this.simpan_Click);
            // 
            // keluar
            // 
            this.keluar.Location = new System.Drawing.Point(505, 283);
            this.keluar.Name = "keluar";
            this.keluar.Size = new System.Drawing.Size(75, 23);
            this.keluar.TabIndex = 14;
            this.keluar.Text = "Keluar";
            this.keluar.UseVisualStyleBackColor = true;
            this.keluar.Click += new System.EventHandler(this.keluar_Click);
            // 
            // cb_kls
            // 
            this.cb_kls.FormattingEnabled = true;
            this.cb_kls.Items.AddRange(new object[] {
            "A",
            "B",
            "C",
            "D",
            "E"});
            this.cb_kls.Location = new System.Drawing.Point(398, 143);
            this.cb_kls.Name = "cb_kls";
            this.cb_kls.Size = new System.Drawing.Size(150, 24);
            this.cb_kls.TabIndex = 15;
            // 
            // epCorrect
            // 
            this.epCorrect.ContainerControl = this;
            this.epCorrect.Icon = ((System.Drawing.Icon)(resources.GetObject("epCorrect.Icon")));
            // 
            // epWarning
            // 
            this.epWarning.ContainerControl = this;
            this.epWarning.Icon = ((System.Drawing.Icon)(resources.GetObject("epWarning.Icon")));
            // 
            // epWrong
            // 
            this.epWrong.ContainerControl = this;
            this.epWrong.Icon = ((System.Drawing.Icon)(resources.GetObject("epWrong.Icon")));
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(614, 348);
            this.Controls.Add(this.cb_kls);
            this.Controls.Add(this.keluar);
            this.Controls.Add(this.simpan);
            this.Controls.Add(this.tb_mapel);
            this.Controls.Add(this.tb_nilai);
            this.Controls.Add(this.kelas);
            this.Controls.Add(this.mapel);
            this.Controls.Add(this.nilai);
            this.Controls.Add(this.tb_email);
            this.Controls.Add(this.tb_no);
            this.Controls.Add(this.tb_nama);
            this.Controls.Add(this.email);
            this.Controls.Add(this.no);
            this.Controls.Add(this.nama);
            this.Controls.Add(this.judul);
            this.Name = "Form1";
            this.Text = "INPUT NILAI";
            ((System.ComponentModel.ISupportInitialize)(this.epCorrect)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.epWarning)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.epWrong)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label judul;
        private System.Windows.Forms.Label nama;
        private System.Windows.Forms.Label no;
        private System.Windows.Forms.Label email;
        private System.Windows.Forms.TextBox tb_nama;
        private System.Windows.Forms.TextBox tb_no;
        private System.Windows.Forms.TextBox tb_email;
        private System.Windows.Forms.TextBox tb_mapel;
        private System.Windows.Forms.TextBox tb_nilai;
        private System.Windows.Forms.Label kelas;
        private System.Windows.Forms.Label mapel;
        private System.Windows.Forms.Label nilai;
        private System.Windows.Forms.Button simpan;
        private System.Windows.Forms.Button keluar;
        private System.Windows.Forms.ComboBox cb_kls;
        private System.Windows.Forms.ErrorProvider epCorrect;
        private System.Windows.Forms.ErrorProvider epWarning;
        private System.Windows.Forms.ErrorProvider epWrong;
    }
}

