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
using System.Windows.Media.Animation;

namespace MyHospital
{
    /// <summary>
    /// Логика взаимодействия для AuthWindow.xaml
    /// </summary>
    public partial class AuthWindow : Window
    {
        public AuthWindow()
        {
            InitializeComponent();

            DoubleAnimation btnAnimation = new DoubleAnimation();
            DoubleAnimation btnAnimation1 = new DoubleAnimation();
            btnAnimation.From = 0;
            btnAnimation.To = 240;
            btnAnimation.Duration = TimeSpan.FromSeconds(3);
            SignInBtn.BeginAnimation(Button.WidthProperty, btnAnimation);
        }

        private void Image_MouseDown(object sender, MouseButtonEventArgs e)
        {
            SpeechSynthesizer synth = new SpeechSynthesizer();

            synth.SetOutputToDefaultAudioDevice();

            synth.Speak("Приветствую вас! Данное окно является окном регистрации. Тут вам необходимо указать ваш ник и пароль. Не болейте!");
        }



        private void Exit_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }
        private void Help_Click(object sender, MouseButtonEventArgs e)
        {
            SpeechSynthesizer synth = new SpeechSynthesizer();

            synth.SetOutputToDefaultAudioDevice();

            synth.Speak("Данное окно является окном авторизации. Тут вам необходимо указать ваш ник и пароль!");
        }

        private void SignIn_Click(object sender, RoutedEventArgs e)
        {
            File.WriteAllText("auth.txt",String.Empty);
            int k = 0;
            int i=0;
            string[] arStr = System.IO.File.ReadAllLines("nicks.txt");
            string[] arStr1 = System.IO.File.ReadAllLines("passwords.txt");
            for (int j=0;j<arStr.Length;j++)
            {
                if (logins.SelectedItem.ToString() == arStr[j])
                {
                    k = j;
                }
            }
            if (Passw.Text == arStr1[k])
            {
                i = 1;
                File.WriteAllText("auth.txt",Convert.ToString(i));
                MessageBox.Show("Авторизация прошла успешно!", "Сообщение");
                Base base1 = new Base();
                base1.Show();

                this.Close();
            }
    
            else if(Passw.Text != arStr[1])
            {
                i = 0;
                File.WriteAllText("auth.txt", Convert.ToString(i));
                Passw.ToolTip = "Password mismatch!";
                Passw.Background = Brushes.MediumPurple;
            }
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            string[] log = System.IO.File.ReadAllLines("nicks.txt");
            for (int i = 0; i < log.Length; i++)
            {
                logins.Items.Add(log[i]);
            }
        }
    }
}

