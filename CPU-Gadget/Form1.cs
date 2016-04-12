﻿using System;
using System.Drawing;
using System.Windows.Forms;
using System.Diagnostics;
using Microsoft.VisualBasic.Devices;

namespace RAM_Gadget
{
    public partial class Form1 : Form
    {
        const int intGapX = 2;
        int intX = intGapX;
        int intY = 60;
        int intRAMUtilization = 0;
        public static int intWarningThreshold = 50;
        public static int intCriticalThreshold = 90;
        int intInterval = 0;
        private bool mouseDown;
        private Point lastLocation;
        public static bool bTransparent;
        public static bool bStayOnTop;
        public static int intTimer = 1;
        public static ulong ulRAM;
        
        MemoryUsage muRAM = new MemoryUsage();
        public static Pen myRedPen = new Pen(System.Drawing.Color.Red);
        public static Pen myGreenPen = new Pen(System.Drawing.Color.Green);
        public static Pen myYellowPen = new Pen(System.Drawing.Color.Yellow);
        public static Color BackgroundColor;
        Pen penColor;
        private Bitmap bmpSurface;
        Graphics objBitmapGraphics;
        Rectangle rectBounds;
        public static frmOptions frmBox;

        public Form1()
        {
            InitializeComponent();      
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            DrawRAMUsage();
            Invalidate();            
            intInterval++;
            if (intInterval == 100)
            {
                objBitmapGraphics.Clear(BackgroundColor);
                intInterval = 0;
                intX = intGapX;
                lbl5min.Text = intRAMUtilization.ToString();                
            }
            if (intInterval == 20)
            {
                lbl1min.Text = intRAMUtilization.ToString();
            }
            if (intInterval == 40)
            {
                lbl2min.Text = intRAMUtilization.ToString();
            }
            if (intInterval == 60)
            {
                lbl3min.Text = intRAMUtilization.ToString();
            }
            if (intInterval == 80)
            {
                lbl4min.Text = intRAMUtilization.ToString();
            }       
        }

        public class MemoryUsage
        {
            const float sampleFrequencyMillis = 1000;
            protected object syncLock = new object();
            protected PerformanceCounter counter;
            protected float lastSample;
            protected DateTime lastSampleTime;

            public MemoryUsage()
            {
                counter = new PerformanceCounter("Memory", "Available MBytes");                                     
            }

            public float GetCurrentValue()
            {
                if ((DateTime.UtcNow - lastSampleTime).TotalMilliseconds > sampleFrequencyMillis)
                {
                    lock (syncLock)
                    {
                        if ((DateTime.UtcNow - lastSampleTime).TotalMilliseconds > sampleFrequencyMillis)
                        {
                            lastSample = counter.NextValue();
                            lastSampleTime = DateTime.UtcNow;
                        }
                    }
                }
                return lastSample;
            }
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            myRedPen.Dispose();
            myGreenPen.Dispose();
            myYellowPen.Dispose();
            objBitmapGraphics.Dispose();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            ComputerInfo CI = new ComputerInfo();
            ulRAM = (CI.TotalPhysicalMemory / 1024)  / 1024;
                        
            BackColor = Color.Black;
            BackgroundColor = BackColor;
            AllowTransparency = true;
            timer1.Interval = intTimer * 1000;
            ShowInTaskbar = false;          

            bTransparent = true;
            bStayOnTop = true;
            TopMost = true;
            bmpSurface = new Bitmap(ClientRectangle.Width, ClientRectangle.Height);            
            objBitmapGraphics = Graphics.FromImage(bmpSurface);
            objBitmapGraphics.Clear(BackgroundColor);
            rectBounds = new Rectangle(0, 0, bmpSurface.Width, bmpSurface.Height);
        }

        private void DrawRAMUsage()
        {         
            float flRAM = muRAM.GetCurrentValue();
            flRAM = 100 - ((flRAM / ulRAM) * 100);
            intRAMUtilization = Convert.ToInt32(flRAM);           

            if (intRAMUtilization < intWarningThreshold) { penColor = myGreenPen; }
            if (intRAMUtilization >= intWarningThreshold && intRAMUtilization <= intCriticalThreshold) { penColor = myYellowPen; }
            if (intRAMUtilization > intCriticalThreshold) { penColor = myRedPen; }

            rectBounds.Inflate(-1, -1);

            objBitmapGraphics.DrawLine(penColor, intX, intY , intX , intY - (intRAMUtilization / 2) );            
            
            intX = intX + 1;
        }

        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            Graphics objFormGraphics;
            objFormGraphics = e.Graphics;            
            objFormGraphics.DrawImage(bmpSurface, 0, 0, bmpSurface.Width, bmpSurface.Height);
            objFormGraphics.Dispose();
        }

        private void pbMinimize_MouseEnter(object sender, EventArgs e)
        {
            pbMinimize.Image = ((System.Drawing.Image)(Properties.Resources.min_on));
        }

        private void pbMinimize_MouseLeave(object sender, EventArgs e)
        {
            pbMinimize.Image = ((System.Drawing.Image)(Properties.Resources.min_off));
        }

        private void pbExit_MouseEnter(object sender, EventArgs e)
        {
            pbExit.Image = ((System.Drawing.Image)(Properties.Resources.close_on));
        }

        private void pbExit_MouseLeave(object sender, EventArgs e)
        {
            pbExit.Image = ((System.Drawing.Image)(Properties.Resources.close_off));
        }

        private void pbExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void pbMinimize_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;            
        }

        private void pbOptions_MouseEnter(object sender, EventArgs e)
        {
            pbOptions.Image = ((System.Drawing.Image)(Properties.Resources.options_on));
        }

        private void pbOptions_MouseLeave(object sender, EventArgs e)
        {
            pbOptions.Image = ((System.Drawing.Image)(Properties.Resources.options_off));
        }

        private void pbMove_MouseEnter(object sender, EventArgs e)
        {
            pbMove.Image = ((System.Drawing.Image)(Properties.Resources.hand_on));
        }

        private void pbMove_MouseLeave(object sender, EventArgs e)
        {
            pbMove.Image = ((System.Drawing.Image)(Properties.Resources.hand_off));
        }

        private void pbMove_MouseDown(object sender, MouseEventArgs e)
        {
            mouseDown = true;
            lastLocation = e.Location;
        }

        private void pbMove_MouseMove(object sender, MouseEventArgs e)
        {
            if (mouseDown)
            {
                this.Location = new Point(
                    (this.Location.X - lastLocation.X) + e.X, (this.Location.Y - lastLocation.Y) + e.Y);

                this.Update();
            }
        }

        private void pbMove_MouseUp(object sender, MouseEventArgs e)
        {
            mouseDown = false;
        }

        private void pbOptions_Click(object sender, EventArgs e)
        {
            frmOptions frmBox = new frmOptions();
            frmBox.ShowDialog();
        }

        private void Form1_Enter(object sender, EventArgs e)
        {
            MessageBox.Show("Enter");
        }

        private void Form1_Activated(object sender, EventArgs e)
        {
            if (bTransparent)
            {
                TransparencyKey = BackgroundColor;
            }
            else TransparencyKey = Color.Empty;
            if (bStayOnTop)
            {
                TopMost = true;                
            }
            else TopMost = false;
            BackColor = BackgroundColor;
            timer1.Interval = intTimer * 1000;           
        }

        private void notifyIcon1_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            Show();
            WindowState = FormWindowState.Normal;
        }

        private void Form1_Resize(object sender, EventArgs e)
        {
            if (FormWindowState.Minimized == WindowState)
                Hide();
        }
    }
}
