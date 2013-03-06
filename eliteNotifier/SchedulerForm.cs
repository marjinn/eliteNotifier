using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace eliteNotifier
{
    public partial class SchedulerForm : Form
    {
        public SchedulerForm()
        {
            InitializeComponent();
        }



        private void Exit_Click(object sender, EventArgs e)
        {
            this.Close();
            this.Dispose();
           
        }
      

        private void Save_Schedule_Click(object sender, EventArgs e)
        {
            
            string dateTimePickerText = dateTimePicker1.Text.ToString();
            string dateTimePickerTimeText = dateTimePicker2.Text.ToString();
            string checkedRadioButton = "";
            if (radioButtonMonthly.Checked == true)
            {
                checkedRadioButton = radioButtonMonthly.Text;
            }



            if (radioButtonWeekly.Checked == true)
            {
                checkedRadioButton = radioButtonWeekly.Text;
            }



            if (radioButtonDaily.Checked == true)
            {
                checkedRadioButton = radioButtonDaily.Text;
            }



            if (radioButtonDateOfChoice.Checked == true)
            {
                checkedRadioButton = radioButtonDateOfChoice.Text;
            }

            //MessageBox.Show("Date : " + dateTimePickerText + " " + "\nTime : " + dateTimePickerTimeText + "\nSchedule Chosen : " + checkedRadioButton.ToUpper());
            Schedule.Text = "Date : " + dateTimePickerText + " " + "  Time : " + dateTimePickerTimeText + "\n\nSchedule Chosen :" + checkedRadioButton.ToUpper();


           

        }
    }
}
