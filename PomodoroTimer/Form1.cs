﻿using System;
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
            //Print(timerLabel, 11, 11);
        }

        SoundPlayer simple = new SoundPlayer(@"C:\Windows\media\tada.wav"); //Звук окончания
        Color WorkColor = Color.Red; //Цвет работы
        Color RestColor = Color.Lime; //Цвет отдыха

        public bool FirstClick = false;

        public int TimeSec =  0; //Время в секундах
        public int TimeMin = 0; //Время в минутах
        public int TimeJobLimit = 1; //Лимит времени работы (минуты)

        public int TimeRestLimit = 1; //Лимит времени отдыха (минуты)
        public int RestScore = 0; //Счётчик перерывов
        public const int RestScoreLimit = 4; //Колличество маленьких перерывов до большого

        public bool Pause = false; //Флаг паузы
        public bool Mode = false; //Флаг отдыха

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
                    timer.Left = 83;
                    else if (textTime.Length == 2)
                        timer.Left = 60;
                        else if(textTime.Length == 3)
                            timer.Left = 50;
                            else if (textTime.Length == 4)
                                timer.Left = 33;
                                else if (textTime.Length == 5)
                                    timer.Left = 13;
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
            if(TimeMin == TimeJobLimit && !Mode) //Если время работы окончено и мы не отдыхаем
            {
                SwitchMode();
            }
            if(TimeMin == TimeRestLimit && Mode) //Если время отдыха закончино и мы отдыхаем
            {
                SwitchMode();
            }
        }

        void SwitchMode()
        {
            if (Mode)
            {
                Stop(); //Останавливаем
                simple.Play(); //Проигрываем звук
                TextLabel.Text = "Rest is over, time to get work!";
                stopButt.Text = "STOP"; //Меняем имя кнопки
                SwitchColors(WorkColor, stopButt, startButt); //Меняем цвет
            }
            else
            {
                Stop(); //Останавливаем
                simple.Play(); //Проигрываем звук
                stopButt.Text = "SKIP";  //Меняем имя кнопки
                SwitchColors(RestColor, stopButt, startButt); //Меняем цвет
                TextLabel.Text = "Time is over, take a rest";
            }
            Mode = !Mode;
        }

        void SwitchColors(Color color, params Button[] butt)
        {
            this.BackColor = color; //Меняем цвет формы
            for (int i = 0; i != butt.Length; i++) //Меняем цвет кнопок
                butt[i].BackColor = color;
        }
        private void startButt_Click(object sender, EventArgs e) //Если конпка старт нажата
        {
            if (!FirstClick) //Проверка на первый клик
            {
                TextLabel.Text = "Good work";
                FirstClick = true;
            }

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
            if (!Mode) //Если не отдыхаем, то останавливаем
            {
                Stop();
            }
            else //Если отдыхаем, то меняем режим
            {
                SwitchMode();
                stopButt.Text = "STOP";
            }
        }
    }
}
