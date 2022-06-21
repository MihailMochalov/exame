using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Media;

namespace Alarm
{
    public partial class Form1 : Form
    {
        int alarm_hour;
        int alarm_minute;
        int hour, minute, second;

        SoundPlayer sp = new SoundPlayer("C:\\Users\\epth\\Downloads\\Alarm (1)\\alarm.wav");
        public Form1()
        {
            InitializeComponent();

            numericUpDown1.Maximum = 23;
            numericUpDown2.Maximum = 59;
           
            timer1.Interval = 1000;
            timer1.Tick += new EventHandler(timer1_Tick);
            timer1.Start();
            
        }

        
        private void Svernut_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

       

        private void notifyIcon1_Click(object sender, EventArgs e)
        {
            contextMenuStrip1.Show();
        }

        

        private void notifyIcon1_MouseClick(object sender, MouseEventArgs e)
        {
            contextMenuStrip1.Show();
        }

        private void выходToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void свернутьРазвернутььToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if(this.WindowState == FormWindowState.Minimized)
            {
                this.WindowState = FormWindowState.Normal;
            }
            else
            {
                this.WindowState = FormWindowState.Minimized;
            }
        }

        

        private void notifyIcon1_MouseClick_1(object sender, MouseEventArgs e)
        {
            contextMenuStrip1.Show();
        }

        private void оПрограммеToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Экзаменационное задание номер 7 - Будильник");
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            current_Time.Text = DateTime.Now.Hour.ToString("00") + ":" + DateTime.Now.Minute.ToString("00") + ":" + DateTime.Now.Second.ToString("00");
            hour = DateTime.Now.Hour;
            minute = DateTime.Now.Minute;
            second = DateTime.Now.Second;
            alarm_hour = (int)numericUpDown1.Value;
            alarm_minute = (int)numericUpDown2.Value;
            if (checkBox1.Checked)
            {
                numericUpDown1.Enabled = false;
                numericUpDown2.Enabled = false;
                Ring_Alarm();            
            }
            else
            {
                numericUpDown1.Enabled = true;
                numericUpDown2.Enabled = true;
            }

        }

        void Ring_Alarm()
        {

            if (alarm_hour == hour && alarm_minute == minute && second == 0)
            {
                checkBox1.Checked = false;
                sp.Play();
                MessageBox.Show("Время!");

            }
        }
        
    }
}
