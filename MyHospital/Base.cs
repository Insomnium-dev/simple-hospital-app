using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Data.OleDb;

namespace MyHospital
{
    public partial class Base : Form
    {
        public Base()
        {
            InitializeComponent();
        }

        private void Base_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "mybaseDataSet.Врачи". При необходимости она может быть перемещена или удалена.
            this.врачиTableAdapter.Fill(this.mybaseDataSet.Врачи);
            string[] x = File.ReadAllLines("auth.txt");
            if (Convert.ToInt32(x[0]) == 1)
            {
                richTextBox1.Visible = true;
                dateTimePicker1.Visible = true;
                button6.Visible = true;
                button2.Visible = true;
                button3.Visible = true;
                button4.Visible = true;
                dataGridView1.ReadOnly = false;
                button1.Visible = false;
            }
            else
            {
                richTextBox1.Visible = false;
                dateTimePicker1.Visible = false;
                button6.Visible = false;
                button2.Visible = false;
                button3.Visible = false;
                button4.Visible = false;
                button1.Visible = true;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int i1 = 0;
            int i2 = 0;
            int i3 = 0;
            int i4 = 0;
            int i5 = 0;
            int i6 = 0;
            int i7 = 0;
            int i8 = 0;
            int i9 = 0;
            int i10 = 0;
            int i11 = 0;
            int i12 = 0;
            File.WriteAllText(@"Anal.txt", string.Empty);
            string lines = label1.Text;
            string lines1 = label2.Text;
            string lines2 = label3.Text;
            File.WriteAllText("talon.txt",lines1 + "\n" + "Должность:" + lines + "\n" + "Кабинет:" + lines2);
            if (lines == "Врач функциональной диагностики")
            {
                i1++;
                File.AppendAllText("vrach1.txt", Convert.ToString(i1) + "\n");
            }
            if (lines == "Врач-аллерголог")
            {
                i2++;
                File.AppendAllText("vrach2.txt", Convert.ToString(i2) + "\n");
            }
            if (lines == "Врач-гематолог")
            {
                i3++;
                File.AppendAllText("vrach3.txt", Convert.ToString(i3) + "\n");
            }
            if (lines == "Врач-дерматовенеролог")
            {
                i4++;
                File.AppendAllText("vrach4.txt", Convert.ToString(i4) + "\n");
            }
            if (lines == "Врач-кардиолог")
            {
                i5++;
                File.AppendAllText("vrach5.txt", Convert.ToString(i5) + "\n");
            }
            if (lines == "Врач-невролог")
            {
                i6++;
                File.AppendAllText("vrach6.txt", Convert.ToString(i6) + "\n");
            }
            if (lines == "Врач-оториноларинголог")
            {
                i7++;
                File.AppendAllText("vrach7.txt", Convert.ToString(i7) + "\n");
            }
            if (lines == "Врач-офтальмолог")
            {
                i8++;
                File.AppendAllText("vrach8.txt", Convert.ToString(i8) + "\n");
            }
            if (lines == "Врач-педиатр участковый")
            {
                i9++;
                File.AppendAllText("vrach9.txt", Convert.ToString(i9) + "\n");
            }
            if (lines == "Врач-травмотолог-ортопед")
            {
                i10++;
                File.AppendAllText("vrach10.txt", Convert.ToString(i10) + "\n");
            }
            if (lines == "Врач-хирург")
            {
                i11++;
                File.AppendAllText("vrach11.txt", Convert.ToString(i11) + "\n");
            }
            if (lines == "Врач-эндокринолог")
            {
                i12++;
                File.AppendAllText("vrach12.txt", Convert.ToString(i12) + "\n");
            }
            string s = dataGridView1[dataGridView1.Columns[1].Index, dataGridView1.CurrentRow.Index].Value.ToString();
            File.WriteAllText("1.txt", s);

            FirstWindow firstWindow = new FirstWindow();
            firstWindow.Show();
            this.Hide();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            dataGridView1.BeginEdit(true);
            bindingNavigator1.Visible = true;

        }

        private void button3_Click(object sender, EventArgs e)
        {
            bindingNavigator1.Visible = false;
            OleDbConnection conn = new OleDbConnection(@"Provider=Microsoft.Jet.OLEDB.4.0;Data Source=D:\Курсовая\MyHospital\MyHospital\mybase.mdb;");
           
            int n = dataGridView1.SelectedCells[0].RowIndex;
            MessageBox.Show(dataGridView1[2, n].Value.ToString());
            OleDbDataAdapter adapter = new OleDbDataAdapter($"UPDATE Врачи SET Должность = '{ dataGridView1[0, n].Value}' , ФИО = '{ dataGridView1[1, n].Value}', Кабинет = { dataGridView1[2, n].Value} WHERE Должность='{ dataGridView1[0, n].Value}' ;" , conn);
         
            DataSet ds = new DataSet();
            adapter.Fill(ds);

            this.dataGridView1.AutoGenerateColumns = true;
            try
            {
                this.dataGridView1.DataSource = ds.Tables[0];
            }
            catch
            {
                MessageBox.Show("Данные успешно сохранены");
            }

            conn.Close();



        }

        private void button4_Click(object sender, EventArgs e)
        {
            File.WriteAllText(@"Anal.txt", string.Empty);
            string[] v1 = File.ReadAllLines("vrach1.txt");
            int sum1 = 0;
            for (int i = 0; i < v1.Length; i++)
            {
                sum1 += Convert.ToInt32(v1[i]);
            }

            System.IO.File.AppendAllText("Anal.txt", "Лукашенок Т.И." + "\n" + "Кол-во пациентов: " + sum1 + "\n" + "Должность: Врач функциональной диагностики" + "\n");
            if (sum1 >= 15)
            {
                System.IO.File.AppendAllText("Anal.txt", "Сильно загружен!" + "\n" + "\n");
            }
            else if (sum1 <= 15 || sum1 == 0) System.IO.File.AppendAllText("Anal.txt", "Средне загружен!" + "\n" + "\n");


            string[] v2 = File.ReadAllLines("vrach2.txt");
            int sum2 = 0;
            for (int i = 0; i < v2.Length; i++)
            {
                sum2 += Convert.ToInt32(v2[i]);
            }
            System.IO.File.AppendAllText("Anal.txt", "Дударчик О.А." + "\n" + "Кол-во пациентов: " + sum2 + "\n" + "Должность: Врач-аллерголог" + "\n");
            if (sum2 >= 15)
            {
                System.IO.File.AppendAllText("Anal.txt", "Сильно загружен!" + "\n" + "\n");
            }
            else if (sum2 <= 15 || sum2 == 0) System.IO.File.AppendAllText("Anal.txt", "Средне загружен!" + "\n" + "\n");



            string[] v3 = File.ReadAllLines("vrach3.txt");
            int sum3 = 0;
            for (int i = 0; i < v3.Length; i++)
            {
                sum3 += Convert.ToInt32(v3[i]);
            }
            System.IO.File.AppendAllText("Anal.txt", "Шаева Н.С." + "\n" + "Кол-во пациентов: " + sum3 + "\n" + "Должность: Врач-гематолог" + "\n");
            if (sum3 >= 15)
            {
                System.IO.File.AppendAllText("Anal.txt", "Сильно загружен!" + "\n" + "\n");
            }
            else if (sum3 <= 15 || sum3 == 0) System.IO.File.AppendAllText("Anal.txt", "Средне загружен!" + "\n" + "\n");


            string[] v4 = File.ReadAllLines("vrach4.txt");
            int sum4 = 0;
            for (int i = 0; i < v4.Length; i++)
            {
                sum4 += Convert.ToInt32(v4[i]);
            }
            System.IO.File.AppendAllText("Anal.txt", "Куликова Г.В." + "\n" + "Кол-во пациентов: " + sum4 + "\n" + "Должность: Врач-дерматовенеролог" + "\n");
            if (sum4 >= 15)
            {
                System.IO.File.AppendAllText("Anal.txt", "Сильно загружен!" + "\n" + "\n");
            }
            else if (sum4 <= 15 || sum4 == 0) System.IO.File.AppendAllText("Anal.txt", "Средне загружен!" + "\n" + "\n");

            string[] v5 = File.ReadAllLines("vrach5.txt");
            int sum5 = 0;
            for (int i = 0; i < v5.Length; i++)
            {
                sum5 += Convert.ToInt32(v5[i]);
            }
            System.IO.File.AppendAllText("Anal.txt", "Поразенко Т.И." + "\n" + "Кол-во пациентов: " + sum5 + "\n" + "Должность: Врач-кардиолог" + "\n");
            if (sum5 >= 15)
            {
                System.IO.File.AppendAllText("Anal.txt", "Сильно загружен!" + "\n" + "\n");
            }
            else if (sum5 <= 15 || sum5 == 0) System.IO.File.AppendAllText("Anal.txt", "Средне загружен!" + "\n" + "\n");

            string[] v6 = File.ReadAllLines("vrach6.txt");
            int sum6 = 0;
            for (int i = 0; i < v6.Length; i++)
            {
                sum6 += Convert.ToInt32(v6[i]);
            }
            System.IO.File.AppendAllText("Anal.txt", "Абрамович Ю.А." + "\n" + "Кол-во пациентов: " + sum6 + "\n" + "Должность: Врач-невролог" + "\n");
            if (sum6 >= 15)
            {
                System.IO.File.AppendAllText("Anal.txt", "Сильно загружен!" + "\n" + "\n");
            }
            else if (sum6 <= 15 || sum6 == 0) System.IO.File.AppendAllText("Anal.txt", "Средне загружен!" + "\n" + "\n");


            string[] v7 = File.ReadAllLines("vrach7.txt");
            int sum7 = 0;
            for (int i = 0; i < v7.Length; i++)
            {
                sum7 += Convert.ToInt32(v7[i]);
            }
            System.IO.File.AppendAllText("Anal.txt", "Грубинова М.В." + "\n" + "Кол-во пациентов: " + sum7 + "\n" + "Должность: Врач-оториноларинголог" + "\n");
            if (sum7 >= 15)
            {
                System.IO.File.AppendAllText("Anal.txt", "Сильно загружен!" + "\n" + "\n");
            }
            else if (sum7 <= 15 || sum7 == 0) System.IO.File.AppendAllText("Anal.txt", "Средне загружен!" + "\n" + "\n");


            string[] v8 = File.ReadAllLines("vrach8.txt");
            int sum8 = 0;
            for (int i = 0; i < v8.Length; i++)
            {
                sum8 += Convert.ToInt32(v8[i]);
            }
            System.IO.File.AppendAllText("Anal.txt", "Павлович А.В." + "\n" + "Кол-во пациентов: " + sum8 + "\n" + "Должность: Врач-офтальмолог" + "\n");
            if (sum8 >= 15)
            {
                System.IO.File.AppendAllText("Anal.txt", "Сильно загружен!" + "\n" + "\n");
            }
            else if (sum8 <= 15 || sum8 == 0) System.IO.File.AppendAllText("Anal.txt", "Средне загружен!" + "\n" + "\n");


            string[] v9 = File.ReadAllLines("vrach9.txt");
            int sum9 = 0;
            for (int i = 0; i < v9.Length; i++)
            {
                sum9 += Convert.ToInt32(v9[i]);
            }
            System.IO.File.AppendAllText("Anal.txt", "Александрова Н.Г." + "\n" + "Кол-во пациентов: " + sum9 + "\n" + "Должность: Врач-педиатр участковый" + "\n");
            if (sum9 >= 15)
            {
                System.IO.File.AppendAllText("Anal.txt", "Сильно загружен!" + "\n" + "\n");
            }
            else if (sum9 <= 15 || sum9 == 0) System.IO.File.AppendAllText("Anal.txt", "Средне загружен!" + "\n" + "\n");

            string[] v10 = File.ReadAllLines("vrach10.txt");
            int sum10 = 0;
            for (int i = 0; i < v10.Length; i++)
            {
                sum10 += Convert.ToInt32(v10[i]);
            }
            System.IO.File.AppendAllText("Anal.txt", "Кузнецов А.А." + "\n" + "Кол-во пациентов: " + sum10 + "\n" + "Должность: Врач-травматолог-ортопед" + "\n");
            if (sum10 >= 15)
            {
                System.IO.File.AppendAllText("Anal.txt", "Сильно загружен!" + "\n" + "\n");
            }
            else if (sum10 <= 15 || sum10 == 0) System.IO.File.AppendAllText("Anal.txt", "Средне загружен!" + "\n" + "\n");

            string[] v11 = File.ReadAllLines("vrach11.txt");
            int sum11 = 0;
            for (int i = 0; i < v11.Length; i++)
            {
                sum11 += Convert.ToInt32(v11[i]);
            }
            System.IO.File.AppendAllText("Anal.txt", "Жабченко Д.В." + "\n" + "Кол-во пациентов: " + sum11 + "\n" + "Должность: Врач-хирург" + "\n");
            if (sum11 >= 15)
            {
                System.IO.File.AppendAllText("Anal.txt", "Сильно загружен!" + "\n" + "\n");
            }
            else if (sum11 <= 15 || sum11 == 0) System.IO.File.AppendAllText("Anal.txt", "Средне загружен!" + "\n" + "\n");

            string[] v12 = File.ReadAllLines("vrach12.txt");
            int sum12 = 0;
            for (int i = 0; i < v12.Length; i++)
            {
                sum12 += Convert.ToInt32(v12[i]);
            }
            System.IO.File.AppendAllText("Anal.txt", "Боровко М.М." + "\n" + "Кол-во пациентов: " + sum12 + "\n" + "Должность: Врач-эндокринолог" + "\n");
            if (sum12 >= 15)
            {
                System.IO.File.AppendAllText("Anal.txt", "Сильно загружен!" + "\n" + "\n");
            }
            else if (sum12 <= 15 || sum12 == 0) System.IO.File.AppendAllText("Anal.txt", "Средне загружен!" + "\n" + "\n");

            MessageBox.Show(System.IO.File.ReadAllText("Anal.txt"), "Анализ загруженности");
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            OleDbConnection conn = new OleDbConnection(@"Provider=Microsoft.Jet.OLEDB.4.0;Data Source=D:\Курсовая\MyHospital\MyHospital\mybase.mdb;");
            OleDbDataAdapter adapter = new OleDbDataAdapter("SELECT * FROM Врачи WHERE Должность LIKE '%" + textBox1.Text + "%' ", conn);

            DataSet ds = new DataSet();
            adapter.Fill(ds);

            this.dataGridView1.AutoGenerateColumns = true;
            this.dataGridView1.DataSource = ds.Tables[0];

            conn.Close();
        }



        private void button6_Click_1(object sender, EventArgs e)
        {
            richTextBox1.Text = "";
            string s = dataGridView1[dataGridView1.Columns[1].Index, dataGridView1.CurrentRow.Index].Value.ToString();
            string[] ss = new string[50];
            string[] sss = new string[50];
            string name = dateTimePicker1.Value.ToShortDateString();
            File.WriteAllText("1.txt", s);
           
            try
            {
                ss = File.ReadAllLines($"{name}{s}.txt");
                sss = File.ReadAllLines($"{name}.txt");
            }
            catch
            {
                MessageBox.Show("Талонов на такую дату не сущевствует!");
            }
           


            if (s == ss[0])
            {
                for (int i = 0; i < ss.Length; i++)
                {
                    richTextBox1.Text += ss[i]+"\n";

                }
            }
            else
            {
                MessageBox.Show("Талонов на такую дату к данному врачу не существует");
            }
        }
    }
}
