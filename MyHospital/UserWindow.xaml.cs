using System;
using System.Collections.Generic;
using System.Linq;
using System.Speech.Synthesis;
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
using System.IO;

namespace MyHospital
{
    /// <summary>
    /// Логика взаимодействия для UserWindow.xaml
    /// </summary>
    public partial class UserWindow : Window
    {
        public UserWindow()
        {
            InitializeComponent();
        }

        private void User_Click(object sender, RoutedEventArgs e)
        {
            File.AppendAllText("users.txt", fio.Text +','+ numberOfCard.Text+Environment.NewLine);
            Base zxc = new Base();
            zxc.Show();
            this.Hide();
        }

        private void Web_MouseDown(object sender, MouseButtonEventArgs e)
        {
            System.Diagnostics.Process.Start("https://talon.by/");

        }
        private void TextBlock_MouseDown(object sender, MouseButtonEventArgs e)
        {
            SpeechSynthesizer synth = new SpeechSynthesizer();

            synth.SetOutputToDefaultAudioDevice();

            synth.Speak("Данное окно является окном регистрации вашей медкарты. Пожалуйста,введите необходимые данные");

        }
        private void Exit_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }
    }
}
