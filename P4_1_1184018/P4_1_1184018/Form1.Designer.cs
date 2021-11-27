namespace P4_1_1184018
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
            this.label1 = new System.Windows.Forms.Label();
            this.btn_csharp = new System.Windows.Forms.Button();
            this.btn_vs = new System.Windows.Forms.Button();
            this.btn_close = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft YaHei", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(117, 53);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(420, 24);
            this.label1.TabIndex = 0;
            this.label1.Text = "Which do you think is better, Visual Basic or C#?";
            // 
            // btn_csharp
            // 
            this.btn_csharp.Font = new System.Drawing.Font("Meiryo UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_csharp.ForeColor = System.Drawing.Color.Red;
            this.btn_csharp.Location = new System.Drawing.Point(367, 146);
            this.btn_csharp.Name = "btn_csharp";
            this.btn_csharp.Size = new System.Drawing.Size(115, 33);
            this.btn_csharp.TabIndex = 1;
            this.btn_csharp.Text = "C#";
            this.btn_csharp.UseVisualStyleBackColor = true;
            this.btn_csharp.Click += new System.EventHandler(this.btn_csharp_Click);
            // 
            // btn_vs
            // 
            this.btn_vs.Font = new System.Drawing.Font("Meiryo UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_vs.ForeColor = System.Drawing.Color.Green;
            this.btn_vs.Location = new System.Drawing.Point(154, 146);
            this.btn_vs.Name = "btn_vs";
            this.btn_vs.Size = new System.Drawing.Size(135, 33);
            this.btn_vs.TabIndex = 2;
            this.btn_vs.Text = "Visual Basic";
            this.btn_vs.UseVisualStyleBackColor = true;
            this.btn_vs.MouseMove += new System.Windows.Forms.MouseEventHandler(this.btn_vs_MouseMove);
            // 
            // btn_close
            // 
            this.btn_close.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_close.Location = new System.Drawing.Point(99, 307);
            this.btn_close.Name = "btn_close";
            this.btn_close.Size = new System.Drawing.Size(100, 30);
            this.btn_close.TabIndex = 3;
            this.btn_close.Text = "close";
            this.btn_close.UseVisualStyleBackColor = true;
            this.btn_close.Click += new System.EventHandler(this.btn_close_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(663, 368);
            this.Controls.Add(this.btn_close);
            this.Controls.Add(this.btn_vs);
            this.Controls.Add(this.btn_csharp);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btn_csharp;
        private System.Windows.Forms.Button btn_vs;
        private System.Windows.Forms.Button btn_close;
    }
}

