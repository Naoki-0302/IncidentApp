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
        }

        private void label_Title_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            IncidentApp_csv.Form1 csv = new IncidentApp_csv.Form1();
            csv.ShowDialog();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Close();  //フォームを終了
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //Input input = new Input();
            //input.ShowDialog();    //Show() or ShowDialog()

            IncidentApp_Input.Form1 input = new IncidentApp_Input.Form1();
            input.ShowDialog();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            IncidentApp_Output.Form1 output = new IncidentApp_Output.Form1();
            output.ShowDialog();
        }
    }
}
