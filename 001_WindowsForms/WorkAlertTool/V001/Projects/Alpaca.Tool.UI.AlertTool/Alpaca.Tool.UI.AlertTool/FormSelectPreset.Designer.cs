namespace Alpaca.Tool.UI.AlertTool
{
    partial class FormSelectPreset
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
            this.gbPresetList = new System.Windows.Forms.GroupBox();
            this.dgvPreset = new System.Windows.Forms.DataGridView();
            this.btnOK = new System.Windows.Forms.Button();
            this.lblDesc = new System.Windows.Forms.Label();
            this.gbPresetList.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPreset)).BeginInit();
            this.SuspendLayout();
            // 
            // gbPresetList
            // 
            this.gbPresetList.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gbPresetList.Controls.Add(this.dgvPreset);
            this.gbPresetList.Location = new System.Drawing.Point(13, 54);
            this.gbPresetList.Name = "gbPresetList";
            this.gbPresetList.Size = new System.Drawing.Size(488, 240);
            this.gbPresetList.TabIndex = 0;
            this.gbPresetList.TabStop = false;
            this.gbPresetList.Text = "プリセット一覧";
            // 
            // dgvPreset
            // 
            this.dgvPreset.AllowUserToAddRows = false;
            this.dgvPreset.AllowUserToDeleteRows = false;
            this.dgvPreset.AllowUserToResizeRows = false;
            this.dgvPreset.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvPreset.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPreset.Location = new System.Drawing.Point(7, 19);
            this.dgvPreset.MultiSelect = false;
            this.dgvPreset.Name = "dgvPreset";
            this.dgvPreset.ReadOnly = true;
            this.dgvPreset.RowTemplate.Height = 21;
            this.dgvPreset.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvPreset.Size = new System.Drawing.Size(475, 215);
            this.dgvPreset.TabIndex = 0;
            // 
            // btnOK
            // 
            this.btnOK.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnOK.Location = new System.Drawing.Point(13, 309);
            this.btnOK.Name = "btnOK";
            this.btnOK.Size = new System.Drawing.Size(488, 39);
            this.btnOK.TabIndex = 1;
            this.btnOK.Text = "OK";
            this.btnOK.UseVisualStyleBackColor = true;
            this.btnOK.Click += new System.EventHandler(this.btnOK_Click);
            // 
            // lblDesc
            // 
            this.lblDesc.AutoSize = true;
            this.lblDesc.Location = new System.Drawing.Point(11, 27);
            this.lblDesc.Name = "lblDesc";
            this.lblDesc.Size = new System.Drawing.Size(238, 12);
            this.lblDesc.TabIndex = 2;
            this.lblDesc.Text = "▼以下のプリセットスケジュールを読み込みました。";
            // 
            // FormSelectPreset
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(513, 360);
            this.Controls.Add(this.lblDesc);
            this.Controls.Add(this.btnOK);
            this.Controls.Add(this.gbPresetList);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormSelectPreset";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.Text = "FormSelectPreset";
            this.Load += new System.EventHandler(this.FormSelectPreset_Load);
            this.gbPresetList.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvPreset)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox gbPresetList;
        private System.Windows.Forms.DataGridView dgvPreset;
        private System.Windows.Forms.Button btnOK;
        private System.Windows.Forms.Label lblDesc;
    }
}