namespace Sterownik_silnika_z_akcelerometrem
{
    partial class Sterownik
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Sterownik));
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.serialPort1 = new System.IO.Ports.SerialPort(this.components);
            this.axisy = new System.Windows.Forms.TextBox();
            this.axisx = new System.Windows.Forms.TextBox();
            this.axisz = new System.Windows.Forms.TextBox();
            this.komunikacja = new System.Windows.Forms.RichTextBox();
            this.inicjalizuj = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
            this.zalacz = new System.Windows.Forms.Button();
            this.numericUpDown2 = new System.Windows.Forms.NumericUpDown();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.pozycjaX = new System.Windows.Forms.Button();
            this.PozycjaY = new System.Windows.Forms.Button();
            this.PozycjaZ = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown2)).BeginInit();
            this.SuspendLayout();
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(15, 24);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(127, 21);
            this.comboBox1.TabIndex = 0;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(12, 190);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(130, 117);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(12, 55);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(130, 116);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 2;
            this.pictureBox2.TabStop = false;
            // 
            // axisy
            // 
            this.axisy.Location = new System.Drawing.Point(150, 104);
            this.axisy.Name = "axisy";
            this.axisy.Size = new System.Drawing.Size(139, 20);
            this.axisy.TabIndex = 3;
            // 
            // axisx
            // 
            this.axisx.Location = new System.Drawing.Point(150, 67);
            this.axisx.Name = "axisx";
            this.axisx.Size = new System.Drawing.Size(139, 20);
            this.axisx.TabIndex = 4;
            this.axisx.TextChanged += new System.EventHandler(this.axisx_TextChanged);
            // 
            // axisz
            // 
            this.axisz.Location = new System.Drawing.Point(150, 141);
            this.axisz.Name = "axisz";
            this.axisz.Size = new System.Drawing.Size(139, 20);
            this.axisz.TabIndex = 5;
            // 
            // komunikacja
            // 
            this.komunikacja.Location = new System.Drawing.Point(148, 190);
            this.komunikacja.Name = "komunikacja";
            this.komunikacja.Size = new System.Drawing.Size(141, 117);
            this.komunikacja.TabIndex = 6;
            this.komunikacja.Text = "";
            this.komunikacja.TextChanged += new System.EventHandler(this.komunikacja_TextChanged);
            // 
            // inicjalizuj
            // 
            this.inicjalizuj.Location = new System.Drawing.Point(150, 24);
            this.inicjalizuj.Name = "inicjalizuj";
            this.inicjalizuj.Size = new System.Drawing.Size(139, 23);
            this.inicjalizuj.TabIndex = 8;
            this.inicjalizuj.Text = "Inicjalizuj urzadzenia";
            this.inicjalizuj.UseVisualStyleBackColor = true;
            this.inicjalizuj.Click += new System.EventHandler(this.inicjalizuj_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(295, 69);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(30, 13);
            this.label1.TabIndex = 9;
            this.label1.Text = "Os X";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(295, 104);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(30, 13);
            this.label2.TabIndex = 10;
            this.label2.Text = "Os Y";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(295, 141);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(30, 13);
            this.label3.TabIndex = 11;
            this.label3.Text = "Os Z";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(148, 310);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(118, 13);
            this.label4.TabIndex = 12;
            this.label4.Text = "Komunikacja z silnikiem";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // numericUpDown1
            // 
            this.numericUpDown1.Location = new System.Drawing.Point(295, 191);
            this.numericUpDown1.Name = "numericUpDown1";
            this.numericUpDown1.Size = new System.Drawing.Size(130, 20);
            this.numericUpDown1.TabIndex = 13;
            this.numericUpDown1.ValueChanged += new System.EventHandler(this.numericUpDown1_ValueChanged);
            // 
            // zalacz
            // 
            this.zalacz.Location = new System.Drawing.Point(295, 244);
            this.zalacz.Name = "zalacz";
            this.zalacz.Size = new System.Drawing.Size(130, 23);
            this.zalacz.TabIndex = 14;
            this.zalacz.Text = "Zalacz obrot silnika";
            this.zalacz.UseVisualStyleBackColor = true;
            this.zalacz.Click += new System.EventHandler(this.zalacz_Click);
            // 
            // numericUpDown2
            // 
            this.numericUpDown2.Location = new System.Drawing.Point(295, 218);
            this.numericUpDown2.Name = "numericUpDown2";
            this.numericUpDown2.Size = new System.Drawing.Size(130, 20);
            this.numericUpDown2.TabIndex = 15;
            this.numericUpDown2.ValueChanged += new System.EventHandler(this.numericUpDown2_ValueChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(435, 193);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(85, 13);
            this.label5.TabIndex = 16;
            this.label5.Text = "Predkosc obrotu";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(435, 220);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(93, 13);
            this.label6.TabIndex = 17;
            this.label6.Text = "Ilosc krokow x100";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(12, 174);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(118, 13);
            this.label7.TabIndex = 18;
            this.label7.Text = "Akcelerometr ADXL345";
            this.label7.Click += new System.EventHandler(this.label7_Click_1);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(12, 310);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(124, 13);
            this.label8.TabIndex = 19;
            this.label8.Text = "Silnik krokowy 28BYJ-48";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(295, 29);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(96, 13);
            this.label9.TabIndex = 20;
            this.label9.Text = "Wybierz port COM ";
            this.label9.Click += new System.EventHandler(this.label9_Click);
            // 
            // pozycjaX
            // 
            this.pozycjaX.Location = new System.Drawing.Point(331, 64);
            this.pozycjaX.Name = "pozycjaX";
            this.pozycjaX.Size = new System.Drawing.Size(130, 23);
            this.pozycjaX.TabIndex = 21;
            this.pozycjaX.Text = "Pobierz pozycje";
            this.pozycjaX.UseVisualStyleBackColor = true;
            this.pozycjaX.Click += new System.EventHandler(this.pozycjaX_Click);
            // 
            // PozycjaY
            // 
            this.PozycjaY.Location = new System.Drawing.Point(331, 104);
            this.PozycjaY.Name = "PozycjaY";
            this.PozycjaY.Size = new System.Drawing.Size(130, 23);
            this.PozycjaY.TabIndex = 22;
            this.PozycjaY.Text = "Pobierz pozycje";
            this.PozycjaY.UseVisualStyleBackColor = true;
            this.PozycjaY.Click += new System.EventHandler(this.PozycjaY_Click);
            // 
            // PozycjaZ
            // 
            this.PozycjaZ.Location = new System.Drawing.Point(331, 141);
            this.PozycjaZ.Name = "PozycjaZ";
            this.PozycjaZ.Size = new System.Drawing.Size(130, 23);
            this.PozycjaZ.TabIndex = 23;
            this.PozycjaZ.Text = "Pobierz pozycje";
            this.PozycjaZ.UseVisualStyleBackColor = true;
            this.PozycjaZ.Click += new System.EventHandler(this.PozycjaZ_Click);
            // 
            // Sterownik
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(531, 334);
            this.Controls.Add(this.PozycjaZ);
            this.Controls.Add(this.PozycjaY);
            this.Controls.Add(this.pozycjaX);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.numericUpDown2);
            this.Controls.Add(this.zalacz);
            this.Controls.Add(this.numericUpDown1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.inicjalizuj);
            this.Controls.Add(this.komunikacja);
            this.Controls.Add(this.axisz);
            this.Controls.Add(this.axisx);
            this.Controls.Add(this.axisy);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.comboBox1);
            this.Name = "Sterownik";
            this.Text = "Sterownik silnika krokowego z weryfikacja pozycji";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.IO.Ports.SerialPort serialPort1;
        private System.Windows.Forms.TextBox axisy;
        private System.Windows.Forms.TextBox axisx;
        private System.Windows.Forms.TextBox axisz;
        private System.Windows.Forms.RichTextBox komunikacja;
        private System.Windows.Forms.Button inicjalizuj;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.NumericUpDown numericUpDown1;
        private System.Windows.Forms.Button zalacz;
        private System.Windows.Forms.NumericUpDown numericUpDown2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button pozycjaX;
        private System.Windows.Forms.Button PozycjaY;
        private System.Windows.Forms.Button PozycjaZ;
    }
}

