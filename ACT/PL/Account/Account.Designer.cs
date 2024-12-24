namespace ACT.PL.Account
{
    partial class Account
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
            this.pnlAccount = new System.Windows.Forms.Panel();
            this.GBInfo = new System.Windows.Forms.GroupBox();
            this.cBAccType = new System.Windows.Forms.ComboBox();
            this.cBReport = new System.Windows.Forms.ComboBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.txtTag = new System.Windows.Forms.TextBox();
            this.GBButton = new System.Windows.Forms.GroupBox();
            this.btnExit = new System.Windows.Forms.Button();
            this.btnDel = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnNew = new System.Windows.Forms.Button();
            this.GBInput = new System.Windows.Forms.GroupBox();
            this.txtBalance = new System.Windows.Forms.TextBox();
            this.txtCredit = new System.Windows.Forms.TextBox();
            this.txtLevel = new System.Windows.Forms.TextBox();
            this.txtDebit = new System.Windows.Forms.TextBox();
            this.txtName = new System.Windows.Forms.TextBox();
            this.txtParent = new System.Windows.Forms.TextBox();
            this.txtnum = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.GBAccount = new System.Windows.Forms.GroupBox();
            this.btnsearch = new System.Windows.Forms.Button();
            this.txtsearch = new System.Windows.Forms.TextBox();
            this.btnIndex = new System.Windows.Forms.Button();
            this.treeAccount = new System.Windows.Forms.TreeView();
            this.button1 = new System.Windows.Forms.Button();
            this.pnlAccount.SuspendLayout();
            this.GBInfo.SuspendLayout();
            this.GBButton.SuspendLayout();
            this.GBInput.SuspendLayout();
            this.GBAccount.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlAccount
            // 
            this.pnlAccount.Controls.Add(this.GBInfo);
            this.pnlAccount.Controls.Add(this.GBButton);
            this.pnlAccount.Controls.Add(this.GBInput);
            this.pnlAccount.Controls.Add(this.GBAccount);
            this.pnlAccount.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlAccount.Location = new System.Drawing.Point(0, 0);
            this.pnlAccount.Name = "pnlAccount";
            this.pnlAccount.Size = new System.Drawing.Size(1046, 610);
            this.pnlAccount.TabIndex = 0;
            // 
            // GBInfo
            // 
            this.GBInfo.Controls.Add(this.cBAccType);
            this.GBInfo.Controls.Add(this.cBReport);
            this.GBInfo.Controls.Add(this.label9);
            this.GBInfo.Controls.Add(this.label8);
            this.GBInfo.Controls.Add(this.txtTag);
            this.GBInfo.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GBInfo.Location = new System.Drawing.Point(3, 315);
            this.GBInfo.Name = "GBInfo";
            this.GBInfo.Size = new System.Drawing.Size(515, 167);
            this.GBInfo.TabIndex = 0;
            this.GBInfo.TabStop = false;
            // 
            // cBAccType
            // 
            this.cBAccType.FormattingEnabled = true;
            this.cBAccType.Location = new System.Drawing.Point(9, 65);
            this.cBAccType.Name = "cBAccType";
            this.cBAccType.Size = new System.Drawing.Size(357, 27);
            this.cBAccType.TabIndex = 9;
            this.cBAccType.SelectedIndexChanged += new System.EventHandler(this.cBAccType_SelectedIndexChanged);
            // 
            // cBReport
            // 
            this.cBReport.FormattingEnabled = true;
            this.cBReport.Location = new System.Drawing.Point(9, 11);
            this.cBReport.Name = "cBReport";
            this.cBReport.Size = new System.Drawing.Size(357, 27);
            this.cBReport.TabIndex = 8;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(438, 72);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(73, 19);
            this.label9.TabIndex = 1;
            this.label9.Text = "نوع الحساب";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(464, 19);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(44, 19);
            this.label8.TabIndex = 0;
            this.label8.Text = "التقرير";
            // 
            // txtTag
            // 
            this.txtTag.Location = new System.Drawing.Point(401, 25);
            this.txtTag.Name = "txtTag";
            this.txtTag.Size = new System.Drawing.Size(57, 26);
            this.txtTag.TabIndex = 7;
            this.txtTag.Visible = false;
            this.txtTag.TextChanged += new System.EventHandler(this.txtTag_TextChanged);
            // 
            // GBButton
            // 
            this.GBButton.Controls.Add(this.button1);
            this.GBButton.Controls.Add(this.btnExit);
            this.GBButton.Controls.Add(this.btnDel);
            this.GBButton.Controls.Add(this.btnUpdate);
            this.GBButton.Controls.Add(this.btnSave);
            this.GBButton.Controls.Add(this.btnNew);
            this.GBButton.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GBButton.Location = new System.Drawing.Point(3, 488);
            this.GBButton.Name = "GBButton";
            this.GBButton.Size = new System.Drawing.Size(515, 110);
            this.GBButton.TabIndex = 2;
            this.GBButton.TabStop = false;
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(21, 25);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(75, 38);
            this.btnExit.TabIndex = 13;
            this.btnExit.Text = "خروج";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // btnDel
            // 
            this.btnDel.Location = new System.Drawing.Point(186, 25);
            this.btnDel.Name = "btnDel";
            this.btnDel.Size = new System.Drawing.Size(75, 38);
            this.btnDel.TabIndex = 12;
            this.btnDel.Text = "حذف";
            this.btnDel.UseVisualStyleBackColor = true;
            this.btnDel.Click += new System.EventHandler(this.button4_Click);
            // 
            // btnUpdate
            // 
            this.btnUpdate.Location = new System.Drawing.Point(267, 25);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(75, 38);
            this.btnUpdate.TabIndex = 11;
            this.btnUpdate.Text = "تعديل";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // btnSave
            // 
            this.btnSave.Enabled = false;
            this.btnSave.Location = new System.Drawing.Point(348, 25);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(75, 38);
            this.btnSave.TabIndex = 10;
            this.btnSave.Text = "حفظ";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnNew
            // 
            this.btnNew.Location = new System.Drawing.Point(429, 25);
            this.btnNew.Name = "btnNew";
            this.btnNew.Size = new System.Drawing.Size(75, 38);
            this.btnNew.TabIndex = 0;
            this.btnNew.Text = "جديد";
            this.btnNew.UseVisualStyleBackColor = true;
            this.btnNew.Click += new System.EventHandler(this.btnNew_Click);
            // 
            // GBInput
            // 
            this.GBInput.Controls.Add(this.txtBalance);
            this.GBInput.Controls.Add(this.txtCredit);
            this.GBInput.Controls.Add(this.txtLevel);
            this.GBInput.Controls.Add(this.txtDebit);
            this.GBInput.Controls.Add(this.txtName);
            this.GBInput.Controls.Add(this.txtParent);
            this.GBInput.Controls.Add(this.txtnum);
            this.GBInput.Controls.Add(this.label7);
            this.GBInput.Controls.Add(this.label6);
            this.GBInput.Controls.Add(this.label5);
            this.GBInput.Controls.Add(this.label4);
            this.GBInput.Controls.Add(this.label3);
            this.GBInput.Controls.Add(this.label2);
            this.GBInput.Controls.Add(this.label1);
            this.GBInput.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GBInput.Location = new System.Drawing.Point(3, 1);
            this.GBInput.Name = "GBInput";
            this.GBInput.Size = new System.Drawing.Size(515, 294);
            this.GBInput.TabIndex = 1;
            this.GBInput.TabStop = false;
            this.GBInput.Text = "المدخلات";
            // 
            // txtBalance
            // 
            this.txtBalance.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.txtBalance.Location = new System.Drawing.Point(21, 201);
            this.txtBalance.Name = "txtBalance";
            this.txtBalance.Size = new System.Drawing.Size(347, 20);
            this.txtBalance.TabIndex = 7;
            this.txtBalance.Text = "0";
            // 
            // txtCredit
            // 
            this.txtCredit.Location = new System.Drawing.Point(21, 173);
            this.txtCredit.Name = "txtCredit";
            this.txtCredit.Size = new System.Drawing.Size(347, 26);
            this.txtCredit.TabIndex = 6;
            this.txtCredit.Text = "0";
            // 
            // txtLevel
            // 
            this.txtLevel.Location = new System.Drawing.Point(21, 114);
            this.txtLevel.Name = "txtLevel";
            this.txtLevel.Size = new System.Drawing.Size(347, 26);
            this.txtLevel.TabIndex = 4;
            // 
            // txtDebit
            // 
            this.txtDebit.Location = new System.Drawing.Point(21, 143);
            this.txtDebit.Name = "txtDebit";
            this.txtDebit.Size = new System.Drawing.Size(347, 26);
            this.txtDebit.TabIndex = 5;
            this.txtDebit.Text = "0";
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(21, 85);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(347, 26);
            this.txtName.TabIndex = 3;
            // 
            // txtParent
            // 
            this.txtParent.Location = new System.Drawing.Point(21, 56);
            this.txtParent.Name = "txtParent";
            this.txtParent.Size = new System.Drawing.Size(347, 26);
            this.txtParent.TabIndex = 2;
            // 
            // txtnum
            // 
            this.txtnum.Enabled = false;
            this.txtnum.Location = new System.Drawing.Point(161, 26);
            this.txtnum.Name = "txtnum";
            this.txtnum.Size = new System.Drawing.Size(207, 26);
            this.txtnum.TabIndex = 1;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(472, 201);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(37, 19);
            this.label7.TabIndex = 6;
            this.label7.Text = "رصيد";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(478, 173);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(31, 19);
            this.label6.TabIndex = 5;
            this.label6.Text = "دائن";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(475, 143);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(34, 19);
            this.label5.TabIndex = 4;
            this.label5.Text = "مدين";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(418, 114);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(91, 19);
            this.label4.TabIndex = 3;
            this.label4.Text = "مستوى الحساب";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(436, 85);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(73, 19);
            this.label3.TabIndex = 2;
            this.label3.Text = "اسم الحساب";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(434, 55);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(75, 19);
            this.label2.TabIndex = 1;
            this.label2.Text = "الحساب الأب";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(438, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(71, 19);
            this.label1.TabIndex = 0;
            this.label1.Text = "رقم الحساب";
            // 
            // GBAccount
            // 
            this.GBAccount.Controls.Add(this.btnsearch);
            this.GBAccount.Controls.Add(this.txtsearch);
            this.GBAccount.Controls.Add(this.btnIndex);
            this.GBAccount.Controls.Add(this.treeAccount);
            this.GBAccount.Location = new System.Drawing.Point(524, 3);
            this.GBAccount.Name = "GBAccount";
            this.GBAccount.Size = new System.Drawing.Size(522, 604);
            this.GBAccount.TabIndex = 0;
            this.GBAccount.TabStop = false;
            this.GBAccount.Text = "الدليل المحاسبي";
            // 
            // btnsearch
            // 
            this.btnsearch.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnsearch.Location = new System.Drawing.Point(3, 26);
            this.btnsearch.Name = "btnsearch";
            this.btnsearch.Size = new System.Drawing.Size(179, 23);
            this.btnsearch.TabIndex = 3;
            this.btnsearch.Text = "بحث";
            this.btnsearch.UseVisualStyleBackColor = true;
            this.btnsearch.Click += new System.EventHandler(this.btnsearch_Click);
            // 
            // txtsearch
            // 
            this.txtsearch.Location = new System.Drawing.Point(187, 26);
            this.txtsearch.Name = "txtsearch";
            this.txtsearch.Size = new System.Drawing.Size(323, 20);
            this.txtsearch.TabIndex = 2;
            // 
            // btnIndex
            // 
            this.btnIndex.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnIndex.Location = new System.Drawing.Point(7, 499);
            this.btnIndex.Name = "btnIndex";
            this.btnIndex.Size = new System.Drawing.Size(512, 63);
            this.btnIndex.TabIndex = 1;
            this.btnIndex.Text = "الدليل المحاسبي";
            this.btnIndex.UseVisualStyleBackColor = true;
            // 
            // treeAccount
            // 
            this.treeAccount.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.treeAccount.Location = new System.Drawing.Point(3, 53);
            this.treeAccount.Name = "treeAccount";
            this.treeAccount.RightToLeftLayout = true;
            this.treeAccount.Size = new System.Drawing.Size(516, 426);
            this.treeAccount.TabIndex = 0;
            this.treeAccount.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(this.treeAccount_AfterSelect);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(105, 34);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 14;
            this.button1.Text = "طباعة";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Account
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1046, 610);
            this.Controls.Add(this.pnlAccount);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Account";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.RightToLeftLayout = true;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "الحسابات";
            this.pnlAccount.ResumeLayout(false);
            this.GBInfo.ResumeLayout(false);
            this.GBInfo.PerformLayout();
            this.GBButton.ResumeLayout(false);
            this.GBInput.ResumeLayout(false);
            this.GBInput.PerformLayout();
            this.GBAccount.ResumeLayout(false);
            this.GBAccount.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.GroupBox GBInfo;
        private System.Windows.Forms.GroupBox GBButton;
        private System.Windows.Forms.GroupBox GBInput;
        private System.Windows.Forms.GroupBox GBAccount;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TreeView treeAccount;
        private System.Windows.Forms.ComboBox cBAccType;
        private System.Windows.Forms.ComboBox cBReport;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Button btnDel;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnNew;
        private System.Windows.Forms.TextBox txtBalance;
        private System.Windows.Forms.TextBox txtCredit;
        private System.Windows.Forms.TextBox txtLevel;
        private System.Windows.Forms.TextBox txtDebit;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.TextBox txtParent;
        private System.Windows.Forms.TextBox txtnum;
        private System.Windows.Forms.TextBox txtTag;
        private System.Windows.Forms.Panel pnlAccount;
        private System.Windows.Forms.Button btnIndex;
        private System.Windows.Forms.Button btnsearch;
        private System.Windows.Forms.TextBox txtsearch;
        private System.Windows.Forms.Button button1;
    }
}