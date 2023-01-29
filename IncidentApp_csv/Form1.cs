using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Tab;


namespace IncidentApp_csv
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            StartPosition = FormStartPosition.CenterScreen;
        }

       
        private void btnCsv_Click(object sender, EventArgs e)
        {

            // 変数作成
            string ID;
            string date;
            string client;
            string person;
            string item;
            string support;

            // 接続するためのインスタンス生成
            SqlConnection con = new SqlConnection();

            try
            {
                SqlConnectionStringBuilder builder = new SqlConnectionStringBuilder();
                builder.DataSource = "(local)";
                builder.InitialCatalog = "Input";
                builder.UserID = "sa";
                builder.Password = "0302";
                con.ConnectionString = builder.ConnectionString;
                con.Open();



                // SqlCommand cmd = new SqlCommand("SELECT * FROM InputTable;", con);
                SqlCommand cmd = con.CreateCommand();
               
                string Sql = "SELECT * FROM INPUTTABLE WHERE DATE BETWEEN @期間1 AND @期間2  ";
                string sqlClient = "";
                string sqlPerson = "";
                string sqlItem = "";

                // 会社名が空欄
                if (textClient.Text != "")

                    sqlClient = " AND CLIENT LIKE @client";
                // 担当者が空欄
                if (textPerson.Text != "")
                    sqlPerson = " AND PERSON = @person";
                // 項目が空欄
                if (cmbItem.Text != "")
                    sqlItem = " AND ITEM = @item";

                string ord = " ORDER BY DATE";

                Sql = Sql + sqlClient + sqlPerson + sqlItem + ord;

                // query
                cmd.CommandText = Sql;

                // パラメーターの設定
                cmd.Parameters.Add("@期間1", SqlDbType.Date);
                cmd.Parameters["@期間1"].Value = dateTimePicker1.Value.ToShortDateString();
                cmd.Parameters.Add("@期間2", SqlDbType.Date);
                cmd.Parameters["@期間2"].Value = dateTimePicker2.Value.ToShortDateString();
                cmd.Parameters.Add("@client", SqlDbType.NVarChar, 50);
                cmd.Parameters["@client"].Value = "%" + textClient.Text + "%";
                cmd.Parameters.Add("@person", SqlDbType.NChar, 10);
                cmd.Parameters["@person"].Value = textPerson.Text;
                cmd.Parameters.Add("@item", SqlDbType.NVarChar, 20);
                cmd.Parameters["@item"].Value = cmbItem.Text;


                SqlDataReader reader = cmd.ExecuteReader();


                string filepath;

                if(saveFileDialog1.ShowDialog() == DialogResult.OK)
                {
                    filepath = saveFileDialog1.FileName;
                }
                else
                {
                    return;
                }


                // 第2引数はtrueなら上書き
                StreamWriter sw = new StreamWriter(filepath, false, Encoding.Default);
                    while (reader.Read())
                    {
                        // DBからデータを取得
                        ID = reader.GetValue(0).ToString();
                        date = reader.GetValue(1).ToString();
                        client = reader.GetValue(2).ToString();
                        person = reader.GetValue(3).ToString();
                        item = reader.GetValue(4).ToString();
                        support = reader.GetValue(5).ToString();


                        // CSVに書き込む
                        sw.WriteLine(ID + "," + date + "," + client + "," + person + "," + item + "," + support);
                    }

                MessageBox.Show("CSV出力が完了しました。", "完了", MessageBoxButtons.OK, MessageBoxIcon.Information);
                sw.Close();
               
            }

            // 例外処理
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "エラー");
            }
            // 必ず通る処理
            finally
            {    
                // 接続を解除
                con.Close();
                con.Dispose();
            }

        }

       
        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}