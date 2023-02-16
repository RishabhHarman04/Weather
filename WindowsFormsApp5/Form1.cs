using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp5
{
    public partial class Form1 : Form
    {
        private int panelIndex = 1;

        public Form1()
        {
            InitializeComponent();
            UpdateLabels();
            timer1.Interval = 10000; 
            timer1.Tick += timer1_Tick;
            timer1.Start();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
        private void label4_Click(object sender, EventArgs e)
        {

        }


        private void lblAtmosphere2_Click(object sender, EventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            panelIndex++;
            if (panelIndex > 3)
            {
                panelIndex = 1;
            }
            UpdateLabels();
        }
        private void UpdateLabels()
        {
            Random rnd = new Random();
            int humidity = rnd.Next(0, 101);
            int atmosphere = rnd.Next(700, 1500);
            int temperature = rnd.Next(0, 101);

            switch (panelIndex)
            {
                case 1:
                    label1.Text = "Weather of Bengaluru";
                    lblHumidity.Text = $"Humidity: {rnd.Next(0, 101)}%";
                    lblAtmosphere.Text = $"Atmosphere: {rnd.Next(700, 1500)} Pa";
                    lblTemperature.Text = $"Temperature: {rnd.Next(0, 101)}°C";
                    break;
                case 2:
                    label1.Text = "Weather of Varanasi";
                    lblHumidity.Text = $"Humidity: {rnd.Next(0, 101)}%";
                    lblAtmosphere.Text = $"Atmosphere: {rnd.Next(700, 1500)} Pa";
                    lblTemperature.Text = $"Temperature: {rnd.Next(0, 101)}°F";
                    break;
                case 3:
                    label1.Text = "Weather of Madikeri";
                    lblHumidity.Text = $"Humidity: {rnd.Next(0, 101)}%";
                    lblAtmosphere.Text = $"Atmosphere: {rnd.Next(700, 1500)} kPa";
                    lblTemperature.Text = $"Temperature: {rnd.Next(-273, 101)}K";
                    break;
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            int w = Screen.PrimaryScreen.Bounds.Width;
            int h = Screen.PrimaryScreen.Bounds.Height;
            this.Location = new Point(0, 0);
            this.Size = new Size(w, h);
        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }
    }
}



      

