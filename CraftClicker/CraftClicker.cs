using System;
using System.Diagnostics;
using System.Drawing;
using System.Threading;
using System.Windows.Forms;
using System.Windows.Input;
using Timer = System.Windows.Forms.Timer;

namespace TimerTest
{
    public partial class CraftClicker: Form
    {
        //Mouse actions


        private readonly int intervallMilliseconds = 10000;
        private readonly Timer timer;
        private bool assignKeyFlag;
        private Key hotKey = Key.F7;
        private int iterationsLeft = -1;
        private int mouseX;
        private int mouseY;

        public CraftClicker()
        {
            this.InitializeComponent();

            this.Icon = Icon.ExtractAssociatedIcon(Application.ExecutablePath);
            for(var i = 0; i < 1000; i++)
            {
                this.secIntervalComboBox.Items.Add(i);
            }
            this.secIntervalComboBox.SelectedIndex = 5;
            for(var i = 0; i < 99; i++)
            {
                this.minInternvalComboBox.Items.Add(i);
            }
            this.minInternvalComboBox.SelectedIndex = 0;
            for(var i = 0; i < 99; i++)
            {
                this.secDelayComboBox.Items.Add(i);
            }
            this.secDelayComboBox.SelectedIndex = 2;
            for(var i = 0; i < 999; i++)
            {
                this.iterationsComboBox.Items.Add(i);
            }
            this.iterationsComboBox.SelectedIndex = 10;
            this.mouseLocRadioButton.Checked = true;
            this.infiniteIterationsRadioButton.Checked = true;

            this.timer = new Timer();
            this.timer.Interval = this.intervallMilliseconds;
            this.timer.Tick += this.TimerOnTick;


            WinApi.RegisterHotKey(this.Handle, 1, 0, (int)this.hotKey);
            this.assignButton.Text = @"Assign - " + this.hotKey;
            this.assignButton.KeyDown += this.AssignButtonOnKeyDown;
        }

        #region Overrides of Form
        protected override void OnClosed(EventArgs e)
        {
            WinApi.UnregisterHotKey(this.Handle, 1);
            base.OnClosed(e);
        }
        #endregion

        protected override void WndProc(ref Message m)
        {
            if(!this.assignKeyFlag)
            {
                if(m.Msg == WinApi.WM_HOTKEY&&(int)m.WParam == 1)
                {
                    this.StartTimerRun();
                }
            }
            base.WndProc(ref m);
        }

        private void assignButton_Click(object sender, EventArgs e)
        {
            this.assignKeyFlag = true;
            this.assignButton.Text = @">> Assign <<";
            ;
        }

        private void AssignButtonOnKeyDown(object sender, KeyEventArgs e)
        {
            if(!this.assignKeyFlag)
            {
                this.OnKeyDown(e);
            }
            WinApi.UnregisterHotKey(this.Handle, 1);
            var modKey = 0;
            /*           if(e.Shift)
                       {
                           modKey = +WinApi.MOD_SHIFT;
                       }
                       if(e.Control)
                       {
                           modKey = +WinApi.MOD_CONTROL;
                       }*/
            this.hotKey = (Key)e.KeyValue;
            this.assignButton.Text = @"Assign - " + e.KeyCode;
            WinApi.RegisterHotKey(this.Handle, 1, modKey, e.KeyValue);
            this.assignKeyFlag = false;
        }

        private void DisableTimer()
        {
            this.timer.Enabled = false;
            this.startButton.Text = @"Start";
        }

        private void DoMouseClick()
        {
            //Call the imported function with the cursor's current position
            if(this.mouseLocRadioButton.Checked)
            {
                this.mouseX = Cursor.Position.X;
                this.mouseY = Cursor.Position.Y;
                WinApi.LeftClick(this.mouseX, this.mouseY);
            }
            else
            {
                var oldCoordinates = WinApi.ConvertCoordinates(Cursor.Position.X, Cursor.Position.Y);
                var targetCoordinates = WinApi.ConvertCoordinates(this.mouseX, this.mouseY);

                WinApi.SetFocusToPoint(new Point(this.mouseX, this.mouseY));

                WinApi.MoveTo(targetCoordinates.X, targetCoordinates.Y);
                Thread.Sleep(10);
                WinApi.LeftClick(targetCoordinates.X, targetCoordinates.Y);
                Thread.Sleep(10);

                //                WinApi.LeftClick(targetCoordinates.X, targetCoordinates.Y);
                Thread.Sleep(10);

                //                ClickSimulator.ClickOnPoint(targetCoordinates);
                WinApi.MoveTo(oldCoordinates.X, oldCoordinates.Y);
            }
            Debug.WriteLine($"X:{this.mouseX} Y:{this.mouseY}");

            //            ClickSimulator.ClickOnPoint(new Point( this.mouseX,this.mouseY));


            //            MouseSimulator.ClickLeftMouseButton(this.mouseX,this.mouseY);
            //            WinApi.mouse_event(MOUSEEVENTF_MOVE, this.mouseX, this.mouseY, 0, 0);

            //            WinApi.mouse_event(MOUSEEVENTF_ABSOLUTE |MOUSEEVENTF_LEFTDOWN, this.mouseX,this.mouseY, 0, 0);
            //            WinApi.mouse_event(MOUSEEVENTF_ABSOLUTE |MOUSEEVENTF_LEFTUP, this.mouseX,this.mouseY, 0, 0);
        }


        private void EnableTimer()
        {
            if(this.fixNumberOfIterationsRadioButton.Checked)
            {
                this.iterationsLeft = Convert.ToInt32(this.iterationsComboBox.SelectedItem);
            }
            if(!this.mouseLocRadioButton.Checked)
            {
                this.mouseX = Cursor.Position.X;
                this.mouseY = Cursor.Position.Y;
            }
            this.SetRandomInterval();
            this.timer.Enabled = true;
            this.startButton.Text = @"Stop";
        }


        private void SetRandomInterval()
        {
            var random = new Random();
            var timerInterval = Convert.ToInt32(this.secIntervalComboBox.SelectedItem) * 1000 + Convert.ToInt32(this.minInternvalComboBox.SelectedItem) * 60 * 1000 + random.Next(Convert.ToInt32(this.secDelayComboBox.SelectedItem) * 1000);
            Debug.WriteLine("TimerInterval:" + timerInterval + "ms");
            this.timer.Interval = timerInterval;
        }

        private void StartButtonClick(object sender, EventArgs e)
        {
            this.StartTimerRun();
        }

        private void StartTimerRun()
        {
            if(this.timer.Enabled)
            {
                this.DisableTimer();
            }
            else
            {
                this.EnableTimer();
            }
        }

        private void TimerOnTick(object sender, EventArgs eventArgs)
        {
            if(this.fixNumberOfIterationsRadioButton.Checked)
            {
                this.iterationsLeft--;
            }
            if(this.fixNumberOfIterationsRadioButton.Checked&&this.iterationsLeft < 1)
            {
                this.DisableTimer();
                return;
            }
            this.DoMouseClick();
            this.SetRandomInterval();
            Debug.WriteLine("Interval: " + this.timer.Interval);
        }

        #region Overrides of Control
        #endregion
    }
}
