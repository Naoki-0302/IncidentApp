using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace IncidentAPP_Report
{
    public partial class Form2 : Form
    {

        public Form2()
        {
            InitializeComponent();

            StartPosition = FormStartPosition.CenterScreen;
        }

      
        public void btnOK_Click(object sender, EventArgs e)
        {
            // ReportViewerへ検索条件を引き渡す
            Form1 form1 = new Form1();
            form1.date1 = dateTimePicker1.Value.ToShortDateString();
            form1.date2 = dateTimePicker2.Value.ToShortDateString();
            form1.client = textClient.Text;
            form1.person = textPerson.Text;
            form1.item = cmbItem.Text;
            form1.Show();
        }

       
        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
