using cyTunnel01_MonitoringRoom.Logics;
using LibVLCSharp.Shared;
using MahApps.Metro.Controls;
using System;
using System.Windows;
using System.Windows.Media;


namespace cyTunnel01_MonitoringRoom
{
    /// <summary>
    /// MainWindow.xaml에 대한 상호 작용 논리
    /// </summary>
    public partial class MainWindow : MetroWindow
    {
        LibVLC _libVLC1;
        LibVLC _libVLC2;
        LibVLC _libVLC3;
        LibVLC _libVLC4;
        LibVLC _libVLC5;
        LibVLCSharp.Shared.MediaPlayer _mediaPlayer1;
        LibVLCSharp.Shared.MediaPlayer _mediaPlayer2;
        LibVLCSharp.Shared.MediaPlayer _mediaPlayer3;
        LibVLCSharp.Shared.MediaPlayer _mediaPlayer4;
        LibVLCSharp.Shared.MediaPlayer _mediaPlayer5;

        public MainWindow()
        {
            InitializeComponent();
            Core.Initialize();

            _libVLC1 = new LibVLC();
            _libVLC2 = new LibVLC();
            _libVLC3 = new LibVLC();
            _libVLC4 = new LibVLC();
            _libVLC5 = new LibVLC();
            _mediaPlayer1 = new LibVLCSharp.Shared.MediaPlayer(_libVLC1);
            _mediaPlayer2 = new LibVLCSharp.Shared.MediaPlayer(_libVLC2);
            _mediaPlayer3 = new LibVLCSharp.Shared.MediaPlayer(_libVLC3);
            _mediaPlayer4 = new LibVLCSharp.Shared.MediaPlayer(_libVLC4);
            _mediaPlayer5 = new LibVLCSharp.Shared.MediaPlayer(_libVLC5);

            //MAIN_CCTV.MediaPlayer = new MediaPlayer(_libVLC1);
            MAIN_CCTV.MediaPlayer = _mediaPlayer1;
            CCTV1.MediaPlayer = _mediaPlayer2;
            CCTV2.MediaPlayer = _mediaPlayer3;
            CCTV3.MediaPlayer = _mediaPlayer4;
            CCTV4.MediaPlayer = _mediaPlayer5;

        }

        private void Btnsolution_Click(object sender, RoutedEventArgs e)
        {
            var subWin = new Emergency();
            subWin.ShowDialog();
        }

        private void BtnLCD_Click(object sender, RoutedEventArgs e)
        {
            var subWin = new LcdControl();
            subWin.ShowDialog();
        }

        private void Btn_Click(object sender, RoutedEventArgs e)
        {
            var subWin = new dontknow();
            subWin.ShowDialog();
        }

        private void BtnMngDBControl_Click(object sender, RoutedEventArgs e)
        {
            var subWin = new DBmanagement();
                        subWin.ShowDialog();
        }

        
        private async void MetroWindow_Loaded(object sender, RoutedEventArgs e)
        {
            try
            {
                CCTV_PLAY();
            }
            catch
            {
                await Commons.ShowMessageAsync("오류", $"CCTV로드 오류발생");
            }
        }

        private void CCTV_PLAY()
        {
            string MAIN_CCTV_PATH = string.Empty;
            string CCTV_PATH1 = string.Empty;
            string CCTV_PATH2 = string.Empty;
            string CCTV_PATH3 = string.Empty;
            string CCTV_PATH4 = string.Empty;

            MAIN_CCTV_PATH = "http://192.168.0.104:5000/get_camera";
            _mediaPlayer1.Play(new Media(_libVLC1, new Uri(MAIN_CCTV_PATH)));
            //MAIN_CCTV.MediaPlayer.Play(new Media(_libVLC1, new Uri(MAIN_CCTV_PATH)));
            CCTV_PATH1 = "http://cctvsec.ktict.co.kr/297/TLOWN3f8wW3qcEXfRYbKoRGVQa+3kqn3DlLQ1TQhB9t+7azp/fDo9q3AOWzVDmV6rZVFxd29CVMmOR9NxkYpRUU/S7abdnpqYWy7Z93O37M=";
            //_mediaPlayer2.Play(new Media(_libVLC2, new Uri(CCTV_PATH1)));
            CCTV1.MediaPlayer.Play(new Media(_libVLC2, new Uri(CCTV_PATH1)));
            CCTV_PATH2 = "http://cctvsec.ktict.co.kr/298/0SEGEo2QJa5VnR1Lw50KkWCqw04CA1RR7papMNawoPPEeRBYtnYJe12UqbEDUvcQnndOd9kS6n3JR4vV0psFDW43ZAyRAjZ4TO23poaC6OQ=";
            //_mediaPlayer3.Play(new Media(_libVLC3, new Uri(CCTV_PATH2)));
            CCTV2.MediaPlayer.Play(new Media(_libVLC3, new Uri(CCTV_PATH2)));
            CCTV_PATH3 = "http://cctvsec.ktict.co.kr/299/U1w04MsKRI4g8Wml3GjarxPwXvGsBWxGZDGxsKnIUVmRLIO1XyxL0lKDFG45/Njl2v3LwdXPDhrdrChIOreSgDfRgjzFDDL5+aAVFUeYdbQ=";
            CCTV3.MediaPlayer.Play(new Media(_libVLC4, new Uri(CCTV_PATH3)));
            CCTV_PATH4 = "http://cctvsec.ktict.co.kr/300/SjqQJ9Kz7QiJDZ8/IRSAyUCB4zqrSdHGSUlVuueBqM178owE+UL54yvnn+c9+sPQK3pjpeA4OP58q75IUu6koUMeonPK5YgQN1UUmaz4dDk=";
            CCTV4.MediaPlayer.Play(new Media(_libVLC5, new Uri(CCTV_PATH4)));
        }

        private async void btn1_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                string MAIN_CCTV_PATH = "http://cctvsec.ktict.co.kr/297/TLOWN3f8wW3qcEXfRYbKoRGVQa+3kqn3DlLQ1TQhB9t+7azp/fDo9q3AOWzVDmV6rZVFxd29CVMmOR9NxkYpRUU/S7abdnpqYWy7Z93O37M=";
                MAIN_CCTV.MediaPlayer.Play(new Media(_libVLC1, new Uri(MAIN_CCTV_PATH)));
                MAIN_CCTV.MediaPlayer.Play();
            }
            catch
            {
                await Commons.ShowMessageAsync("오류", $"CCTV로드 오류발생");
            }
        }

        private async void btn2_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                string MAIN_CCTV_PATH = "http://cctvsec.ktict.co.kr/298/0SEGEo2QJa5VnR1Lw50KkWCqw04CA1RR7papMNawoPPEeRBYtnYJe12UqbEDUvcQnndOd9kS6n3JR4vV0psFDW43ZAyRAjZ4TO23poaC6OQ=";
                MAIN_CCTV.MediaPlayer.Play(new Media(_libVLC1, new Uri(MAIN_CCTV_PATH)));
                MAIN_CCTV.MediaPlayer.Play();
            }
            catch (Exception)
            {
                await Commons.ShowMessageAsync("오류", $"CCTV로드 오류발생");
            }            
        }

        private async void btn3_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                string MAIN_CCTV_PATH = "http://cctvsec.ktict.co.kr/299/U1w04MsKRI4g8Wml3GjarxPwXvGsBWxGZDGxsKnIUVmRLIO1XyxL0lKDFG45/Njl2v3LwdXPDhrdrChIOreSgDfRgjzFDDL5+aAVFUeYdbQ=";
                MAIN_CCTV.MediaPlayer.Play(new Media(_libVLC1, new Uri(MAIN_CCTV_PATH)));
                MAIN_CCTV.MediaPlayer.Play();
            }
            catch (Exception)
            {
                await Commons.ShowMessageAsync("오류", $"CCTV로드 오류발생");
            }
        }

        private async void btn4_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                string MAIN_CCTV_PATH = "http://cctvsec.ktict.co.kr/300/SjqQJ9Kz7QiJDZ8/IRSAyUCB4zqrSdHGSUlVuueBqM178owE+UL54yvnn+c9+sPQK3pjpeA4OP58q75IUu6koUMeonPK5YgQN1UUmaz4dDk=";
                MAIN_CCTV.MediaPlayer.Play(new Media(_libVLC1, new Uri(MAIN_CCTV_PATH)));
                MAIN_CCTV.MediaPlayer.Play();
            }
            catch (Exception)
            {
                await Commons.ShowMessageAsync("오류", $"CCTV로드 오류발생");
            }
        }
    }
}
