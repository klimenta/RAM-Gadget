namespace CPU_Gadget
{
    partial class frmOptions
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmOptions));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lblBGColor = new System.Windows.Forms.Label();
            this.btnBGColor = new System.Windows.Forms.Button();
            this.btnCritical = new System.Windows.Forms.Button();
            this.btnWarning = new System.Windows.Forms.Button();
            this.btnNormal = new System.Windows.Forms.Button();
            this.lblCritical = new System.Windows.Forms.Label();
            this.lblWarning = new System.Windows.Forms.Label();
            this.lblNormal = new System.Windows.Forms.Label();
            this.colorDialog1 = new System.Windows.Forms.ColorDialog();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.neCritical = new System.Windows.Forms.NumericUpDown();
            this.neWarning = new System.Windows.Forms.NumericUpDown();
            this.lblAlarmCritical = new System.Windows.Forms.Label();
            this.lblAlarmWarning = new System.Windows.Forms.Label();
            this.cbTransparent = new System.Windows.Forms.CheckBox();
            this.btnOK = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.cbStayOnTop = new System.Windows.Forms.CheckBox();
            this.neInterval = new System.Windows.Forms.NumericUpDown();
            this.lblInterval = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.lblNote = new System.Windows.Forms.Label();
            this.llblCopyright = new System.Windows.Forms.LinkLabel();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.neCritical)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.neWarning)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.neInterval)).BeginInit();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lblBGColor);
            this.groupBox1.Controls.Add(this.btnBGColor);
            this.groupBox1.Controls.Add(this.btnCritical);
            this.groupBox1.Controls.Add(this.btnWarning);
            this.groupBox1.Controls.Add(this.btnNormal);
            this.groupBox1.Controls.Add(this.lblCritical);
            this.groupBox1.Controls.Add(this.lblWarning);
            this.groupBox1.Controls.Add(this.lblNormal);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(127, 196);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "  < Colors >  ";
            // 
            // lblBGColor
            // 
            this.lblBGColor.AutoSize = true;
            this.lblBGColor.Location = new System.Drawing.Point(9, 150);
            this.lblBGColor.Name = "lblBGColor";
            this.lblBGColor.Size = new System.Drawing.Size(92, 13);
            this.lblBGColor.TabIndex = 0;
            this.lblBGColor.Text = "Background Color";
            // 
            // btnBGColor
            // 
            this.btnBGColor.Location = new System.Drawing.Point(12, 165);
            this.btnBGColor.Name = "btnBGColor";
            this.btnBGColor.Size = new System.Drawing.Size(100, 25);
            this.btnBGColor.TabIndex = 6;
            this.btnBGColor.Text = "...";
            this.btnBGColor.UseVisualStyleBackColor = true;
            this.btnBGColor.Click += new System.EventHandler(this.btnBGColor_Click);
            // 
            // btnCritical
            // 
            this.btnCritical.Location = new System.Drawing.Point(10, 125);
            this.btnCritical.Name = "btnCritical";
            this.btnCritical.Size = new System.Drawing.Size(100, 25);
            this.btnCritical.TabIndex = 5;
            this.btnCritical.Text = "...";
            this.btnCritical.UseVisualStyleBackColor = true;
            this.btnCritical.Click += new System.EventHandler(this.btnCritical_Click);
            // 
            // btnWarning
            // 
            this.btnWarning.Location = new System.Drawing.Point(10, 80);
            this.btnWarning.Name = "btnWarning";
            this.btnWarning.Size = new System.Drawing.Size(100, 25);
            this.btnWarning.TabIndex = 4;
            this.btnWarning.Text = "...";
            this.btnWarning.UseVisualStyleBackColor = true;
            this.btnWarning.Click += new System.EventHandler(this.btnWarning_Click);
            // 
            // btnNormal
            // 
            this.btnNormal.Location = new System.Drawing.Point(10, 35);
            this.btnNormal.Name = "btnNormal";
            this.btnNormal.Size = new System.Drawing.Size(100, 25);
            this.btnNormal.TabIndex = 3;
            this.btnNormal.Text = "...";
            this.btnNormal.UseVisualStyleBackColor = true;
            this.btnNormal.Click += new System.EventHandler(this.btnNormal_Click);
            // 
            // lblCritical
            // 
            this.lblCritical.AutoSize = true;
            this.lblCritical.Location = new System.Drawing.Point(9, 110);
            this.lblCritical.Name = "lblCritical";
            this.lblCritical.Size = new System.Drawing.Size(38, 13);
            this.lblCritical.TabIndex = 2;
            this.lblCritical.Text = "Critical";
            // 
            // lblWarning
            // 
            this.lblWarning.AutoSize = true;
            this.lblWarning.Location = new System.Drawing.Point(7, 65);
            this.lblWarning.Name = "lblWarning";
            this.lblWarning.Size = new System.Drawing.Size(47, 13);
            this.lblWarning.TabIndex = 1;
            this.lblWarning.Text = "Warning";
            // 
            // lblNormal
            // 
            this.lblNormal.AutoSize = true;
            this.lblNormal.Location = new System.Drawing.Point(7, 20);
            this.lblNormal.Name = "lblNormal";
            this.lblNormal.Size = new System.Drawing.Size(40, 13);
            this.lblNormal.TabIndex = 0;
            this.lblNormal.Text = "Normal";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.neCritical);
            this.groupBox2.Controls.Add(this.neWarning);
            this.groupBox2.Controls.Add(this.lblAlarmCritical);
            this.groupBox2.Controls.Add(this.lblAlarmWarning);
            this.groupBox2.Location = new System.Drawing.Point(145, 14);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(155, 76);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "  < Alarm Threshold >  ";
            // 
            // neCritical
            // 
            this.neCritical.Location = new System.Drawing.Point(78, 47);
            this.neCritical.Minimum = new decimal(new int[] {
            50,
            0,
            0,
            0});
            this.neCritical.Name = "neCritical";
            this.neCritical.Size = new System.Drawing.Size(67, 20);
            this.neCritical.TabIndex = 3;
            this.neCritical.Value = new decimal(new int[] {
            50,
            0,
            0,
            0});
            // 
            // neWarning
            // 
            this.neWarning.Location = new System.Drawing.Point(78, 23);
            this.neWarning.Maximum = new decimal(new int[] {
            90,
            0,
            0,
            0});
            this.neWarning.Minimum = new decimal(new int[] {
            20,
            0,
            0,
            0});
            this.neWarning.Name = "neWarning";
            this.neWarning.Size = new System.Drawing.Size(67, 20);
            this.neWarning.TabIndex = 2;
            this.neWarning.Value = new decimal(new int[] {
            20,
            0,
            0,
            0});
            // 
            // lblAlarmCritical
            // 
            this.lblAlarmCritical.AutoSize = true;
            this.lblAlarmCritical.Location = new System.Drawing.Point(7, 50);
            this.lblAlarmCritical.Name = "lblAlarmCritical";
            this.lblAlarmCritical.Size = new System.Drawing.Size(49, 13);
            this.lblAlarmCritical.TabIndex = 1;
            this.lblAlarmCritical.Text = "Critical %";
            // 
            // lblAlarmWarning
            // 
            this.lblAlarmWarning.AutoSize = true;
            this.lblAlarmWarning.Location = new System.Drawing.Point(7, 23);
            this.lblAlarmWarning.Name = "lblAlarmWarning";
            this.lblAlarmWarning.Size = new System.Drawing.Size(58, 13);
            this.lblAlarmWarning.TabIndex = 0;
            this.lblAlarmWarning.Text = "Warning %";
            // 
            // cbTransparent
            // 
            this.cbTransparent.AutoSize = true;
            this.cbTransparent.Location = new System.Drawing.Point(16, 49);
            this.cbTransparent.Name = "cbTransparent";
            this.cbTransparent.Size = new System.Drawing.Size(83, 17);
            this.cbTransparent.TabIndex = 3;
            this.cbTransparent.Text = "Transparent";
            this.cbTransparent.UseVisualStyleBackColor = true;
            this.cbTransparent.Click += new System.EventHandler(this.cbTransparent_Click);
            // 
            // btnOK
            // 
            this.btnOK.Location = new System.Drawing.Point(74, 228);
            this.btnOK.Name = "btnOK";
            this.btnOK.Size = new System.Drawing.Size(75, 23);
            this.btnOK.TabIndex = 4;
            this.btnOK.Text = "OK";
            this.btnOK.UseVisualStyleBackColor = true;
            this.btnOK.Click += new System.EventHandler(this.btnOK_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(155, 228);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 23);
            this.btnCancel.TabIndex = 5;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // cbStayOnTop
            // 
            this.cbStayOnTop.AutoSize = true;
            this.cbStayOnTop.Location = new System.Drawing.Point(16, 81);
            this.cbStayOnTop.Name = "cbStayOnTop";
            this.cbStayOnTop.Size = new System.Drawing.Size(86, 17);
            this.cbStayOnTop.TabIndex = 6;
            this.cbStayOnTop.Text = "Stay On Top";
            this.cbStayOnTop.UseVisualStyleBackColor = true;
            this.cbStayOnTop.CheckedChanged += new System.EventHandler(this.cbStayOnTop_CheckedChanged);
            this.cbStayOnTop.Click += new System.EventHandler(this.cbStayOnTop_Click);
            // 
            // neInterval
            // 
            this.neInterval.Location = new System.Drawing.Point(16, 19);
            this.neInterval.Maximum = new decimal(new int[] {
            600,
            0,
            0,
            0});
            this.neInterval.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.neInterval.Name = "neInterval";
            this.neInterval.Size = new System.Drawing.Size(40, 20);
            this.neInterval.TabIndex = 7;
            this.neInterval.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // lblInterval
            // 
            this.lblInterval.AutoSize = true;
            this.lblInterval.Location = new System.Drawing.Point(62, 22);
            this.lblInterval.Name = "lblInterval";
            this.lblInterval.Size = new System.Drawing.Size(91, 13);
            this.lblInterval.TabIndex = 8;
            this.lblInterval.Text = "Interval (seconds)";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.neInterval);
            this.groupBox3.Controls.Add(this.cbStayOnTop);
            this.groupBox3.Controls.Add(this.lblInterval);
            this.groupBox3.Controls.Add(this.cbTransparent);
            this.groupBox3.Location = new System.Drawing.Point(145, 96);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(155, 111);
            this.groupBox3.TabIndex = 9;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "  < Misc >  ";
            // 
            // lblNote
            // 
            this.lblNote.AutoSize = true;
            this.lblNote.Location = new System.Drawing.Point(3, 210);
            this.lblNote.Name = "lblNote";
            this.lblNote.Size = new System.Drawing.Size(319, 13);
            this.lblNote.TabIndex = 10;
            this.lblNote.Text = "* Background color will change after the interval period completes.";
            // 
            // llblCopyright
            // 
            this.llblCopyright.AutoSize = true;
            this.llblCopyright.Location = new System.Drawing.Point(251, 238);
            this.llblCopyright.Name = "llblCopyright";
            this.llblCopyright.Size = new System.Drawing.Size(57, 13);
            this.llblCopyright.TabIndex = 11;
            this.llblCopyright.TabStop = true;
            this.llblCopyright.Text = "K.Andreev";
            this.llblCopyright.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.llblCopyright_LinkClicked);
            // 
            // frmOptions
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(318, 260);
            this.Controls.Add(this.llblCopyright);
            this.Controls.Add(this.lblNote);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnOK);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmOptions";
            this.Text = "Options";
            this.Load += new System.EventHandler(this.frmOptions_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.neCritical)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.neWarning)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.neInterval)).EndInit();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnCritical;
        private System.Windows.Forms.Button btnWarning;
        private System.Windows.Forms.Button btnNormal;
        private System.Windows.Forms.Label lblCritical;
        private System.Windows.Forms.Label lblWarning;
        private System.Windows.Forms.Label lblNormal;
        private System.Windows.Forms.ColorDialog colorDialog1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.NumericUpDown neCritical;
        private System.Windows.Forms.NumericUpDown neWarning;
        private System.Windows.Forms.Label lblAlarmCritical;
        private System.Windows.Forms.Label lblAlarmWarning;
        private System.Windows.Forms.CheckBox cbTransparent;
        private System.Windows.Forms.Button btnOK;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.CheckBox cbStayOnTop;
        private System.Windows.Forms.Label lblBGColor;
        private System.Windows.Forms.Button btnBGColor;
        private System.Windows.Forms.NumericUpDown neInterval;
        private System.Windows.Forms.Label lblInterval;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label lblNote;
        private System.Windows.Forms.LinkLabel llblCopyright;
    }
}