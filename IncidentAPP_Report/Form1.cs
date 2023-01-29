using Microsoft.Reporting.WinForms;
using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Drawing.Printing;
using System.Linq;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Tab;

namespace IncidentAPP_Report
{
    public partial class Form1 : Form
    {
        // Form2で入力された値を受け取るフィールド
        public string date1;
        public string date2;
        public string client;
        public string person;
        public string item;

        public Form1()
        {
            InitializeComponent();
        }

        public void Form1_Load(object sender, EventArgs e)
        {
            // フォームの最大化
            this.WindowState = FormWindowState.Maximized;

            // プリンタ設定オブジェクト
            PageSettings ps = new PageSettings();
            //余白
            ps.Margins.Bottom = 1;
            ps.Margins.Top = 1;
            ps.Margins.Left = 1;
            ps.Margins.Right = 1;
            // 印刷の向きの設定
            ps.Landscape = true;
            // ReportViewer オブジェクトの設定
            reportViewer1.SetPageSettings(ps);




            // 会社名に関してはLike演算子を使用

            // Fill1メソッド(条件：期間)
            if ((client == "") &&
                (person == "") &&
                (item == ""))
            {
                this.inputTableTableAdapter.Fill1(this.inputDataSet.InputTable, date1, date2);
                this.reportViewer1.RefreshReport();
            }
            // Fill2メソッド(条件：期間 + 項目)
            else if ((client == "") &&
                     (person == ""))
            {
                this.inputTableTableAdapter.Fill2(this.inputDataSet.InputTable, date1, date2, item);
                this.reportViewer1.RefreshReport();
            }
            // Fill3メソッド(条件：期間 + 担当者)
            else if ((client == "") &&
                     (item == ""))
            {
                this.inputTableTableAdapter.Fill3(this.inputDataSet.InputTable, date1, date2, person);
                this.reportViewer1.RefreshReport();
            }
            // Fill4メソッド(条件：期間 + 会社名)
            else if ((person == "") &&
                     (item == ""))
            {
                client = "%" + client + "%";
                this.inputTableTableAdapter.Fill4(this.inputDataSet.InputTable, date1, date2, client);
                this.reportViewer1.RefreshReport();
            }
            // Fill5メソッド(条件：期間 + 担当者 + 項目)
            else if (client == "")
            {
                this.inputTableTableAdapter.Fill5(this.inputDataSet.InputTable, date1, date2, person, item);
                this.reportViewer1.RefreshReport();
            }
            // Fill6メソッド(条件：期間 + 会社名 + 担当者)
            else if (item == "")
            {
                client = "%" + client + "%";
                this.inputTableTableAdapter.Fill6(this.inputDataSet.InputTable, date1, date2, client, person);
                this.reportViewer1.RefreshReport();
            }
            // Fill7メソッド(条件：期間 + 会社名 + 項目)
            else if (person == "")
            {
                client = "%" + client + "%";
                this.inputTableTableAdapter.Fill7(this.inputDataSet.InputTable, date1, date2, client, item);
                this.reportViewer1.RefreshReport();
            }
            // Fillメソッド(条件：全入力)
            else
            {
                client = "%" + client + "%";
                // todo: このコード行はデータを 'inputdataset.inputtable' テーブルに読み込みます。必要に応じて移動、または削除をしてください。
                this.inputTableTableAdapter.Fill(this.inputDataSet.InputTable, date1, date2, client, person, item);
                this.reportViewer1.RefreshReport();

            }





        }
            
    }
}
