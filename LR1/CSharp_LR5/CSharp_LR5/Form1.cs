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
using System.Windows.Forms.DataVisualization.Charting;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace CSharp_LR5
{
    public partial class Form1 : Form
    {
        /// <summary>
        /// Переменные
        /// </summary>
        private OleDbConnection connection;                         //Подключение к БД
        private long index = 0;                                     //Индекс последней (нижней) строки БД
        private long feeder_current = 0;                            //Общий ток (фидера)
        private Thread t;                                           //Фоновый поток
        private DateTime DTstarted;                                 //Время предыдущей регистрации параметров
        private bool timeStarted = false;                           //"Зещёлка", начали ли мы считать время?
        private double HoursDiff = 0;                               //Разница между показаниями в часах
        private double energyCounter = 0;                           //Квт*ч
        private long chartCounter = 0;                              //Счётчик для графика

        private int cycleDelay = 4000;                              //Задержка в цикле
        private int maxCurrent = 130;                               //Максимальный "штатный" ток для 1 станка

        /// <summary>
        /// Компоненты формы
        /// </summary>
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //
            //Инициализируем график при загрузке формы
            //
            /*for (int i = 0; i < 6; i++)
            {
                chart1.Series[i].ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline;
                chart1.Series[i].Points.AddXY(0, 0);
            }*/
            chart1.Series[0].ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline;
            chart1.Series[0].Points.AddXY(0, 0);
            chart1.ChartAreas[0].AxisX.Minimum = 0;
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            //
            //При закрытии формы, убиваем процесс и отключаемся от БД
            //
            if (t != null && t.IsAlive)
                t.Abort();
            if (connection != null)
                connection.Close();
            Environment.Exit(0);                                //Убиваем все фоновые процессы
        }

        private void db_btn_Click(object sender, EventArgs e)
        {
           //
           //Кнопка "Подключиться к БД"
           //
            connection = new OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0; Data Source =" + Path.Combine(AppDomain.CurrentDomain.BaseDirectory, @"..\..\LR05.mdb"));
            try
            {
                this.connection.Open();                         //Открываем соединение
                table1_load();                                  //Пробуем прочитать таблицу

                index = countRows();                            //Ищем низ БД (последняя запись)

                t = new Thread(new ThreadStart(ThreadProc));    //Запускам фоновый процесс
                t.Start();

                MessageBox.Show("Подключено!");
                db_btn.Enabled = false;                         //Делаем кнопку "подключиться" некликабельной
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);        //Сообщение об ошибке
            }
        }

        private void random_btn_Click(object sender, EventArgs e)
        {
            //
            //Форма генератора случайных чисел
            //
            if (!CheckOpened("Randomizer"))                     //Проверяем, не открыта ли форма
            {
                Randomizer randomizer = new Randomizer();
                randomizer.Show();                              //Если нет, открываем
            }
        }

        /// <summary>
        /// Остальные финкции
        /// </summary>
        /// <returns></returns>
        private bool CheckOpened(string name)
        {
            //
            //Проверка "формы на открытость"
            //
            FormCollection fc = Application.OpenForms;
            foreach (Form frm in fc)
            {
                if (frm.Text == name)
                {
                    return true;
                }
            }
            return false;
        }

        private void ThreadProc()
        {
            //
            //Фоновый процесс
            //
            try
            {
                while (true)                                    //Бесконечный цекл
                {
                    long curIndex = countRows();                //Проверяем, не выросла ли БД
                    if (curIndex > index)                       //Если строк стало больше
                    {
                        var table_1 = table1_load();            //Выгружаем таблицу
                        long k = 0;
                        while (k < curIndex)                    //Доходим до последней строки
                        {
                            k++;
                            table_1.Read();
                        }

                        if (!timeStarted)                       //"Защёлка" времени для энергосчётчика
                        {
                            timeStarted = true;
                            DTstarted = (DateTime)table_1[7];   //Время начала отсчёта
                        }

                        //Считаем разницу во времени (в часах) (от последнего времени отнимаем предыдущее)
                        DateTime DTcurrent = (DateTime)table_1[7];
                        HoursDiff = DTcurrent.Subtract(DTstarted).TotalHours;
                        DTstarted = DTcurrent;

                        //Вычисляем общий ток
                        feeder_current = 0;
                        for (int i = 1; i < 6; i++)
                        {
                            feeder_current += (int)table_1[i];
                        }

                        fillFields(table_1);                    //Заполняем основные поля

                        fillChart(table_1);                     //Чертим график

                        index = curIndex;                       //Запоминаем последнюю строку

                        Thread.Sleep(cycleDelay);               //Ждём
                    }
                }
            }
            catch (ThreadAbortException)
            {
                //
                //Процесс остановлен
                //
            }
        }

        private void fillChart(OleDbDataReader table_1)
        {
            //
            //Отрисовка графика
            //
            BeginInvoke(new Action(() =>
            {
                /*for (int i = 0; i < 5; i++)                     //Основные токи
                    chart1.Series[i].Points.AddXY(chartCounter, (int)table_1[i + 1]);*/

                //Общий ток
                chart1.Series[0].Points.AddXY(chartCounter, (int)feeder_current);

                bool error = false;                             //Проверяем на превышение токов
                for (int i = 1; i < 6; i++)
                    if ((int)table_1[i] > maxCurrent)
                        error = true;

                if (error)                                      //Если хоть где-то больше maxCurrent, красим красным
                    chart1.Series[0].Color = Color.Red;
                else
                    chart1.Series[0].Color = Color.LimeGreen;

            }));
            chartCounter++;
        }

        private void fillFields(OleDbDataReader table_1)
        {
            //
            //Заполнение полей
            //
            BeginInvoke(new Action(() => {                      //Токи
                for (int i = 1; i < 6; i++)
                {
                    System.Windows.Forms.TextBox tb = this.Controls.Find("amps_" + i.ToString(), true).FirstOrDefault() as System.Windows.Forms.TextBox;

                    tb.Text = table_1[i].ToString();
                }

            }));

            BeginInvoke(new Action(() => {                      //Мгновенные мощности
                for (int i = 1; i < 6; i++)
                {
                    System.Windows.Forms.TextBox tb = this.Controls.Find("power_" + i.ToString(), true).FirstOrDefault() as System.Windows.Forms.TextBox;

                    tb.Text = (((int)table_1[i] * (int)table_1[6]) / 1000).ToString();

                }

            }));

            //Напряжение на фидере
            string volts = table_1[6].ToString();               
            if (volts_feeder.InvokeRequired)
                volts_feeder.BeginInvoke(new Action(() => { volts_feeder.Text = volts; }));
            else
                volts_feeder.Text = volts;

            //Мощность на фидере
            string fPower = ((feeder_current * (int)table_1[6]) / 1000).ToString();
            if (power_feeder.InvokeRequired)
                power_feeder.BeginInvoke(new Action(() => { power_feeder.Text = fPower; }));
            else
                power_feeder.Text = fPower;

            //кВт*ч
            if (timeStarted)
            {
                energyCounter += ((feeder_current * (int)table_1[6]) / 1000.0) * HoursDiff;
                string energy = new String(energyCounter.ToString().ToCharArray());

                if (energy_feeder.InvokeRequired)
                    energy_feeder.BeginInvoke(new Action(() => { energy_feeder.Text = energy; }));
                else
                    energy_feeder.Text = energy;
            }
        }

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

        private long countRows()
        {
            //
            //Подсчёт строк
            //
            OleDbCommand cmd;

            cmd = new OleDbCommand(
               "SELECT COUNT(*) FROM table_1", this.connection
            );
            return (int)cmd.ExecuteScalar();
        }
    }
}