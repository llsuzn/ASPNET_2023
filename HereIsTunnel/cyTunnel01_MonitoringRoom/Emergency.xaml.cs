using MahApps.Metro.Controls;
using System;
using System.Collections.Generic;
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
using System.Net.Sockets;

namespace cyTunnel01_MonitoringRoom
{
    /// <summary>
    /// Emergency.xaml에 대한 상호 작용 논리
    /// </summary>
    public partial class Emergency : MetroWindow
    {
        private const string ServerIP = "192.168.0.104";  // 라즈베리 파이의 IP 주소로 변경
        private const int Port = 9190;  // 라즈베리 파이의 포트 번호로 변경
        private TcpClient client;

        public Emergency()
        {
            InitializeComponent();
            //client = new TcpClient();
            //client.Connect(ServerIP, Port);
        }

        private void BtnCrash_Click(object sender, RoutedEventArgs e)
        {
            client = new TcpClient();
            client.Connect(ServerIP, Port);
            SendCommandToServer("ON");
            client.Close();
        }

        private void SendCommandToServer(string command)
        {
            try
            {
                NetworkStream stream = client.GetStream();
                byte[] data = Encoding.ASCII.GetBytes(command);
                stream.Write(data, 0, data.Length);
                Console.WriteLine("Sent: {0}", command);
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error sending command to server: {0}", ex.Message);
            }
        }

        private void BtnOverturn_Click(object sender, RoutedEventArgs e)
        {
            client = new TcpClient();
            client.Connect(ServerIP, Port);
            SendCommandToServer("OFF");
            client.Close();
        }

        private void BtnFire_Click(object sender, RoutedEventArgs e)
        {

        }

        private void BtnSide_Click(object sender, RoutedEventArgs e)
        {

        }
    }
}
