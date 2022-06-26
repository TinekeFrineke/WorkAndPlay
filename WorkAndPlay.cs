using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Work_And_Play
{
    public partial class WorkAndPlay : Form
    {
        public WorkAndPlay()
        {
            InitializeComponent();
            InitializeTimer();

            textHours.Text = "123";
        }

        private void InitializeTimer()
        {
            timerForCurrentTime.Start();
        }

        private void StopTickStartEdit()
        {
            textHours.BackColor = Color.Aqua;
            textMinutes.BackColor = Color.Aqua;
            timerForCurrentTime.Stop();
            timerForCountDownAfterAction.Start();
        }

        private void timerForCurrentTime_Tick(object sender, EventArgs e)
        {
            textHours.Text = DateTime.Now.Hour.ToString("00");
            textMinutes.Text = DateTime.Now.Minute.ToString("00");

            textSumToday.Text = "12:10";
            textSumThisWeek.Text = "13:33";
        }

        private void textHours_MouseDown(object sender, MouseEventArgs e)
        {
            StopTickStartEdit();
        }

        private void timerForCountDownAfterAction_Tick(object sender, EventArgs e)
        {
            textHours.BackColor = Color.Pink;
            textMinutes.BackColor = Color.Pink;
            timerForCurrentTime.Start();
            timerForCountDownAfterAction.Stop();
        }

        private void textHours_KeyDown(object sender, KeyEventArgs e)
        {
            StopTickStartEdit();
        }

        private void textMinutes_MouseDown(object sender, MouseEventArgs e)
        {
            StopTickStartEdit();
        }

        private void textMinutes_KeyDown(object sender, KeyEventArgs e)
        {
            StopTickStartEdit();
        }

        private void textHours_Enter(object sender, EventArgs e)
        {
            StopTickStartEdit();
        }

        private void textMinutes_Enter(object sender, EventArgs e)
        {
            StopTickStartEdit();
        }

        private void buttonNow_Click(object sender, EventArgs e)
        {
            textHours.Text = DateTime.Now.Hour.ToString();
            textMinutes.Text = DateTime.Now.Minute.ToString();
        }
    }
}
