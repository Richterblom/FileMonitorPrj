namespace FileMonitorProject
{
    partial class FileMonitor
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FileMonitor));
            this.cbIncludeSubIdercories = new System.Windows.Forms.CheckBox();
            this.btnEndMonitor = new System.Windows.Forms.Button();
            this.btnStartMonitor = new System.Windows.Forms.Button();
            this.btnBrowse = new System.Windows.Forms.Button();
            this.txtSearchBox = new System.Windows.Forms.TextBox();
            this.lblSearch = new System.Windows.Forms.Label();
            this.dgvFileChangeRecords = new System.Windows.Forms.DataGridView();
            this.lblHeading = new System.Windows.Forms.Label();
            this.btnLogOff = new System.Windows.Forms.Button();
            this.dtpStartDate = new System.Windows.Forms.DateTimePicker();
            this.dtpEndDate = new System.Windows.Forms.DateTimePicker();
            this.btnTimeMonitoring = new System.Windows.Forms.Button();
            this.tTimer = new System.Windows.Forms.Timer(this.components);
            this.notify = new System.Windows.Forms.NotifyIcon(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.dgvFileChangeRecords)).BeginInit();
            this.SuspendLayout();
            // 
            // cbIncludeSubIdercories
            // 
            this.cbIncludeSubIdercories.AutoSize = true;
            this.cbIncludeSubIdercories.Location = new System.Drawing.Point(63, 147);
            this.cbIncludeSubIdercories.Margin = new System.Windows.Forms.Padding(2);
            this.cbIncludeSubIdercories.Name = "cbIncludeSubIdercories";
            this.cbIncludeSubIdercories.Size = new System.Drawing.Size(132, 17);
            this.cbIncludeSubIdercories.TabIndex = 13;
            this.cbIncludeSubIdercories.Text = "Include sub-directories";
            this.cbIncludeSubIdercories.UseVisualStyleBackColor = true;
            // 
            // btnEndMonitor
            // 
            this.btnEndMonitor.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEndMonitor.Location = new System.Drawing.Point(81, 238);
            this.btnEndMonitor.Margin = new System.Windows.Forms.Padding(2);
            this.btnEndMonitor.Name = "btnEndMonitor";
            this.btnEndMonitor.Size = new System.Drawing.Size(114, 37);
            this.btnEndMonitor.TabIndex = 12;
            this.btnEndMonitor.Text = "End File Monitor";
            this.btnEndMonitor.UseVisualStyleBackColor = true;
            this.btnEndMonitor.Click += new System.EventHandler(this.btnEndMonitor_Click);
            // 
            // btnStartMonitor
            // 
            this.btnStartMonitor.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnStartMonitor.Location = new System.Drawing.Point(63, 183);
            this.btnStartMonitor.Margin = new System.Windows.Forms.Padding(2);
            this.btnStartMonitor.Name = "btnStartMonitor";
            this.btnStartMonitor.Size = new System.Drawing.Size(132, 37);
            this.btnStartMonitor.TabIndex = 11;
            this.btnStartMonitor.Text = "Begin File Monitor";
            this.btnStartMonitor.UseVisualStyleBackColor = true;
            this.btnStartMonitor.Click += new System.EventHandler(this.btnStartMonitor_Click);
            // 
            // btnBrowse
            // 
            this.btnBrowse.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBrowse.Location = new System.Drawing.Point(51, 87);
            this.btnBrowse.Margin = new System.Windows.Forms.Padding(2);
            this.btnBrowse.Name = "btnBrowse";
            this.btnBrowse.Size = new System.Drawing.Size(144, 37);
            this.btnBrowse.TabIndex = 10;
            this.btnBrowse.Text = "Choose File To Monitor";
            this.btnBrowse.UseVisualStyleBackColor = true;
            this.btnBrowse.Click += new System.EventHandler(this.btnBrowse_Click);
            // 
            // txtSearchBox
            // 
            this.txtSearchBox.Location = new System.Drawing.Point(287, 342);
            this.txtSearchBox.Margin = new System.Windows.Forms.Padding(2);
            this.txtSearchBox.Name = "txtSearchBox";
            this.txtSearchBox.Size = new System.Drawing.Size(426, 20);
            this.txtSearchBox.TabIndex = 9;
            this.txtSearchBox.TextChanged += new System.EventHandler(this.txtSearchBox_TextChanged);
            // 
            // lblSearch
            // 
            this.lblSearch.AutoSize = true;
            this.lblSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSearch.Location = new System.Drawing.Point(195, 342);
            this.lblSearch.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblSearch.Name = "lblSearch";
            this.lblSearch.Size = new System.Drawing.Size(71, 20);
            this.lblSearch.TabIndex = 8;
            this.lblSearch.Text = "Search:";
            // 
            // dgvFileChangeRecords
            // 
            this.dgvFileChangeRecords.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvFileChangeRecords.BackgroundColor = System.Drawing.SystemColors.ButtonShadow;
            this.dgvFileChangeRecords.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvFileChangeRecords.Location = new System.Drawing.Point(199, 87);
            this.dgvFileChangeRecords.Margin = new System.Windows.Forms.Padding(2);
            this.dgvFileChangeRecords.Name = "dgvFileChangeRecords";
            this.dgvFileChangeRecords.RowTemplate.Height = 24;
            this.dgvFileChangeRecords.Size = new System.Drawing.Size(514, 243);
            this.dgvFileChangeRecords.TabIndex = 7;
            // 
            // lblHeading
            // 
            this.lblHeading.AutoSize = true;
            this.lblHeading.BackColor = System.Drawing.Color.Transparent;
            this.lblHeading.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHeading.ForeColor = System.Drawing.Color.Azure;
            this.lblHeading.Location = new System.Drawing.Point(328, 42);
            this.lblHeading.Name = "lblHeading";
            this.lblHeading.Size = new System.Drawing.Size(312, 31);
            this.lblHeading.TabIndex = 14;
            this.lblHeading.Text = "File Monitoring Service";
            this.lblHeading.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // btnLogOff
            // 
            this.btnLogOff.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLogOff.Location = new System.Drawing.Point(81, 293);
            this.btnLogOff.Name = "btnLogOff";
            this.btnLogOff.Size = new System.Drawing.Size(114, 37);
            this.btnLogOff.TabIndex = 15;
            this.btnLogOff.Text = "Log Off";
            this.btnLogOff.UseVisualStyleBackColor = true;
            this.btnLogOff.Click += new System.EventHandler(this.btnLogOff_Click);
            // 
            // dtpStartDate
            // 
            this.dtpStartDate.Location = new System.Drawing.Point(718, 87);
            this.dtpStartDate.Name = "dtpStartDate";
            this.dtpStartDate.Size = new System.Drawing.Size(142, 20);
            this.dtpStartDate.TabIndex = 16;
            // 
            // dtpEndDate
            // 
            this.dtpEndDate.Location = new System.Drawing.Point(718, 123);
            this.dtpEndDate.Name = "dtpEndDate";
            this.dtpEndDate.Size = new System.Drawing.Size(142, 20);
            this.dtpEndDate.TabIndex = 16;
            // 
            // btnTimeMonitoring
            // 
            this.btnTimeMonitoring.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTimeMonitoring.Location = new System.Drawing.Point(718, 163);
            this.btnTimeMonitoring.Name = "btnTimeMonitoring";
            this.btnTimeMonitoring.Size = new System.Drawing.Size(114, 44);
            this.btnTimeMonitoring.TabIndex = 17;
            this.btnTimeMonitoring.Text = "choose time you wish to monitor";
            this.btnTimeMonitoring.UseVisualStyleBackColor = true;
            this.btnTimeMonitoring.Click += new System.EventHandler(this.btnTimeMonitoring_Click);
            // 
            // notify
            // 
            this.notify.Icon = ((System.Drawing.Icon)(resources.GetObject("notify.Icon")));
            this.notify.Text = "notify";
            this.notify.Visible = true;
            // 
            // FileMonitor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(974, 432);
            this.Controls.Add(this.btnTimeMonitoring);
            this.Controls.Add(this.dtpEndDate);
            this.Controls.Add(this.dtpStartDate);
            this.Controls.Add(this.btnLogOff);
            this.Controls.Add(this.lblHeading);
            this.Controls.Add(this.cbIncludeSubIdercories);
            this.Controls.Add(this.btnEndMonitor);
            this.Controls.Add(this.btnStartMonitor);
            this.Controls.Add(this.btnBrowse);
            this.Controls.Add(this.txtSearchBox);
            this.Controls.Add(this.lblSearch);
            this.Controls.Add(this.dgvFileChangeRecords);
            this.Cursor = System.Windows.Forms.Cursors.Hand;
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FileMonitor";
            this.Text = "File Monitor";
            this.Load += new System.EventHandler(this.FileMonitor_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvFileChangeRecords)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.CheckBox cbIncludeSubIdercories;
        private System.Windows.Forms.Button btnEndMonitor;
        private System.Windows.Forms.Button btnStartMonitor;
        private System.Windows.Forms.Button btnBrowse;
        private System.Windows.Forms.TextBox txtSearchBox;
        private System.Windows.Forms.Label lblSearch;
        private System.Windows.Forms.DataGridView dgvFileChangeRecords;
        private System.Windows.Forms.Label lblHeading;
        private System.Windows.Forms.Button btnLogOff;
        private System.Windows.Forms.DateTimePicker dtpStartDate;
        private System.Windows.Forms.DateTimePicker dtpEndDate;
        private System.Windows.Forms.Button btnTimeMonitoring;
        private System.Windows.Forms.Timer tTimer;
        private System.Windows.Forms.NotifyIcon notify;
    }
}

