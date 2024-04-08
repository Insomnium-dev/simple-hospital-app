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
using System.Windows.Media.Animation;



namespace MyHospital
{
    /// <summary>
    /// Логика взаимодействия для SignUpWindow.xaml
    /// </summary>
    public partial class SignUpWindow : Window
    {
        public SignUpWindow()
        {
            InitializeComponent();
            DoubleAnimation btnAnimation = new DoubleAnimation();
            DoubleAnimation btnAnimation1 = new DoubleAnimation();
            btnAnimation.From = 0;
            btnAnimation.To = 240;
            btnAnimation.Duration = TimeSpan.FromSeconds(3);
            SignUpBtn.BeginAnimation(Button.WidthProperty, btnAnimation);
        }
        private void Exit_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
            MainWindow mainWindow = new MainWindow();
            mainWindow.Show();
        }
        private void SignUp_Click(object sender, RoutedEventArgs e)
        {
            string log = nick.Text.Trim();
            string pass = Passw.Text.Trim();
            string pass2 = rePass.Text.Trim();

            if (pass.Length < 5)
            {
                Passw.ToolTip = "Password must be more than 5 characters!";
                Passw.Background = Brushes.MediumPurple;
            }
            else
          if (pass != pass2)
            {
                rePass.ToolTip = "Password mismatch!";
                rePass.Background = Brushes.MediumPurple;
            }
            else
            {
                nick.ToolTip = "";
                nick.Background = Brushes.Transparent;
                Passw.ToolTip = "";
                Passw.Background = Brushes.Transparent;
                rePass.ToolTip = "";
                rePass.Background = Brushes.Transparent;
                string lines = nick.Text;
                string lines1 = Passw.Text;
                System.IO.File.AppendAllText("nicks.txt", lines + "\n");
                System.IO.File.AppendAllText("passwords.txt", lines1 + "\n");

                this.Close();
                MessageBox.Show("Ваш аккаунт успешно зарегистрирован");
                AuthWindow authWindow = new AuthWindow();
                authWindow.Show();
            }
            }


        private void Image_MouseDown(object sender, MouseButtonEventArgs e)
        {
            SpeechSynthesizer synth = new SpeechSynthesizer();

            synth.SetOutputToDefaultAudioDevice();

            synth.Speak("Приветствую вас! Данное окно является окном регистрации. Тут вам необходимо указать ваш ник и пароль. Не болейте!");
        }

        private void Help_Click(object sender, MouseButtonEventArgs e)
        {
            SpeechSynthesizer synth = new SpeechSynthesizer();

            synth.SetOutputToDefaultAudioDevice();

            synth.Speak("Приветствую вас! Данное окно является окном регистрации. Тут вам необходимо указать ваш ник и пароль. Не болейте!");
        }
    }
}
