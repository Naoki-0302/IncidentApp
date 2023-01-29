namespace IncidentAPP_Report
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
            this.components = new System.ComponentModel.Container();
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource1 = new Microsoft.Reporting.WinForms.ReportDataSource();
            this.inputTableBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.inputDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.inputDataSet = new IncidentAPP_Report.InputDataSet();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.inputTableBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.inputTableBindingSource2 = new System.Windows.Forms.BindingSource(this.components);
            this.inputTableBindingSource3 = new System.Windows.Forms.BindingSource(this.components);
            this.inputDataSetBindingSource2 = new System.Windows.Forms.BindingSource(this.components);
            this.inputTableBindingSource4 = new System.Windows.Forms.BindingSource(this.components);
            this.inputTableTableAdapter = new IncidentAPP_Report.InputDataSetTableAdapters.InputTableTableAdapter();
            this.inputDataSetBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.inputTableBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.inputDataSetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.inputDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.inputTableBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.inputTableBindingSource2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.inputTableBindingSource3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.inputDataSetBindingSource2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.inputTableBindingSource4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.inputDataSetBindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // inputTableBindingSource
            // 
            this.inputTableBindingSource.DataMember = "InputTable";
            this.inputTableBindingSource.DataSource = this.inputDataSetBindingSource;
            // 
            // inputDataSetBindingSource
            // 
            this.inputDataSetBindingSource.DataSource = this.inputDataSet;
            this.inputDataSetBindingSource.Position = 0;
            // 
            // inputDataSet
            // 
            this.inputDataSet.DataSetName = "InputDataSet";
            this.inputDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // reportViewer1
            // 
            this.reportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource1.Name = "InputDataSet";
            reportDataSource1.Value = this.inputTableBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "IncidentAPP_Report.Report1.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(0, 0);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.ServerReport.BearerToken = null;
            this.reportViewer1.Size = new System.Drawing.Size(849, 617);
            this.reportViewer1.TabIndex = 0;
            this.reportViewer1.ZoomMode = Microsoft.Reporting.WinForms.ZoomMode.PageWidth;
            // 
            // inputTableBindingSource1
            // 
            this.inputTableBindingSource1.DataMember = "InputTable";
            this.inputTableBindingSource1.DataSource = this.inputDataSetBindingSource;
            // 
            // inputTableBindingSource2
            // 
            this.inputTableBindingSource2.DataMember = "InputTable";
            this.inputTableBindingSource2.DataSource = this.inputDataSetBindingSource;
            // 
            // inputTableBindingSource3
            // 
            this.inputTableBindingSource3.DataMember = "InputTable";
            this.inputTableBindingSource3.DataSource = this.inputDataSetBindingSource2;
            // 
            // inputDataSetBindingSource2
            // 
            this.inputDataSetBindingSource2.DataSource = this.inputDataSet;
            this.inputDataSetBindingSource2.Position = 0;
            // 
            // inputTableBindingSource4
            // 
            this.inputTableBindingSource4.DataMember = "InputTable";
            this.inputTableBindingSource4.DataSource = this.inputDataSetBindingSource;
            // 
            // inputTableTableAdapter
            // 
            this.inputTableTableAdapter.ClearBeforeFill = true;
            // 
            // inputDataSetBindingSource1
            // 
            this.inputDataSetBindingSource1.DataSource = this.inputDataSet;
            this.inputDataSetBindingSource1.Position = 0;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(849, 617);
            this.Controls.Add(this.reportViewer1);
            this.Name = "Form1";
            this.Text = "帳票出力";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.inputTableBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.inputDataSetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.inputDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.inputTableBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.inputTableBindingSource2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.inputTableBindingSource3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.inputDataSetBindingSource2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.inputTableBindingSource4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.inputDataSetBindingSource1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource inputDataSetBindingSource;
        private InputDataSet inputDataSet;
        private System.Windows.Forms.BindingSource inputTableBindingSource;
        private InputDataSetTableAdapters.InputTableTableAdapter inputTableTableAdapter;
        private System.Windows.Forms.BindingSource inputTableBindingSource1;
        private System.Windows.Forms.BindingSource inputTableBindingSource4;
        private System.Windows.Forms.BindingSource inputDataSetBindingSource1;
        private System.Windows.Forms.BindingSource inputDataSetBindingSource2;
        private System.Windows.Forms.BindingSource inputTableBindingSource2;
        private System.Windows.Forms.BindingSource inputTableBindingSource3;
    }
}

