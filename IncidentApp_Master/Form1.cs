using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace IncidentApp_Master
{
    public partial class form1 : Form
    {
        public form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection();
            SqlTransaction tran = null;


            try
            {
                SqlConnectionStringBuilder builder = new SqlConnectionStringBuilder();
                builder.DataSource = "(local)";
                builder.InitialCatalog = "login";
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

                // query
                // シングルコートの前に「@」をつけると複数行に渡って文字がかける
                cmd.CommandText = @"INSERT INTO login   
                                  VALUES (@user,@pass) ";

                // パラメーターの設定   (SQLインジェクション対策   危険な文字列はすべてエスケープされる)
                cmd.Parameters.AddWithValue("@user", textUser.Text);
                cmd.Parameters.AddWithValue("@pass", textPass.Text);

                // SQL実行 実行した件数が帰ってくる, cmd.ExecuteNonQuery();だけでもOK
                int i = cmd.ExecuteNonQuery();
                if (i == 1)
                    MessageBox.Show("登録が完了しました。", "登録完了");

                // コミット(正常終了)
                tran.Commit();

                nudID.Value = 0;
                textUser.Text = "";
                textPass.Text = "";


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


        private static readonly string DeleteSql = @"DELETE FROM login WHERE ID = @id";

        private void btnDelete_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection();

            try
            {
                SqlConnectionStringBuilder builder = new SqlConnectionStringBuilder();
                builder.DataSource = "(local)";
                builder.InitialCatalog = "login";
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

                textUser.Clear();
                textPass.Clear();




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



        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Close();
        }



        private void nudID_ValueChanged(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection();

            try
            {


                string name = "";
                string pass = "";

                SqlConnectionStringBuilder builder = new SqlConnectionStringBuilder();
                builder.DataSource = "(local)";
                builder.InitialCatalog = "login";
                builder.UserID = "sa";
                builder.Password = "0302";
                con.ConnectionString = builder.ConnectionString;

                // DB接続
                con.Open();

                SqlCommand cmd = con.CreateCommand();
                cmd.CommandText = @"SELECT * FROM login WHERE ID = @id";
                cmd.Parameters.AddWithValue("@id", nudID.Value);

                textUser.Clear();
                textPass.Clear();

                // SQLを実行します。
                SqlDataReader reader = cmd.ExecuteReader();


                // 結果を表示します。
                while (reader.Read())
                {
                    // id = (int)reader.GetValue(0);
                    name = (string)reader.GetValue(1);
                    pass = (string)reader.GetValue(2);

                    /*
                    Console.WriteLine("ID:" + id + " ユーザー名:" + name + " パスワード:" + pass);
                    Console.ReadKey();
                    */

                    textUser.Text = name;
                    textPass.Text = pass;

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

        private void textUser_TextChanged(object sender, EventArgs e)
        {

        }




        private static readonly string UpdateSql = @"UPDATE login 
                                                     SET ユーザー名 = @user  ,パスワード = @pass
                                                     WHERE ID = @id";

        private void btnFix_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection();

            try
            {
                SqlConnectionStringBuilder builder = new SqlConnectionStringBuilder();
                builder.DataSource = "(local)";
                builder.InitialCatalog = "login";
                builder.UserID = "sa";
                builder.Password = "0302";
                con.ConnectionString = builder.ConnectionString;

                // DB接続
                con.Open();

                SqlCommand cmd = con.CreateCommand();
                cmd.CommandText = UpdateSql;
                cmd.Parameters.AddWithValue("@id", nudID.Value);
                cmd.Parameters.AddWithValue("@user", textUser.Text);
                cmd.Parameters.AddWithValue("@pass", textPass.Text);

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

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void form1_Load(object sender, EventArgs e)
        {
            this.KeyPreview = true;
        }
        private void Form1_KeyDown(object sender, System.Windows.Forms.KeyEventArgs e)
        {

            if (e.KeyCode == Keys.Enter)
            {

                if (!e.Control)
                {

                    this.SelectNextControl(this.ActiveControl, !e.Shift, true, true, true);

                }
            }

        }
    }
}
