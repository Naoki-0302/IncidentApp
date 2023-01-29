namespace IncidentApp_Input
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
            this.btnRegister = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
            this.Lbl_Date = new System.Windows.Forms.Label();
            this.Lbl_Client = new System.Windows.Forms.Label();
            this.Lbl_Person = new System.Windows.Forms.Label();
            this.Lbl_Item = new System.Windows.Forms.Label();
            this.Lbl_Support = new System.Windows.Forms.Label();
            this.cmbItem = new System.Windows.Forms.ComboBox();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.textClient = new System.Windows.Forms.TextBox();
            this.textPerson = new System.Windows.Forms.TextBox();
            this.textSupport = new System.Windows.Forms.TextBox();
            this.btnClear = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.nudID = new System.Windows.Forms.NumericUpDown();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnEdit = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.nudID)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnRegister
            // 
            this.btnRegister.Location = new System.Drawing.Point(18, 12);
            this.btnRegister.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnRegister.Name = "btnRegister";
            this.btnRegister.Size = new System.Drawing.Size(57, 35);
            this.btnRegister.TabIndex = 6;
            this.btnRegister.Text = "登録";
            this.btnRegister.UseVisualStyleBackColor = true;
            this.btnRegister.Click += new System.EventHandler(this.btnRegister_Click);
            // 
            // btnClose
            // 
            this.btnClose.Location = new System.Drawing.Point(334, 12);
            this.btnClose.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(57, 35);
            this.btnClose.TabIndex = 10;
            this.btnClose.Text = "閉じる";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // Lbl_Date
            // 
            this.Lbl_Date.AutoSize = true;
            this.Lbl_Date.Font = new System.Drawing.Font("MS UI Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.Lbl_Date.Location = new System.Drawing.Point(31, 105);
            this.Lbl_Date.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.Lbl_Date.Name = "Lbl_Date";
            this.Lbl_Date.Size = new System.Drawing.Size(41, 16);
            this.Lbl_Date.TabIndex = 2;
            this.Lbl_Date.Text = "日付";
            // 
            // Lbl_Client
            // 
            this.Lbl_Client.AutoSize = true;
            this.Lbl_Client.Font = new System.Drawing.Font("MS UI Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.Lbl_Client.Location = new System.Drawing.Point(23, 137);
            this.Lbl_Client.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.Lbl_Client.Name = "Lbl_Client";
            this.Lbl_Client.Size = new System.Drawing.Size(58, 16);
            this.Lbl_Client.TabIndex = 3;
            this.Lbl_Client.Text = "顧客名";
            // 
            // Lbl_Person
            // 
            this.Lbl_Person.AutoSize = true;
            this.Lbl_Person.Font = new System.Drawing.Font("MS UI Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.Lbl_Person.Location = new System.Drawing.Point(23, 166);
            this.Lbl_Person.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.Lbl_Person.Name = "Lbl_Person";
            this.Lbl_Person.Size = new System.Drawing.Size(58, 16);
            this.Lbl_Person.TabIndex = 4;
            this.Lbl_Person.Text = "担当者";
            // 
            // Lbl_Item
            // 
            this.Lbl_Item.AutoSize = true;
            this.Lbl_Item.Font = new System.Drawing.Font("MS UI Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.Lbl_Item.Location = new System.Drawing.Point(31, 197);
            this.Lbl_Item.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.Lbl_Item.Name = "Lbl_Item";
            this.Lbl_Item.Size = new System.Drawing.Size(41, 16);
            this.Lbl_Item.TabIndex = 5;
            this.Lbl_Item.Text = "項目";
            // 
            // Lbl_Support
            // 
            this.Lbl_Support.AutoSize = true;
            this.Lbl_Support.Font = new System.Drawing.Font("MS UI Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.Lbl_Support.Location = new System.Drawing.Point(16, 226);
            this.Lbl_Support.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.Lbl_Support.Name = "Lbl_Support";
            this.Lbl_Support.Size = new System.Drawing.Size(75, 16);
            this.Lbl_Support.TabIndex = 6;
            this.Lbl_Support.Text = "対応内容";
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
            this.cmbItem.Location = new System.Drawing.Point(93, 196);
            this.cmbItem.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.cmbItem.Name = "cmbItem";
            this.cmbItem.Size = new System.Drawing.Size(180, 20);
            this.cmbItem.TabIndex = 4;
            this.cmbItem.SelectedIndexChanged += new System.EventHandler(this.cmbItem_SelectedIndexChanged);
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Checked = false;
            this.dateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePicker1.Location = new System.Drawing.Point(93, 106);
            this.dateTimePicker1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(180, 19);
            this.dateTimePicker1.TabIndex = 1;
            this.dateTimePicker1.ValueChanged += new System.EventHandler(this.dateTimePicker1_ValueChanged);
            // 
            // textClient
            // 
            this.textClient.Location = new System.Drawing.Point(93, 136);
            this.textClient.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.textClient.Name = "textClient";
            this.textClient.Size = new System.Drawing.Size(180, 19);
            this.textClient.TabIndex = 2;
            this.textClient.TextChanged += new System.EventHandler(this.textClient_TextChanged);
            // 
            // textPerson
            // 
            this.textPerson.Location = new System.Drawing.Point(93, 165);
            this.textPerson.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.textPerson.Name = "textPerson";
            this.textPerson.Size = new System.Drawing.Size(180, 19);
            this.textPerson.TabIndex = 3;
            this.textPerson.TextChanged += new System.EventHandler(this.textPerson_TextChanged);
            // 
            // textSupport
            // 
            this.textSupport.AcceptsReturn = true;
            this.textSupport.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textSupport.Location = new System.Drawing.Point(19, 251);
            this.textSupport.Multiline = true;
            this.textSupport.Name = "textSupport";
            this.textSupport.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textSupport.Size = new System.Drawing.Size(428, 213);
            this.textSupport.TabIndex = 5;
            this.textSupport.TextChanged += new System.EventHandler(this.textSupport_TextChanged);
            // 
            // btnClear
            // 
            this.btnClear.Location = new System.Drawing.Point(176, 12);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(57, 35);
            this.btnClear.TabIndex = 8;
            this.btnClear.Text = "クリア";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("MS UI Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label1.Location = new System.Drawing.Point(40, 80);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(23, 16);
            this.label1.TabIndex = 8;
            this.label1.Text = "ID";
            // 
            // nudID
            // 
            this.nudID.Location = new System.Drawing.Point(93, 80);
            this.nudID.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.nudID.Name = "nudID";
            this.nudID.Size = new System.Drawing.Size(72, 19);
            this.nudID.TabIndex = 0;
            this.nudID.ValueChanged += new System.EventHandler(this.nudID_ValueChanged);
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(255, 12);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(57, 35);
            this.btnDelete.TabIndex = 9;
            this.btnDelete.Text = "削除";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnEdit
            // 
            this.btnEdit.Location = new System.Drawing.Point(97, 12);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(57, 35);
            this.btnEdit.TabIndex = 7;
            this.btnEdit.Text = "編集";
            this.btnEdit.UseVisualStyleBackColor = true;
            this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panel1.Controls.Add(this.btnRegister);
            this.panel1.Controls.Add(this.btnDelete);
            this.panel1.Controls.Add(this.btnEdit);
            this.panel1.Controls.Add(this.btnClose);
            this.panel1.Controls.Add(this.btnClear);
            this.panel1.Location = new System.Drawing.Point(15, 11);
            this.panel1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(430, 57);
            this.panel1.TabIndex = 12;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(459, 525);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.nudID);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textSupport);
            this.Controls.Add(this.textPerson);
            this.Controls.Add(this.textClient);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.cmbItem);
            this.Controls.Add(this.Lbl_Support);
            this.Controls.Add(this.Lbl_Item);
            this.Controls.Add(this.Lbl_Person);
            this.Controls.Add(this.Lbl_Client);
            this.Controls.Add(this.Lbl_Date);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "Form1";
            this.Text = "入力処理";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.nudID)).EndInit();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnRegister;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Label Lbl_Date;
        private System.Windows.Forms.Label Lbl_Client;
        private System.Windows.Forms.Label Lbl_Person;
        private System.Windows.Forms.Label Lbl_Item;
        private System.Windows.Forms.Label Lbl_Support;
        private System.Windows.Forms.ComboBox cmbItem;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.TextBox textClient;
        private System.Windows.Forms.TextBox textPerson;
        private System.Windows.Forms.TextBox textSupport;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.NumericUpDown nudID;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnEdit;
        private System.Windows.Forms.Panel panel1;
    }
}

