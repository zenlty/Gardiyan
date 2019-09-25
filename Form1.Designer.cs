namespace DERIN
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.numpad = new System.Windows.Forms.TextBox();
            this.btn_backspace = new System.Windows.Forms.PictureBox();
            this.number_0 = new System.Windows.Forms.PictureBox();
            this.btn_clear = new System.Windows.Forms.PictureBox();
            this.number_9 = new System.Windows.Forms.PictureBox();
            this.number_8 = new System.Windows.Forms.PictureBox();
            this.number_7 = new System.Windows.Forms.PictureBox();
            this.number_6 = new System.Windows.Forms.PictureBox();
            this.number_5 = new System.Windows.Forms.PictureBox();
            this.number_4 = new System.Windows.Forms.PictureBox();
            this.number_3 = new System.Windows.Forms.PictureBox();
            this.number_2 = new System.Windows.Forms.PictureBox();
            this.number_1 = new System.Windows.Forms.PictureBox();
            this.btn_poweroff = new System.Windows.Forms.PictureBox();
            this.btn_lock = new System.Windows.Forms.PictureBox();
            this.ekranıGörüntüleToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tahtayıKilitleToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.bilgisayarıKapatToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.yöneticiPaneliToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menu = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.notify = new System.Windows.Forms.NotifyIcon(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.btn_backspace)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.number_0)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btn_clear)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.number_9)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.number_8)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.number_7)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.number_6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.number_5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.number_4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.number_3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.number_2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.number_1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btn_poweroff)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btn_lock)).BeginInit();
            this.menu.SuspendLayout();
            this.SuspendLayout();
            // 
            // numpad
            // 
            this.numpad.BackColor = System.Drawing.SystemColors.Control;
            this.numpad.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.numpad.Enabled = false;
            this.numpad.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.numpad.Location = new System.Drawing.Point(12, 119);
            this.numpad.Multiline = true;
            this.numpad.Name = "numpad";
            this.numpad.Size = new System.Drawing.Size(206, 32);
            this.numpad.TabIndex = 2;
            this.numpad.TextChanged += new System.EventHandler(this.Numpad_TextChanged);
            // 
            // btn_backspace
            // 
            this.btn_backspace.Image = global::DERIN.Properties.Resources.BS;
            this.btn_backspace.Location = new System.Drawing.Point(153, 370);
            this.btn_backspace.Name = "btn_backspace";
            this.btn_backspace.Size = new System.Drawing.Size(65, 65);
            this.btn_backspace.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.btn_backspace.TabIndex = 14;
            this.btn_backspace.TabStop = false;
            this.btn_backspace.Click += new System.EventHandler(this.Btn_backspace_Click);
            // 
            // number_0
            // 
            this.number_0.Image = global::DERIN.Properties.Resources._0;
            this.number_0.Location = new System.Drawing.Point(82, 370);
            this.number_0.Name = "number_0";
            this.number_0.Size = new System.Drawing.Size(65, 65);
            this.number_0.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.number_0.TabIndex = 13;
            this.number_0.TabStop = false;
            this.number_0.Click += new System.EventHandler(this.Number_0_Click);
            // 
            // btn_clear
            // 
            this.btn_clear.Image = global::DERIN.Properties.Resources.C;
            this.btn_clear.Location = new System.Drawing.Point(11, 370);
            this.btn_clear.Name = "btn_clear";
            this.btn_clear.Size = new System.Drawing.Size(65, 65);
            this.btn_clear.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.btn_clear.TabIndex = 12;
            this.btn_clear.TabStop = false;
            this.btn_clear.Click += new System.EventHandler(this.Btn_clear_Click);
            // 
            // number_9
            // 
            this.number_9.Image = global::DERIN.Properties.Resources._9;
            this.number_9.Location = new System.Drawing.Point(154, 299);
            this.number_9.Name = "number_9";
            this.number_9.Size = new System.Drawing.Size(65, 65);
            this.number_9.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.number_9.TabIndex = 11;
            this.number_9.TabStop = false;
            this.number_9.Click += new System.EventHandler(this.Number_9_Click);
            // 
            // number_8
            // 
            this.number_8.Image = global::DERIN.Properties.Resources._8;
            this.number_8.Location = new System.Drawing.Point(83, 299);
            this.number_8.Name = "number_8";
            this.number_8.Size = new System.Drawing.Size(65, 65);
            this.number_8.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.number_8.TabIndex = 10;
            this.number_8.TabStop = false;
            this.number_8.Click += new System.EventHandler(this.Number_8_Click);
            // 
            // number_7
            // 
            this.number_7.Image = global::DERIN.Properties.Resources._7;
            this.number_7.Location = new System.Drawing.Point(12, 299);
            this.number_7.Name = "number_7";
            this.number_7.Size = new System.Drawing.Size(65, 65);
            this.number_7.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.number_7.TabIndex = 9;
            this.number_7.TabStop = false;
            this.number_7.Click += new System.EventHandler(this.Number_7_Click);
            // 
            // number_6
            // 
            this.number_6.Image = global::DERIN.Properties.Resources._6;
            this.number_6.Location = new System.Drawing.Point(153, 228);
            this.number_6.Name = "number_6";
            this.number_6.Size = new System.Drawing.Size(65, 65);
            this.number_6.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.number_6.TabIndex = 8;
            this.number_6.TabStop = false;
            this.number_6.Click += new System.EventHandler(this.Number_6_Click);
            // 
            // number_5
            // 
            this.number_5.Image = global::DERIN.Properties.Resources._5;
            this.number_5.Location = new System.Drawing.Point(82, 228);
            this.number_5.Name = "number_5";
            this.number_5.Size = new System.Drawing.Size(65, 65);
            this.number_5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.number_5.TabIndex = 7;
            this.number_5.TabStop = false;
            this.number_5.Click += new System.EventHandler(this.Number_5_Click);
            // 
            // number_4
            // 
            this.number_4.Image = global::DERIN.Properties.Resources._4;
            this.number_4.Location = new System.Drawing.Point(11, 228);
            this.number_4.Name = "number_4";
            this.number_4.Size = new System.Drawing.Size(65, 65);
            this.number_4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.number_4.TabIndex = 6;
            this.number_4.TabStop = false;
            this.number_4.Click += new System.EventHandler(this.Number_4_Click);
            // 
            // number_3
            // 
            this.number_3.Image = global::DERIN.Properties.Resources._3;
            this.number_3.Location = new System.Drawing.Point(154, 157);
            this.number_3.Name = "number_3";
            this.number_3.Size = new System.Drawing.Size(65, 65);
            this.number_3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.number_3.TabIndex = 5;
            this.number_3.TabStop = false;
            this.number_3.Click += new System.EventHandler(this.Number_3_Click);
            // 
            // number_2
            // 
            this.number_2.Image = global::DERIN.Properties.Resources._2;
            this.number_2.Location = new System.Drawing.Point(83, 157);
            this.number_2.Name = "number_2";
            this.number_2.Size = new System.Drawing.Size(65, 65);
            this.number_2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.number_2.TabIndex = 4;
            this.number_2.TabStop = false;
            this.number_2.Click += new System.EventHandler(this.Number_2_Click);
            // 
            // number_1
            // 
            this.number_1.Image = global::DERIN.Properties.Resources._1;
            this.number_1.Location = new System.Drawing.Point(12, 157);
            this.number_1.Name = "number_1";
            this.number_1.Size = new System.Drawing.Size(65, 65);
            this.number_1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.number_1.TabIndex = 3;
            this.number_1.TabStop = false;
            this.number_1.Click += new System.EventHandler(this.Number_1_Click);
            // 
            // btn_poweroff
            // 
            this.btn_poweroff.Image = ((System.Drawing.Image)(resources.GetObject("btn_poweroff.Image")));
            this.btn_poweroff.Location = new System.Drawing.Point(119, 12);
            this.btn_poweroff.Name = "btn_poweroff";
            this.btn_poweroff.Size = new System.Drawing.Size(100, 100);
            this.btn_poweroff.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.btn_poweroff.TabIndex = 1;
            this.btn_poweroff.TabStop = false;
            this.btn_poweroff.Click += new System.EventHandler(this.Btn_poweroff_Click);
            // 
            // btn_lock
            // 
            this.btn_lock.Image = global::DERIN.Properties.Resources.padlock;
            this.btn_lock.Location = new System.Drawing.Point(12, 12);
            this.btn_lock.Name = "btn_lock";
            this.btn_lock.Size = new System.Drawing.Size(100, 100);
            this.btn_lock.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.btn_lock.TabIndex = 0;
            this.btn_lock.TabStop = false;
            this.btn_lock.Click += new System.EventHandler(this.Btn_lock_Click);
            // 
            // ekranıGörüntüleToolStripMenuItem
            // 
            this.ekranıGörüntüleToolStripMenuItem.Name = "ekranıGörüntüleToolStripMenuItem";
            this.ekranıGörüntüleToolStripMenuItem.Size = new System.Drawing.Size(160, 22);
            this.ekranıGörüntüleToolStripMenuItem.Text = "DERIN\'i aç";
            this.ekranıGörüntüleToolStripMenuItem.Click += new System.EventHandler(this.EkranıGörüntüleToolStripMenuItem_Click);
            // 
            // tahtayıKilitleToolStripMenuItem
            // 
            this.tahtayıKilitleToolStripMenuItem.Name = "tahtayıKilitleToolStripMenuItem";
            this.tahtayıKilitleToolStripMenuItem.Size = new System.Drawing.Size(160, 22);
            this.tahtayıKilitleToolStripMenuItem.Text = "Tahtayı Kilitle";
            this.tahtayıKilitleToolStripMenuItem.Click += new System.EventHandler(this.TahtayıKilitleToolStripMenuItem_Click);
            // 
            // bilgisayarıKapatToolStripMenuItem
            // 
            this.bilgisayarıKapatToolStripMenuItem.Name = "bilgisayarıKapatToolStripMenuItem";
            this.bilgisayarıKapatToolStripMenuItem.Size = new System.Drawing.Size(160, 22);
            this.bilgisayarıKapatToolStripMenuItem.Text = "Bilgisayarı Kapat";
            this.bilgisayarıKapatToolStripMenuItem.Click += new System.EventHandler(this.BilgisayarıKapatToolStripMenuItem_Click);
            // 
            // yöneticiPaneliToolStripMenuItem
            // 
            this.yöneticiPaneliToolStripMenuItem.Name = "yöneticiPaneliToolStripMenuItem";
            this.yöneticiPaneliToolStripMenuItem.Size = new System.Drawing.Size(160, 22);
            this.yöneticiPaneliToolStripMenuItem.Text = "Yönetici Paneli";
            // 
            // menu
            // 
            this.menu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ekranıGörüntüleToolStripMenuItem,
            this.tahtayıKilitleToolStripMenuItem,
            this.bilgisayarıKapatToolStripMenuItem,
            this.yöneticiPaneliToolStripMenuItem});
            this.menu.Name = "menu";
            this.menu.Size = new System.Drawing.Size(161, 92);
            // 
            // notify
            // 
            this.notify.BalloonTipIcon = System.Windows.Forms.ToolTipIcon.Info;
            this.notify.BalloonTipText = "DERIN";
            this.notify.BalloonTipTitle = "DERIN";
            this.notify.ContextMenuStrip = this.menu;
            this.notify.Icon = ((System.Drawing.Icon)(resources.GetObject("notify.Icon")));
            this.notify.Text = "DERIN";
            this.notify.Visible = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(229, 439);
            this.Controls.Add(this.btn_backspace);
            this.Controls.Add(this.number_0);
            this.Controls.Add(this.btn_clear);
            this.Controls.Add(this.number_9);
            this.Controls.Add(this.number_8);
            this.Controls.Add(this.number_7);
            this.Controls.Add(this.number_6);
            this.Controls.Add(this.number_5);
            this.Controls.Add(this.number_4);
            this.Controls.Add(this.number_3);
            this.Controls.Add(this.number_2);
            this.Controls.Add(this.number_1);
            this.Controls.Add(this.numpad);
            this.Controls.Add(this.btn_poweroff);
            this.Controls.Add(this.btn_lock);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "DERIN";
            this.TopMost = true;
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.btn_backspace)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.number_0)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btn_clear)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.number_9)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.number_8)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.number_7)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.number_6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.number_5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.number_4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.number_3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.number_2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.number_1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btn_poweroff)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btn_lock)).EndInit();
            this.menu.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox btn_lock;
        private System.Windows.Forms.PictureBox btn_poweroff;
        private System.Windows.Forms.TextBox numpad;
        private System.Windows.Forms.PictureBox number_1;
        private System.Windows.Forms.PictureBox number_2;
        private System.Windows.Forms.PictureBox number_3;
        private System.Windows.Forms.PictureBox number_6;
        private System.Windows.Forms.PictureBox number_5;
        private System.Windows.Forms.PictureBox number_4;
        private System.Windows.Forms.PictureBox number_9;
        private System.Windows.Forms.PictureBox number_8;
        private System.Windows.Forms.PictureBox number_7;
        private System.Windows.Forms.PictureBox btn_backspace;
        private System.Windows.Forms.PictureBox number_0;
        private System.Windows.Forms.PictureBox btn_clear;
        private System.Windows.Forms.ToolStripMenuItem ekranıGörüntüleToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem tahtayıKilitleToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem bilgisayarıKapatToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem yöneticiPaneliToolStripMenuItem;
        private System.Windows.Forms.ContextMenuStrip menu;
        private System.Windows.Forms.NotifyIcon notify;
    }
}

