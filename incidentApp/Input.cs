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

namespace IncidentApp
{
    public partial class Input: Form
    {
        public Input()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {


        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Btn_Input_Click(object sender, EventArgs e)
        {

            SqlConnection con = new SqlConnection();   //SqlConnectionインスタンス生成
            SqlTransaction tran = null;  //クラス

            try
            {
                //接続文字列
                SqlConnectionStringBuilder builder = new SqlConnectionStringBuilder(); //SqlConnectionStringBuilderインスタンス生成 
                                                                                       //SQLServer認証
                builder.DataSource = "(local)";
                builder.InitialCatalog = "Input";
                builder.UserID = "sa";
                builder.Password = "0302";

                Console.WriteLine(builder.ConnectionString);
                con.ConnectionString = builder.ConnectionString;

                con.Open();
                Console.WriteLine("接続完了");

                //DB操作
                //トランザクション開始  select以外は必要
                tran = con.BeginTransaction();
                SqlCommand cmd = con.CreateCommand();

                cmd.Transaction = tran;  //トランザクション設定  

                cmd.CommandText = "insert into InputTable(Date,Client,Person,Item,Support) values (@date,@client,@person,@item,@support) ";


                //string client = Txt_Client.Text;
                //パラメーターはSQLインジェクション対策   危険な文字列はすべてエスケープされる
                cmd.Parameters.AddWithValue("@date", dateTimePicker1.Value.ToShortDateString());
                cmd.Parameters.AddWithValue("@client", Txt_Client.Text);
                cmd.Parameters.AddWithValue("@person", Txt_Person.Text);
                cmd.Parameters.AddWithValue("@item", Cmb_Item.Text);
                cmd.Parameters.AddWithValue("@support", Rtb_Support.Text);

                int i = cmd.ExecuteNonQuery();    //SQL実行  更新系の実行   実行した件数が帰ってくる    cmd.ExecuteNonQuery();だけでもOK
                Console.WriteLine(i + "件処理しました。");
                MessageBox.Show("登録が完了しました。");
                tran.Commit();

            }
            catch (Exception t)
            {
                if (tran != null)
                {
                    tran.Rollback();
                }
                Console.WriteLine("接続エラー");
            }
            finally
            {
                con.Close();
                con.Dispose();
            }
            Console.ReadLine();


        }
    }
}
