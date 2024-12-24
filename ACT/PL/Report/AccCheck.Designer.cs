namespace ACT.PL.Report
{
    partial class AccCheck
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtAccName = new System.Windows.Forms.TextBox();
            this.txtAccNum = new System.Windows.Forms.TextBox();
            this.txtExchange = new System.Windows.Forms.TextBox();
            this.cmbCurr = new System.Windows.Forms.ComboBox();
            this.dtpTo = new System.Windows.Forms.DateTimePicker();
            this.dtpFrom = new System.Windows.Forms.DateTimePicker();
            this.label6 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.gridAccCheck = new System.Windows.Forms.DataGridView();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.btnShow = new System.Windows.Forms.Button();
            this.txtBalance = new System.Windows.Forms.TextBox();
            this.txtTotalDeb = new System.Windows.Forms.TextBox();
            this.txtTotalCred = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridAccCheck)).BeginInit();
            this.groupBox4.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtAccName);
            this.groupBox1.Controls.Add(this.txtAccNum);
            this.groupBox1.Controls.Add(this.txtExchange);
            this.groupBox1.Controls.Add(this.cmbCurr);
            this.groupBox1.Controls.Add(this.dtpTo);
            this.groupBox1.Controls.Add(this.dtpFrom);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(776, 100);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // txtAccName
            // 
            this.txtAccName.Location = new System.Drawing.Point(19, 61);
            this.txtAccName.Name = "txtAccName";
            this.txtAccName.ReadOnly = true;
            this.txtAccName.Size = new System.Drawing.Size(142, 26);
            this.txtAccName.TabIndex = 3;
            this.txtAccName.TextChanged += new System.EventHandler(this.textBox3_TextChanged);
            // 
            // txtAccNum
            // 
            this.txtAccNum.Location = new System.Drawing.Point(19, 15);
            this.txtAccNum.Name = "txtAccNum";
            this.txtAccNum.ReadOnly = true;
            this.txtAccNum.Size = new System.Drawing.Size(142, 26);
            this.txtAccNum.TabIndex = 3;
            this.txtAccNum.TextChanged += new System.EventHandler(this.txtAccNum_TextChanged);
            // 
            // txtExchange
            // 
            this.txtExchange.Location = new System.Drawing.Point(286, 61);
            this.txtExchange.Name = "txtExchange";
            this.txtExchange.ReadOnly = true;
            this.txtExchange.Size = new System.Drawing.Size(142, 26);
            this.txtExchange.TabIndex = 3;
            this.txtExchange.TextChanged += new System.EventHandler(this.txtExchange_TextChanged);
            // 
            // cmbCurr
            // 
            this.cmbCurr.FormattingEnabled = true;
            this.cmbCurr.Location = new System.Drawing.Point(286, 14);
            this.cmbCurr.Name = "cmbCurr";
            this.cmbCurr.Size = new System.Drawing.Size(142, 27);
            this.cmbCurr.TabIndex = 2;
            this.cmbCurr.SelectedIndexChanged += new System.EventHandler(this.cmbCurr_SelectedIndexChanged);
            // 
            // dtpTo
            // 
            this.dtpTo.Location = new System.Drawing.Point(515, 61);
            this.dtpTo.Name = "dtpTo";
            this.dtpTo.Size = new System.Drawing.Size(200, 26);
            this.dtpTo.TabIndex = 1;
            this.dtpTo.ValueChanged += new System.EventHandler(this.dtpTo_ValueChanged);
            // 
            // dtpFrom
            // 
            this.dtpFrom.Location = new System.Drawing.Point(515, 15);
            this.dtpFrom.Name = "dtpFrom";
            this.dtpFrom.Size = new System.Drawing.Size(200, 26);
            this.dtpFrom.TabIndex = 1;
            this.dtpFrom.ValueChanged += new System.EventHandler(this.dtpFrom_ValueChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(181, 68);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(73, 19);
            this.label6.TabIndex = 0;
            this.label6.Text = "اسم الحساب";
            this.label6.Click += new System.EventHandler(this.label6_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(451, 68);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(48, 19);
            this.label4.TabIndex = 0;
            this.label4.Text = "الصرف";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(721, 68);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(26, 19);
            this.label2.TabIndex = 0;
            this.label2.Text = "إلى";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(181, 22);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(71, 19);
            this.label5.TabIndex = 0;
            this.label5.Text = "رقم الحساب";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(451, 22);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(41, 19);
            this.label3.TabIndex = 0;
            this.label3.Text = "العملة";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(721, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(25, 19);
            this.label1.TabIndex = 0;
            this.label1.Text = "من";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.gridAccCheck);
            this.groupBox2.Controls.Add(this.groupBox3);
            this.groupBox2.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(12, 127);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(776, 249);
            this.groupBox2.TabIndex = 0;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "كشف حساب";
            this.groupBox2.Enter += new System.EventHandler(this.groupBox2_Enter);
            // 
            // gridAccCheck
            // 
            this.gridAccCheck.AllowUserToAddRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.gridAccCheck.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.gridAccCheck.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.gridAccCheck.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridAccCheck.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridAccCheck.Location = new System.Drawing.Point(3, 22);
            this.gridAccCheck.Name = "gridAccCheck";
            this.gridAccCheck.RowHeadersVisible = false;
            this.gridAccCheck.Size = new System.Drawing.Size(770, 224);
            this.gridAccCheck.TabIndex = 1;
            this.gridAccCheck.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.gridAccCheck_CellContentClick);
            // 
            // groupBox3
            // 
            this.groupBox3.Location = new System.Drawing.Point(6, 255);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(776, 100);
            this.groupBox3.TabIndex = 0;
            this.groupBox3.TabStop = false;
            this.groupBox3.Enter += new System.EventHandler(this.groupBox3_Enter);
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.btnShow);
            this.groupBox4.Controls.Add(this.txtBalance);
            this.groupBox4.Controls.Add(this.txtTotalDeb);
            this.groupBox4.Controls.Add(this.txtTotalCred);
            this.groupBox4.Controls.Add(this.label9);
            this.groupBox4.Controls.Add(this.label8);
            this.groupBox4.Controls.Add(this.label7);
            this.groupBox4.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox4.Location = new System.Drawing.Point(12, 383);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(776, 100);
            this.groupBox4.TabIndex = 0;
            this.groupBox4.TabStop = false;
            this.groupBox4.Enter += new System.EventHandler(this.groupBox4_Enter);
            // 
            // btnShow
            // 
            this.btnShow.Location = new System.Drawing.Point(54, 65);
            this.btnShow.Name = "btnShow";
            this.btnShow.Size = new System.Drawing.Size(75, 28);
            this.btnShow.TabIndex = 4;
            this.btnShow.Text = "عرض";
            this.btnShow.UseVisualStyleBackColor = true;
            this.btnShow.Click += new System.EventHandler(this.btnShow_Click);
            // 
            // txtBalance
            // 
            this.txtBalance.Location = new System.Drawing.Point(19, 33);
            this.txtBalance.Name = "txtBalance";
            this.txtBalance.Size = new System.Drawing.Size(142, 26);
            this.txtBalance.TabIndex = 3;
            this.txtBalance.TextChanged += new System.EventHandler(this.textBox3_TextChanged);
            // 
            // txtTotalDeb
            // 
            this.txtTotalDeb.Location = new System.Drawing.Point(545, 33);
            this.txtTotalDeb.Name = "txtTotalDeb";
            this.txtTotalDeb.Size = new System.Drawing.Size(142, 26);
            this.txtTotalDeb.TabIndex = 3;
            this.txtTotalDeb.TextChanged += new System.EventHandler(this.textBox3_TextChanged);
            // 
            // txtTotalCred
            // 
            this.txtTotalCred.Location = new System.Drawing.Point(286, 33);
            this.txtTotalCred.Name = "txtTotalCred";
            this.txtTotalCred.Size = new System.Drawing.Size(142, 26);
            this.txtTotalCred.TabIndex = 3;
            this.txtTotalCred.TextChanged += new System.EventHandler(this.textBox3_TextChanged);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(181, 40);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(45, 19);
            this.label9.TabIndex = 0;
            this.label9.Text = "الرصيد";
            this.label9.Click += new System.EventHandler(this.label9_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(451, 40);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(63, 19);
            this.label8.TabIndex = 0;
            this.label8.Text = "رصيد دائن";
            this.label8.Click += new System.EventHandler(this.label8_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(706, 40);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(66, 19);
            this.label7.TabIndex = 0;
            this.label7.Text = "رصيد مدين";
            this.label7.Click += new System.EventHandler(this.label7_Click);
            // 
            // AccCheck
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 495);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "AccCheck";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.RightToLeftLayout = true;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "كشف حساب";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridAccCheck)).EndInit();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        public System.Windows.Forms.GroupBox groupBox1;
        public System.Windows.Forms.Label label6;
        public System.Windows.Forms.Label label4;
        public System.Windows.Forms.Label label2;
        public System.Windows.Forms.Label label5;
        public System.Windows.Forms.Label label3;
        public System.Windows.Forms.Label label1;
        public System.Windows.Forms.GroupBox groupBox2;
        public System.Windows.Forms.GroupBox groupBox3;
        public System.Windows.Forms.GroupBox groupBox4;
        public System.Windows.Forms.Label label9;
        public System.Windows.Forms.Label label8;
        public System.Windows.Forms.Label label7;
        public System.Windows.Forms.TextBox txtAccName;
        public System.Windows.Forms.TextBox txtAccNum;
        public System.Windows.Forms.TextBox txtExchange;
        public System.Windows.Forms.ComboBox cmbCurr;
        public System.Windows.Forms.DateTimePicker dtpTo;
        public System.Windows.Forms.DateTimePicker dtpFrom;
        public System.Windows.Forms.TextBox txtBalance;
        public System.Windows.Forms.TextBox txtTotalDeb;
        public System.Windows.Forms.TextBox txtTotalCred;
        public System.Windows.Forms.DataGridView gridAccCheck;
        public System.Windows.Forms.Button btnShow;
    }
}