namespace IncidentApp_Output
{
    partial class Form1

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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.DgvResult = new System.Windows.Forms.DataGridView();
            this.GroupBox = new System.Windows.Forms.GroupBox();
            this.btnPrint = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
            this.btnSerch = new System.Windows.Forms.Button();
            this.dateTimePicker2 = new System.Windows.Forms.DateTimePicker();
            this.textPerson = new System.Windows.Forms.TextBox();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.cmbItem = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.textClient = new System.Windows.Forms.TextBox();
            this.lblDate2 = new System.Windows.Forms.Label();
            this.lblDate1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.DgvResult)).BeginInit();
            this.GroupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // DgvResult
            // 
            this.DgvResult.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.DgvResult.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("MS UI Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DgvResult.DefaultCellStyle = dataGridViewCellStyle1;
            this.DgvResult.Location = new System.Drawing.Point(14, 276);
            this.DgvResult.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.DgvResult.Name = "DgvResult";
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("MS UI Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            this.DgvResult.RowHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.DgvResult.RowHeadersWidth = 62;
            this.DgvResult.RowTemplate.Height = 21;
            this.DgvResult.Size = new System.Drawing.Size(1398, 416);
            this.DgvResult.TabIndex = 0;
            // 
            // GroupBox
            // 
            this.GroupBox.Controls.Add(this.btnPrint);
            this.GroupBox.Controls.Add(this.btnClose);
            this.GroupBox.Controls.Add(this.btnSerch);
            this.GroupBox.Controls.Add(this.dateTimePicker2);
            this.GroupBox.Controls.Add(this.textPerson);
            this.GroupBox.Controls.Add(this.dateTimePicker1);
            this.GroupBox.Controls.Add(this.cmbItem);
            this.GroupBox.Controls.Add(this.label3);
            this.GroupBox.Controls.Add(this.label2);
            this.GroupBox.Controls.Add(this.label1);
            this.GroupBox.Controls.Add(this.textClient);
            this.GroupBox.Controls.Add(this.lblDate2);
            this.GroupBox.Controls.Add(this.lblDate1);
            this.GroupBox.Font = new System.Drawing.Font("MS UI Gothic", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.GroupBox.Location = new System.Drawing.Point(14, 13);
            this.GroupBox.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.GroupBox.Name = "GroupBox";
            this.GroupBox.Padding = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.GroupBox.Size = new System.Drawing.Size(908, 255);
            this.GroupBox.TabIndex = 1;
            this.GroupBox.TabStop = false;
            this.GroupBox.Text = "条件";
            // 
            // btnPrint
            // 
            this.btnPrint.Location = new System.Drawing.Point(699, 122);
            this.btnPrint.Name = "btnPrint";
            this.btnPrint.Size = new System.Drawing.Size(167, 49);
            this.btnPrint.TabIndex = 7;
            this.btnPrint.Text = "印刷条件";
            this.btnPrint.UseVisualStyleBackColor = true;
            this.btnPrint.Click += new System.EventHandler(this.btnPrint_Click);
            // 
            // btnClose
            // 
            this.btnClose.Location = new System.Drawing.Point(528, 194);
            this.btnClose.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(154, 47);
            this.btnClose.TabIndex = 6;
            this.btnClose.Text = "閉じる";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // btnSerch
            // 
            this.btnSerch.Location = new System.Drawing.Point(528, 120);
            this.btnSerch.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.btnSerch.Name = "btnSerch";
            this.btnSerch.Size = new System.Drawing.Size(154, 51);
            this.btnSerch.TabIndex = 5;
            this.btnSerch.Text = "検索";
            this.btnSerch.UseVisualStyleBackColor = true;
            this.btnSerch.Click += new System.EventHandler(this.btnSerch_Click);
            // 
            // dateTimePicker2
            // 
            this.dateTimePicker2.Location = new System.Drawing.Point(528, 43);
            this.dateTimePicker2.Name = "dateTimePicker2";
            this.dateTimePicker2.Size = new System.Drawing.Size(294, 35);
            this.dateTimePicker2.TabIndex = 1;
            // 
            // textPerson
            // 
            this.textPerson.Location = new System.Drawing.Point(177, 147);
            this.textPerson.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.textPerson.Name = "textPerson";
            this.textPerson.Size = new System.Drawing.Size(294, 35);
            this.textPerson.TabIndex = 3;
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(176, 43);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(294, 35);
            this.dateTimePicker1.TabIndex = 0;
            // 
            // cmbItem
            // 
            this.cmbItem.FormattingEnabled = true;
            this.cmbItem.Items.AddRange(new object[] {
            "ハードウェア",
            "ソフトウェア",
            "ネットワーク",
            "データベース",
            "セキュリティ",
            "その他作業"});
            this.cmbItem.Location = new System.Drawing.Point(177, 194);
            this.cmbItem.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.cmbItem.MaxDropDownItems = 5;
            this.cmbItem.Name = "cmbItem";
            this.cmbItem.Size = new System.Drawing.Size(294, 36);
            this.cmbItem.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(72, 194);
            this.label3.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(70, 28);
            this.label3.TabIndex = 13;
            this.label3.Text = "項目";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(43, 147);
            this.label2.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(99, 28);
            this.label2.TabIndex = 12;
            this.label2.Text = "担当者";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("MS UI Gothic", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label1.Location = new System.Drawing.Point(43, 98);
            this.label1.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(99, 28);
            this.label1.TabIndex = 11;
            this.label1.Text = "会社名";
            // 
            // textClient
            // 
            this.textClient.Location = new System.Drawing.Point(176, 98);
            this.textClient.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.textClient.Name = "textClient";
            this.textClient.Size = new System.Drawing.Size(294, 35);
            this.textClient.TabIndex = 2;
            // 
            // lblDate2
            // 
            this.lblDate2.AutoSize = true;
            this.lblDate2.Location = new System.Drawing.Point(478, 50);
            this.lblDate2.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.lblDate2.Name = "lblDate2";
            this.lblDate2.Size = new System.Drawing.Size(41, 28);
            this.lblDate2.TabIndex = 10;
            this.lblDate2.Text = "～";
            // 
            // lblDate1
            // 
            this.lblDate1.Font = new System.Drawing.Font("MS UI Gothic", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.lblDate1.Location = new System.Drawing.Point(57, 43);
            this.lblDate1.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.lblDate1.Name = "lblDate1";
            this.lblDate1.Size = new System.Drawing.Size(85, 30);
            this.lblDate1.TabIndex = 9;
            this.lblDate1.Text = "期間";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1426, 722);
            this.Controls.Add(this.GroupBox);
            this.Controls.Add(this.DgvResult);
            this.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.MaximumSize = new System.Drawing.Size(1730, 992);
            this.Name = "Form1";
            this.Text = "検索";
            ((System.ComponentModel.ISupportInitialize)(this.DgvResult)).EndInit();
            this.GroupBox.ResumeLayout(false);
            this.GroupBox.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView DgvResult;
        private System.Windows.Forms.GroupBox GroupBox;
        private System.Windows.Forms.Button btnSerch;
        private System.Windows.Forms.Label lblDate2;
        private System.Windows.Forms.Label lblDate1;
        private System.Windows.Forms.TextBox textClient;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textPerson;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cmbItem;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.DateTimePicker dateTimePicker2;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Button btnPrint;
    }
}

