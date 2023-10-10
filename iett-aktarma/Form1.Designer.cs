namespace iett_aktarma
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
            this.lblBakiye = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.rbİlkGiris = new System.Windows.Forms.RadioButton();
            this.rbAktarma1 = new System.Windows.Forms.RadioButton();
            this.rbAktarma2 = new System.Windows.Forms.RadioButton();
            this.rbAktarma3 = new System.Windows.Forms.RadioButton();
            this.rbAktarma4 = new System.Windows.Forms.RadioButton();
            this.chkOgrenci = new System.Windows.Forms.CheckBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnYükle20 = new System.Windows.Forms.Button();
            this.btnYükle50 = new System.Windows.Forms.Button();
            this.btnYükle100 = new System.Windows.Forms.Button();
            this.btnYükle200 = new System.Windows.Forms.Button();
            this.btnYükle500 = new System.Windows.Forms.Button();
            this.btnOdeme = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblBakiye
            // 
            this.lblBakiye.AutoSize = true;
            this.lblBakiye.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblBakiye.Location = new System.Drawing.Point(12, 20);
            this.lblBakiye.Name = "lblBakiye";
            this.lblBakiye.Size = new System.Drawing.Size(71, 24);
            this.lblBakiye.TabIndex = 0;
            this.lblBakiye.Text = "Bakiye";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.chkOgrenci);
            this.groupBox1.Controls.Add(this.rbAktarma4);
            this.groupBox1.Controls.Add(this.rbAktarma3);
            this.groupBox1.Controls.Add(this.rbAktarma2);
            this.groupBox1.Controls.Add(this.rbAktarma1);
            this.groupBox1.Controls.Add(this.rbİlkGiris);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.groupBox1.Location = new System.Drawing.Point(16, 114);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(200, 238);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Aktarmalar";
            // 
            // rbİlkGiris
            // 
            this.rbİlkGiris.AutoSize = true;
            this.rbİlkGiris.Location = new System.Drawing.Point(6, 29);
            this.rbİlkGiris.Name = "rbİlkGiris";
            this.rbİlkGiris.Size = new System.Drawing.Size(96, 28);
            this.rbİlkGiris.TabIndex = 0;
            this.rbİlkGiris.TabStop = true;
            this.rbİlkGiris.Text = "İlk Giriş";
            this.rbİlkGiris.UseVisualStyleBackColor = true;
            // 
            // rbAktarma1
            // 
            this.rbAktarma1.AutoSize = true;
            this.rbAktarma1.Location = new System.Drawing.Point(6, 52);
            this.rbAktarma1.Name = "rbAktarma1";
            this.rbAktarma1.Size = new System.Drawing.Size(126, 28);
            this.rbAktarma1.TabIndex = 1;
            this.rbAktarma1.TabStop = true;
            this.rbAktarma1.Text = "1. Aktarma";
            this.rbAktarma1.UseVisualStyleBackColor = true;
            this.rbAktarma1.CheckedChanged += new System.EventHandler(this.radioButton2_CheckedChanged);
            // 
            // rbAktarma2
            // 
            this.rbAktarma2.AutoSize = true;
            this.rbAktarma2.Location = new System.Drawing.Point(6, 75);
            this.rbAktarma2.Name = "rbAktarma2";
            this.rbAktarma2.Size = new System.Drawing.Size(126, 28);
            this.rbAktarma2.TabIndex = 2;
            this.rbAktarma2.TabStop = true;
            this.rbAktarma2.Text = "2. Aktarma";
            this.rbAktarma2.UseVisualStyleBackColor = true;
            // 
            // rbAktarma3
            // 
            this.rbAktarma3.AutoSize = true;
            this.rbAktarma3.Location = new System.Drawing.Point(6, 98);
            this.rbAktarma3.Name = "rbAktarma3";
            this.rbAktarma3.Size = new System.Drawing.Size(120, 28);
            this.rbAktarma3.TabIndex = 3;
            this.rbAktarma3.TabStop = true;
            this.rbAktarma3.Text = "3.Aktarma";
            this.rbAktarma3.UseVisualStyleBackColor = true;
            // 
            // rbAktarma4
            // 
            this.rbAktarma4.AutoSize = true;
            this.rbAktarma4.Location = new System.Drawing.Point(6, 121);
            this.rbAktarma4.Name = "rbAktarma4";
            this.rbAktarma4.Size = new System.Drawing.Size(120, 28);
            this.rbAktarma4.TabIndex = 4;
            this.rbAktarma4.TabStop = true;
            this.rbAktarma4.Text = "4.Aktarma";
            this.rbAktarma4.UseVisualStyleBackColor = true;
            // 
            // chkOgrenci
            // 
            this.chkOgrenci.AutoSize = true;
            this.chkOgrenci.Location = new System.Drawing.Point(6, 157);
            this.chkOgrenci.Name = "chkOgrenci";
            this.chkOgrenci.Size = new System.Drawing.Size(104, 28);
            this.chkOgrenci.TabIndex = 5;
            this.chkOgrenci.Text = "Öğrenci";
            this.chkOgrenci.UseVisualStyleBackColor = true;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btnYükle500);
            this.groupBox2.Controls.Add(this.btnYükle200);
            this.groupBox2.Controls.Add(this.btnYükle100);
            this.groupBox2.Controls.Add(this.btnYükle50);
            this.groupBox2.Controls.Add(this.btnYükle20);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.groupBox2.Location = new System.Drawing.Point(242, 115);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(215, 237);
            this.groupBox2.TabIndex = 3;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Bakiye Yükleme";
            // 
            // btnYükle20
            // 
            this.btnYükle20.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btnYükle20.Location = new System.Drawing.Point(30, 28);
            this.btnYükle20.Name = "btnYükle20";
            this.btnYükle20.Size = new System.Drawing.Size(154, 33);
            this.btnYükle20.TabIndex = 0;
            this.btnYükle20.Text = "20₺ Yükle";
            this.btnYükle20.UseVisualStyleBackColor = false;
            // 
            // btnYükle50
            // 
            this.btnYükle50.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btnYükle50.Location = new System.Drawing.Point(30, 67);
            this.btnYükle50.Name = "btnYükle50";
            this.btnYükle50.Size = new System.Drawing.Size(154, 33);
            this.btnYükle50.TabIndex = 1;
            this.btnYükle50.Text = "50₺ Yükle";
            this.btnYükle50.UseVisualStyleBackColor = false;
            // 
            // btnYükle100
            // 
            this.btnYükle100.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btnYükle100.Location = new System.Drawing.Point(30, 106);
            this.btnYükle100.Name = "btnYükle100";
            this.btnYükle100.Size = new System.Drawing.Size(154, 33);
            this.btnYükle100.TabIndex = 2;
            this.btnYükle100.Text = "100₺ Yükle";
            this.btnYükle100.UseVisualStyleBackColor = false;
            // 
            // btnYükle200
            // 
            this.btnYükle200.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btnYükle200.Location = new System.Drawing.Point(30, 145);
            this.btnYükle200.Name = "btnYükle200";
            this.btnYükle200.Size = new System.Drawing.Size(154, 33);
            this.btnYükle200.TabIndex = 3;
            this.btnYükle200.Text = "200₺ Yükle";
            this.btnYükle200.UseVisualStyleBackColor = false;
            // 
            // btnYükle500
            // 
            this.btnYükle500.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btnYükle500.Location = new System.Drawing.Point(30, 184);
            this.btnYükle500.Name = "btnYükle500";
            this.btnYükle500.Size = new System.Drawing.Size(154, 33);
            this.btnYükle500.TabIndex = 4;
            this.btnYükle500.Text = "500₺ Yükle";
            this.btnYükle500.UseVisualStyleBackColor = false;
            // 
            // btnOdeme
            // 
            this.btnOdeme.BackColor = System.Drawing.Color.ForestGreen;
            this.btnOdeme.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnOdeme.ForeColor = System.Drawing.SystemColors.Control;
            this.btnOdeme.Location = new System.Drawing.Point(254, 42);
            this.btnOdeme.Name = "btnOdeme";
            this.btnOdeme.Size = new System.Drawing.Size(165, 56);
            this.btnOdeme.TabIndex = 4;
            this.btnOdeme.Text = "Ödeme";
            this.btnOdeme.UseVisualStyleBackColor = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.ForeColor = System.Drawing.Color.Red;
            this.label1.Location = new System.Drawing.Point(17, 60);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(55, 29);
            this.label1.TabIndex = 5;
            this.label1.Text = "200";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 428);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnOdeme);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.lblBakiye);
            this.Name = "Form1";
            this.Text = "Form1";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblBakiye;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton rbAktarma1;
        private System.Windows.Forms.RadioButton rbİlkGiris;
        private System.Windows.Forms.CheckBox chkOgrenci;
        private System.Windows.Forms.RadioButton rbAktarma4;
        private System.Windows.Forms.RadioButton rbAktarma3;
        private System.Windows.Forms.RadioButton rbAktarma2;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btnYükle500;
        private System.Windows.Forms.Button btnYükle200;
        private System.Windows.Forms.Button btnYükle100;
        private System.Windows.Forms.Button btnYükle50;
        private System.Windows.Forms.Button btnYükle20;
        private System.Windows.Forms.Button btnOdeme;
        private System.Windows.Forms.Label label1;
    }
}

