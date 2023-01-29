using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace IncidentApp
{
    public partial class FrmLogin : Form
    {
        public FrmLogin()
        {
            InitializeComponent();
        }

        private void FrmLogin_Load(object sender, EventArgs e)
        {

        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            bool ret = false;

            //入力値の間違いチェック
            ret = this.Check();  //メソッドの戻り値
            if (ret == false)
            {
                return;   //エラーがあればリターンする=実行中のメソッドを終了する  , なければ認証処理をする
            }


            //認証
            ret = this.Authenticate();   //メソッドの戻り値
            if (ret)
            {
                //MessageBox.Show("ログイン成功");
                MainMenu form1 = new MainMenu();    //★
                form1.Show();    //Show() or ShowDialog()
                this.Close();
            }
            else
            {
                MessageBox.Show("ユーザー名またはパスワードが間違っています。", "エラー");
            }
        }
        private bool Check()
        {
            //必須チェック
            if (txtUser.Text == "")   //User名が入力されていないとき
            {
                MessageBox.Show("ユーザー名を入力してください。", "エラー");
                return false;
            }
            if (txtPass.Text == "")
            {
                MessageBox.Show("パスワードを入力してください。", "エラー");
                return false;
            }

            //文字数チェック
            if (txtUser.Text.Length > 10)
            {
                MessageBox.Show("ユーザー名：入力値に誤りがあります。","エラー");
                return false;

            }
            if (txtPass.Text.Length > 5)
            {
                MessageBox.Show("パスワード名：入力値に誤りがあります。","エラー");
                return false;

            }

            //禁則文字チェック
            if(Regex.IsMatch(txtUser.Text, @"[\\/:*?""<>|]"))
            {
                MessageBox.Show("禁止されている文字が入力されました。","エラー",MessageBoxButtons.OK,MessageBoxIcon.Warning);
                return false;
            }

            return true;
        }

        private bool Authenticate()
        {
            SqlConnection con = new SqlConnection();

            try
            {
                SqlConnectionStringBuilder builder = new SqlConnectionStringBuilder();

                builder.DataSource = "(local)";
                builder.InitialCatalog = "login";
                builder.UserID = "sa";
                builder.Password = "0302";

                Console.WriteLine(builder.ConnectionString);
                con.ConnectionString = builder.ConnectionString;

                con.Open();//DB接続
                Console.WriteLine("接続完了");

                //DataAdapter
                DataTable dt = new DataTable();           //DataSetでもOK
                SqlDataAdapter da = new SqlDataAdapter();

                SqlCommand cmd = con.CreateCommand();  //★参照変数を初期化している

                //クエリ
                cmd.CommandText = "select * from login_1 where ユーザー名 = @ユーザー ";
                //パラメーター
                cmd.Parameters.Add("@ユーザー", System.Data.SqlDbType.NVarChar, 10);
                cmd.Parameters["@ユーザー"].Value = txtUser.Text;   //ユーザー入力欄
               

                da.SelectCommand = cmd;  //DataAdapterのSelctコマンドを設定
                da.Fill(dt);  //上記のSQL文の結果をdt(DataTable)へ

                //検索結果が一件も出ない場合   登録されているDBがあるか通常は1
                if (dt.Rows.Count != 1)
                {
                    return false;
                }

               


                //パスワードが一致しない場合   インデックス+文字列
                if (dt.Rows[0]["パスワード"].ToString() != txtPass.Text)
                {
                    return false;
                }

                else//Test
                {
                    //インデックス + 文字列
                    Console.WriteLine(dt.Rows[0]["ユーザー名"]);
                    Console.WriteLine(dt.Rows[0]["パスワード"]); //今回は1行目のパスワード → 0302
                   
                }

                return true;
            }
            catch (Exception ex)
            {
                //Console.WriteLine("接続エラー");
                MessageBox.Show(ex.Message,"エラー");
                return false;
            }
            finally
            {
                con.Close();    //接続解除
                con.Dispose();  //リソース開放
            }






        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
