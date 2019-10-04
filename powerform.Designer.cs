namespace DERIN
{
    partial class powerform
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
            this.powertimer = new System.Windows.Forms.Timer(this.components);
            this.nyX_Theme1 = new CS_ClassLibraryTester.NYX_Theme();
            this.label1 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.sure = new System.Windows.Forms.Label();
            this.nyX_Theme1.SuspendLayout();
            this.SuspendLayout();
            // 
            // powertimer
            // 
            this.powertimer.Enabled = true;
            this.powertimer.Interval = 1000;
            this.powertimer.Tick += new System.EventHandler(this.Powertimer_Tick);
            // 
            // nyX_Theme1
            // 
            this.nyX_Theme1.Animated = true;
            this.nyX_Theme1.BorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.nyX_Theme1.Colors = new CS_ClassLibraryTester.Bloom[0];
            this.nyX_Theme1.Controls.Add(this.label1);
            this.nyX_Theme1.Controls.Add(this.button2);
            this.nyX_Theme1.Controls.Add(this.button1);
            this.nyX_Theme1.Controls.Add(this.sure);
            this.nyX_Theme1.Customization = "";
            this.nyX_Theme1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.nyX_Theme1.Font = new System.Drawing.Font("Verdana", 8F);
            this.nyX_Theme1.Image = null;
            this.nyX_Theme1.Location = new System.Drawing.Point(0, 0);
            this.nyX_Theme1.Movable = true;
            this.nyX_Theme1.Name = "nyX_Theme1";
            this.nyX_Theme1.NoRounding = false;
            this.nyX_Theme1.Sizable = true;
            this.nyX_Theme1.Size = new System.Drawing.Size(288, 100);
            this.nyX_Theme1.SmartBounds = true;
            this.nyX_Theme1.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.nyX_Theme1.TabIndex = 0;
            this.nyX_Theme1.Text = "Akıllı Tahta Kapanıyor ";
            this.nyX_Theme1.TransparencyKey = System.Drawing.Color.Fuchsia;
            this.nyX_Theme1.Transparent = false;
            this.nyX_Theme1.Click += new System.EventHandler(this.Powerform_Load);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(22)))), ((int)(((byte)(22)))));
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(27, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(194, 20);
            this.label1.TabIndex = 11;
            this.label1.Text = "Saniye içinde kapatılacak :\r\n";
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.SeaGreen;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button2.ForeColor = System.Drawing.Color.White;
            this.button2.Location = new System.Drawing.Point(148, 51);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(118, 37);
            this.button2.TabIndex = 9;
            this.button2.Text = "KAPATMA";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.Button2_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.DarkRed;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Location = new System.Drawing.Point(28, 51);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(118, 38);
            this.button1.TabIndex = 8;
            this.button1.Text = "KAPAT";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.Button1_Click);
            // 
            // sure
            // 
            this.sure.AutoSize = true;
            this.sure.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(22)))), ((int)(((byte)(22)))));
            this.sure.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.sure.ForeColor = System.Drawing.Color.White;
            this.sure.Location = new System.Drawing.Point(227, 28);
            this.sure.Name = "sure";
            this.sure.Size = new System.Drawing.Size(27, 20);
            this.sure.TabIndex = 10;
            this.sure.Text = "15";
            // 
            // powerform
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(288, 100);
            this.Controls.Add(this.nyX_Theme1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "powerform";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.TransparencyKey = System.Drawing.Color.Fuchsia;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.powerform_FormClosing);
            this.Load += new System.EventHandler(this.Powerform_Load);
            this.nyX_Theme1.ResumeLayout(false);
            this.nyX_Theme1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Timer powertimer;
        private CS_ClassLibraryTester.NYX_Theme nyX_Theme1;
        private System.Windows.Forms.Label sure;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label1;
    }
}