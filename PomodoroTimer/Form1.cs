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
            TimeOver(); //Проаерять не закончилось ли время
            Print(timerLabel, ref TimeSec, ref TimeMin); // Вывести время в форму
            TimeSec++; //Прибавить тик
        }

        void Print(Label timer, ref int TimeSec, ref int TimeMin) //Метод вывода времени на форму
        {
            const int Min = 60; //Значение минуты
            if (TimeMin == 0) //Если не прошло минуты
            {
                if (TimeSec > 9) //Если не двухзначное число
                    timer.Left = 47; //Перемещяем
                else
                    timer.Left = 66;

                timer.Text = TimeSec.ToString(); //Выводим
                if (TimeSec == Min) //Проверка на минуту
                {
                    TimeMin++;
                    TimeSec = 0;
                }
            }
            else 
            {
                timer.Left = 40;
                timer.Text = $"{TimeMin}:{TimeSec}"; //Выводим вместе с минутами
                if (TimeSec == 60) //Проверка на минуту
                {
                    TimeMin++;
                    TimeSec = 0;
                }
            }
        }
        void Stop() //Сброс всех значений 
        {
            timer1.Enabled = false;
            startButt.Text = "START";
            Pause = false;
            TimeSec = 0;
            TimeMin = 0;
            Print(timerLabel, ref TimeSec, ref TimeMin);
        }
        void TimeOver() //Проверка на окончание времени
        {
            if(TimeMin == TimeJobLimit && !Rest) //Если время работы окончено и мы не отдыхаем
            {
                Stop(); //Останавливаем
                simple.Play(); //Проигрываем звук
                stopButt.Text = "SKIP";  //Меняем имя кнопки
                MessageBox.Show("Time is over, take a rest", "Time is over", MessageBoxButtons.OK, MessageBoxIcon.None); //Выводим сообщение
                Rest = true; //Задаём отдых
                SwitchColors(RestColor ,stopButt, startButt); //Меняем цвет
            }
            if(TimeMin == TimeRestLimit && Rest) //Если время отдыха закончино и мы отдыхаем
            {
                Stop(); //Останавливаем
                simple.Play(); //Проигрываем звук
                stopButt.Text = "STOP"; //Меняем имя кнопки
                MessageBox.Show("Rest is over, time to get work!", "Rest is over", MessageBoxButtons.OK, MessageBoxIcon.None); //Выводим сообщение
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
                Rest = false;
                startButt.Text = "STOP";
                SwitchColors(WorkColor ,stopButt, startButt);
            }
        }
    }
}
