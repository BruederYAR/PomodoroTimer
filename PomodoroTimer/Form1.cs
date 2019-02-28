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
using System.Media;

namespace PomodoroTimer
{
    public partial class Pomodoro : Form
    {
        public Pomodoro()
        {
            InitializeComponent();
            //Print(timerLabel, 22, 22);
        }

        SoundPlayer simple = new SoundPlayer(@"C:\Windows\media\tada.wav"); //Звук окончания
        Color WorkColor = Color.Red; //Цвет работы
        Color RestColor = Color.Lime; //Цвет отдыха

        public int TimeSec =  0; //Время в секундах
        public int TimeMin = 0; //Время в минутах
        public int TimeJobLimit = 25; //Лимит времени работы (минуты)
        public int TimeRestLimit = 5; //Лимит времени работы (минуты)

        public bool Pause = false; //Флаг паузы
        public bool Rest = false; //Флаг отдыха

        private void timer1_Tick(object sender, EventArgs e) 
        {
            const int Min = 60; //Значение минуты

            TimeOver(); //Проаерять не закончилось ли время
            Print(timerLabel, TimeSec, TimeMin); // Вывести время в форму
            TimeSec++; //Прибавить тик
            if (TimeSec == Min) //Проверка на минуту
            {
                TimeMin++;
                TimeSec = 0;
            }
        }

        void Print(Label timer, int TimeSec, int TimeMin) //Метод вывода времени на форму
        {
            if (TimeMin == 0) //Если не прошло минуты
            {
                timer.Text = TimeSec.ToString(); //Выводим
                Center(timer.Text);
            }
            else
            {
                timer.Text = $"{TimeMin}:{TimeSec}"; //Выводим вместе с минутами
                Center(timer.Text);
            }
            void Center(string textTime) //Центрируем текст
            {
                if (textTime.Length == 1)
                    timer.Left = 66;
                    else if (textTime.Length == 2)
                        timer.Left = 50;
                        else if(textTime.Length == 3)
                            timer.Left = 40;
                            else if (textTime.Length == 4)
                                timer.Left = 30;
                                else if (textTime.Length == 5)
                                    timer.Left = 15;
            }
        }
        void Stop() //Сброс всех значений 
        {
            timer1.Enabled = false;
            startButt.Text = "START";
            Pause = false;
            TimeSec = 0;
            TimeMin = 0;
            Print(timerLabel, TimeSec, TimeMin);
        }
        void TimeOver() //Проверка на окончание времени
        {
            if(TimeMin == TimeJobLimit && !Rest) //Если время работы окончено и мы не отдыхаем
            {
                Stop(); //Останавливаем
                simple.Play(); //Проигрываем звук
                MessageBox.Show("Time is over, take a rest", "Time is over", MessageBoxButtons.OK, MessageBoxIcon.None); //Выводим сообщение
                stopButt.Text = "SKIP";  //Меняем имя кнопки
                Rest = true; //Задаём отдых
                SwitchColors(RestColor ,stopButt, startButt); //Меняем цвет
            }
            if(TimeMin == TimeRestLimit && Rest) //Если время отдыха закончино и мы отдыхаем
            {
                Stop(); //Останавливаем
                simple.Play(); //Проигрываем звук
                MessageBox.Show("Rest is over, time to get work!", "Rest is over", MessageBoxButtons.OK, MessageBoxIcon.None); //Выводим сообщение
                stopButt.Text = "STOP"; //Меняем имя кнопки
                Rest = false; //Говорим о работе
                SwitchColors(WorkColor, stopButt, startButt); //Меняем цвет
            }
        }

        void SwitchColors(Color color, params Button[] butt)
        {
            this.BackColor = color; //Меняем цвет формы
            for (int i = 0; i != butt.Length; i++) //Меняем цвет кнопок
                butt[i].BackColor = color;
        }
        private void startButt_Click(object sender, EventArgs e) //Если конпка старт нажата
        {
            Pause = !Pause; //Реверсируем значение флага
            if (Pause) 
            {
                timer1.Enabled = true;
                startButt.Text = "PAUSE";
            }
            else
            {
                timer1.Enabled = false;
                startButt.Text = "START";
            }   
        }

        private void stopButt_Click(object sender, EventArgs e) //Если кнопка стоп нажата
        {
            if (!Rest) //Если не отдыхаем, то останавливаем
            {
                Stop();
            }
            else //Если отдыхаем, то меняем режим
            {
                Stop();
                stopButt.Text = "STOP";
                SwitchColors(WorkColor ,stopButt, startButt);
                Rest = false;
            }
        }
    }
}
