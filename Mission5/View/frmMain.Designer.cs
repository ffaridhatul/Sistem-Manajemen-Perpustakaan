namespace Mission5
{
    partial class frmMain
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMain));
            this.grpMemberInfo = new System.Windows.Forms.GroupBox();
            this.btnCari = new System.Windows.Forms.Button();
            this.lblOverdueFee = new System.Windows.Forms.TextBox();
            this.lblDaysOfOverdue = new System.Windows.Forms.TextBox();
            this.lblNumOfOverdue = new System.Windows.Forms.TextBox();
            this.lblNumOfAvailable = new System.Windows.Forms.TextBox();
            this.lblNumOfCheckOut = new System.Windows.Forms.TextBox();
            this.lblPhoneNo = new System.Windows.Forms.TextBox();
            this.lblMemberName = new System.Windows.Forms.TextBox();
            this.txtMemberId = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            this.grpBookInfo = new System.Windows.Forms.GroupBox();
            this.lblPublisher = new System.Windows.Forms.TextBox();
            this.lblTitle = new System.Windows.Forms.TextBox();
            this.txtBookCopyCode = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.dgvBookList = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnCheckOut = new System.Windows.Forms.Button();
            this.btnReturn = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
            this.btnSearchBook = new System.Windows.Forms.Button();
            this.grpMemberInfo.SuspendLayout();
            this.grpBookInfo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvBookList)).BeginInit();
            this.SuspendLayout();
            // 
            // grpMemberInfo
            // 
            this.grpMemberInfo.Controls.Add(this.btnCari);
            this.grpMemberInfo.Controls.Add(this.lblOverdueFee);
            this.grpMemberInfo.Controls.Add(this.lblDaysOfOverdue);
            this.grpMemberInfo.Controls.Add(this.lblNumOfOverdue);
            this.grpMemberInfo.Controls.Add(this.lblNumOfAvailable);
            this.grpMemberInfo.Controls.Add(this.lblNumOfCheckOut);
            this.grpMemberInfo.Controls.Add(this.lblPhoneNo);
            this.grpMemberInfo.Controls.Add(this.lblMemberName);
            this.grpMemberInfo.Controls.Add(this.txtMemberId);
            this.grpMemberInfo.Controls.Add(this.label8);
            this.grpMemberInfo.Controls.Add(this.label7);
            this.grpMemberInfo.Controls.Add(this.label6);
            this.grpMemberInfo.Controls.Add(this.label5);
            this.grpMemberInfo.Controls.Add(this.label4);
            this.grpMemberInfo.Controls.Add(this.label3);
            this.grpMemberInfo.Controls.Add(this.label2);
            this.grpMemberInfo.Controls.Add(this.label1);
            this.grpMemberInfo.Controls.Add(this.linkLabel1);
            this.grpMemberInfo.Location = new System.Drawing.Point(17, 22);
            this.grpMemberInfo.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.grpMemberInfo.Name = "grpMemberInfo";
            this.grpMemberInfo.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.grpMemberInfo.Size = new System.Drawing.Size(711, 416);
            this.grpMemberInfo.TabIndex = 0;
            this.grpMemberInfo.TabStop = false;
            this.grpMemberInfo.Text = "Informasi anggota";
            // 
            // btnCari
            // 
            this.btnCari.Location = new System.Drawing.Point(575, 17);
            this.btnCari.Name = "btnCari";
            this.btnCari.Size = new System.Drawing.Size(129, 42);
            this.btnCari.TabIndex = 38;
            this.btnCari.Text = "Cari";
            this.btnCari.UseVisualStyleBackColor = true;
            this.btnCari.Click += new System.EventHandler(this.btnCari_Click);
            // 
            // lblOverdueFee
            // 
            this.lblOverdueFee.Location = new System.Drawing.Point(185, 372);
            this.lblOverdueFee.Name = "lblOverdueFee";
            this.lblOverdueFee.Size = new System.Drawing.Size(295, 26);
            this.lblOverdueFee.TabIndex = 37;
            // 
            // lblDaysOfOverdue
            // 
            this.lblDaysOfOverdue.Location = new System.Drawing.Point(389, 329);
            this.lblDaysOfOverdue.Name = "lblDaysOfOverdue";
            this.lblDaysOfOverdue.Size = new System.Drawing.Size(295, 26);
            this.lblDaysOfOverdue.TabIndex = 36;
            // 
            // lblNumOfOverdue
            // 
            this.lblNumOfOverdue.Location = new System.Drawing.Point(297, 280);
            this.lblNumOfOverdue.Name = "lblNumOfOverdue";
            this.lblNumOfOverdue.Size = new System.Drawing.Size(295, 26);
            this.lblNumOfOverdue.TabIndex = 35;
            // 
            // lblNumOfAvailable
            // 
            this.lblNumOfAvailable.Location = new System.Drawing.Point(223, 230);
            this.lblNumOfAvailable.Name = "lblNumOfAvailable";
            this.lblNumOfAvailable.Size = new System.Drawing.Size(295, 26);
            this.lblNumOfAvailable.TabIndex = 34;
            // 
            // lblNumOfCheckOut
            // 
            this.lblNumOfCheckOut.Location = new System.Drawing.Point(174, 189);
            this.lblNumOfCheckOut.Name = "lblNumOfCheckOut";
            this.lblNumOfCheckOut.Size = new System.Drawing.Size(295, 26);
            this.lblNumOfCheckOut.TabIndex = 33;
            // 
            // lblPhoneNo
            // 
            this.lblPhoneNo.Location = new System.Drawing.Point(119, 116);
            this.lblPhoneNo.Name = "lblPhoneNo";
            this.lblPhoneNo.Size = new System.Drawing.Size(295, 26);
            this.lblPhoneNo.TabIndex = 32;
            // 
            // lblMemberName
            // 
            this.lblMemberName.Location = new System.Drawing.Point(119, 80);
            this.lblMemberName.Name = "lblMemberName";
            this.lblMemberName.Size = new System.Drawing.Size(295, 26);
            this.lblMemberName.TabIndex = 31;
            // 
            // txtMemberId
            // 
            this.txtMemberId.Location = new System.Drawing.Point(119, 33);
            this.txtMemberId.Name = "txtMemberId";
            this.txtMemberId.Size = new System.Drawing.Size(295, 26);
            this.txtMemberId.TabIndex = 30;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(7, 375);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(154, 20);
            this.label8.TabIndex = 29;
            this.label8.Text = "Biaya keterlambatan";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(7, 332);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(376, 20);
            this.label7.TabIndex = 28;
            this.label7.Text = "Total hari yang sudah lewat dari tanggal jatuh tempo";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(7, 286);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(273, 20);
            this.label6.TabIndex = 27;
            this.label6.Text = "Jumlah buku yang sudah jatuh tempo";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(7, 233);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(193, 20);
            this.label5.TabIndex = 26;
            this.label5.Text = "Jumlah yang bisa dipinjam";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(7, 189);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(150, 20);
            this.label4.TabIndex = 25;
            this.label4.Text = "Jumlah peminjaman";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(7, 122);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(55, 20);
            this.label3.TabIndex = 24;
            this.label3.Text = "No.HP";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 86);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(51, 20);
            this.label2.TabIndex = 23;
            this.label2.Text = "Nama";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 39);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(91, 20);
            this.label1.TabIndex = 22;
            this.label1.Text = "ID Anggota";
            // 
            // linkLabel1
            // 
            this.linkLabel1.AutoSize = true;
            this.linkLabel1.LinkColor = System.Drawing.Color.Gray;
            this.linkLabel1.Location = new System.Drawing.Point(6, 145);
            this.linkLabel1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.Size = new System.Drawing.Size(205, 20);
            this.linkLabel1.TabIndex = 1;
            this.linkLabel1.TabStop = true;
            this.linkLabel1.Text = "                                                 ";
            // 
            // grpBookInfo
            // 
            this.grpBookInfo.Controls.Add(this.btnSearchBook);
            this.grpBookInfo.Controls.Add(this.lblPublisher);
            this.grpBookInfo.Controls.Add(this.lblTitle);
            this.grpBookInfo.Controls.Add(this.txtBookCopyCode);
            this.grpBookInfo.Controls.Add(this.label11);
            this.grpBookInfo.Controls.Add(this.label10);
            this.grpBookInfo.Controls.Add(this.label9);
            this.grpBookInfo.Location = new System.Drawing.Point(799, 22);
            this.grpBookInfo.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.grpBookInfo.Name = "grpBookInfo";
            this.grpBookInfo.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.grpBookInfo.Size = new System.Drawing.Size(488, 177);
            this.grpBookInfo.TabIndex = 17;
            this.grpBookInfo.TabStop = false;
            this.grpBookInfo.Text = "Informasi buku";
            // 
            // lblPublisher
            // 
            this.lblPublisher.Location = new System.Drawing.Point(95, 129);
            this.lblPublisher.Name = "lblPublisher";
            this.lblPublisher.Size = new System.Drawing.Size(295, 26);
            this.lblPublisher.TabIndex = 40;
            // 
            // lblTitle
            // 
            this.lblTitle.Location = new System.Drawing.Point(117, 80);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(295, 26);
            this.lblTitle.TabIndex = 39;
            // 
            // txtBookCopyCode
            // 
            this.txtBookCopyCode.Location = new System.Drawing.Point(193, 42);
            this.txtBookCopyCode.Name = "txtBookCopyCode";
            this.txtBookCopyCode.Size = new System.Drawing.Size(197, 26);
            this.txtBookCopyCode.TabIndex = 38;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(11, 129);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(68, 20);
            this.label11.TabIndex = 32;
            this.label11.Text = "Penerbit";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(7, 86);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(92, 20);
            this.label10.TabIndex = 31;
            this.label10.Text = "Nama Buku";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(7, 42);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(163, 20);
            this.label9.TabIndex = 30;
            this.label9.Text = "Nomor registrasi buku";
            // 
            // dgvBookList
            // 
            this.dgvBookList.AllowUserToAddRows = false;
            this.dgvBookList.AllowUserToDeleteRows = false;
            this.dgvBookList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvBookList.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4,
            this.Column5,
            this.Column6,
            this.Column7});
            this.dgvBookList.Location = new System.Drawing.Point(17, 479);
            this.dgvBookList.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.dgvBookList.MultiSelect = false;
            this.dgvBookList.Name = "dgvBookList";
            this.dgvBookList.ReadOnly = true;
            this.dgvBookList.RowHeadersWidth = 62;
            this.dgvBookList.RowTemplate.Height = 23;
            this.dgvBookList.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvBookList.Size = new System.Drawing.Size(1270, 205);
            this.dgvBookList.TabIndex = 18;
            this.dgvBookList.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvBookList_CellContentClick);
            // 
            // Column1
            // 
            this.Column1.DataPropertyName = "CheckOutId";
            this.Column1.FillWeight = 70F;
            this.Column1.HeaderText = "ID Peminjaman";
            this.Column1.MinimumWidth = 8;
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            this.Column1.Visible = false;
            this.Column1.Width = 70;
            // 
            // Column2
            // 
            this.Column2.DataPropertyName = "BookCopyCode";
            this.Column2.FillWeight = 110F;
            this.Column2.HeaderText = "Nomor registrasi buku";
            this.Column2.MinimumWidth = 8;
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            this.Column2.Width = 110;
            // 
            // Column3
            // 
            this.Column3.DataPropertyName = "Title";
            this.Column3.HeaderText = "Nama buku";
            this.Column3.MinimumWidth = 8;
            this.Column3.Name = "Column3";
            this.Column3.ReadOnly = true;
            this.Column3.Width = 150;
            // 
            // Column4
            // 
            this.Column4.DataPropertyName = "CheckOutDate";
            dataGridViewCellStyle3.Format = "yyyy-MM-dd HH:mm";
            dataGridViewCellStyle3.NullValue = null;
            this.Column4.DefaultCellStyle = dataGridViewCellStyle3;
            this.Column4.HeaderText = "Tanggal peminjaman";
            this.Column4.MinimumWidth = 8;
            this.Column4.Name = "Column4";
            this.Column4.ReadOnly = true;
            this.Column4.Width = 250;
            // 
            // Column5
            // 
            this.Column5.DataPropertyName = "DueDate";
            this.Column5.FillWeight = 80F;
            this.Column5.HeaderText = "Tanggal rencana pengembalian";
            this.Column5.MinimumWidth = 8;
            this.Column5.Name = "Column5";
            this.Column5.ReadOnly = true;
            this.Column5.Width = 250;
            // 
            // Column6
            // 
            this.Column6.DataPropertyName = "OverdueDays";
            this.Column6.FillWeight = 80F;
            this.Column6.HeaderText = "Tanggal jatuh tempo pengembalian";
            this.Column6.MinimumWidth = 8;
            this.Column6.Name = "Column6";
            this.Column6.ReadOnly = true;
            this.Column6.Width = 250;
            // 
            // Column7
            // 
            this.Column7.DataPropertyName = "OverdueCharge";
            this.Column7.FillWeight = 65F;
            this.Column7.HeaderText = "Biaya keterlambatan";
            this.Column7.MinimumWidth = 8;
            this.Column7.Name = "Column7";
            this.Column7.ReadOnly = true;
            this.Column7.Width = 65;
            // 
            // btnCheckOut
            // 
            this.btnCheckOut.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.btnCheckOut.Image = ((System.Drawing.Image)(resources.GetObject("btnCheckOut.Image")));
            this.btnCheckOut.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCheckOut.Location = new System.Drawing.Point(799, 271);
            this.btnCheckOut.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnCheckOut.Name = "btnCheckOut";
            this.btnCheckOut.Size = new System.Drawing.Size(177, 103);
            this.btnCheckOut.TabIndex = 19;
            this.btnCheckOut.Text = "Peminjaman";
            this.btnCheckOut.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnCheckOut.UseVisualStyleBackColor = true;
            this.btnCheckOut.Click += new System.EventHandler(this.btnCheckOut_Click);
            // 
            // btnReturn
            // 
            this.btnReturn.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.btnReturn.Image = ((System.Drawing.Image)(resources.GetObject("btnReturn.Image")));
            this.btnReturn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnReturn.Location = new System.Drawing.Point(1075, 271);
            this.btnReturn.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnReturn.Name = "btnReturn";
            this.btnReturn.Size = new System.Drawing.Size(189, 103);
            this.btnReturn.TabIndex = 20;
            this.btnReturn.Text = "Pengembalian";
            this.btnReturn.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnReturn.UseVisualStyleBackColor = true;
            this.btnReturn.Click += new System.EventHandler(this.btnReturn_Click);
            // 
            // btnClose
            // 
            this.btnClose.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnClose.Image = ((System.Drawing.Image)(resources.GetObject("btnClose.Image")));
            this.btnClose.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnClose.Location = new System.Drawing.Point(644, 694);
            this.btnClose.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(107, 57);
            this.btnClose.TabIndex = 21;
            this.btnClose.Text = "Tutup";
            this.btnClose.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // btnSearchBook
            // 
            this.btnSearchBook.Location = new System.Drawing.Point(397, 33);
            this.btnSearchBook.Name = "btnSearchBook";
            this.btnSearchBook.Size = new System.Drawing.Size(68, 42);
            this.btnSearchBook.TabIndex = 39;
            this.btnSearchBook.Text = "Cari";
            this.btnSearchBook.UseVisualStyleBackColor = true;
            this.btnSearchBook.Click += new System.EventHandler(this.btnSearchBook_Click_1);
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1349, 851);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.btnReturn);
            this.Controls.Add(this.btnCheckOut);
            this.Controls.Add(this.dgvBookList);
            this.Controls.Add(this.grpBookInfo);
            this.Controls.Add(this.grpMemberInfo);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Peminjaman/pengembalian buku";
            this.Load += new System.EventHandler(this.frmMain_Load);
            this.grpMemberInfo.ResumeLayout(false);
            this.grpMemberInfo.PerformLayout();
            this.grpBookInfo.ResumeLayout(false);
            this.grpBookInfo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvBookList)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox grpMemberInfo;
        private System.Windows.Forms.LinkLabel linkLabel1;
        private System.Windows.Forms.GroupBox grpBookInfo;
        private System.Windows.Forms.DataGridView dgvBookList;
        private System.Windows.Forms.Button btnCheckOut;
        private System.Windows.Forms.Button btnReturn;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox lblOverdueFee;
        private System.Windows.Forms.TextBox lblDaysOfOverdue;
        private System.Windows.Forms.TextBox lblNumOfOverdue;
        private System.Windows.Forms.TextBox lblNumOfAvailable;
        private System.Windows.Forms.TextBox lblNumOfCheckOut;
        private System.Windows.Forms.TextBox lblPhoneNo;
        private System.Windows.Forms.TextBox lblMemberName;
        private System.Windows.Forms.TextBox txtMemberId;
        private System.Windows.Forms.TextBox lblPublisher;
        private System.Windows.Forms.TextBox lblTitle;
        private System.Windows.Forms.TextBox txtBookCopyCode;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column6;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column7;
        private System.Windows.Forms.Button btnCari;
        private System.Windows.Forms.Button btnSearchBook;
    }
}