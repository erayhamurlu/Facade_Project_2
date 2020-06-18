namespace YazilimMimarisiFinal
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
            this.KonumGoster = new System.Windows.Forms.Button();
            this.comboBoxUlasimTipi = new System.Windows.Forms.ComboBox();
            this.comboBoxDurak = new System.Windows.Forms.ComboBox();
            this.labelOtobusNo = new System.Windows.Forms.Label();
            this.labelDurak = new System.Windows.Forms.Label();
            this.pictureBoxKonum = new System.Windows.Forms.PictureBox();
            this.pictureBoxArac = new System.Windows.Forms.PictureBox();
            this.pictureBoxDurak = new System.Windows.Forms.PictureBox();
            this.labelAracDurumu = new System.Windows.Forms.Label();
            this.labelDurakdurumu = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxKonum)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxArac)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxDurak)).BeginInit();
            this.SuspendLayout();
            // 
            // KonumGoster
            // 
            this.KonumGoster.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.KonumGoster.Location = new System.Drawing.Point(44, 330);
            this.KonumGoster.Name = "KonumGoster";
            this.KonumGoster.Size = new System.Drawing.Size(206, 96);
            this.KonumGoster.TabIndex = 0;
            this.KonumGoster.Text = "Konum Göster";
            this.KonumGoster.UseVisualStyleBackColor = true;
            this.KonumGoster.Click += new System.EventHandler(this.KonumGoster_Click);
            // 
            // comboBoxUlasimTipi
            // 
            this.comboBoxUlasimTipi.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBoxUlasimTipi.FormattingEnabled = true;
            this.comboBoxUlasimTipi.Items.AddRange(new object[] {
            "254",
            "704",
            "705",
            "712",
            "887"});
            this.comboBoxUlasimTipi.Location = new System.Drawing.Point(43, 93);
            this.comboBoxUlasimTipi.Name = "comboBoxUlasimTipi";
            this.comboBoxUlasimTipi.Size = new System.Drawing.Size(206, 29);
            this.comboBoxUlasimTipi.TabIndex = 1;
            // 
            // comboBoxDurak
            // 
            this.comboBoxDurak.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBoxDurak.FormattingEnabled = true;
            this.comboBoxDurak.Items.AddRange(new object[] {
            "Gaziemir",
            "Buca",
            "Torbalı",
            "Konak",
            "Alsancak"});
            this.comboBoxDurak.Location = new System.Drawing.Point(43, 212);
            this.comboBoxDurak.Name = "comboBoxDurak";
            this.comboBoxDurak.Size = new System.Drawing.Size(205, 29);
            this.comboBoxDurak.TabIndex = 2;
            // 
            // labelOtobusNo
            // 
            this.labelOtobusNo.AutoSize = true;
            this.labelOtobusNo.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelOtobusNo.Location = new System.Drawing.Point(40, 43);
            this.labelOtobusNo.Name = "labelOtobusNo";
            this.labelOtobusNo.Size = new System.Drawing.Size(213, 21);
            this.labelOtobusNo.TabIndex = 3;
            this.labelOtobusNo.Text = "Otobüs Numarasını Seçiniz";
            // 
            // labelDurak
            // 
            this.labelDurak.AutoSize = true;
            this.labelDurak.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelDurak.Location = new System.Drawing.Point(39, 161);
            this.labelDurak.Name = "labelDurak";
            this.labelDurak.Size = new System.Drawing.Size(111, 21);
            this.labelDurak.TabIndex = 4;
            this.labelDurak.Text = "Durak Seçiniz";
            // 
            // pictureBoxKonum
            // 
            this.pictureBoxKonum.Location = new System.Drawing.Point(299, 43);
            this.pictureBoxKonum.Name = "pictureBoxKonum";
            this.pictureBoxKonum.Size = new System.Drawing.Size(474, 335);
            this.pictureBoxKonum.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBoxKonum.TabIndex = 5;
            this.pictureBoxKonum.TabStop = false;
            // 
            // pictureBoxArac
            // 
            this.pictureBoxArac.Location = new System.Drawing.Point(410, 388);
            this.pictureBoxArac.Name = "pictureBoxArac";
            this.pictureBoxArac.Size = new System.Drawing.Size(68, 50);
            this.pictureBoxArac.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBoxArac.TabIndex = 6;
            this.pictureBoxArac.TabStop = false;
            // 
            // pictureBoxDurak
            // 
            this.pictureBoxDurak.Location = new System.Drawing.Point(663, 388);
            this.pictureBoxDurak.Name = "pictureBoxDurak";
            this.pictureBoxDurak.Size = new System.Drawing.Size(66, 50);
            this.pictureBoxDurak.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBoxDurak.TabIndex = 7;
            this.pictureBoxDurak.TabStop = false;
            // 
            // labelAracDurumu
            // 
            this.labelAracDurumu.AutoSize = true;
            this.labelAracDurumu.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelAracDurumu.Location = new System.Drawing.Point(295, 406);
            this.labelAracDurumu.Name = "labelAracDurumu";
            this.labelAracDurumu.Size = new System.Drawing.Size(109, 20);
            this.labelAracDurumu.TabIndex = 8;
            this.labelAracDurumu.Text = "Araç Durumu:";
            // 
            // labelDurakdurumu
            // 
            this.labelDurakdurumu.AutoSize = true;
            this.labelDurakdurumu.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelDurakdurumu.Location = new System.Drawing.Point(541, 406);
            this.labelDurakdurumu.Name = "labelDurakdurumu";
            this.labelDurakdurumu.Size = new System.Drawing.Size(116, 20);
            this.labelDurakdurumu.TabIndex = 9;
            this.labelDurakdurumu.Text = "Durak Durumu:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.labelDurakdurumu);
            this.Controls.Add(this.labelAracDurumu);
            this.Controls.Add(this.pictureBoxDurak);
            this.Controls.Add(this.pictureBoxArac);
            this.Controls.Add(this.pictureBoxKonum);
            this.Controls.Add(this.labelDurak);
            this.Controls.Add(this.labelOtobusNo);
            this.Controls.Add(this.comboBoxDurak);
            this.Controls.Add(this.comboBoxUlasimTipi);
            this.Controls.Add(this.KonumGoster);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxKonum)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxArac)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxDurak)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button KonumGoster;
        private System.Windows.Forms.ComboBox comboBoxUlasimTipi;
        private System.Windows.Forms.ComboBox comboBoxDurak;
        private System.Windows.Forms.Label labelOtobusNo;
        private System.Windows.Forms.Label labelDurak;
        private System.Windows.Forms.PictureBox pictureBoxKonum;
        private System.Windows.Forms.PictureBox pictureBoxArac;
        private System.Windows.Forms.PictureBox pictureBoxDurak;
        private System.Windows.Forms.Label labelAracDurumu;
        private System.Windows.Forms.Label labelDurakdurumu;
    }
}

