namespace IncidentApp
{
    partial class Input
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
            this.Btn_Input = new System.Windows.Forms.Button();
            this.Btn_Close = new System.Windows.Forms.Button();
            this.Lbl_Date = new System.Windows.Forms.Label();
            this.Lbl_Client = new System.Windows.Forms.Label();
            this.Lbl_Person = new System.Windows.Forms.Label();
            this.Lbl_Item = new System.Windows.Forms.Label();
            this.Lbl_Support = new System.Windows.Forms.Label();
            this.Cmb_Item = new System.Windows.Forms.ComboBox();
            this.Rtb_Support = new System.Windows.Forms.RichTextBox();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.Txt_Client = new System.Windows.Forms.TextBox();
            this.Txt_Person = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // Btn_Input
            // 
            this.Btn_Input.Location = new System.Drawing.Point(133, 442);
            this.Btn_Input.Name = "Btn_Input";
            this.Btn_Input.Size = new System.Drawing.Size(98, 40);
            this.Btn_Input.TabIndex = 0;
            this.Btn_Input.Text = "登録";
            this.Btn_Input.UseVisualStyleBackColor = true;
            this.Btn_Input.Click += new System.EventHandler(this.Btn_Input_Click);
            // 
            // Btn_Close
            // 
            this.Btn_Close.Location = new System.Drawing.Point(255, 442);
            this.Btn_Close.Name = "Btn_Close";
            this.Btn_Close.Size = new System.Drawing.Size(98, 40);
            this.Btn_Close.TabIndex = 1;
            this.Btn_Close.Text = "閉じる";
            this.Btn_Close.UseVisualStyleBackColor = true;
            this.Btn_Close.Click += new System.EventHandler(this.button2_Click);
            // 
            // Lbl_Date
            // 
            this.Lbl_Date.AutoSize = true;
            this.Lbl_Date.Location = new System.Drawing.Point(42, 38);
            this.Lbl_Date.Name = "Lbl_Date";
            this.Lbl_Date.Size = new System.Drawing.Size(44, 18);
            this.Lbl_Date.TabIndex = 2;
            this.Lbl_Date.Text = "日付";
            // 
            // Lbl_Client
            // 
            this.Lbl_Client.AutoSize = true;
            this.Lbl_Client.Location = new System.Drawing.Point(42, 86);
            this.Lbl_Client.Name = "Lbl_Client";
            this.Lbl_Client.Size = new System.Drawing.Size(62, 18);
            this.Lbl_Client.TabIndex = 3;
            this.Lbl_Client.Text = "顧客名";
            // 
            // Lbl_Person
            // 
            this.Lbl_Person.AutoSize = true;
            this.Lbl_Person.Location = new System.Drawing.Point(42, 134);
            this.Lbl_Person.Name = "Lbl_Person";
            this.Lbl_Person.Size = new System.Drawing.Size(62, 18);
            this.Lbl_Person.TabIndex = 4;
            this.Lbl_Person.Text = "担当者";
            // 
            // Lbl_Item
            // 
            this.Lbl_Item.AutoSize = true;
            this.Lbl_Item.Location = new System.Drawing.Point(42, 184);
            this.Lbl_Item.Name = "Lbl_Item";
            this.Lbl_Item.Size = new System.Drawing.Size(44, 18);
            this.Lbl_Item.TabIndex = 5;
            this.Lbl_Item.Text = "項目";
            // 
            // Lbl_Support
            // 
            this.Lbl_Support.AutoSize = true;
            this.Lbl_Support.Location = new System.Drawing.Point(42, 240);
            this.Lbl_Support.Name = "Lbl_Support";
            this.Lbl_Support.Size = new System.Drawing.Size(80, 18);
            this.Lbl_Support.TabIndex = 6;
            this.Lbl_Support.Text = "対応内容";
            // 
            // Cmb_Item
            // 
            this.Cmb_Item.FormattingEnabled = true;
            this.Cmb_Item.Items.AddRange(new object[] {
            "ハードウェア",
            "ソフトウェア",
            "ネットワーク",
            "データベース",
            "セキュリティ",
            "その他作業"});
            this.Cmb_Item.Location = new System.Drawing.Point(133, 176);
            this.Cmb_Item.Name = "Cmb_Item";
            this.Cmb_Item.Size = new System.Drawing.Size(201, 26);
            this.Cmb_Item.TabIndex = 7;
            // 
            // Rtb_Support
            // 
            this.Rtb_Support.Location = new System.Drawing.Point(133, 240);
            this.Rtb_Support.Name = "Rtb_Support";
            this.Rtb_Support.Size = new System.Drawing.Size(554, 170);
            this.Rtb_Support.TabIndex = 8;
            this.Rtb_Support.Text = "";
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePicker1.Location = new System.Drawing.Point(133, 33);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(201, 25);
            this.dateTimePicker1.TabIndex = 9;
            this.dateTimePicker1.Value = new System.DateTime(2022, 12, 12, 0, 0, 0, 0);
            // 
            // Txt_Client
            // 
            this.Txt_Client.Location = new System.Drawing.Point(133, 82);
            this.Txt_Client.Name = "Txt_Client";
            this.Txt_Client.Size = new System.Drawing.Size(297, 25);
            this.Txt_Client.TabIndex = 10;
            // 
            // Txt_Person
            // 
            this.Txt_Person.Location = new System.Drawing.Point(133, 128);
            this.Txt_Person.Name = "Txt_Person";
            this.Txt_Person.Size = new System.Drawing.Size(297, 25);
            this.Txt_Person.TabIndex = 11;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(718, 508);
            this.Controls.Add(this.Txt_Person);
            this.Controls.Add(this.Txt_Client);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.Rtb_Support);
            this.Controls.Add(this.Cmb_Item);
            this.Controls.Add(this.Lbl_Support);
            this.Controls.Add(this.Lbl_Item);
            this.Controls.Add(this.Lbl_Person);
            this.Controls.Add(this.Lbl_Client);
            this.Controls.Add(this.Lbl_Date);
            this.Controls.Add(this.Btn_Close);
            this.Controls.Add(this.Btn_Input);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Btn_Input;
        private System.Windows.Forms.Button Btn_Close;
        private System.Windows.Forms.Label Lbl_Date;
        private System.Windows.Forms.Label Lbl_Client;
        private System.Windows.Forms.Label Lbl_Person;
        private System.Windows.Forms.Label Lbl_Item;
        private System.Windows.Forms.Label Lbl_Support;
        private System.Windows.Forms.ComboBox Cmb_Item;
        private System.Windows.Forms.RichTextBox Rtb_Support;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.TextBox Txt_Client;
        private System.Windows.Forms.TextBox Txt_Person;
    }
}

