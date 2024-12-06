namespace Pizzauyg
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
            this.cmbkenar = new System.Windows.Forms.ComboBox();
            this.cmbboyut = new System.Windows.Forms.ComboBox();
            this.checkmlzm2 = new System.Windows.Forms.CheckBox();
            this.checkmlzm3 = new System.Windows.Forms.CheckBox();
            this.checkmlzm4 = new System.Windows.Forms.CheckBox();
            this.checktatli = new System.Windows.Forms.CheckBox();
            this.checkicecek = new System.Windows.Forms.CheckBox();
            this.btnhesapla = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.checkmlzm5 = new System.Windows.Forms.CheckBox();
            this.checkmlzm1 = new System.Windows.Forms.CheckBox();
            this.label12 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // cmbkenar
            // 
            this.cmbkenar.FormattingEnabled = true;
            this.cmbkenar.Location = new System.Drawing.Point(43, 178);
            this.cmbkenar.Name = "cmbkenar";
            this.cmbkenar.Size = new System.Drawing.Size(121, 21);
            this.cmbkenar.TabIndex = 0;
            // 
            // cmbboyut
            // 
            this.cmbboyut.FormattingEnabled = true;
            this.cmbboyut.Location = new System.Drawing.Point(225, 178);
            this.cmbboyut.Name = "cmbboyut";
            this.cmbboyut.Size = new System.Drawing.Size(121, 21);
            this.cmbboyut.TabIndex = 1;
            // 
            // checkmlzm2
            // 
            this.checkmlzm2.AutoSize = true;
            this.checkmlzm2.Location = new System.Drawing.Point(98, 255);
            this.checkmlzm2.Name = "checkmlzm2";
            this.checkmlzm2.Size = new System.Drawing.Size(58, 17);
            this.checkmlzm2.TabIndex = 3;
            this.checkmlzm2.Text = "mantar";
            this.checkmlzm2.UseVisualStyleBackColor = true;
            // 
            // checkmlzm3
            // 
            this.checkmlzm3.AutoSize = true;
            this.checkmlzm3.Location = new System.Drawing.Point(162, 255);
            this.checkmlzm3.Name = "checkmlzm3";
            this.checkmlzm3.Size = new System.Drawing.Size(56, 17);
            this.checkmlzm3.TabIndex = 4;
            this.checkmlzm3.Text = "susam";
            this.checkmlzm3.UseVisualStyleBackColor = true;
            // 
            // checkmlzm4
            // 
            this.checkmlzm4.AutoSize = true;
            this.checkmlzm4.Location = new System.Drawing.Point(224, 255);
            this.checkmlzm4.Name = "checkmlzm4";
            this.checkmlzm4.Size = new System.Drawing.Size(53, 17);
            this.checkmlzm4.TabIndex = 5;
            this.checkmlzm4.Text = "salam";
            this.checkmlzm4.UseVisualStyleBackColor = true;
            // 
            // checktatli
            // 
            this.checktatli.AutoSize = true;
            this.checktatli.Location = new System.Drawing.Point(154, 309);
            this.checktatli.Name = "checktatli";
            this.checktatli.Size = new System.Drawing.Size(107, 17);
            this.checktatli.TabIndex = 7;
            this.checktatli.Text = "Tatlı ister misiniz?";
            this.checktatli.UseVisualStyleBackColor = true;
            // 
            // checkicecek
            // 
            this.checkicecek.AutoSize = true;
            this.checkicecek.Location = new System.Drawing.Point(154, 351);
            this.checkicecek.Name = "checkicecek";
            this.checkicecek.Size = new System.Drawing.Size(120, 17);
            this.checkicecek.TabIndex = 8;
            this.checkicecek.Text = "İçecek ister misiniz?";
            this.checkicecek.UseVisualStyleBackColor = true;
            // 
            // btnhesapla
            // 
            this.btnhesapla.Location = new System.Drawing.Point(130, 399);
            this.btnhesapla.Name = "btnhesapla";
            this.btnhesapla.Size = new System.Drawing.Size(144, 23);
            this.btnhesapla.TabIndex = 9;
            this.btnhesapla.Text = "Sipariş oluştur";
            this.btnhesapla.UseVisualStyleBackColor = true;
            this.btnhesapla.Click += new System.EventHandler(this.btnhesapla_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(72, 148);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(70, 13);
            this.label2.TabIndex = 11;
            this.label2.Text = "Kenar seçiniz";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(252, 148);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(68, 13);
            this.label3.TabIndex = 12;
            this.label3.Text = "boyut seçiniz";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(151, 227);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(83, 13);
            this.label4.TabIndex = 13;
            this.label4.Text = "malzeme seçiniz";
            // 
            // checkmlzm5
            // 
            this.checkmlzm5.AutoSize = true;
            this.checkmlzm5.Location = new System.Drawing.Point(283, 255);
            this.checkmlzm5.Name = "checkmlzm5";
            this.checkmlzm5.Size = new System.Drawing.Size(53, 17);
            this.checkmlzm5.TabIndex = 14;
            this.checkmlzm5.Text = "zeytin";
            this.checkmlzm5.UseVisualStyleBackColor = true;
            // 
            // checkmlzm1
            // 
            this.checkmlzm1.AutoSize = true;
            this.checkmlzm1.Location = new System.Drawing.Point(41, 255);
            this.checkmlzm1.Name = "checkmlzm1";
            this.checkmlzm1.Size = new System.Drawing.Size(51, 17);
            this.checkmlzm1.TabIndex = 2;
            this.checkmlzm1.Text = "Sosis";
            this.checkmlzm1.UseVisualStyleBackColor = true;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.label12.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label12.Cursor = System.Windows.Forms.Cursors.Hand;
            this.label12.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.label12.Font = new System.Drawing.Font("Javanese Text", 35F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label12.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label12.Location = new System.Drawing.Point(26, 28);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(373, 55);
            this.label12.TabIndex = 15;
            this.label12.Text = "PİZZAM BURDA";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(425, 436);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.checkmlzm5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnhesapla);
            this.Controls.Add(this.checkicecek);
            this.Controls.Add(this.checktatli);
            this.Controls.Add(this.checkmlzm4);
            this.Controls.Add(this.checkmlzm3);
            this.Controls.Add(this.checkmlzm2);
            this.Controls.Add(this.checkmlzm1);
            this.Controls.Add(this.cmbboyut);
            this.Controls.Add(this.cmbkenar);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cmbkenar;
        private System.Windows.Forms.ComboBox cmbboyut;
        private System.Windows.Forms.CheckBox checkmlzm2;
        private System.Windows.Forms.CheckBox checkmlzm3;
        private System.Windows.Forms.CheckBox checkmlzm4;
        private System.Windows.Forms.CheckBox checktatli;
        private System.Windows.Forms.CheckBox checkicecek;
        private System.Windows.Forms.Button btnhesapla;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.CheckBox checkmlzm5;
        private System.Windows.Forms.CheckBox checkmlzm1;
        private System.Windows.Forms.Label label12;
    }
}

