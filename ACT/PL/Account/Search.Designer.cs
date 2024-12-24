namespace ACT.PL.Account
{
    partial class Search
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
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.gbSearch = new System.Windows.Forms.GroupBox();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.gbResult = new System.Windows.Forms.GroupBox();
            this.gridSearchResult = new System.Windows.Forms.DataGridView();
            this.gbSearch.SuspendLayout();
            this.gbResult.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridSearchResult)).BeginInit();
            this.SuspendLayout();
            // 
            // gbSearch
            // 
            this.gbSearch.Controls.Add(this.txtSearch);
            this.gbSearch.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbSearch.Location = new System.Drawing.Point(3, 2);
            this.gbSearch.Name = "gbSearch";
            this.gbSearch.Size = new System.Drawing.Size(374, 71);
            this.gbSearch.TabIndex = 0;
            this.gbSearch.TabStop = false;
            this.gbSearch.Text = "البحث";
            // 
            // txtSearch
            // 
            this.txtSearch.Location = new System.Drawing.Point(30, 20);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(317, 22);
            this.txtSearch.TabIndex = 0;
            this.txtSearch.TextChanged += new System.EventHandler(this.txtSearch_TextChanged);
            // 
            // gbResult
            // 
            this.gbResult.Controls.Add(this.gridSearchResult);
            this.gbResult.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbResult.Location = new System.Drawing.Point(3, 91);
            this.gbResult.Name = "gbResult";
            this.gbResult.Size = new System.Drawing.Size(367, 203);
            this.gbResult.TabIndex = 1;
            this.gbResult.TabStop = false;
            this.gbResult.Text = "نتائج البحث";
            // 
            // gridSearchResult
            // 
            this.gridSearchResult.AllowUserToAddRows = false;
            this.gridSearchResult.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.gridSearchResult.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridSearchResult.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridSearchResult.Location = new System.Drawing.Point(3, 18);
            this.gridSearchResult.Name = "gridSearchResult";
            this.gridSearchResult.Size = new System.Drawing.Size(361, 182);
            this.gridSearchResult.TabIndex = 0;
            this.gridSearchResult.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.gridSearchResult_CellClick);
            this.gridSearchResult.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.gridSearchResult_CellContentClick);
            this.gridSearchResult.DoubleClick += new System.EventHandler(this.gridSearchResult_DoubleClick);
            // 
            // Search
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(382, 317);
            this.Controls.Add(this.gbResult);
            this.Controls.Add(this.gbSearch);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Search";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.RightToLeftLayout = true;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "البحث عن حساب";
            this.gbSearch.ResumeLayout(false);
            this.gbSearch.PerformLayout();
            this.gbResult.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridSearchResult)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        public System.Windows.Forms.GroupBox gbSearch;
        public System.Windows.Forms.TextBox txtSearch;
        public System.Windows.Forms.GroupBox gbResult;
        public System.Windows.Forms.DataGridView gridSearchResult;
    }
}