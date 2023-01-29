using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace IncidentApp
{
    public partial class MainMenu : Form
    {
        public MainMenu()
        {
            InitializeComponent();

            StartPosition = FormStartPosition.CenterScreen;
        }

        
        private void btnCsv_Click(object sender, EventArgs e)
        {
            // CSV出力画面へ移動
            IncidentApp_csv.Form1 csv = new IncidentApp_csv.Form1();
            csv.ShowDialog();
        }
        

        private void btnClose_Click(object sender, EventArgs e)
        {
            // アプリケーションを終了
            Application.Exit();
        }

        private void btnInput_Click(object sender, EventArgs e)
        {
            // 入力画面へ移動
            IncidentApp_Input.Form1 input = new IncidentApp_Input.Form1();
            input.Show();
        }

        private void btnReference_Click(object sender, EventArgs e)
        {
            // 照会画面へ移動
            IncidentApp_Output.Form1 output = new IncidentApp_Output.Form1();
            output.Show();
        }
      
        private void btnReport_Click(object sender, EventArgs e)
        {
            // 帳票出力条件指定画面へ移動
            IncidentAPP_Report.Form2 report = new IncidentAPP_Report.Form2();
            report.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            IncidentApp_Master.form1 master = new IncidentApp_Master.form1();
            master.Show();
        }
    }
}
