namespace ACT.tool
{
    partial class Tost
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
            this.pic_toest = new System.Windows.Forms.PictureBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.Caption = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.pic_toest)).BeginInit();
            this.SuspendLayout();
            // 
            // pic_toest
            // 
            this.pic_toest.Dock = System.Windows.Forms.DockStyle.Left;
            this.pic_toest.Image = global::ACT.Properties.Resources.Tost;
            this.pic_toest.Location = new System.Drawing.Point(0, 0);
            this.pic_toest.Name = "pic_toest";
            this.pic_toest.Size = new System.Drawing.Size(100, 100);
            this.pic_toest.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pic_toest.TabIndex = 0;
            this.pic_toest.TabStop = false;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.panel1.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel1.Location = new System.Drawing.Point(477, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(23, 100);
            this.panel1.TabIndex = 1;
            // 
            // Caption
            // 
            this.Caption.Font = new System.Drawing.Font("Tahoma", 14F, System.Drawing.FontStyle.Bold);
            this.Caption.ForeColor = System.Drawing.SystemColors.ButtonShadow;
            this.Caption.Location = new System.Drawing.Point(106, 9);
            this.Caption.Name = "Caption";
            this.Caption.Size = new System.Drawing.Size(365, 82);
            this.Caption.TabIndex = 3;
            this.Caption.Text = "الرسالة";
            this.Caption.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.Caption.Click += new System.EventHandler(this.Caption_Click);
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 4000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick_1);
            // 
            // Tost
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(500, 100);
            this.Controls.Add(this.Caption);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.pic_toest);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Tost";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "Tost";
            this.TopMost = true;
            ((System.ComponentModel.ISupportInitialize)(this.pic_toest)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Timer timer1;
        public System.Windows.Forms.PictureBox pic_toest;
        public System.Windows.Forms.Label Caption;
    }
}