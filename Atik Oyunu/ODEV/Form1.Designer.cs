namespace ODEV
{
    partial class Form1
    {
        /// <summary>
        ///Gerekli tasarımcı değişkeni.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///Kullanılan tüm kaynakları temizleyin.
        /// </summary>
        ///<param name="disposing">yönetilen kaynaklar dispose edilmeliyse doğru; aksi halde yanlış.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer üretilen kod

        /// <summary>
        /// Tasarımcı desteği için gerekli metot - bu metodun 
        ///içeriğini kod düzenleyici ile değiştirmeyin.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.baslat_button = new System.Windows.Forms.Button();
            this.cikis_button = new System.Windows.Forms.Button();
            this.kutular_baslik = new System.Windows.Forms.TextBox();
            this.organik_bosalt = new System.Windows.Forms.Button();
            this.kagit_bosalt = new System.Windows.Forms.Button();
            this.cam_bosalt = new System.Windows.Forms.Button();
            this.metal_bosalt = new System.Windows.Forms.Button();
            this.organik_yuzde = new System.Windows.Forms.ProgressBar();
            this.kagit_yuzde = new System.Windows.Forms.ProgressBar();
            this.cam_yuzde = new System.Windows.Forms.ProgressBar();
            this.metal_yuzde = new System.Windows.Forms.ProgressBar();
            this.puan_baslik_text = new System.Windows.Forms.TextBox();
            this.organik_ekle_button = new System.Windows.Forms.Button();
            this.kagit_ekle_button = new System.Windows.Forms.Button();
            this.cam_ekle_button = new System.Windows.Forms.Button();
            this.metal_ekle_button = new System.Windows.Forms.Button();
            this.zamanSayaci = new System.Windows.Forms.Label();
            this.puanText = new System.Windows.Forms.Label();
            this.my_image = new System.Windows.Forms.PictureBox();
            this.cam_list = new System.Windows.Forms.Label();
            this.metal_list = new System.Windows.Forms.Label();
            this.kagit_list = new System.Windows.Forms.Label();
            this.organik_list = new System.Windows.Forms.Label();
            this.time_baslik_text = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.my_image)).BeginInit();
            this.SuspendLayout();
            // 
            // baslat_button
            // 
            this.baslat_button.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.baslat_button.Location = new System.Drawing.Point(12, 204);
            this.baslat_button.Name = "baslat_button";
            this.baslat_button.Size = new System.Drawing.Size(191, 23);
            this.baslat_button.TabIndex = 1;
            this.baslat_button.Text = "YENİ OYUN";
            this.baslat_button.UseVisualStyleBackColor = true;
            this.baslat_button.Click += new System.EventHandler(this.baslat_button_Click);
            // 
            // cikis_button
            // 
            this.cikis_button.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.cikis_button.Location = new System.Drawing.Point(12, 377);
            this.cikis_button.Name = "cikis_button";
            this.cikis_button.Size = new System.Drawing.Size(191, 23);
            this.cikis_button.TabIndex = 2;
            this.cikis_button.Text = "ÇIKIŞ";
            this.cikis_button.UseVisualStyleBackColor = true;
            this.cikis_button.Click += new System.EventHandler(this.cikis_button_Click);
            // 
            // kutular_baslik
            // 
            this.kutular_baslik.BackColor = System.Drawing.Color.Bisque;
            this.kutular_baslik.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.kutular_baslik.Location = new System.Drawing.Point(209, 12);
            this.kutular_baslik.Name = "kutular_baslik";
            this.kutular_baslik.Size = new System.Drawing.Size(206, 20);
            this.kutular_baslik.TabIndex = 3;
            this.kutular_baslik.Text = "ATIK KUTULARI";
            this.kutular_baslik.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // organik_bosalt
            // 
            this.organik_bosalt.Location = new System.Drawing.Point(209, 192);
            this.organik_bosalt.Name = "organik_bosalt";
            this.organik_bosalt.Size = new System.Drawing.Size(100, 23);
            this.organik_bosalt.TabIndex = 8;
            this.organik_bosalt.Text = "BOŞALT";
            this.organik_bosalt.UseVisualStyleBackColor = true;
            this.organik_bosalt.Click += new System.EventHandler(this.organik_bosalt_Click);
            // 
            // kagit_bosalt
            // 
            this.kagit_bosalt.Location = new System.Drawing.Point(315, 191);
            this.kagit_bosalt.Name = "kagit_bosalt";
            this.kagit_bosalt.Size = new System.Drawing.Size(100, 23);
            this.kagit_bosalt.TabIndex = 9;
            this.kagit_bosalt.Text = "BOŞALT";
            this.kagit_bosalt.UseVisualStyleBackColor = true;
            this.kagit_bosalt.Click += new System.EventHandler(this.kagit_bosalt_click);
            // 
            // cam_bosalt
            // 
            this.cam_bosalt.Location = new System.Drawing.Point(209, 377);
            this.cam_bosalt.Name = "cam_bosalt";
            this.cam_bosalt.Size = new System.Drawing.Size(100, 23);
            this.cam_bosalt.TabIndex = 10;
            this.cam_bosalt.Text = "BOŞALT";
            this.cam_bosalt.UseVisualStyleBackColor = true;
            this.cam_bosalt.Click += new System.EventHandler(this.cam_bosalt_Click);
            // 
            // metal_bosalt
            // 
            this.metal_bosalt.Location = new System.Drawing.Point(315, 377);
            this.metal_bosalt.Name = "metal_bosalt";
            this.metal_bosalt.Size = new System.Drawing.Size(100, 23);
            this.metal_bosalt.TabIndex = 11;
            this.metal_bosalt.Text = "BOŞALT";
            this.metal_bosalt.UseVisualStyleBackColor = true;
            this.metal_bosalt.Click += new System.EventHandler(this.metal_bosalt_click);
            // 
            // organik_yuzde
            // 
            this.organik_yuzde.Location = new System.Drawing.Point(209, 165);
            this.organik_yuzde.Name = "organik_yuzde";
            this.organik_yuzde.Size = new System.Drawing.Size(100, 24);
            this.organik_yuzde.TabIndex = 16;
            // 
            // kagit_yuzde
            // 
            this.kagit_yuzde.Location = new System.Drawing.Point(315, 165);
            this.kagit_yuzde.Name = "kagit_yuzde";
            this.kagit_yuzde.Size = new System.Drawing.Size(100, 23);
            this.kagit_yuzde.TabIndex = 17;
            // 
            // cam_yuzde
            // 
            this.cam_yuzde.Location = new System.Drawing.Point(210, 348);
            this.cam_yuzde.Name = "cam_yuzde";
            this.cam_yuzde.Size = new System.Drawing.Size(99, 23);
            this.cam_yuzde.TabIndex = 18;
            // 
            // metal_yuzde
            // 
            this.metal_yuzde.Location = new System.Drawing.Point(315, 348);
            this.metal_yuzde.Name = "metal_yuzde";
            this.metal_yuzde.Size = new System.Drawing.Size(100, 23);
            this.metal_yuzde.TabIndex = 19;
            // 
            // puan_baslik_text
            // 
            this.puan_baslik_text.BackColor = System.Drawing.Color.Teal;
            this.puan_baslik_text.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.puan_baslik_text.ForeColor = System.Drawing.SystemColors.Window;
            this.puan_baslik_text.Location = new System.Drawing.Point(12, 305);
            this.puan_baslik_text.Name = "puan_baslik_text";
            this.puan_baslik_text.Size = new System.Drawing.Size(191, 20);
            this.puan_baslik_text.TabIndex = 22;
            this.puan_baslik_text.Text = "PUAN";
            this.puan_baslik_text.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // organik_ekle_button
            // 
            this.organik_ekle_button.Location = new System.Drawing.Point(210, 35);
            this.organik_ekle_button.Name = "organik_ekle_button";
            this.organik_ekle_button.Size = new System.Drawing.Size(99, 23);
            this.organik_ekle_button.TabIndex = 24;
            this.organik_ekle_button.Text = "ORGANİK ATIK";
            this.organik_ekle_button.UseVisualStyleBackColor = true;
            this.organik_ekle_button.Click += new System.EventHandler(this.organik_ekle_button_Click);
            // 
            // kagit_ekle_button
            // 
            this.kagit_ekle_button.Location = new System.Drawing.Point(315, 35);
            this.kagit_ekle_button.Name = "kagit_ekle_button";
            this.kagit_ekle_button.Size = new System.Drawing.Size(100, 23);
            this.kagit_ekle_button.TabIndex = 25;
            this.kagit_ekle_button.Text = "KAĞIT";
            this.kagit_ekle_button.UseVisualStyleBackColor = true;
            this.kagit_ekle_button.Click += new System.EventHandler(this.kagit_ekle_button_Click);
            // 
            // cam_ekle_button
            // 
            this.cam_ekle_button.Location = new System.Drawing.Point(210, 218);
            this.cam_ekle_button.Name = "cam_ekle_button";
            this.cam_ekle_button.Size = new System.Drawing.Size(99, 23);
            this.cam_ekle_button.TabIndex = 26;
            this.cam_ekle_button.Text = "CAM";
            this.cam_ekle_button.UseVisualStyleBackColor = true;
            this.cam_ekle_button.Click += new System.EventHandler(this.cam_ekle_button_Click);
            // 
            // metal_ekle_button
            // 
            this.metal_ekle_button.Location = new System.Drawing.Point(315, 218);
            this.metal_ekle_button.Name = "metal_ekle_button";
            this.metal_ekle_button.Size = new System.Drawing.Size(100, 23);
            this.metal_ekle_button.TabIndex = 27;
            this.metal_ekle_button.Text = "METAL";
            this.metal_ekle_button.UseVisualStyleBackColor = true;
            this.metal_ekle_button.Click += new System.EventHandler(this.metal_ekle_button_Click);
            // 
            // zamanSayaci
            // 
            this.zamanSayaci.BackColor = System.Drawing.Color.Aqua;
            this.zamanSayaci.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.zamanSayaci.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.zamanSayaci.ForeColor = System.Drawing.Color.Linen;
            this.zamanSayaci.Location = new System.Drawing.Point(15, 256);
            this.zamanSayaci.MaximumSize = new System.Drawing.Size(189, 43);
            this.zamanSayaci.Name = "zamanSayaci";
            this.zamanSayaci.Size = new System.Drawing.Size(187, 43);
            this.zamanSayaci.TabIndex = 38;
            this.zamanSayaci.Text = "60";
            this.zamanSayaci.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // puanText
            // 
            this.puanText.BackColor = System.Drawing.Color.Aqua;
            this.puanText.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.puanText.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.puanText.ForeColor = System.Drawing.Color.White;
            this.puanText.Location = new System.Drawing.Point(15, 331);
            this.puanText.MaximumSize = new System.Drawing.Size(189, 43);
            this.puanText.Name = "puanText";
            this.puanText.Size = new System.Drawing.Size(187, 43);
            this.puanText.TabIndex = 39;
            this.puanText.Text = "0";
            this.puanText.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // my_image
            // 
            this.my_image.Location = new System.Drawing.Point(12, 12);
            this.my_image.Name = "my_image";
            this.my_image.Size = new System.Drawing.Size(186, 178);
            this.my_image.TabIndex = 40;
            this.my_image.TabStop = false;
            // 
            // cam_list
            // 
            this.cam_list.BackColor = System.Drawing.Color.Bisque;
            this.cam_list.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.cam_list.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.cam_list.Location = new System.Drawing.Point(210, 247);
            this.cam_list.MaximumSize = new System.Drawing.Size(189, 95);
            this.cam_list.Name = "cam_list";
            this.cam_list.Size = new System.Drawing.Size(100, 95);
            this.cam_list.TabIndex = 41;
            // 
            // metal_list
            // 
            this.metal_list.BackColor = System.Drawing.Color.Bisque;
            this.metal_list.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.metal_list.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.metal_list.Location = new System.Drawing.Point(316, 247);
            this.metal_list.MaximumSize = new System.Drawing.Size(189, 95);
            this.metal_list.Name = "metal_list";
            this.metal_list.Size = new System.Drawing.Size(100, 95);
            this.metal_list.TabIndex = 42;
            // 
            // kagit_list
            // 
            this.kagit_list.BackColor = System.Drawing.Color.Bisque;
            this.kagit_list.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.kagit_list.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.kagit_list.Location = new System.Drawing.Point(316, 64);
            this.kagit_list.MaximumSize = new System.Drawing.Size(189, 95);
            this.kagit_list.Name = "kagit_list";
            this.kagit_list.Size = new System.Drawing.Size(100, 95);
            this.kagit_list.TabIndex = 44;
            // 
            // organik_list
            // 
            this.organik_list.BackColor = System.Drawing.Color.Bisque;
            this.organik_list.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.organik_list.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.organik_list.Location = new System.Drawing.Point(209, 64);
            this.organik_list.MaximumSize = new System.Drawing.Size(189, 95);
            this.organik_list.Name = "organik_list";
            this.organik_list.Size = new System.Drawing.Size(100, 95);
            this.organik_list.TabIndex = 45;
            // 
            // time_baslik_text
            // 
            this.time_baslik_text.BackColor = System.Drawing.Color.Teal;
            this.time_baslik_text.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.time_baslik_text.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.time_baslik_text.Location = new System.Drawing.Point(15, 233);
            this.time_baslik_text.Name = "time_baslik_text";
            this.time_baslik_text.Size = new System.Drawing.Size(191, 20);
            this.time_baslik_text.TabIndex = 46;
            this.time_baslik_text.Text = "SÜRE";
            this.time_baslik_text.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.ClientSize = new System.Drawing.Size(422, 412);
            this.Controls.Add(this.time_baslik_text);
            this.Controls.Add(this.organik_list);
            this.Controls.Add(this.kagit_list);
            this.Controls.Add(this.metal_list);
            this.Controls.Add(this.cam_list);
            this.Controls.Add(this.my_image);
            this.Controls.Add(this.puanText);
            this.Controls.Add(this.zamanSayaci);
            this.Controls.Add(this.metal_ekle_button);
            this.Controls.Add(this.cam_ekle_button);
            this.Controls.Add(this.kagit_ekle_button);
            this.Controls.Add(this.organik_ekle_button);
            this.Controls.Add(this.puan_baslik_text);
            this.Controls.Add(this.metal_yuzde);
            this.Controls.Add(this.cam_yuzde);
            this.Controls.Add(this.kagit_yuzde);
            this.Controls.Add(this.organik_yuzde);
            this.Controls.Add(this.metal_bosalt);
            this.Controls.Add(this.cam_bosalt);
            this.Controls.Add(this.kagit_bosalt);
            this.Controls.Add(this.organik_bosalt);
            this.Controls.Add(this.kutular_baslik);
            this.Controls.Add(this.cikis_button);
            this.Controls.Add(this.baslat_button);
            this.ForeColor = System.Drawing.Color.Black;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "ATIK TOPLAMA OYUNU";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.my_image)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button baslat_button;
        private System.Windows.Forms.Button cikis_button;
        private System.Windows.Forms.TextBox kutular_baslik;
        private System.Windows.Forms.Button organik_bosalt;
        private System.Windows.Forms.Button kagit_bosalt;
        private System.Windows.Forms.Button cam_bosalt;
        private System.Windows.Forms.Button metal_bosalt;
        private System.Windows.Forms.ProgressBar organik_yuzde;
        private System.Windows.Forms.ProgressBar kagit_yuzde;
        private System.Windows.Forms.ProgressBar cam_yuzde;
        private System.Windows.Forms.TextBox puan_baslik_text;
        private System.Windows.Forms.Button organik_ekle_button;
        private System.Windows.Forms.Button kagit_ekle_button;
        private System.Windows.Forms.Button cam_ekle_button;
        private System.Windows.Forms.Button metal_ekle_button;
        private System.Windows.Forms.Label zamanSayaci;
        private System.Windows.Forms.Label puanText;
        private System.Windows.Forms.PictureBox my_image;
        public System.Windows.Forms.ProgressBar metal_yuzde;
        private System.Windows.Forms.Label cam_list;
        private System.Windows.Forms.Label metal_list;
        private System.Windows.Forms.Label kagit_list;
        private System.Windows.Forms.Label organik_list;
        private System.Windows.Forms.TextBox time_baslik_text;
    }
}

