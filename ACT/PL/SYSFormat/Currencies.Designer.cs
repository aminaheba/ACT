namespace ACT.PL.SYSFormat
{
    partial class Currencies
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
            this.gridCurr = new System.Windows.Forms.DataGridView();
            this.gbCurr = new System.Windows.Forms.GroupBox();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnNew = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.btnDel = new System.Windows.Forms.Button();
            this.gbControl = new System.Windows.Forms.GroupBox();
            this.btnEdit = new System.Windows.Forms.Button();
            this.txtFname = new System.Windows.Forms.TextBox();
            this.txtName = new System.Windows.Forms.TextBox();
            this.txtSym = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.gbInput = new System.Windows.Forms.GroupBox();
            this.rbf = new System.Windows.Forms.RadioButton();
            this.rblocal = new System.Windows.Forms.RadioButton();
            this.txtDec = new System.Windows.Forms.TextBox();
            this.txtexch = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.gridCurr)).BeginInit();
            this.gbCurr.SuspendLayout();
            this.gbControl.SuspendLayout();
            this.panel1.SuspendLayout();
            this.gbInput.SuspendLayout();
            this.SuspendLayout();
            // 
            // gridCurr
            // 
            this.gridCurr.AllowUserToAddRows = false;
            this.gridCurr.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.gridCurr.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridCurr.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridCurr.Location = new System.Drawing.Point(3, 16);
            this.gridCurr.Name = "gridCurr";
            this.gridCurr.Size = new System.Drawing.Size(402, 133);
            this.gridCurr.TabIndex = 0;
            this.gridCurr.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.gridCurr_CellClick);
            // 
            // gbCurr
            // 
            this.gbCurr.Controls.Add(this.gridCurr);
            this.gbCurr.Location = new System.Drawing.Point(3, 3);
            this.gbCurr.Name = "gbCurr";
            this.gbCurr.Size = new System.Drawing.Size(408, 152);
            this.gbCurr.TabIndex = 0;
            this.gbCurr.TabStop = false;
            this.gbCurr.Text = "العملات";
            // 
            // btnSave
            // 
            this.btnSave.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSave.Location = new System.Drawing.Point(253, 18);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(75, 23);
            this.btnSave.TabIndex = 8;
            this.btnSave.Text = "حفظ";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnNew
            // 
            this.btnNew.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNew.Location = new System.Drawing.Point(333, 18);
            this.btnNew.Name = "btnNew";
            this.btnNew.Size = new System.Drawing.Size(75, 23);
            this.btnNew.TabIndex = 0;
            this.btnNew.Text = "جديد";
            this.btnNew.UseVisualStyleBackColor = true;
            this.btnNew.Click += new System.EventHandler(this.btnNew_Click);
            // 
            // btnExit
            // 
            this.btnExit.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExit.Location = new System.Drawing.Point(14, 18);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(75, 23);
            this.btnExit.TabIndex = 11;
            this.btnExit.Text = "الغاء";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // btnDel
            // 
            this.btnDel.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDel.Location = new System.Drawing.Point(94, 18);
            this.btnDel.Name = "btnDel";
            this.btnDel.Size = new System.Drawing.Size(75, 23);
            this.btnDel.TabIndex = 10;
            this.btnDel.Text = "حذف";
            this.btnDel.UseVisualStyleBackColor = true;
            this.btnDel.Click += new System.EventHandler(this.btnDel_Click);
            // 
            // gbControl
            // 
            this.gbControl.Controls.Add(this.btnExit);
            this.gbControl.Controls.Add(this.btnDel);
            this.gbControl.Controls.Add(this.btnEdit);
            this.gbControl.Controls.Add(this.btnSave);
            this.gbControl.Controls.Add(this.btnNew);
            this.gbControl.Location = new System.Drawing.Point(3, 328);
            this.gbControl.Name = "gbControl";
            this.gbControl.Size = new System.Drawing.Size(408, 53);
            this.gbControl.TabIndex = 2;
            this.gbControl.TabStop = false;
            // 
            // btnEdit
            // 
            this.btnEdit.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEdit.Location = new System.Drawing.Point(174, 18);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(75, 23);
            this.btnEdit.TabIndex = 9;
            this.btnEdit.Text = "تعديل";
            this.btnEdit.UseVisualStyleBackColor = true;
            this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
            // 
            // txtFname
            // 
            this.txtFname.Enabled = false;
            this.txtFname.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtFname.Location = new System.Drawing.Point(87, 43);
            this.txtFname.Name = "txtFname";
            this.txtFname.Size = new System.Drawing.Size(190, 21);
            this.txtFname.TabIndex = 2;
            // 
            // txtName
            // 
            this.txtName.Enabled = false;
            this.txtName.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtName.Location = new System.Drawing.Point(87, 19);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(190, 21);
            this.txtName.TabIndex = 1;
            this.txtName.TextChanged += new System.EventHandler(this.txtName_TextChanged);
            // 
            // txtSym
            // 
            this.txtSym.Enabled = false;
            this.txtSym.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSym.Location = new System.Drawing.Point(87, 68);
            this.txtSym.Name = "txtSym";
            this.txtSym.Size = new System.Drawing.Size(190, 21);
            this.txtSym.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(330, 49);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(58, 15);
            this.label3.TabIndex = 2;
            this.label3.Text = "الاسم الاجنبي";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(361, 25);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(27, 15);
            this.label2.TabIndex = 1;
            this.label2.Text = "الاسم";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(340, 71);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(48, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "رمز العملة";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.gbControl);
            this.panel1.Controls.Add(this.gbInput);
            this.panel1.Controls.Add(this.gbCurr);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(421, 382);
            this.panel1.TabIndex = 1;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // gbInput
            // 
            this.gbInput.Controls.Add(this.rbf);
            this.gbInput.Controls.Add(this.rblocal);
            this.gbInput.Controls.Add(this.txtSym);
            this.gbInput.Controls.Add(this.txtDec);
            this.gbInput.Controls.Add(this.txtexch);
            this.gbInput.Controls.Add(this.label6);
            this.gbInput.Controls.Add(this.label5);
            this.gbInput.Controls.Add(this.label1);
            this.gbInput.Controls.Add(this.label4);
            this.gbInput.Controls.Add(this.txtFname);
            this.gbInput.Controls.Add(this.txtName);
            this.gbInput.Controls.Add(this.label3);
            this.gbInput.Controls.Add(this.label2);
            this.gbInput.Location = new System.Drawing.Point(3, 158);
            this.gbInput.Name = "gbInput";
            this.gbInput.Size = new System.Drawing.Size(408, 164);
            this.gbInput.TabIndex = 1;
            this.gbInput.TabStop = false;
            this.gbInput.Text = "المدخلات";
            this.gbInput.Enter += new System.EventHandler(this.gbInput_Enter);
            // 
            // rbf
            // 
            this.rbf.AutoSize = true;
            this.rbf.Enabled = false;
            this.rbf.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbf.Location = new System.Drawing.Point(127, 142);
            this.rbf.Name = "rbf";
            this.rbf.Size = new System.Drawing.Size(48, 19);
            this.rbf.TabIndex = 7;
            this.rbf.TabStop = true;
            this.rbf.Text = "أجنبية";
            this.rbf.UseVisualStyleBackColor = true;
            // 
            // rblocal
            // 
            this.rblocal.AutoSize = true;
            this.rblocal.Enabled = false;
            this.rblocal.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rblocal.Location = new System.Drawing.Point(230, 142);
            this.rblocal.Name = "rblocal";
            this.rblocal.Size = new System.Drawing.Size(47, 19);
            this.rblocal.TabIndex = 6;
            this.rblocal.TabStop = true;
            this.rblocal.Text = "محلية";
            this.rblocal.UseVisualStyleBackColor = true;
            // 
            // txtDec
            // 
            this.txtDec.Enabled = false;
            this.txtDec.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDec.Location = new System.Drawing.Point(87, 115);
            this.txtDec.Name = "txtDec";
            this.txtDec.Size = new System.Drawing.Size(190, 21);
            this.txtDec.TabIndex = 5;
            // 
            // txtexch
            // 
            this.txtexch.Enabled = false;
            this.txtexch.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtexch.Location = new System.Drawing.Point(87, 92);
            this.txtexch.Name = "txtexch";
            this.txtexch.Size = new System.Drawing.Size(190, 21);
            this.txtexch.TabIndex = 4;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(340, 144);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(48, 15);
            this.label6.TabIndex = 6;
            this.label6.Text = "نوع العملة";
            this.label6.Click += new System.EventHandler(this.label6_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(362, 119);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(26, 15);
            this.label5.TabIndex = 5;
            this.label5.Text = "الفكة";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(333, 92);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(55, 15);
            this.label4.TabIndex = 4;
            this.label4.Text = "سعر الصرف";
            // 
            // Currencies
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(421, 382);
            this.Controls.Add(this.panel1);
            this.MaximizeBox = false;
            this.Name = "Currencies";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.RightToLeftLayout = true;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "العملات";
            ((System.ComponentModel.ISupportInitialize)(this.gridCurr)).EndInit();
            this.gbCurr.ResumeLayout(false);
            this.gbControl.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.gbInput.ResumeLayout(false);
            this.gbInput.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView gridCurr;
        public System.Windows.Forms.GroupBox gbCurr;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnNew;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Button btnDel;
        private System.Windows.Forms.GroupBox gbControl;
        private System.Windows.Forms.Button btnEdit;
        private System.Windows.Forms.TextBox txtFname;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.TextBox txtSym;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        public System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.GroupBox gbInput;
        private System.Windows.Forms.TextBox txtDec;
        private System.Windows.Forms.TextBox txtexch;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.RadioButton rbf;
        private System.Windows.Forms.RadioButton rblocal;
    }
}