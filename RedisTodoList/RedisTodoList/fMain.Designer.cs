namespace RedisTodoList
{
    partial class fMain
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
            this.labID = new System.Windows.Forms.Label();
            this.labMyJob = new System.Windows.Forms.Label();
            this.labStartDay = new System.Windows.Forms.Label();
            this.labEndDate = new System.Windows.Forms.Label();
            this.labContent = new System.Windows.Forms.Label();
            this.txtID = new System.Windows.Forms.TextBox();
            this.workBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.txtMyJob = new System.Windows.Forms.TextBox();
            this.txtContent = new System.Windows.Forms.TextBox();
            this.dgvWork = new System.Windows.Forms.DataGridView();
            this.iDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.myJobDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.startDayDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.endDateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.contentDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Status = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.dtStartDay = new System.Windows.Forms.DateTimePicker();
            this.dtEndDate = new System.Windows.Forms.DateTimePicker();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnEdit = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnSearch = new System.Windows.Forms.Button();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.workBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvWork)).BeginInit();
            this.SuspendLayout();
            // 
            // labID
            // 
            this.labID.AutoSize = true;
            this.labID.Location = new System.Drawing.Point(23, 73);
            this.labID.Name = "labID";
            this.labID.Size = new System.Drawing.Size(18, 13);
            this.labID.TabIndex = 9;
            this.labID.Text = "ID";
            // 
            // labMyJob
            // 
            this.labMyJob.AutoSize = true;
            this.labMyJob.Location = new System.Drawing.Point(23, 100);
            this.labMyJob.Name = "labMyJob";
            this.labMyJob.Size = new System.Drawing.Size(38, 13);
            this.labMyJob.TabIndex = 9;
            this.labMyJob.Text = "My job";
            // 
            // labStartDay
            // 
            this.labStartDay.AutoSize = true;
            this.labStartDay.Location = new System.Drawing.Point(23, 133);
            this.labStartDay.Name = "labStartDay";
            this.labStartDay.Size = new System.Drawing.Size(49, 13);
            this.labStartDay.TabIndex = 9;
            this.labStartDay.Text = "Start day";
            // 
            // labEndDate
            // 
            this.labEndDate.AutoSize = true;
            this.labEndDate.Location = new System.Drawing.Point(23, 162);
            this.labEndDate.Name = "labEndDate";
            this.labEndDate.Size = new System.Drawing.Size(52, 13);
            this.labEndDate.TabIndex = 9;
            this.labEndDate.Text = "End Date";
            // 
            // labContent
            // 
            this.labContent.AutoSize = true;
            this.labContent.Location = new System.Drawing.Point(468, 73);
            this.labContent.Name = "labContent";
            this.labContent.Size = new System.Drawing.Size(44, 13);
            this.labContent.TabIndex = 9;
            this.labContent.Text = "Content";
            // 
            // txtID
            // 
            this.txtID.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.workBindingSource, "ID", true));
            this.txtID.Location = new System.Drawing.Point(93, 67);
            this.txtID.Name = "txtID";
            this.txtID.ReadOnly = true;
            this.txtID.Size = new System.Drawing.Size(200, 20);
            this.txtID.TabIndex = 0;
            // 
            // workBindingSource
            // 
            this.workBindingSource.DataSource = typeof(RedisTodoList.Work);
            // 
            // txtMyJob
            // 
            this.txtMyJob.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.workBindingSource, "MyJob", true));
            this.txtMyJob.Location = new System.Drawing.Point(93, 98);
            this.txtMyJob.Name = "txtMyJob";
            this.txtMyJob.Size = new System.Drawing.Size(200, 20);
            this.txtMyJob.TabIndex = 1;
            // 
            // txtContent
            // 
            this.txtContent.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.workBindingSource, "Content", true));
            this.txtContent.Location = new System.Drawing.Point(524, 67);
            this.txtContent.Multiline = true;
            this.txtContent.Name = "txtContent";
            this.txtContent.Size = new System.Drawing.Size(243, 113);
            this.txtContent.TabIndex = 4;
            // 
            // dgvWork
            // 
            this.dgvWork.AllowUserToAddRows = false;
            this.dgvWork.AutoGenerateColumns = false;
            this.dgvWork.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvWork.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.iDDataGridViewTextBoxColumn,
            this.myJobDataGridViewTextBoxColumn,
            this.startDayDataGridViewTextBoxColumn,
            this.endDateDataGridViewTextBoxColumn,
            this.contentDataGridViewTextBoxColumn,
            this.Status});
            this.dgvWork.DataSource = this.workBindingSource;
            this.dgvWork.Location = new System.Drawing.Point(93, 250);
            this.dgvWork.Name = "dgvWork";
            this.dgvWork.Size = new System.Drawing.Size(674, 181);
            this.dgvWork.TabIndex = 9;
            this.dgvWork.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvWork_CellContentClick);
            // 
            // iDDataGridViewTextBoxColumn
            // 
            this.iDDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.iDDataGridViewTextBoxColumn.DataPropertyName = "ID";
            this.iDDataGridViewTextBoxColumn.HeaderText = "ID";
            this.iDDataGridViewTextBoxColumn.Name = "iDDataGridViewTextBoxColumn";
            this.iDDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // myJobDataGridViewTextBoxColumn
            // 
            this.myJobDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.myJobDataGridViewTextBoxColumn.DataPropertyName = "MyJob";
            this.myJobDataGridViewTextBoxColumn.HeaderText = "Tên công việc";
            this.myJobDataGridViewTextBoxColumn.Name = "myJobDataGridViewTextBoxColumn";
            this.myJobDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // startDayDataGridViewTextBoxColumn
            // 
            this.startDayDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.startDayDataGridViewTextBoxColumn.DataPropertyName = "StartDay";
            this.startDayDataGridViewTextBoxColumn.HeaderText = "Ngày bắt đầu";
            this.startDayDataGridViewTextBoxColumn.Name = "startDayDataGridViewTextBoxColumn";
            this.startDayDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // endDateDataGridViewTextBoxColumn
            // 
            this.endDateDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.endDateDataGridViewTextBoxColumn.DataPropertyName = "EndDate";
            this.endDateDataGridViewTextBoxColumn.HeaderText = "Ngày kết thúc";
            this.endDateDataGridViewTextBoxColumn.Name = "endDateDataGridViewTextBoxColumn";
            this.endDateDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // contentDataGridViewTextBoxColumn
            // 
            this.contentDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.contentDataGridViewTextBoxColumn.DataPropertyName = "Content";
            this.contentDataGridViewTextBoxColumn.HeaderText = "Mô tả";
            this.contentDataGridViewTextBoxColumn.Name = "contentDataGridViewTextBoxColumn";
            this.contentDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // Status
            // 
            this.Status.HeaderText = "Tình trạng";
            this.Status.Name = "Status";
            // 
            // dtStartDay
            // 
            this.dtStartDay.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.workBindingSource, "StartDay", true));
            this.dtStartDay.Location = new System.Drawing.Point(93, 128);
            this.dtStartDay.Name = "dtStartDay";
            this.dtStartDay.Size = new System.Drawing.Size(200, 20);
            this.dtStartDay.TabIndex = 2;
            // 
            // dtEndDate
            // 
            this.dtEndDate.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.workBindingSource, "EndDate", true));
            this.dtEndDate.Location = new System.Drawing.Point(93, 160);
            this.dtEndDate.Name = "dtEndDate";
            this.dtEndDate.Size = new System.Drawing.Size(200, 20);
            this.dtEndDate.TabIndex = 3;
            // 
            // btnCancel
            // 
            this.btnCancel.Image = global::RedisTodoList.Properties.Resources.back_arrow;
            this.btnCancel.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCancel.Location = new System.Drawing.Point(512, 437);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(185, 32);
            this.btnCancel.TabIndex = 9;
            this.btnCancel.Text = "Xóa tất cả danh sách chưa lưu";
            this.btnCancel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnSave
            // 
            this.btnSave.Image = global::RedisTodoList.Properties.Resources.download__3_;
            this.btnSave.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSave.Location = new System.Drawing.Point(703, 437);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(64, 32);
            this.btnSave.TabIndex = 8;
            this.btnSave.Text = "Lưu ";
            this.btnSave.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Image = global::RedisTodoList.Properties.Resources.trash;
            this.btnDelete.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnDelete.Location = new System.Drawing.Point(286, 437);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(70, 32);
            this.btnDelete.TabIndex = 7;
            this.btnDelete.Text = "Xóa";
            this.btnDelete.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnEdit
            // 
            this.btnEdit.Image = global::RedisTodoList.Properties.Resources.edit;
            this.btnEdit.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnEdit.Location = new System.Drawing.Point(219, 437);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(61, 32);
            this.btnEdit.TabIndex = 6;
            this.btnEdit.Text = "Sửa ";
            this.btnEdit.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnEdit.UseVisualStyleBackColor = true;
            this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.Image = global::RedisTodoList.Properties.Resources.add_file;
            this.btnAdd.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAdd.Location = new System.Drawing.Point(93, 437);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(120, 32);
            this.btnAdd.TabIndex = 5;
            this.btnAdd.Text = "Tạo mới danh sách";
            this.btnAdd.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(171, 222);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(13, 13);
            this.label1.TabIndex = 11;
            this.label1.Text = "0";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(23, 222);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(142, 13);
            this.label2.TabIndex = 12;
            this.label2.Text = "Số lượng công việc cần làm:";
            // 
            // btnSearch
            // 
            this.btnSearch.Location = new System.Drawing.Point(26, 184);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(114, 23);
            this.btnSearch.TabIndex = 13;
            this.btnSearch.Text = "Tìm kiếm công việc";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // txtSearch
            // 
            this.txtSearch.Location = new System.Drawing.Point(146, 186);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(147, 20);
            this.txtSearch.TabIndex = 14;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(521, 215);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(57, 13);
            this.label3.TabIndex = 15;
            this.label3.Text = "Đúng hạn:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(584, 215);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(13, 13);
            this.label4.TabIndex = 16;
            this.label4.Text = "0";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(618, 215);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(51, 13);
            this.label5.TabIndex = 17;
            this.label5.Text = "Quá hạn:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(675, 215);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(13, 13);
            this.label6.TabIndex = 18;
            this.label6.Text = "0";
            // 
            // fMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 474);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtSearch);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnEdit);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.dtEndDate);
            this.Controls.Add(this.dtStartDay);
            this.Controls.Add(this.dgvWork);
            this.Controls.Add(this.txtContent);
            this.Controls.Add(this.txtMyJob);
            this.Controls.Add(this.txtID);
            this.Controls.Add(this.labContent);
            this.Controls.Add(this.labEndDate);
            this.Controls.Add(this.labStartDay);
            this.Controls.Add(this.labMyJob);
            this.Controls.Add(this.labID);
            this.ForeColor = System.Drawing.Color.Green;
            this.Name = "fMain";
            this.Text = "Todo List";
            this.Load += new System.EventHandler(this.fMain_Load);
            ((System.ComponentModel.ISupportInitialize)(this.workBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvWork)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labID;
        private System.Windows.Forms.Label labMyJob;
        private System.Windows.Forms.Label labStartDay;
        private System.Windows.Forms.Label labEndDate;
        private System.Windows.Forms.Label labContent;
        private System.Windows.Forms.TextBox txtID;
        private System.Windows.Forms.TextBox txtMyJob;
        private System.Windows.Forms.TextBox txtContent;
        private System.Windows.Forms.DataGridView dgvWork;
        private System.Windows.Forms.DateTimePicker dtStartDay;
        private System.Windows.Forms.DateTimePicker dtEndDate;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnEdit;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.BindingSource workBindingSource;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn myJobDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn startDayDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn endDateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn contentDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewCheckBoxColumn Status;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
    }
}

