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

namespace MyHospital
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Exit_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }
        private void SignUp_Click(object sender, RoutedEventArgs e)
        {
            SignUpWindow signUpWindow = new SignUpWindow();
            signUpWindow.Show();
            this.Hide();

        }

        private void Web_MouseDown(object sender, MouseButtonEventArgs e)
        {
            System.Diagnostics.Process.Start("https://talon.by/");
        }

        private void Help_MouseDown(object sender, MouseButtonEventArgs e)
        {
            SpeechSynthesizer synth = new SpeechSynthesizer();

            synth.SetOutputToDefaultAudioDevice();

            synth.Speak("Вас приветствует Информационно-поисковая система Поликлиника. На данном окне у вас есть возможность войти как админ, так и пользователем");
        }

        private void SignIn_Click(object sender, RoutedEventArgs e)
        {
            AuthWindow authWindow = new AuthWindow();
            authWindow.Show();
        }

        private void Talon_Click(object sender, RoutedEventArgs e)
        {
            
            System.IO.File.WriteAllText("auth.txt", Convert.ToString(0));
            UserWindow userWindow = new UserWindow();
            userWindow.Show();
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            System.IO.File.WriteAllText("count.txt", Convert.ToString(0));
        }
    }
}
