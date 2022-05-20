using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Timer
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        int hours = 0;
        int minutes = 0;
        int seconds = 0;

        private void Form1_Load(object sender, EventArgs e)
        {
        }

        private void PlusHoursButton_Click(object sender, EventArgs e)
        {
            if (hours < 60)
                hours++;

            HoursLabel.Text = hours.ToString();
        }

        private void MinusHoursButton_Click(object sender, EventArgs e)
        {
            if (hours > 0)
                hours--;

            HoursLabel.Text = hours.ToString();
        }

        private void PlusMinutesButton_Click(object sender, EventArgs e)
        {
            if (minutes < 60)
                minutes++;

            MinutesLabel.Text = minutes.ToString();
        }

        private void MinusMinutesButton_Click(object sender, EventArgs e)
        {
            if (minutes > 0)
                minutes--;

            MinutesLabel.Text = minutes.ToString();
        }

        private void PlusSecondsButton_Click(object sender, EventArgs e)
        {
            if (seconds < 60)
                seconds++;

            SecondsLabel.Text = seconds.ToString();
        }

        private void MinusSecondsButton_Click(object sender, EventArgs e)
        {
            if (seconds > 0)
                seconds--;

            SecondsLabel.Text = seconds.ToString();
        }

        private void CancelButton_Click(object sender, EventArgs e)
        {
            Timer.Stop();

            hours = 0;
            HoursLabel.Text = hours.ToString();

            minutes = 0;
            MinutesLabel.Text = minutes.ToString();

            seconds = 0;
            SecondsLabel.Text = seconds.ToString();

            StartButton.Text = "Старт";

            ButtonEnabled();
        }

        private void StartButton_Click(object sender, EventArgs e)
        {
            if (Timer.Enabled == true)
            {
                Timer.Stop();
                StartButton.Text = "Дальше";

                ButtonEnabled();
            }
            else if (minutes != 0 || seconds != 0 || hours != 0)
            {
                Timer.Start();
                StartButton.Text = "Пауза";

                ButtonDisenabled();
            }

            
        }

        private void Timer_Tick(object sender, EventArgs e)
        {
            if (seconds > 0)
            {
                seconds--;
                SecondsLabel.Text = seconds.ToString();
                return;
            }
            
            if (minutes > 0 && seconds == 0)
            {
                minutes--;
                MinutesLabel.Text = minutes.ToString();
                seconds = 59;
                SecondsLabel.Text = seconds.ToString();
                return;
            }

            if (hours > 0 && minutes == 0 & seconds == 0)
            {
                hours--;
                HoursLabel.Text = hours.ToString();

                minutes = 59;
                MinutesLabel.Text = minutes.ToString();

                seconds = 59;
                SecondsLabel.Text = seconds.ToString();
            }

            if (hours == 0 && minutes == 0 & seconds == 0)
            {
                ButtonEnabled();
            }
        }

        public void ButtonEnabled()
        {
            MinusHoursButton.Enabled = true;
            PlusHoursButton.Enabled = true;

            MinusMinutesButton.Enabled = true;
            PlusMinutesButton.Enabled = true;

            PlusSecondsButton.Enabled = true;
            MinusSecondsButton.Enabled = true;
        }

        public void ButtonDisenabled()
        {
            MinusHoursButton.Enabled = false;
            PlusHoursButton.Enabled = false;

            MinusMinutesButton.Enabled = false;
            PlusMinutesButton.Enabled = false;

            PlusSecondsButton.Enabled = false;
            MinusSecondsButton.Enabled = false;
        }
    }
}
