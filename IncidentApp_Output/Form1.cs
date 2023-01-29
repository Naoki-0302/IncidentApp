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
using static System.Runtime.CompilerServices.RuntimeHelpers;

namespace IncidentApp_Output
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            // フォームをセンタースクリーン表示
            StartPosition = FormStartPosition.CenterScreen;
        }

       



        private void btnSerch_Click(object sender, EventArgs e)
        {
            // SQLコネクションの用意
            SqlConnection con = new SqlConnection();
            string sql = "";
            string sqlClient= "";
            string sqlPerson = "";
            string sqlItem = "";


            try
            {
                // 接続文字列の構築
                SqlConnectionStringBuilder builder = new SqlConnectionStringBuilder();
                builder.DataSource = "(local)";      
                builder.InitialCatalog = "Input";   
                builder.UserID = "sa";              
                builder.Password = "0302";
                // 接続タイムアウトの秒数(ms) デフォルトは 15 秒
                // builder.ConnectTimeout = 60000;  
                                                    
                con.ConnectionString = builder.ConnectionString;
                // SQLServer接続
                con.Open();



                // DataAdapter 一括取得
                DataTable dt = new DataTable();
                SqlDataAdapter da = new SqlDataAdapter();
                // 参照変数を初期化
                SqlCommand cmd = con.CreateCommand();
                cmd.CommandTimeout = 60000; // コマンドがタイムアウトする場合は秒数を変更(ms) デフォルトは 30秒




                sql = "SELECT * FROM INPUTTABLE WHERE DATE BETWEEN @期間1 AND @期間2  ";
                sqlClient = "";
                sqlPerson = "";
                sqlItem = "";

                // 会社名が空欄
                if (textClient.Text != "")

                    sqlClient = " AND CLIENT LIKE @client";
                // 担当者が空欄
                if (textPerson.Text  != "")
                    sqlPerson = " AND PERSON = @person";
                // 項目が空欄
                if (cmbItem.Text != "")
                    sqlItem = " AND ITEM = @item";

                string ord = " ORDER BY DATE";

                sql = sql + sqlClient + sqlPerson + sqlItem + ord;
           
                // query
                cmd.CommandText = sql;

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


                da.SelectCommand = cmd;
                da.Fill(dt);



                // データソースクリア
                // 繰り返し検索できるように,データの表示をリセットできるようにしている
                this.DgvResult.DataSource = null;   
                if (dt.Rows.Count > 0)
                {
                    // DataGridViewのDataSourceプロパティにDataTableの情報を代入することで表示できるようになる
                    this.DgvResult.DataSource = dt;  

                    DgvResult.Columns[0].Width = 25;
                    DgvResult.Columns[1].Width = 100;
                    DgvResult.Columns[2].Width = 200;
                    DgvResult.Columns[3].Width = 100;
                    DgvResult.Columns[4].Width = 100;
                    DgvResult.Columns[5].Width = 550;

                    //行ヘッダを非表示にする
                    DgvResult.RowHeadersVisible = false;
                }
                else
                {
                    MessageBox.Show("検索結果は0件です。");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "エラー");
            }
            finally
            {
                con.Close();
                con.Dispose();
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnPrint_Click(object sender, EventArgs e)
        {
            // 照会条件を印刷条件へ
            IncidentAPP_Report.Form2 form2 = new IncidentAPP_Report.Form2();
            form2.Show();
            form2.dateTimePicker1.Value = this.dateTimePicker1.Value;
            form2.dateTimePicker2.Value = this.dateTimePicker2.Value;
            form2.textClient.Text = this.textClient.Text;
            form2.textPerson.Text = this.textPerson.Text;
            form2.cmbItem.Text = this.cmbItem.Text;
        }
    }
}
