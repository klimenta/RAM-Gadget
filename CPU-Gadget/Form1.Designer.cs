namespace CPU_Gadget
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.lbl1min = new System.Windows.Forms.Label();
            this.lbl2min = new System.Windows.Forms.Label();
            this.lbl3min = new System.Windows.Forms.Label();
            this.lbl4min = new System.Windows.Forms.Label();
            this.lbl5min = new System.Windows.Forms.Label();
            this.pbMove = new System.Windows.Forms.PictureBox();
            this.pbOptions = new System.Windows.Forms.PictureBox();
            this.pbMinimize = new System.Windows.Forms.PictureBox();
            this.pbExit = new System.Windows.Forms.PictureBox();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.notifyIcon1 = new System.Windows.Forms.NotifyIcon(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.pbMove)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbOptions)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbMinimize)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbExit)).BeginInit();
            this.SuspendLayout();
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // lbl1min
            // 
            this.lbl1min.AutoSize = true;
            this.lbl1min.Font = new System.Drawing.Font("Microsoft Sans Serif", 6F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl1min.ForeColor = System.Drawing.Color.Yellow;
            this.lbl1min.Location = new System.Drawing.Point(12, 63);
            this.lbl1min.Name = "lbl1min";
            this.lbl1min.Size = new System.Drawing.Size(0, 9);
            this.lbl1min.TabIndex = 4;
            // 
            // lbl2min
            // 
            this.lbl2min.AutoSize = true;
            this.lbl2min.Font = new System.Drawing.Font("Microsoft Sans Serif", 6F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl2min.ForeColor = System.Drawing.Color.Yellow;
            this.lbl2min.Location = new System.Drawing.Point(32, 63);
            this.lbl2min.Name = "lbl2min";
            this.lbl2min.Size = new System.Drawing.Size(0, 9);
            this.lbl2min.TabIndex = 5;
            // 
            // lbl3min
            // 
            this.lbl3min.AutoSize = true;
            this.lbl3min.Font = new System.Drawing.Font("Microsoft Sans Serif", 6F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl3min.ForeColor = System.Drawing.Color.Yellow;
            this.lbl3min.Location = new System.Drawing.Point(52, 63);
            this.lbl3min.Name = "lbl3min";
            this.lbl3min.Size = new System.Drawing.Size(0, 9);
            this.lbl3min.TabIndex = 6;
            // 
            // lbl4min
            // 
            this.lbl4min.AutoSize = true;
            this.lbl4min.Font = new System.Drawing.Font("Microsoft Sans Serif", 6F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl4min.ForeColor = System.Drawing.Color.Yellow;
            this.lbl4min.Location = new System.Drawing.Point(72, 63);
            this.lbl4min.Name = "lbl4min";
            this.lbl4min.Size = new System.Drawing.Size(0, 9);
            this.lbl4min.TabIndex = 7;
            // 
            // lbl5min
            // 
            this.lbl5min.AutoSize = true;
            this.lbl5min.Font = new System.Drawing.Font("Microsoft Sans Serif", 6F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl5min.ForeColor = System.Drawing.Color.Yellow;
            this.lbl5min.Location = new System.Drawing.Point(92, 63);
            this.lbl5min.Name = "lbl5min";
            this.lbl5min.Size = new System.Drawing.Size(0, 9);
            this.lbl5min.TabIndex = 8;
            // 
            // pbMove
            // 
            this.pbMove.Image = global::CPU_Gadget.Properties.Resources.hand_off;
            this.pbMove.Location = new System.Drawing.Point(112, 58);
            this.pbMove.Name = "pbMove";
            this.pbMove.Size = new System.Drawing.Size(20, 20);
            this.pbMove.TabIndex = 12;
            this.pbMove.TabStop = false;
            this.toolTip1.SetToolTip(this.pbMove, "Move");
            this.pbMove.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pbMove_MouseDown);
            this.pbMove.MouseEnter += new System.EventHandler(this.pbMove_MouseEnter);
            this.pbMove.MouseLeave += new System.EventHandler(this.pbMove_MouseLeave);
            this.pbMove.MouseMove += new System.Windows.Forms.MouseEventHandler(this.pbMove_MouseMove);
            this.pbMove.MouseUp += new System.Windows.Forms.MouseEventHandler(this.pbMove_MouseUp);
            // 
            // pbOptions
            // 
            this.pbOptions.Image = global::CPU_Gadget.Properties.Resources.options_off;
            this.pbOptions.Location = new System.Drawing.Point(114, 33);
            this.pbOptions.Name = "pbOptions";
            this.pbOptions.Size = new System.Drawing.Size(15, 15);
            this.pbOptions.TabIndex = 11;
            this.pbOptions.TabStop = false;
            this.toolTip1.SetToolTip(this.pbOptions, "Options");
            this.pbOptions.Click += new System.EventHandler(this.pbOptions_Click);
            this.pbOptions.MouseEnter += new System.EventHandler(this.pbOptions_MouseEnter);
            this.pbOptions.MouseLeave += new System.EventHandler(this.pbOptions_MouseLeave);
            // 
            // pbMinimize
            // 
            this.pbMinimize.Image = global::CPU_Gadget.Properties.Resources.min_off;
            this.pbMinimize.Location = new System.Drawing.Point(114, 17);
            this.pbMinimize.Name = "pbMinimize";
            this.pbMinimize.Size = new System.Drawing.Size(15, 15);
            this.pbMinimize.TabIndex = 10;
            this.pbMinimize.TabStop = false;
            this.toolTip1.SetToolTip(this.pbMinimize, "Minimize");
            this.pbMinimize.Click += new System.EventHandler(this.pbMinimize_Click);
            this.pbMinimize.MouseEnter += new System.EventHandler(this.pbMinimize_MouseEnter);
            this.pbMinimize.MouseLeave += new System.EventHandler(this.pbMinimize_MouseLeave);
            // 
            // pbExit
            // 
            this.pbExit.Image = global::CPU_Gadget.Properties.Resources.close_off;
            this.pbExit.Location = new System.Drawing.Point(114, 1);
            this.pbExit.Name = "pbExit";
            this.pbExit.Size = new System.Drawing.Size(15, 15);
            this.pbExit.TabIndex = 9;
            this.pbExit.TabStop = false;
            this.toolTip1.SetToolTip(this.pbExit, "Exit");
            this.pbExit.Click += new System.EventHandler(this.pbExit_Click);
            this.pbExit.MouseEnter += new System.EventHandler(this.pbExit_MouseEnter);
            this.pbExit.MouseLeave += new System.EventHandler(this.pbExit_MouseLeave);
            // 
            // notifyIcon1
            // 
            this.notifyIcon1.Icon = ((System.Drawing.Icon)(resources.GetObject("notifyIcon1.Icon")));
            this.notifyIcon1.Text = "CPU-Gadget";
            this.notifyIcon1.Visible = true;
            this.notifyIcon1.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.notifyIcon1_MouseDoubleClick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(119, 82);
            this.Controls.Add(this.pbMove);
            this.Controls.Add(this.pbOptions);
            this.Controls.Add(this.pbMinimize);
            this.Controls.Add(this.pbExit);
            this.Controls.Add(this.lbl5min);
            this.Controls.Add(this.lbl4min);
            this.Controls.Add(this.lbl3min);
            this.Controls.Add(this.lbl2min);
            this.Controls.Add(this.lbl1min);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.Text = "Form1";
            this.TransparencyKey = System.Drawing.Color.Black;
            this.Activated += new System.EventHandler(this.Form1_Activated);
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.Form1_Paint);
            this.Enter += new System.EventHandler(this.Form1_Enter);
            this.Resize += new System.EventHandler(this.Form1_Resize);
            ((System.ComponentModel.ISupportInitialize)(this.pbMove)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbOptions)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbMinimize)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbExit)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label lbl1min;
        private System.Windows.Forms.Label lbl2min;
        private System.Windows.Forms.Label lbl3min;
        private System.Windows.Forms.Label lbl4min;
        private System.Windows.Forms.Label lbl5min;
        private System.Windows.Forms.PictureBox pbExit;
        private System.Windows.Forms.PictureBox pbMinimize;
        private System.Windows.Forms.PictureBox pbOptions;
        private System.Windows.Forms.PictureBox pbMove;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.NotifyIcon notifyIcon1;
    }
}

