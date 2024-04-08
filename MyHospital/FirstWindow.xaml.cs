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
    /// Логика взаимодействия для FirstWindow.xaml
    /// </summary>
    public partial class FirstWindow : Window
    {
  
        int countOFTalon = 0;


        public FirstWindow()
        {
            InitializeComponent();

        }

        private void Parse_Click(object sender, RoutedEventArgs e)
        {

        }

        private void Exit_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }
        private void Web_MouseDown(object sender, MouseButtonEventArgs e)
        {
            System.Diagnostics.Process.Start("https://talon.by/");
        }

        private void Help_MouseDown(object sender, MouseButtonEventArgs e)
        {
            SpeechSynthesizer synth = new SpeechSynthesizer();

            synth.SetOutputToDefaultAudioDevice();

            synth.Speak("Данное окно является завершающим этапом в цикле заказа талона. Выберите дату и мы сгенирируем вам время.");
        }

        private void RadioButton_Checked(object sender, RoutedEventArgs e)
        {
            string[] c = File.ReadAllLines("1.txt");
            string[] talon1 = File.ReadAllLines("talon1.txt");
            if (talon1[0] != c[0])
            {
                talon1[talon1.Length - 1] = "8:00";
                File.WriteAllLines("talon1.txt", talon1);
               
            }
            string[] s = File.ReadAllLines("talon1.txt");
            string time = s[s.Length - 1];
            string[] split = time.Split(':');
            int hour1 = Convert.ToInt32(split[0]);
            int min1 = Convert.ToInt32(split[1]);
            if (hour1 <= 17)
            {
                hour1 = 17;
                min1 = 0;
            }

            min1 += 10;
            if (min1==60)
            {
                hour1++;
                min1 = 0;
            }
            if (hour1 == 21)
            {
                
                min1= 0;
            }
           
            radio2.Content = Convert.ToString(hour1)+":"+Convert.ToString(min1);
        }

        private void radio1_Checked(object sender, RoutedEventArgs e)
        {
            string[] c = File.ReadAllLines("1.txt");
            string[] talon1 = File.ReadAllLines("talon1.txt");
            if (talon1[0] != c[0])
            {
                talon1[talon1.Length - 1] = "8:00";
                File.WriteAllLines("talon1.txt", talon1);
        
            }
            string[] s = File.ReadAllLines("talon1.txt");
            string time = s[s.Length - 1];
            string[] split = time.Split(':');
            MessageBox.Show(split[0]);
            int hour = Convert.ToInt32(split[0]);
            int min = Convert.ToInt32(split[1]);
            if (hour>=16)
            {
                hour = 8;
                min = 0;
            }
            min += 10;
            if (min == 60)
            {
                hour++;
                min = 10;
            }
            if (hour == 16)
            {
                min = 0;
            }

            radio1.Content = Convert.ToString(hour)  +":" + Convert.ToString(min);
        }

        private void Talon_Click(object sender, RoutedEventArgs e)
        {
            string[] c = File.ReadAllLines("1.txt");
            string[] talon1 = File.ReadAllLines("talon1.txt");
            if (talon1[0]!=c[0])
            {
                talon1[talon1.Length - 1] = "8:00";
                File.WriteAllLines("talon1.txt", talon1);
                File.WriteAllText("count.txt",Convert.ToString(0));
            }
            countOFTalon = Convert.ToInt32(File.ReadAllText("count.txt"));

            countOFTalon++;
            File.WriteAllText("count.txt", countOFTalon.ToString()); 
            string name = Convert.ToString(dateTime.Text);
            StreamWriter zn;
            FileInfo file = new FileInfo("talon.txt");
            zn = file.AppendText();
            zn.WriteLine("\n"+"№ Талона:"+countOFTalon);
            zn.WriteLine("\n" + "Дата:" + name);
            zn.Close();
            if ((bool)radio1.IsChecked)
            {
                zn = file.AppendText();
                zn.WriteLine(radio1.Content);
                zn.Close();
            }
            if ((bool)radio2.IsChecked)
            {
                zn = file.AppendText();
                zn.WriteLine(radio2.Content);
                zn.Close();
            }
            string[] talon = File.ReadAllLines("talon.txt");
            string[] user = File.ReadAllLines("users.txt");
            string[] s = user[user.Length - 1].Split(',');
            File.AppendAllText($"{name}{talon[0]}.txt",talon[0] + Environment.NewLine + "№Талона:"+countOFTalon.ToString()+",Пациент:" +s[0]+", Время:"+ talon[talon.Length-1]+ Environment.NewLine);
            File.WriteAllLines($"{name}.txt",talon);
            File.WriteAllText("talon1.txt", String.Empty);
            File.WriteAllLines($"talon1.txt", talon);
            MessageBox.Show("Информация:" + "\n" + System.IO.File.ReadAllText("talon.txt"), "Талон");
            this.Hide();

        }
    }
}
