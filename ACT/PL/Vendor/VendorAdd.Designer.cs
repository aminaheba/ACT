namespace ACT.PL
{
    partial class VendorAdd
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
            this.title = new System.Windows.Forms.Label();
            this.edit_name = new System.Windows.Forms.TextBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.button1 = new System.Windows.Forms.Button();
            this.btnclose = new System.Windows.Forms.Button();
            this.edit_email = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.edit_phone = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // title
            // 
            this.title.AutoSize = true;
            this.title.Font = new System.Drawing.Font("Tahoma", 14F, System.Drawing.FontStyle.Bold);
            this.title.ForeColor = System.Drawing.SystemColors.ButtonShadow;
            this.title.Location = new System.Drawing.Point(283, 47);
            this.title.Name = "title";
            this.title.Size = new System.Drawing.Size(118, 23);
            this.title.TabIndex = 2;
            this.title.Text = "اسم المورد ";
            this.title.Click += new System.EventHandler(this.title_Click);
            // 
            // edit_name
            // 
            this.edit_name.Location = new System.Drawing.Point(85, 47);
            this.edit_name.Name = "edit_name";
            this.edit_name.Size = new System.Drawing.Size(192, 20);
            this.edit_name.TabIndex = 6;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::ACT.Properties.Resources.user;
            this.pictureBox2.Location = new System.Drawing.Point(12, 202);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(192, 122);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 7;
            this.pictureBox2.TabStop = false;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(347, 301);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(89, 23);
            this.button1.TabIndex = 8;
            this.button1.Text = "اضافة";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // btnclose
            // 
            this.btnclose.BackColor = System.Drawing.Color.Transparent;
            this.btnclose.FlatAppearance.BorderSize = 0;
            this.btnclose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnclose.Image = global::ACT.Properties.Resources.Close;
            this.btnclose.Location = new System.Drawing.Point(12, 12);
            this.btnclose.Name = "btnclose";
            this.btnclose.Size = new System.Drawing.Size(53, 33);
            this.btnclose.TabIndex = 9;
            this.btnclose.UseVisualStyleBackColor = false;
            // 
            // edit_email
            // 
            this.edit_email.Location = new System.Drawing.Point(85, 122);
            this.edit_email.Name = "edit_email";
            this.edit_email.Size = new System.Drawing.Size(192, 20);
            this.edit_email.TabIndex = 11;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 14F, System.Drawing.FontStyle.Bold);
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonShadow;
            this.label1.Location = new System.Drawing.Point(324, 122);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(77, 23);
            this.label1.TabIndex = 10;
            this.label1.Text = "الايميل ";
            // 
            // edit_phone
            // 
            this.edit_phone.Location = new System.Drawing.Point(85, 84);
            this.edit_phone.Name = "edit_phone";
            this.edit_phone.Size = new System.Drawing.Size(192, 20);
            this.edit_phone.TabIndex = 13;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Tahoma", 14F, System.Drawing.FontStyle.Bold);
            this.label2.ForeColor = System.Drawing.SystemColors.ButtonShadow;
            this.label2.Location = new System.Drawing.Point(330, 84);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(71, 23);
            this.label2.TabIndex = 12;
            this.label2.Text = "الهاتف ";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // VendorAdd
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(448, 380);
            this.Controls.Add(this.edit_phone);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.edit_email);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnclose);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.edit_name);
            this.Controls.Add(this.title);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "VendorAdd";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.ShowInTaskbar = false;
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label title;
        private System.Windows.Forms.TextBox edit_name;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btnclose;
        private System.Windows.Forms.TextBox edit_email;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox edit_phone;
        private System.Windows.Forms.Label label2;
    }
}