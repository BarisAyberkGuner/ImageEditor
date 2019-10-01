namespace WindowsFormsApp1
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea4 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend4 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series10 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series11 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series12 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.dosyaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.kaydetToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.yenidenAcToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.görüntüToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ölçeklemeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aynalamaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.döndürToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saatYönünde90ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saatYönününTersine90ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.filtrelerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.terslemeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.kırmızıToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.yeşilToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.maviToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.griToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.HistogramToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.çıkışToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox1.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.pictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pictureBox1.Location = new System.Drawing.Point(0, 132);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(1510, 701);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.dosyaToolStripMenuItem,
            this.görüntüToolStripMenuItem,
            this.filtrelerToolStripMenuItem,
            this.HistogramToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1512, 33);
            this.menuStrip1.TabIndex = 31;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // dosyaToolStripMenuItem
            // 
            this.dosyaToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem1,
            this.kaydetToolStripMenuItem,
            this.yenidenAcToolStripMenuItem,
            this.çıkışToolStripMenuItem});
            this.dosyaToolStripMenuItem.Name = "dosyaToolStripMenuItem";
            this.dosyaToolStripMenuItem.Size = new System.Drawing.Size(74, 29);
            this.dosyaToolStripMenuItem.Text = "Dosya";
            this.dosyaToolStripMenuItem.Click += new System.EventHandler(this.dosyaToolStripMenuItem_Click);
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(177, 30);
            this.toolStripMenuItem1.Text = "Aç";
            this.toolStripMenuItem1.Click += new System.EventHandler(this.toolStripMenuItem1_Click);
            // 
            // kaydetToolStripMenuItem
            // 
            this.kaydetToolStripMenuItem.Name = "kaydetToolStripMenuItem";
            this.kaydetToolStripMenuItem.Size = new System.Drawing.Size(177, 30);
            this.kaydetToolStripMenuItem.Text = "Kaydet";
            this.kaydetToolStripMenuItem.Click += new System.EventHandler(this.kaydetToolStripMenuItem_Click);
            // 
            // yenidenAcToolStripMenuItem
            // 
            this.yenidenAcToolStripMenuItem.Name = "yenidenAcToolStripMenuItem";
            this.yenidenAcToolStripMenuItem.Size = new System.Drawing.Size(210, 30);
            this.yenidenAcToolStripMenuItem.Text = "Yeniden Aç";
            this.yenidenAcToolStripMenuItem.Click += new System.EventHandler(this.yenidenAcToolStripMenuItem_Click);
            // 
            // görüntüToolStripMenuItem
            // 
            this.görüntüToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ölçeklemeToolStripMenuItem,
            this.aynalamaToolStripMenuItem,
            this.döndürToolStripMenuItem});
            this.görüntüToolStripMenuItem.Name = "görüntüToolStripMenuItem";
            this.görüntüToolStripMenuItem.Size = new System.Drawing.Size(89, 29);
            this.görüntüToolStripMenuItem.Text = "Görüntü";
            this.görüntüToolStripMenuItem.Click += new System.EventHandler(this.görüntüToolStripMenuItem_Click);
            // 
            // ölçeklemeToolStripMenuItem
            // 
            this.ölçeklemeToolStripMenuItem.Name = "ölçeklemeToolStripMenuItem";
            this.ölçeklemeToolStripMenuItem.Size = new System.Drawing.Size(178, 30);
            this.ölçeklemeToolStripMenuItem.Text = "Ölçekleme";
            // 
            // aynalamaToolStripMenuItem
            // 
            this.aynalamaToolStripMenuItem.Name = "aynalamaToolStripMenuItem";
            this.aynalamaToolStripMenuItem.Size = new System.Drawing.Size(178, 30);
            this.aynalamaToolStripMenuItem.Text = "Aynalama";
            this.aynalamaToolStripMenuItem.Click += new System.EventHandler(this.aynalamaToolStripMenuItem_Click);
            // 
            // döndürToolStripMenuItem
            // 
            this.döndürToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.saatYönünde90ToolStripMenuItem,
            this.saatYönününTersine90ToolStripMenuItem});
            this.döndürToolStripMenuItem.Name = "döndürToolStripMenuItem";
            this.döndürToolStripMenuItem.Size = new System.Drawing.Size(178, 30);
            this.döndürToolStripMenuItem.Text = "Döndür";
            // 
            // saatYönünde90ToolStripMenuItem
            // 
            this.saatYönünde90ToolStripMenuItem.Name = "saatYönünde90ToolStripMenuItem";
            this.saatYönünde90ToolStripMenuItem.Size = new System.Drawing.Size(305, 30);
            this.saatYönünde90ToolStripMenuItem.Text = "Saat Yönünde 90°";
            this.saatYönünde90ToolStripMenuItem.Click += new System.EventHandler(this.saatYönünde90ToolStripMenuItem_Click);
            // 
            // saatYönününTersine90ToolStripMenuItem
            // 
            this.saatYönününTersine90ToolStripMenuItem.Name = "saatYönününTersine90ToolStripMenuItem";
            this.saatYönününTersine90ToolStripMenuItem.Size = new System.Drawing.Size(305, 30);
            this.saatYönününTersine90ToolStripMenuItem.Text = "Saat Yönünün Tersinde 90°";
            this.saatYönününTersine90ToolStripMenuItem.Click += new System.EventHandler(this.saatYönününTersine90ToolStripMenuItem_Click);
            // 
            // filtrelerToolStripMenuItem
            // 
            this.filtrelerToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.terslemeToolStripMenuItem,
            this.kırmızıToolStripMenuItem,
            this.yeşilToolStripMenuItem,
            this.maviToolStripMenuItem,
            this.griToolStripMenuItem});
            this.filtrelerToolStripMenuItem.Name = "filtrelerToolStripMenuItem";
            this.filtrelerToolStripMenuItem.Size = new System.Drawing.Size(81, 29);
            this.filtrelerToolStripMenuItem.Text = "Filtreler";
            // 
            // terslemeToolStripMenuItem
            // 
            this.terslemeToolStripMenuItem.Name = "terslemeToolStripMenuItem";
            this.terslemeToolStripMenuItem.Size = new System.Drawing.Size(164, 30);
            this.terslemeToolStripMenuItem.Text = "Tersleme";
            this.terslemeToolStripMenuItem.Click += new System.EventHandler(this.terslemeToolStripMenuItem_Click);
            // 
            // kırmızıToolStripMenuItem
            // 
            this.kırmızıToolStripMenuItem.Name = "kırmızıToolStripMenuItem";
            this.kırmızıToolStripMenuItem.Size = new System.Drawing.Size(164, 30);
            this.kırmızıToolStripMenuItem.Text = "Kırmızı";
            this.kırmızıToolStripMenuItem.Click += new System.EventHandler(this.kırmızıToolStripMenuItem_Click);
            // 
            // yeşilToolStripMenuItem
            // 
            this.yeşilToolStripMenuItem.Name = "yeşilToolStripMenuItem";
            this.yeşilToolStripMenuItem.Size = new System.Drawing.Size(164, 30);
            this.yeşilToolStripMenuItem.Text = "Yeşil";
            this.yeşilToolStripMenuItem.Click += new System.EventHandler(this.yeşilToolStripMenuItem_Click);
            // 
            // maviToolStripMenuItem
            // 
            this.maviToolStripMenuItem.Name = "maviToolStripMenuItem";
            this.maviToolStripMenuItem.Size = new System.Drawing.Size(164, 30);
            this.maviToolStripMenuItem.Text = "Mavi";
            this.maviToolStripMenuItem.Click += new System.EventHandler(this.maviToolStripMenuItem_Click);
            // 
            // griToolStripMenuItem
            // 
            this.griToolStripMenuItem.Name = "griToolStripMenuItem";
            this.griToolStripMenuItem.Size = new System.Drawing.Size(164, 30);
            this.griToolStripMenuItem.Text = "Gri";
            this.griToolStripMenuItem.Click += new System.EventHandler(this.griToolStripMenuItem_Click);
            // 
            // HistogramToolStripMenuItem
            // 
            this.HistogramToolStripMenuItem.Name = "HistogramToolStripMenuItem";
            this.HistogramToolStripMenuItem.Size = new System.Drawing.Size(108, 29);
            this.HistogramToolStripMenuItem.Text = "Histogram";
            this.HistogramToolStripMenuItem.Click += new System.EventHandler(this.gARAVELToolStripMenuItem_Click);
            // 
            // chart1
            // 
            this.chart1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.chart1.BackColor = System.Drawing.Color.Transparent;
            this.chart1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.chart1.BorderlineColor = System.Drawing.Color.Black;
            this.chart1.BorderlineDashStyle = System.Windows.Forms.DataVisualization.Charting.ChartDashStyle.Solid;
            chartArea4.BackColor = System.Drawing.Color.Transparent;
            chartArea4.BackSecondaryColor = System.Drawing.Color.DimGray;
            chartArea4.Name = "ChartArea1";
            this.chart1.ChartAreas.Add(chartArea4);
            legend4.BackColor = System.Drawing.Color.Transparent;
            legend4.InterlacedRowsColor = System.Drawing.Color.White;
            legend4.Name = "Legend1";
            legend4.TitleBackColor = System.Drawing.Color.Transparent;
            this.chart1.Legends.Add(legend4);
            this.chart1.Location = new System.Drawing.Point(0, 841);
            this.chart1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.chart1.Name = "chart1";
            series10.ChartArea = "ChartArea1";
            series10.Color = System.Drawing.Color.Red;
            series10.Legend = "Legend1";
            series10.Name = "Red";
            series11.ChartArea = "ChartArea1";
            series11.Color = System.Drawing.Color.Green;
            series11.Legend = "Legend1";
            series11.Name = "Green";
            series12.ChartArea = "ChartArea1";
            series12.Color = System.Drawing.Color.Blue;
            series12.Legend = "Legend1";
            series12.Name = "Blue";
            this.chart1.Series.Add(series10);
            this.chart1.Series.Add(series11);
            this.chart1.Series.Add(series12);
            this.chart1.Size = new System.Drawing.Size(1512, 213);
            this.chart1.TabIndex = 38;
            this.chart1.Text = "chart1";
            this.chart1.Visible = false;
            this.chart1.Click += new System.EventHandler(this.chart1_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(0, 42);
            this.pictureBox2.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(86, 83);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 39;
            this.pictureBox2.TabStop = false;
            this.pictureBox2.Click += new System.EventHandler(this.pictureBox2_Click);
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe Print", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(554, 52);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(254, 56);
            this.label1.TabIndex = 45;
            this.label1.Text = "Resim Editörü";
            // 
            // textBox1
            // 
            this.textBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.textBox1.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.textBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.textBox1.Location = new System.Drawing.Point(1196, 46);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(141, 30);
            this.textBox1.TabIndex = 46;
            // 
            // textBox2
            // 
            this.textBox2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.textBox2.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.textBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.textBox2.Location = new System.Drawing.Point(1196, 88);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(141, 30);
            this.textBox2.TabIndex = 47;
            // 
            // button1
            // 
            this.button1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.button1.BackColor = System.Drawing.SystemColors.GrayText;
            this.button1.Font = new System.Drawing.Font("Segoe Print", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.button1.Location = new System.Drawing.Point(1343, 46);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(157, 72);
            this.button1.TabIndex = 48;
            this.button1.Text = "Ölçekle";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe Print", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(1012, 42);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(178, 42);
            this.label2.TabIndex = 49;
            this.label2.Text = "Yeni Genişlik:";
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe Print", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.Location = new System.Drawing.Point(1006, 81);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(184, 42);
            this.label3.TabIndex = 50;
            this.label3.Text = "Yeni Uzunluk:";
            // 
            // çıkışToolStripMenuItem
            // 
            this.çıkışToolStripMenuItem.Name = "çıkışToolStripMenuItem";
            this.çıkışToolStripMenuItem.Size = new System.Drawing.Size(210, 30);
            this.çıkışToolStripMenuItem.Text = "Çıkış";
            this.çıkışToolStripMenuItem.Click += new System.EventHandler(this.çıkışToolStripMenuItem_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.ClientSize = new System.Drawing.Size(1512, 1048);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.chart1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "RA Resim Editörü";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem dosyaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem kaydetToolStripMenuItem;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
        private System.Windows.Forms.ToolStripMenuItem görüntüToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ölçeklemeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aynalamaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem döndürToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saatYönünde90ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saatYönününTersine90ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem filtrelerToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem terslemeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem HistogramToolStripMenuItem;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ToolStripMenuItem yenidenAcToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem kırmızıToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem yeşilToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem maviToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem griToolStripMenuItem;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ToolStripMenuItem çıkışToolStripMenuItem;
    }
}

