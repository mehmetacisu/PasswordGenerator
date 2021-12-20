
namespace RastgeleSifreOlusturucu
{
    partial class FormSifreOlusturucu
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormSifreOlusturucu));
            this.panel_header = new System.Windows.Forms.Panel();
            this.panel_footer = new System.Windows.Forms.Panel();
            this.panel_content = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.label_Cikis = new System.Windows.Forms.Label();
            this.label_Baslik = new System.Windows.Forms.Label();
            this.label_Sifre = new System.Windows.Forms.Label();
            this.comboBox_Uzunluk = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label_Message = new System.Windows.Forms.Label();
            this.button_Kopyala = new System.Windows.Forms.Button();
            this.button_Temizle = new System.Windows.Forms.Button();
            this.button_Olustur = new System.Windows.Forms.Button();
            this.panel_header.SuspendLayout();
            this.panel_footer.SuspendLayout();
            this.panel_content.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel_header
            // 
            this.panel_header.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(172)))), ((int)(((byte)(126)))), ((int)(((byte)(98)))));
            this.panel_header.Controls.Add(this.label_Baslik);
            this.panel_header.Controls.Add(this.label_Cikis);
            this.panel_header.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel_header.Location = new System.Drawing.Point(0, 0);
            this.panel_header.Margin = new System.Windows.Forms.Padding(5);
            this.panel_header.Name = "panel_header";
            this.panel_header.Size = new System.Drawing.Size(800, 25);
            this.panel_header.TabIndex = 0;
            // 
            // panel_footer
            // 
            this.panel_footer.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(172)))), ((int)(((byte)(126)))), ((int)(((byte)(98)))));
            this.panel_footer.Controls.Add(this.label1);
            this.panel_footer.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel_footer.Location = new System.Drawing.Point(0, 425);
            this.panel_footer.Margin = new System.Windows.Forms.Padding(5);
            this.panel_footer.Name = "panel_footer";
            this.panel_footer.Size = new System.Drawing.Size(800, 25);
            this.panel_footer.TabIndex = 0;
            // 
            // panel_content
            // 
            this.panel_content.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(210)))), ((int)(((byte)(200)))), ((int)(((byte)(188)))));
            this.panel_content.Controls.Add(this.label_Message);
            this.panel_content.Controls.Add(this.label2);
            this.panel_content.Controls.Add(this.comboBox_Uzunluk);
            this.panel_content.Controls.Add(this.label_Sifre);
            this.panel_content.Controls.Add(this.button_Kopyala);
            this.panel_content.Controls.Add(this.button_Temizle);
            this.panel_content.Controls.Add(this.button_Olustur);
            this.panel_content.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel_content.Location = new System.Drawing.Point(0, 25);
            this.panel_content.Margin = new System.Windows.Forms.Padding(5);
            this.panel_content.Name = "panel_content";
            this.panel_content.Size = new System.Drawing.Size(800, 400);
            this.panel_content.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(210)))), ((int)(((byte)(200)))), ((int)(((byte)(188)))));
            this.label1.Location = new System.Drawing.Point(286, 2);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(209, 18);
            this.label1.TabIndex = 0;
            this.label1.Text = "Designed By Mehmet Acısu";
            // 
            // label_Cikis
            // 
            this.label_Cikis.AutoSize = true;
            this.label_Cikis.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(172)))), ((int)(((byte)(126)))), ((int)(((byte)(98)))));
            this.label_Cikis.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label_Cikis.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(210)))), ((int)(((byte)(200)))), ((int)(((byte)(188)))));
            this.label_Cikis.Location = new System.Drawing.Point(775, 2);
            this.label_Cikis.Name = "label_Cikis";
            this.label_Cikis.Size = new System.Drawing.Size(22, 22);
            this.label_Cikis.TabIndex = 0;
            this.label_Cikis.Text = "X";
            this.label_Cikis.Click += new System.EventHandler(this.label_Cikis_Click);
            // 
            // label_Baslik
            // 
            this.label_Baslik.AutoSize = true;
            this.label_Baslik.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label_Baslik.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(210)))), ((int)(((byte)(200)))), ((int)(((byte)(188)))));
            this.label_Baslik.Location = new System.Drawing.Point(306, 3);
            this.label_Baslik.Name = "label_Baslik";
            this.label_Baslik.Size = new System.Drawing.Size(188, 18);
            this.label_Baslik.TabIndex = 1;
            this.label_Baslik.Text = "Rastgele Şifre Oluşturucu";
            // 
            // label_Sifre
            // 
            this.label_Sifre.AutoSize = true;
            this.label_Sifre.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(172)))), ((int)(((byte)(126)))), ((int)(((byte)(98)))));
            this.label_Sifre.Location = new System.Drawing.Point(3, 328);
            this.label_Sifre.Name = "label_Sifre";
            this.label_Sifre.Size = new System.Drawing.Size(162, 21);
            this.label_Sifre.TabIndex = 1;
            this.label_Sifre.Text = "Oluşturulan Şifreniz :";
            // 
            // comboBox_Uzunluk
            // 
            this.comboBox_Uzunluk.BackColor = System.Drawing.Color.White;
            this.comboBox_Uzunluk.DropDownWidth = 50;
            this.comboBox_Uzunluk.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.comboBox_Uzunluk.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(172)))), ((int)(((byte)(126)))), ((int)(((byte)(98)))));
            this.comboBox_Uzunluk.FormattingEnabled = true;
            this.comboBox_Uzunluk.Location = new System.Drawing.Point(384, 170);
            this.comboBox_Uzunluk.Name = "comboBox_Uzunluk";
            this.comboBox_Uzunluk.Size = new System.Drawing.Size(179, 29);
            this.comboBox_Uzunluk.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(172)))), ((int)(((byte)(126)))), ((int)(((byte)(98)))));
            this.label2.Location = new System.Drawing.Point(124, 174);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(237, 21);
            this.label2.TabIndex = 3;
            this.label2.Text = "Şifrenizin Uzunluğunu Seçiniz : ";
            // 
            // label_Message
            // 
            this.label_Message.AutoSize = true;
            this.label_Message.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(172)))), ((int)(((byte)(126)))), ((int)(((byte)(98)))));
            this.label_Message.Location = new System.Drawing.Point(3, 328);
            this.label_Message.Name = "label_Message";
            this.label_Message.Size = new System.Drawing.Size(102, 21);
            this.label_Message.TabIndex = 4;
            this.label_Message.Text = "Hata Mesajı";
            // 
            // button_Kopyala
            // 
            this.button_Kopyala.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(172)))), ((int)(((byte)(126)))), ((int)(((byte)(98)))));
            this.button_Kopyala.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_Kopyala.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(172)))), ((int)(((byte)(126)))), ((int)(((byte)(98)))));
            this.button_Kopyala.Image = global::RastgeleSifreOlusturucu.Properties.Resources.copy_32px;
            this.button_Kopyala.Location = new System.Drawing.Point(511, 353);
            this.button_Kopyala.Name = "button_Kopyala";
            this.button_Kopyala.Size = new System.Drawing.Size(162, 42);
            this.button_Kopyala.TabIndex = 0;
            this.button_Kopyala.Text = "Şifreyi Kopyala";
            this.button_Kopyala.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.button_Kopyala.UseVisualStyleBackColor = true;
            this.button_Kopyala.Click += new System.EventHandler(this.button_Kopyala_Click);
            // 
            // button_Temizle
            // 
            this.button_Temizle.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(172)))), ((int)(((byte)(126)))), ((int)(((byte)(98)))));
            this.button_Temizle.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_Temizle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(172)))), ((int)(((byte)(126)))), ((int)(((byte)(98)))));
            this.button_Temizle.Image = global::RastgeleSifreOlusturucu.Properties.Resources.broom_32px;
            this.button_Temizle.Location = new System.Drawing.Point(687, 353);
            this.button_Temizle.Name = "button_Temizle";
            this.button_Temizle.Size = new System.Drawing.Size(110, 42);
            this.button_Temizle.TabIndex = 0;
            this.button_Temizle.Text = "Temizle";
            this.button_Temizle.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.button_Temizle.UseVisualStyleBackColor = true;
            this.button_Temizle.Click += new System.EventHandler(this.button_Temizle_Click);
            // 
            // button_Olustur
            // 
            this.button_Olustur.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(172)))), ((int)(((byte)(126)))), ((int)(((byte)(98)))));
            this.button_Olustur.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_Olustur.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(172)))), ((int)(((byte)(126)))), ((int)(((byte)(98)))));
            this.button_Olustur.Image = global::RastgeleSifreOlusturucu.Properties.Resources.create_32px;
            this.button_Olustur.Location = new System.Drawing.Point(354, 353);
            this.button_Olustur.Name = "button_Olustur";
            this.button_Olustur.Size = new System.Drawing.Size(143, 42);
            this.button_Olustur.TabIndex = 0;
            this.button_Olustur.Text = "Şifre Oluştur";
            this.button_Olustur.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.button_Olustur.UseVisualStyleBackColor = true;
            this.button_Olustur.Click += new System.EventHandler(this.button_Olustur_Click);
            // 
            // FormSifreOlusturucu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.panel_content);
            this.Controls.Add(this.panel_footer);
            this.Controls.Add(this.panel_header);
            this.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(5);
            this.Name = "FormSifreOlusturucu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormSifreOlusturucu";
            this.panel_header.ResumeLayout(false);
            this.panel_header.PerformLayout();
            this.panel_footer.ResumeLayout(false);
            this.panel_footer.PerformLayout();
            this.panel_content.ResumeLayout(false);
            this.panel_content.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel_header;
        private System.Windows.Forms.Panel panel_footer;
        private System.Windows.Forms.Panel panel_content;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label_Cikis;
        private System.Windows.Forms.Button button_Olustur;
        private System.Windows.Forms.Label label_Baslik;
        private System.Windows.Forms.Label label_Sifre;
        private System.Windows.Forms.ComboBox comboBox_Uzunluk;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label_Message;
        private System.Windows.Forms.Button button_Kopyala;
        private System.Windows.Forms.Button button_Temizle;
    }
}

