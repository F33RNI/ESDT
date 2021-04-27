using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CSharp_LR5
{
    public partial class Randomizer : Form
    {
        /// <summary>
        /// Переменные
        /// </summary>
        private OleDbConnection connection;                     //Подключение к БД
        private Thread t;                                       //Фоновый поток
        private int seconds = 0;                                //Таймер на отправку
        private int[] values = { 0, 0, 0, 0, 0, 0};             //Рандомные значения

        private int sendingTime = 60;                           //Интервал отправки (сек)

        /// <summary>
        /// Компоненты формы
        /// </summary>
        public Randomizer()
        {
            InitializeComponent();
        }

        private void start_btn_Click(object sender, EventArgs e)
        {
            //
            //Кнопка "старт"
            //
            start_btn.Visible = false;                          //Убираем кнопку с глаз долой
            pause_btn.Visible = true;                           //Включаем кнопку паузы
            t = new Thread(new ThreadStart(ThreadProc));        //Запускам фоновый процесс
            t.Start();
        }

        private void pause_btn_Click(object sender, EventArgs e)
        {
            //
            //Кнопка "пауза"
            //
            start_btn.Visible = true;                           
            pause_btn.Visible = false;                          //Прячем кнопки
            t.Abort();                                          //Убиваем процесс
        }

        private void db_conn_btn_Click(object sender, EventArgs e)
        {
            //
            //Кнопка "подключиться к БД"
            //
            connection = new OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0; Data Source =" + Path.Combine(AppDomain.CurrentDomain.BaseDirectory, @"..\..\LR05.mdb"));
            try
            {
                this.connection.Open();                         //Открываем подключение
                table1_load();                                  //Пробуем выгрузить таблицу
                start_btn.Visible = true;                       //Делаем кнопку старта видимой
                MessageBox.Show("Подключено!");                 //Выводим сообщение
                db_conn_btn.Enabled = false;                    //Выключаем кнопку подключения
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error while loading database: " + ex.Message);
            }
        }

        private void Randomizer_Load(object sender, EventArgs e)
        {
            //
            //При загрузки формы генерируем первые случайные числа
            //
            updateRandom();
        }

        private void Randomizer_FormClosing(object sender, FormClosingEventArgs e)
        {
            //
            //При закрытии формы, убиваем процесс и отключаемся от БД
            //
            if (t != null && t.IsAlive)
                t.Abort();
            if (connection != null)
                 connection.Close();
        }

        /// <summary>
        /// Остальные финкции
        /// </summary>
        /// <returns></returns>
        private OleDbDataReader table1_load()
        {
            //
            //Чтение всей таблицы
            //
            OleDbCommand cmd;

            cmd = new OleDbCommand(
               "SELECT * FROM table_1", this.connection
            );
            return cmd.ExecuteReader();
        }

        private void ThreadProc()
        {
            //
            //Фоновый процесс
            //
            try
            {
                while (true)                                    //Бесконечный цикл
                {
                    if (seconds == 0)                           //Если время вышло, отправляем
                    {
                        //
                        //Генерируем запрос
                        //
                        string sql = "INSERT INTO table_1 (machine_1,  machine_2,  machine_3,  machine_4,  machine_5, feeder, DT)" +
                            " VALUES (?, ?, ?, ?, ?, ?, ?);";
                        OleDbCommand cmd = new OleDbCommand();
                        cmd.CommandText = sql;
                        cmd.Connection = this.connection;
                        for (int i = 0; i < 5; i++)             //Токи
                        {
                            cmd.Parameters.Add("machine_" + i.ToString(), OleDbType.Integer).Value = values[i];
                        }
                        //Напряжение на фидере
                        cmd.Parameters.Add("feeder", OleDbType.Integer).Value = values[5];
                        //текущее время
                        cmd.Parameters.Add("DT", OleDbType.Date).Value = DateTime.Now;
                        cmd.ExecuteNonQuery();

                        seconds = sendingTime;                  //Ставим таймер

                        updateRandom();                         //Обновляем рандомные значения
                    }

                    if (timer.InvokeRequired)                   //Вывод текста тамера (обратный отсчёт)
                        timer.BeginInvoke(new Action(() => { timer.Text = "Отправка показаний через: " + seconds.ToString() + " сек."; }));
                    else
                        timer.Text = "Отправка показаний через: " + seconds.ToString() + " сек.";
                    Thread.Sleep(1000);                         //Каждую секунду выводим текст и проверяем таймер
                    seconds--;                                  //Вычитаем таймер
                }
            }
            catch (ThreadAbortException)
            {
                //
                //Процесс остановлен
                //
            }
        }

        private void updateRandom()
        {
            //
            //Генератор рандрмных значений
            //
            Random rnd = new Random();
            for (int i = 0; i < 5; i++)                         //Токи
                values[i] = rnd.Next(26, 140);

            //Вычисляем уловное напряжение на фидере
            int totalCurrent = 0;
            for (int i = 0; i < 5; i++)                         //Общий ток
                totalCurrent += values[i];

            long totalPower = (totalCurrent * 380) / 1000;      //Условная общая мощность
            //Считаем падение напряжения
            if (totalPower > 200)
                values[5] = (int)map(totalCurrent, 200, 500, 380, 300);
            else
                values[5] = 380;

            BeginInvoke(new Action(() => {                      //Выодим в поля
                for (int i = 0; i < 5; i++)
                {
                    System.Windows.Forms.TextBox tb = this.Controls.Find("amps_" + (i + 1).ToString(), true).FirstOrDefault() as System.Windows.Forms.TextBox;

                    tb.Text = new String(values[i].ToString().ToCharArray());
                }

            }));

            string volts = values[5].ToString();                //Выводим в поле напряжение на фидере

            if (voltage_feeder.InvokeRequired)
                voltage_feeder.BeginInvoke(new Action(() => { voltage_feeder.Text = volts; }));
            else
                voltage_feeder.Text = volts;
        }

        private long map(long x, long in_min, long in_max, long out_min, long out_max)
        {
            //
            //Ардуиновская функция map
            //
            return (x - in_min) * (out_max - out_min) / (in_max - in_min) + out_min;
        }
    }
}
