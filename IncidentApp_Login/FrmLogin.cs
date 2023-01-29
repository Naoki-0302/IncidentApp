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

            StartPosition = FormStartPosition.CenterScreen;
        }

      

        private void btnLogin_Click(object sender, EventArgs e)
        {
            // 変数ret(bool)を作り,判定として使用する
            bool ret = false;

            // 入力値の間違いチェック
            // Checkメソッドの戻り値
            ret = this.Check();  
            if (ret == false)
            {
                // エラーがあれば実行中のメソッドを終了する
                return;     
            }

            // 認証チェック
            // Authenticateメソッドの戻り値
            ret = this.Authenticate();  
            if (ret) //true
            {
                // メインメニュー画面へ移動する
                MainMenu form1 = new MainMenu();    
                form1.Show();    
                // ログイン画面を非表示にする
                this.Hide();
                // もしくは this.Visible = false;
            }
            else   
            {
                MessageBox.Show("ユーザー名またはパスワードが間違っています。", "エラー");
            }
        }

        private bool Check()
        {
            // 必須チェック
            // ユーザー名が入力されていないとエラー
            if (textUser.Text == "")  
            {
                MessageBox.Show("ユーザー名を入力してください。", "エラー");
                return false;
            }
            // パスワードが入力されていないとエラー
            if (textPass.Text == "")
            {
                MessageBox.Show("パスワードを入力してください。", "エラー");
                return false;
            }

            // 文字数チェック
            // ユーザー名が10桁以上だとエラー
            if (textUser.Text.Length > 10)
            {
                MessageBox.Show("ユーザー名：入力値に誤りがあります。", "エラー");
                return false;
            }
            // パスワードが5桁以上だとエラー
            if (textPass.Text.Length > 5)
            {
                MessageBox.Show("パスワード名：入力値に誤りがあります。", "エラー");
                return false;
            }

            // 禁則文字チェック
            if (Regex.IsMatch(textUser.Text, @"[\\/:*?""<>|]"))
            {
                MessageBox.Show("禁止されている文字が入力されました。", "エラー", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            // チェックに引っかからなればtrueを返す
            return true;
        }

        private bool Authenticate()
        {
            SqlConnection con = new SqlConnection();

            try
            {
                // 接続文字列の構築
                SqlConnectionStringBuilder builder = new SqlConnectionStringBuilder();
                builder.DataSource = "(local)";
                builder.InitialCatalog = "login";
                builder.UserID = "sa";
                builder.Password = "0302";
                con.ConnectionString = builder.ConnectionString;

                // DB接続
                con.Open();
               

                DataTable dt = new DataTable();          
                SqlDataAdapter da = new SqlDataAdapter();
                //参照変数を初期化
                SqlCommand cmd = con.CreateCommand();  


                // query
                cmd.CommandText = "SELECT * FROM LOGIN WHERE ユーザー名 = @ユーザー ";
                // パラメーターの設定①
                cmd.Parameters.AddWithValue("@ユーザー", textUser.Text);

                // パラメータの設定②(①と②どちらでも結果は一緒)
                // cmd.Parameters.Add("@ユーザー", System.Data.SqlDbType.NVarChar, 10);
                // cmd.Parameters["@ユーザー"].Value = txtUser.Text;   

                da.SelectCommand = cmd;
                // 上記のSQL文の結果をdt(DataTable)へ
                da.Fill(dt);  



                // 検索結果が一件も出ない場合   登録されているDBがあるか通常は1
                if (dt.Rows.Count != 1)
                {
                    return false;  //Authenticateメソッドに返す
                }

                // パスワードが一致しない場合   (インデックス+カラム名)
                // 今回は1行目のパスワードカラムの文字が一致しているか判定
                if (dt.Rows[0]["パスワード"].ToString() != textPass.Text)
                {
                    // Authenticateメソッドに返す
                    return false;  
                }

                // チェックに引っかからなればtrueを返す
                return true;       
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "エラー");
                // Authenticateメソッドに返す
                return false;      
            }
            finally
            {
                // 接続解除
                con.Close();
                // リソース開放
                con.Dispose();  
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            // アプリケーションを終了
            Application.Exit();
        }

    }
}
