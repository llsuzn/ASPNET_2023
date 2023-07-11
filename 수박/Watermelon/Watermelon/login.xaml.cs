using MahApps.Metro.Controls;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;
using MySql.Data.MySqlClient;
using MahApps.Metro.Controls.Dialogs;

namespace Watermelon
{
    /// <summary>
    /// login.xaml에 대한 상호 작용 논리
    /// </summary>
    public partial class login : MetroWindow
    {
        public login()
        {
            InitializeComponent();
        }

        private async void BtnSubmit_Click(object sender, RoutedEventArgs e)
        {
            string errorMsg = string.Empty;

            if (string.IsNullOrEmpty(TxtName.Text))
            {
                errorMsg += "이름이 입력되지 않았습니다.\n";
            }

            try
            {
                using (MySqlConnection conn = new MySqlConnection(Commons.MyConnString)) // MySql 연결 (ConnString)으로
                {
                    string strTxtName = "";


                    // DB에 대한 현재 연결 상태 
                    if (conn.State == ConnectionState.Closed)
                    {
                        conn.Open();
                    }
                    string query = @"SELECT Id
                                          , Name
                                          , base_Id
                                       FROM watermelon_result
                                      WHERE Name = @Name";
                    MySqlCommand cmd = new MySqlCommand(query, conn);

                    cmd.Parameters.AddWithValue("@Name", TxtName.Text);

                    MySqlDataReader reader = cmd.ExecuteReader();
                    if (reader.Read())
                    {
                        strTxtName = reader["Id"].ToString();
                        Commons.Name = strTxtName;

                        this.Close();
                    }
                    else
                    {
                        TxtName.Focus();
                        await this.ShowMessageAsync("로그인 실패", "회원 정보가 맞지 않습니다", MessageDialogStyle.Affirmative, null);
                        TxtName.Text = "";
                    }
                    reader.Close();

                }
            }

            catch (Exception ex)
            {
                await this.ShowMessageAsync("로그인 오류", $"{ex.Message}", MessageDialogStyle.Affirmative, null);
            }
        }
    }
}
