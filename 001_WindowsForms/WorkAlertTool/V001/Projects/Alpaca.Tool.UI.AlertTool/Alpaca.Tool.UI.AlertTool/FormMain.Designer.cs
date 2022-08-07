namespace Alpaca.Tool.UI.AlertTool
{
    partial class FormMain
    {
        /// <summary>
        /// 必要なデザイナー変数です。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 使用中のリソースをすべてクリーンアップします。
        /// </summary>
        /// <param name="disposing">マネージド リソースを破棄する場合は true を指定し、その他の場合は false を指定します。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows フォーム デザイナーで生成されたコード

        /// <summary>
        /// デザイナー サポートに必要なメソッドです。このメソッドの内容を
        /// コード エディターで変更しないでください。
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            this.gbAbout = new System.Windows.Forms.GroupBox();
            this.btnRowDelete = new System.Windows.Forms.Button();
            this.btnLoadPreset = new System.Windows.Forms.Button();
            this.cmbScheduleType = new System.Windows.Forms.ComboBox();
            this.lblScheduleType = new System.Windows.Forms.Label();
            this.btnStartNStopSchedule = new System.Windows.Forms.Button();
            this.btnScheduleAdd = new System.Windows.Forms.Button();
            this.txtBxScheduleName = new System.Windows.Forms.TextBox();
            this.スケジュール名称 = new System.Windows.Forms.Label();
            this.lblPlayTime = new System.Windows.Forms.Label();
            this.txtBxPlayTime = new System.Windows.Forms.TextBox();
            this.lblScheduleAdd = new System.Windows.Forms.Label();
            this.lblTimeNow = new System.Windows.Forms.Label();
            this.btnExit = new System.Windows.Forms.Button();
            this.dgvAlertList = new System.Windows.Forms.DataGridView();
            this.timerTime = new System.Windows.Forms.Timer(this.components);
            this.scheduleTimer = new System.Windows.Forms.Timer(this.components);
            this.btnPlayHotaru = new System.Windows.Forms.Button();
            this.gbAbout.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAlertList)).BeginInit();
            this.SuspendLayout();
            // 
            // gbAbout
            // 
            this.gbAbout.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gbAbout.Controls.Add(this.btnPlayHotaru);
            this.gbAbout.Controls.Add(this.btnRowDelete);
            this.gbAbout.Controls.Add(this.btnLoadPreset);
            this.gbAbout.Controls.Add(this.cmbScheduleType);
            this.gbAbout.Controls.Add(this.lblScheduleType);
            this.gbAbout.Controls.Add(this.btnStartNStopSchedule);
            this.gbAbout.Controls.Add(this.btnScheduleAdd);
            this.gbAbout.Controls.Add(this.txtBxScheduleName);
            this.gbAbout.Controls.Add(this.スケジュール名称);
            this.gbAbout.Controls.Add(this.lblPlayTime);
            this.gbAbout.Controls.Add(this.txtBxPlayTime);
            this.gbAbout.Controls.Add(this.lblScheduleAdd);
            this.gbAbout.Controls.Add(this.lblTimeNow);
            this.gbAbout.Controls.Add(this.btnExit);
            this.gbAbout.Controls.Add(this.dgvAlertList);
            this.gbAbout.Font = new System.Drawing.Font("MS UI Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.gbAbout.Location = new System.Drawing.Point(12, 12);
            this.gbAbout.Name = "gbAbout";
            this.gbAbout.Size = new System.Drawing.Size(924, 515);
            this.gbAbout.TabIndex = 0;
            this.gbAbout.TabStop = false;
            this.gbAbout.Text = "社内イベントアラートツール";
            // 
            // btnRowDelete
            // 
            this.btnRowDelete.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnRowDelete.Location = new System.Drawing.Point(350, 460);
            this.btnRowDelete.Name = "btnRowDelete";
            this.btnRowDelete.Size = new System.Drawing.Size(166, 49);
            this.btnRowDelete.TabIndex = 12;
            this.btnRowDelete.Text = "スケジュール削除";
            this.btnRowDelete.UseVisualStyleBackColor = true;
            this.btnRowDelete.Click += new System.EventHandler(this.btnRowDelete_Click);
            // 
            // btnLoadPreset
            // 
            this.btnLoadPreset.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnLoadPreset.Location = new System.Drawing.Point(178, 460);
            this.btnLoadPreset.Name = "btnLoadPreset";
            this.btnLoadPreset.Size = new System.Drawing.Size(166, 49);
            this.btnLoadPreset.TabIndex = 11;
            this.btnLoadPreset.Text = "プリセット読込";
            this.btnLoadPreset.UseVisualStyleBackColor = true;
            this.btnLoadPreset.Click += new System.EventHandler(this.btnLoadPreset_Click);
            // 
            // cmbScheduleType
            // 
            this.cmbScheduleType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbScheduleType.FormattingEnabled = true;
            this.cmbScheduleType.Location = new System.Drawing.Point(617, 163);
            this.cmbScheduleType.Name = "cmbScheduleType";
            this.cmbScheduleType.Size = new System.Drawing.Size(121, 27);
            this.cmbScheduleType.TabIndex = 7;
            // 
            // lblScheduleType
            // 
            this.lblScheduleType.AutoSize = true;
            this.lblScheduleType.Location = new System.Drawing.Point(522, 166);
            this.lblScheduleType.Name = "lblScheduleType";
            this.lblScheduleType.Size = new System.Drawing.Size(89, 19);
            this.lblScheduleType.TabIndex = 6;
            this.lblScheduleType.Text = "鳴動種別";
            // 
            // btnStartNStopSchedule
            // 
            this.btnStartNStopSchedule.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnStartNStopSchedule.Location = new System.Drawing.Point(6, 460);
            this.btnStartNStopSchedule.Name = "btnStartNStopSchedule";
            this.btnStartNStopSchedule.Size = new System.Drawing.Size(166, 49);
            this.btnStartNStopSchedule.TabIndex = 10;
            this.btnStartNStopSchedule.Text = "開始";
            this.btnStartNStopSchedule.UseVisualStyleBackColor = true;
            this.btnStartNStopSchedule.Click += new System.EventHandler(this.btnStartNStopSchedule_Click);
            // 
            // btnScheduleAdd
            // 
            this.btnScheduleAdd.Location = new System.Drawing.Point(744, 163);
            this.btnScheduleAdd.Name = "btnScheduleAdd";
            this.btnScheduleAdd.Size = new System.Drawing.Size(166, 27);
            this.btnScheduleAdd.TabIndex = 8;
            this.btnScheduleAdd.Text = "スケジュール追加";
            this.btnScheduleAdd.UseVisualStyleBackColor = true;
            this.btnScheduleAdd.Click += new System.EventHandler(this.btnScheduleAdd_Click);
            // 
            // txtBxScheduleName
            // 
            this.txtBxScheduleName.Location = new System.Drawing.Point(339, 163);
            this.txtBxScheduleName.MaxLength = 50;
            this.txtBxScheduleName.Name = "txtBxScheduleName";
            this.txtBxScheduleName.Size = new System.Drawing.Size(171, 26);
            this.txtBxScheduleName.TabIndex = 5;
            // 
            // スケジュール名称
            // 
            this.スケジュール名称.AutoSize = true;
            this.スケジュール名称.Location = new System.Drawing.Point(187, 166);
            this.スケジュール名称.Name = "スケジュール名称";
            this.スケジュール名称.Size = new System.Drawing.Size(146, 19);
            this.スケジュール名称.TabIndex = 4;
            this.スケジュール名称.Text = "スケジュール名称";
            // 
            // lblPlayTime
            // 
            this.lblPlayTime.AutoSize = true;
            this.lblPlayTime.Location = new System.Drawing.Point(17, 166);
            this.lblPlayTime.Name = "lblPlayTime";
            this.lblPlayTime.Size = new System.Drawing.Size(89, 19);
            this.lblPlayTime.TabIndex = 2;
            this.lblPlayTime.Text = "再生時刻";
            // 
            // txtBxPlayTime
            // 
            this.txtBxPlayTime.Location = new System.Drawing.Point(112, 163);
            this.txtBxPlayTime.MaxLength = 5;
            this.txtBxPlayTime.Name = "txtBxPlayTime";
            this.txtBxPlayTime.Size = new System.Drawing.Size(62, 26);
            this.txtBxPlayTime.TabIndex = 3;
            this.txtBxPlayTime.Text = "08:00";
            this.txtBxPlayTime.Enter += new System.EventHandler(this.txtBxPlayTime_Enter);
            this.txtBxPlayTime.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtBxPlayTime_KeyDown);
            this.txtBxPlayTime.Validating += new System.ComponentModel.CancelEventHandler(this.txtBxPlayTime_Validating);
            // 
            // lblScheduleAdd
            // 
            this.lblScheduleAdd.AutoSize = true;
            this.lblScheduleAdd.Location = new System.Drawing.Point(7, 137);
            this.lblScheduleAdd.Name = "lblScheduleAdd";
            this.lblScheduleAdd.Size = new System.Drawing.Size(166, 19);
            this.lblScheduleAdd.TabIndex = 1;
            this.lblScheduleAdd.Text = "スケジュール追加欄";
            // 
            // lblTimeNow
            // 
            this.lblTimeNow.AutoSize = true;
            this.lblTimeNow.Font = new System.Drawing.Font("MS UI Gothic", 64F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.lblTimeNow.Location = new System.Drawing.Point(6, 22);
            this.lblTimeNow.Name = "lblTimeNow";
            this.lblTimeNow.Size = new System.Drawing.Size(804, 86);
            this.lblTimeNow.TabIndex = 0;
            this.lblTimeNow.Text = "0001/01/01 00:00:00";
            this.lblTimeNow.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnExit
            // 
            this.btnExit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnExit.Font = new System.Drawing.Font("MS UI Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.btnExit.Location = new System.Drawing.Point(801, 460);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(117, 49);
            this.btnExit.TabIndex = 13;
            this.btnExit.Text = "終了";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // dgvAlertList
            // 
            this.dgvAlertList.AllowUserToAddRows = false;
            this.dgvAlertList.AllowUserToDeleteRows = false;
            this.dgvAlertList.AllowUserToResizeRows = false;
            this.dgvAlertList.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle7.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle7.Font = new System.Drawing.Font("MS UI Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            dataGridViewCellStyle7.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle7.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle7.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvAlertList.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle7;
            this.dgvAlertList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvAlertList.Location = new System.Drawing.Point(0, 196);
            this.dgvAlertList.MultiSelect = false;
            this.dgvAlertList.Name = "dgvAlertList";
            this.dgvAlertList.ReadOnly = true;
            this.dgvAlertList.RowTemplate.Height = 21;
            this.dgvAlertList.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvAlertList.Size = new System.Drawing.Size(918, 258);
            this.dgvAlertList.TabIndex = 9;
            // 
            // timerTime
            // 
            this.timerTime.Interval = 1000;
            this.timerTime.Tick += new System.EventHandler(this.timerTime_Tick);
            // 
            // scheduleTimer
            // 
            this.scheduleTimer.Interval = 1000;
            this.scheduleTimer.Tick += new System.EventHandler(this.scheduleTimer_Tick);
            // 
            // btnPlayHotaru
            // 
            this.btnPlayHotaru.Location = new System.Drawing.Point(710, 114);
            this.btnPlayHotaru.Name = "btnPlayHotaru";
            this.btnPlayHotaru.Size = new System.Drawing.Size(161, 42);
            this.btnPlayHotaru.TabIndex = 14;
            this.btnPlayHotaru.Text = "蛍の光 再生";
            this.btnPlayHotaru.UseVisualStyleBackColor = true;
            this.btnPlayHotaru.Click += new System.EventHandler(this.btnPlayHotaru_Click);
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(948, 538);
            this.Controls.Add(this.gbAbout);
            this.MinimumSize = new System.Drawing.Size(964, 407);
            this.Name = "FormMain";
            this.Text = "社内イベントアラートツール";
            this.Load += new System.EventHandler(this.FormMain_Load);
            this.gbAbout.ResumeLayout(false);
            this.gbAbout.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAlertList)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gbAbout;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.DataGridView dgvAlertList;
        private System.Windows.Forms.Label lblTimeNow;
        private System.Windows.Forms.Timer timerTime;
        private System.Windows.Forms.Label lblScheduleAdd;
        private System.Windows.Forms.Button btnScheduleAdd;
        private System.Windows.Forms.TextBox txtBxScheduleName;
        private System.Windows.Forms.Label スケジュール名称;
        private System.Windows.Forms.Label lblPlayTime;
        private System.Windows.Forms.TextBox txtBxPlayTime;
        private System.Windows.Forms.Button btnStartNStopSchedule;
        private System.Windows.Forms.ComboBox cmbScheduleType;
        private System.Windows.Forms.Label lblScheduleType;
        private System.Windows.Forms.Timer scheduleTimer;
        private System.Windows.Forms.Button btnLoadPreset;
        private System.Windows.Forms.Button btnRowDelete;
        private System.Windows.Forms.Button btnPlayHotaru;
    }
}

