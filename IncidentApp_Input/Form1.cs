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
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Tab;

namespace IncidentApp_Input
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            StartPosition = FormStartPosition.CenterScreen;
        }


        private void btnClose_Click(object sender, EventArgs e)
        {
            // 入力画面を閉じる
            this.Close();
        }

        private void btnRegister_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection();
            // ここにtran変数を作ることで,try...catch内でも読み取れるようにする
            SqlTransaction tran = null;


            try
            {
                // 接続文字列の構築
                SqlConnectionStringBuilder builder = new SqlConnectionStringBuilder();
                builder.DataSource = "(local)";
                builder.InitialCatalog = "Input";
                builder.UserID = "sa";
                builder.Password = "0302";
                con.ConnectionString = builder.ConnectionString;

                // DB接続
                con.Open();


                // DB操作
                // トランザクション開始  select文以外は必要
                tran = con.BeginTransaction();
                // 初期化
                SqlCommand cmd = con.CreateCommand();

                // トランザクションにコマンドを関連付ける
                cmd.Transaction = tran;
                //query
                cmd.CommandText = "INSERT INTO INPUTTABLE(DATE,CLIENT,PERSON,ITEM,SUPPORT) VALUES (@date,@client,@person,@item,@support) ";

                // パラメーターの設定   (SQLインジェクション対策   危険な文字列はすべてエスケープされる)
                cmd.Parameters.AddWithValue("@date", dateTimePicker1.Value.Date.ToShortDateString());
                cmd.Parameters.AddWithValue("@client", textClient.Text);
                cmd.Parameters.AddWithValue("@person", textPerson.Text);
                cmd.Parameters.AddWithValue("@item", cmbItem.Text);
                cmd.Parameters.AddWithValue("@support", textSupport.Text);


                // SQL実行 実行した件数が帰ってくる, cmd.ExecuteNonQuery();だけでもOK
                int i = cmd.ExecuteNonQuery();
                MessageBox.Show(i + "件の登録が完了しました。", "登録完了");

                // コミット(正常終了)
                tran.Commit();


                nudID.Value = 0;
                dateTimePicker1.Value = DateTime.Now;
                textClient.Text = "";
                textPerson.Text = "";
                cmbItem.Text = "";
                textSupport.Text = "";


            }
            catch (Exception ex)
            {
                // トランザクションが有効な場合
                if (tran != null)
                {
                    // ロールバック(異常終了)
                    tran.Rollback();
                }
                MessageBox.Show(ex.Message, "エラー");
            }
            finally
            {
                con.Close();
                con.Dispose();
            }

        }
        private void btnClear_Click(object sender, EventArgs e)
        {
            // テキストボックス内の文字列をクリアする

            nudID.Value = 0;
            dateTimePicker1.Value = DateTime.Now;
            textClient.Text = "";
            textPerson.Text = "";
            cmbItem.Text = "";
            textSupport.Text = "";

        }

        private void textClient_TextChanged(object sender, EventArgs e)
        {

        }

        private void cmbItem_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void textPerson_TextChanged(object sender, EventArgs e)
        {

        }

        private void textSupport_TextChanged(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }



        private static readonly string UpdateSql = @"UPDATE InputTable
                                                     SET Date=@date,Client=@client,Person=@person,Item=@item,Support=@support
                                                     WHERE ID = @id";
        private void btnEdit_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection();

            try
            {
                SqlConnectionStringBuilder builder = new SqlConnectionStringBuilder();
                builder.DataSource = "(local)";
                builder.InitialCatalog = "Input";
                builder.UserID = "sa";
                builder.Password = "0302";
                con.ConnectionString = builder.ConnectionString;

                // DB接続
                con.Open();

                SqlCommand cmd = con.CreateCommand();
                cmd.CommandText = UpdateSql;
                cmd.Parameters.AddWithValue("@id", nudID.Value);
                cmd.Parameters.AddWithValue("@date", dateTimePicker1.Value.Date.ToShortDateString());
                cmd.Parameters.AddWithValue("@client", textClient.Text);
                cmd.Parameters.AddWithValue("@person", textPerson.Text);
                cmd.Parameters.AddWithValue("@item", cmbItem.Text);
                cmd.Parameters.AddWithValue("@support", textSupport.Text);
                

                // SQL実行 実行した件数が帰ってくる, cmd.ExecuteNonQuery();だけでもOK
                int i = cmd.ExecuteNonQuery();
                MessageBox.Show(i + "件の修正が完了しました。", "修正完了");


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

        private void nudID_ValueChanged(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection();

            try
            {


                DateTime date ;
                string client = "";
                string person = "";
                string item = "";
                string support = "";



                SqlConnectionStringBuilder builder = new SqlConnectionStringBuilder();
                builder.DataSource = "(local)";
                builder.InitialCatalog = "Input";
                builder.UserID = "sa";
                builder.Password = "0302";
                con.ConnectionString = builder.ConnectionString;

                // DB接続
                con.Open();

                SqlCommand cmd = con.CreateCommand();
                cmd.CommandText = @"SELECT * FROM InputTable WHERE ID = @id";
                cmd.Parameters.AddWithValue("@id", nudID.Value);

                date = DateTime.Now;
                textClient.Clear();
                textPerson.Clear();
                cmbItem.Text = "";
                textSupport.Clear();
                

                // SQLを実行します。
                SqlDataReader reader = cmd.ExecuteReader();


                // 結果を表示します。
                while (reader.Read())
                {
                    // id = (int)reader.GetValue(0);
                    date = (DateTime)reader.GetValue(1);
                    client = (string)reader.GetValue(2);
                    person = (string)reader.GetValue(3);
                    item  = (string)reader.GetValue(4);
                    support = (string)reader.GetValue(5);


                    /*
                    Console.WriteLine("ID:" + id + " ユーザー名:" + name + " パスワード:" + pass);
                    Console.ReadKey();
                    */

                    dateTimePicker1.Value = date;
                    textClient.Text = client;
                    textPerson.Text = person;
                    cmbItem.Text = item;
                    textSupport.Text = support;

                }



            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "エラー");
                return;
            }
            finally
            {
                // 接続解除
                con.Close();
                // リソース開放
                con.Dispose();
            }
        }




        private static readonly string DeleteSql = @"DELETE FROM InputTable  WHERE ID = @id";
        private void btnDelete_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection();

            try
            {

                DateTime date;
                string client = "";
                string person = "";
                string item = "";
                string support = "";



                SqlConnectionStringBuilder builder = new SqlConnectionStringBuilder();
                builder.DataSource = "(local)";
                builder.InitialCatalog = "Input";
                builder.UserID = "sa";
                builder.Password = "0302";
                con.ConnectionString = builder.ConnectionString;

                // DB接続
                con.Open();

                SqlCommand cmd = con.CreateCommand();
                cmd.CommandText = DeleteSql;
                cmd.Parameters.AddWithValue("@id", nudID.Value);

                // SQL実行 実行した件数が帰ってくる, cmd.ExecuteNonQuery();だけでもOK
                int i = cmd.ExecuteNonQuery();
                MessageBox.Show(i + "件の削除が完了しました。", "削除完了");



                nudID.Value = 0;
                dateTimePicker1.Value = DateTime.Now;
                textClient.Text = "";
                textPerson.Text = "";
                cmbItem.Text = "";
                textSupport.Text = "";




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
    }
}
