using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Threading;
using System.Windows.Forms;

using NotificationWindow; 

namespace eliteNotifier
{
    public partial class Form1 : Form
    {
        private WindowsServiceMonitor MonTone; 

        public Form1()
        {
            InitializeComponent();
            //contextMenuStrip1.Renderer = 
            //new MyRenderer();

             this.notifyIcon1.ShowBalloonTip(300);

           // this.popupNotifier1.Popup();

             this.MonTone = new WindowsServiceMonitor();

             Thread monThread = new Thread(this.MonTone.StartMonitor);
             monThread.Start();
             //this.MonTone.StartMonitor();

            this.MonTone.MessageRecieved += 
                new WindowsServiceMonitor.MessageReceivedHandler(
                    MonTone_MessageRecieved);
                
        }

        private void MonTone_MessageRecieved(string message)
        {
            this.notifyIcon1.BalloonTipText = 
               message.ToString() +
               Environment.NewLine +
               " Success! Staples® EasyTech™ Small Business Class has\n" +
               " detected and fixed a potential issue " +
               "with this computer.\n" +
               Environment.NewLine;
            this.notifyIcon1.ShowBalloonTip(1);
           

            
        }


        /*
        private void MonTone_MessageRecieved(string message)
        {
            this.Invoke(new WindowsServiceMonitor.MessageReceivedHandler(
                Display_MonTone_MessageRecieved), new object[] { message });
        }

        private void Display_MonTone_MessageRecieved(string message)
        {
            //this.popupNotifier1.Popup();
            this.notifyIcon1.BalloonTipText = @"                        " +
               message.ToString() +
               Environment.NewLine +
               @"Success!  Staples® EasyTech™ Small Business Class has detected and fixed a potential issue with this computer";
            this.notifyIcon1.ShowBalloonTip(5);
        }

         */

        private class MyRenderer : ToolStripProfessionalRenderer
        {
            public MyRenderer() : base(new MyColors()) { }
        }

        private class MyColors : ProfessionalColorTable
        {
            public override Color MenuItemSelected
            {
                //get { return Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(118)))), ((int)(((byte)(135))))); }
                get { return Color.White; }
            }
            public override Color MenuItemSelectedGradientBegin
            {
                get { return Color.Orange; }
            }
            public override Color MenuItemSelectedGradientEnd
            {
                get { return Color.Yellow; }
            }
        }

       

        //sets the visibility of the form to invisble so that the form is not show on launch
        //also set are forms - showOnTaskbar property and WindowStateMinimized - are set to false .. which is not necessary
       
        protected override void SetVisibleCore(bool value)
        {
            base.SetVisibleCore(false);
        }
        
        
        //on exit visibility is set back to visibile so as to exit the form
        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {


            base.SetVisibleCore(true);
            base.Dispose();
           // this.Close();
           // this.Dispose();

            MonTone.Dispose();
        }
       
        #region MouseEventsFor-exitToolStripMenuItem

        private void exitToolStripMenuItem_MouseEnter(object sender, EventArgs e)
        {
            this.exitToolStripMenuItem.BackColor = 
                System.Drawing.Color.FromArgb(((int)(((byte)(100)))), 
                ((int)(((byte)(118)))), 
                ((int)(((byte)(135)))));
            this.exitToolStripMenuItem.Font = 
                new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            //this.exitToolStripMenuItem.ForeColor = System.Drawing.Color.White;
            this.exitToolStripMenuItem.ForeColor = 
                System.Drawing.Color.Black;
        }

        private void exitToolStripMenuItem_MouseLeave(object sender, EventArgs e)
        {
            /*
            this.exitToolStripMenuItem.BackColor = System.Drawing.Color.White;
            this.exitToolStripMenuItem.Font = null;
            this.exitToolStripMenuItem.ForeColor = System.Drawing.Color.Black;
            */

            this.exitToolStripMenuItem.BackColor =
             System.Drawing.Color.FromArgb(((int)(((byte)(100)))),
             ((int)(((byte)(118)))),
             ((int)(((byte)(135)))));
            this.exitToolStripMenuItem.Font =
                new System.Drawing.Font("Segoe UI", 9.00F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.exitToolStripMenuItem.ForeColor =
                System.Drawing.Color.White;

        }

        #endregion

        #region MouseEventsFor-aboutToolStripMenuItem

        private void aboutToolStripMenuItem_MouseEnter(object sender, EventArgs e)
        {
            this.aboutToolStripMenuItem.BackColor = 
                System.Drawing.Color.FromArgb(((int)(((byte)(100)))),
                ((int)(((byte)(118)))),
                ((int)(((byte)(135)))));
            this.aboutToolStripMenuItem.Font = 
                new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            //this.exitToolStripMenuItem.ForeColor = System.Drawing.Color.White;
            this.aboutToolStripMenuItem.ForeColor = System.Drawing.Color.Black;
        }

        private void aboutToolStripMenuItem_MouseLeave(object sender, EventArgs e)
        {
            /*
            this.aboutToolStripMenuItem.BackColor = System.Drawing.Color.White;
            this.aboutToolStripMenuItem.Font = null;
            this.aboutToolStripMenuItem.ForeColor = System.Drawing.Color.Black;
            */

            this.aboutToolStripMenuItem.BackColor =
               System.Drawing.Color.FromArgb(((int)(((byte)(100)))),
               ((int)(((byte)(118)))),
               ((int)(((byte)(135)))));
            this.aboutToolStripMenuItem.Font =
                new System.Drawing.Font("Segoe UI", 9.00F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.aboutToolStripMenuItem.ForeColor =
                System.Drawing.Color.White;

        }

        #endregion


        #region MouseEventsFor-chatWithATechNowToolStripMenuItem

        private void chatWithATechNowToolStripMenuItem_MouseEnter(object sender, EventArgs e)
        {
            this.chatWithATechNowToolStripMenuItem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(118)))), ((int)(((byte)(135)))));
            this.chatWithATechNowToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            //this.exitToolStripMenuItem.ForeColor = System.Drawing.Color.White;
            this.chatWithATechNowToolStripMenuItem.ForeColor = System.Drawing.Color.Black;
        }

        private void chatWithATechNowToolStripMenuItem_MouseLeave(object sender, EventArgs e)
        {
            /*
            this.chatWithATechNowToolStripMenuItem.BackColor = System.Drawing.Color.White;
            this.chatWithATechNowToolStripMenuItem.Font = null;
            this.chatWithATechNowToolStripMenuItem.ForeColor = System.Drawing.Color.Black;
       
             */


            this.chatWithATechNowToolStripMenuItem.BackColor = 
                System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(118)))), ((int)(((byte)(135)))));
            this.chatWithATechNowToolStripMenuItem.Font = 
                new System.Drawing.Font("Segoe UI", 9.00F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chatWithATechNowToolStripMenuItem.ForeColor = 
                System.Drawing.Color.White;

        }

        #endregion

        #region MouseEventsFor-myDeviceInfoToolStripMenuItem

        private void myDeviceInfoToolStripMenuItem_MouseEnter(object sender, EventArgs e)
        {
            this.myDeviceInfoToolStripMenuItem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(118)))), ((int)(((byte)(135)))));
            this.myDeviceInfoToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            //this.exitToolStripMenuItem.ForeColor = System.Drawing.Color.White;
            this.myDeviceInfoToolStripMenuItem.ForeColor = System.Drawing.Color.Black;
        }

        private void myDeviceInfoToolStripMenuItem_MouseLeave(object sender, EventArgs e)
        {
            /*
            this.myDeviceInfoToolStripMenuItem.BackColor = System.Drawing.Color.White;
            this.myDeviceInfoToolStripMenuItem.Font = null;
            this.myDeviceInfoToolStripMenuItem.ForeColor = System.Drawing.Color.Black;
               */

            this.myDeviceInfoToolStripMenuItem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(118)))), ((int)(((byte)(135)))));
            this.myDeviceInfoToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 9.00F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.myDeviceInfoToolStripMenuItem.ForeColor = System.Drawing.Color.White;

          

        }

        #endregion


        #region MouseEventsFor-executeDetailedOptimizationToolStripMenuItem

        private void executeDetailedOptimizationToolStripMenuItem_MouseEnter(object sender, EventArgs e)
        {
            this.executeDetailedOptimizationToolStripMenuItem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(118)))), ((int)(((byte)(135)))));
            this.executeDetailedOptimizationToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            //this.exitToolStripMenuItem.ForeColor = System.Drawing.Color.White;
            this.executeDetailedOptimizationToolStripMenuItem.ForeColor = System.Drawing.Color.Black;
        }

        private void executeDetailedOptimizationToolStripMenuItem_MouseLeave(object sender, EventArgs e)
        {
            /*
            this.executeDetailedOptimizationToolStripMenuItem.BackColor = System.Drawing.Color.White;
            this.executeDetailedOptimizationToolStripMenuItem.Font = null;
            this.executeDetailedOptimizationToolStripMenuItem.ForeColor = System.Drawing.Color.Black;
            */

            this.executeDetailedOptimizationToolStripMenuItem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(118)))), ((int)(((byte)(135)))));
            this.executeDetailedOptimizationToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 9.00F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.executeDetailedOptimizationToolStripMenuItem.ForeColor = System.Drawing.Color.White;

        }

        #endregion



        #region MouseEventsFor-optimizePerformanceNowToolStripMenuItem

        private void optimizePerformanceNowToolStripMenuItem_MouseEnter(object sender, EventArgs e)
        {
            //saveCurrentState
            
            this.optimizePerformanceNowToolStripMenuItem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(118)))), ((int)(((byte)(135)))));
            this.optimizePerformanceNowToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            //this.exitToolStripMenuItem.ForeColor = System.Drawing.Color.White;
            this.optimizePerformanceNowToolStripMenuItem.ForeColor = System.Drawing.Color.Black;
        }

        private void optimizePerformanceNowToolStripMenuItem_MouseLeave(object sender, EventArgs e)
        {
            /*
            this.optimizePerformanceNowToolStripMenuItem.BackColor = System.Drawing.Color.White;
            this.optimizePerformanceNowToolStripMenuItem.Font = null;
            this.optimizePerformanceNowToolStripMenuItem.ForeColor = System.Drawing.Color.Black;
        
             */

            this.optimizePerformanceNowToolStripMenuItem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(118)))), ((int)(((byte)(135)))));
            this.optimizePerformanceNowToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 9.00F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.optimizePerformanceNowToolStripMenuItem.ForeColor = System.Drawing.Color.White;
            //this.optimizePerformanceNowToolStripMenuItem.ForeColor = System.Drawing.Color.Black;

        }

        #endregion


        #region MouseEventsFor-schedulePerformanceOptimizationToolStripMenuItem

        private void schedulePerformanceOptimizationToolStripMenuItem_MouseEnter(object sender, EventArgs e)
        {
            this.schedulePerformanceOptimizationToolStripMenuItem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(118)))), ((int)(((byte)(135)))));
            this.schedulePerformanceOptimizationToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            //this.exitToolStripMenuItem.ForeColor = System.Drawing.Color.White;
            this.schedulePerformanceOptimizationToolStripMenuItem.ForeColor = System.Drawing.Color.Black;
        }

        private void schedulePerformanceOptimizationToolStripMenuItem_MouseLeave(object sender, EventArgs e)
        {
            this.schedulePerformanceOptimizationToolStripMenuItem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(118)))), ((int)(((byte)(135)))));
            this.schedulePerformanceOptimizationToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 9.00F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.schedulePerformanceOptimizationToolStripMenuItem.ForeColor = System.Drawing.Color.White;
        }

        #endregion



        #region MouseEventsFor-staplesEasyTechSmallBusinessClassToolStripMenuItem

        private void staplesEasyTechSmallBusinessClassToolStripMenuItem_MouseEnter(
            object sender, EventArgs e)
        {
            this.staplesEasyTechSmallBusinessClassToolStripMenuItem.BackColor =
               System.Drawing.Color.White;
            this.staplesEasyTechSmallBusinessClassToolStripMenuItem.Font = 
                new System.Drawing.Font("Segoe UI", 9.75F, 
                    System.Drawing.FontStyle.Bold, 
                    System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            //this.exitToolStripMenuItem.ForeColor = System.Drawing.Color.White;
            this.staplesEasyTechSmallBusinessClassToolStripMenuItem.ForeColor = 
                System.Drawing.Color.Black;
        }

        private void staplesEasyTechSmallBusinessClassToolStripMenuItem_MouseLeave(object sender, EventArgs e)
        {
            this.staplesEasyTechSmallBusinessClassToolStripMenuItem.BackColor =
                System.Drawing.Color.FromArgb(((int)(((byte)(100)))),
                ((int)(((byte)(118)))), ((int)(((byte)(135)))));
            this.staplesEasyTechSmallBusinessClassToolStripMenuItem.Font =
                new System.Drawing.Font("Segoe UI", 9.75F,
                    System.Drawing.FontStyle.Bold,
                    System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            //this.exitToolStripMenuItem.ForeColor = System.Drawing.Color.White;
            this.staplesEasyTechSmallBusinessClassToolStripMenuItem.ForeColor =
                System.Drawing.Color.Black;
        }

        #endregion

        SchedulerForm theSchedule = new SchedulerForm();
        private void schedulePerformanceOptimizationToolStripMenuItem_Click(object sender, EventArgs e)
        {

            try
            {
                theSchedule.Show();
             

            }
            catch (System.ObjectDisposedException)
            {
                SchedulerForm theSchedule = new SchedulerForm();
                theSchedule.ShowDialog();
            }

            finally
            {

            }
        }

        CustomProgressForm theProgress = new CustomProgressForm();
        private void optimizePerformanceNowToolStripMenuItem_Click(object sender, EventArgs e)
        {

              try
            {
                theProgress.Show();
             

            }
            catch (System.ObjectDisposedException)
            {
                CustomProgressForm theProgress = new CustomProgressForm();
                theProgress.ShowDialog();
            }

            finally
            {

            }

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.popupNotifier1.Popup();
        }

    }
}
