using System;
using System.Windows.Forms;

namespace RAM_Gadget
{
    public partial class frmOptions : Form
    {
        bool bChangeTransparency;
        bool bChangeStayOnTop = true;

        public frmOptions()
        {
            InitializeComponent();
        }

        private void btnNormal_Click(object sender, EventArgs e)
        {            
            if (colorDialog1.ShowDialog() == DialogResult.OK)
            {
                btnNormal.BackColor = colorDialog1.Color;
            }
        }

        private void btnWarning_Click(object sender, EventArgs e)
        {
            if (colorDialog1.ShowDialog() == DialogResult.OK)
            {
                btnWarning.BackColor = colorDialog1.Color;
            }
        }

        private void btnCritical_Click(object sender, EventArgs e)
        {
            if (colorDialog1.ShowDialog() == DialogResult.OK)
            {
                btnCritical.BackColor = colorDialog1.Color;                               
            }
        }

        private void frmOptions_Load(object sender, EventArgs e)
        {
            GetFormProperty();
        }

        private void GetFormProperty()
        {
            btnNormal.BackColor = Form1.myGreenPen.Color;
            btnWarning.BackColor = Form1.myYellowPen.Color;
            btnCritical.BackColor = Form1.myRedPen.Color;
            btnBGColor.BackColor = Form1.BackgroundColor;
            neWarning.Value = Form1.intWarningThreshold;
            neCritical.Value = Form1.intCriticalThreshold;
            cbTransparent.Checked = Form1.bTransparent;
            bChangeTransparency = Form1.bTransparent;
            cbStayOnTop.Checked = Form1.bStayOnTop;
            bChangeStayOnTop = Form1.bStayOnTop;
            neInterval.Value = Form1.intTimer; 
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            GetFormProperty();
            Close();
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            int intTempWarning, intTempCritical;
            intTempWarning = Decimal.ToInt32(neWarning.Value);
            intTempCritical = Decimal.ToInt32(neCritical.Value);
            if (intTempWarning >= intTempCritical)
            {
                MessageBox.Show("Warning should be less than critical." + Environment.NewLine + "Resetting to default.", "Options");
                neWarning.Value = Form1.intWarningThreshold;
                neCritical.Value = Form1.intCriticalThreshold;
                return;
            }

            if (bChangeTransparency)
            {
                Form1.bTransparent = true;
            }
            else Form1.bTransparent = false;

            if (bChangeStayOnTop)
            {
                Form1.bStayOnTop = true;                
            }
            else Form1.bStayOnTop = false;       
                                 
            Form1.myGreenPen.Color = btnNormal.BackColor;
            Form1.myYellowPen.Color = btnWarning.BackColor;
            Form1.myRedPen.Color = btnCritical.BackColor;
            Form1.BackgroundColor = btnBGColor.BackColor;
            Form1.intTimer = Decimal.ToInt32(neInterval.Value);
            Form1.intWarningThreshold = Decimal.ToInt32(neWarning.Value);
            Form1.intCriticalThreshold = Decimal.ToInt32(neCritical.Value);         
            Close();
        }

        private void cbTransparent_Click(object sender, EventArgs e)
        {
            bChangeTransparency = !bChangeTransparency;
        }

        private void btnBGColor_Click(object sender, EventArgs e)
        {
            if (colorDialog1.ShowDialog() == DialogResult.OK)
            {
                btnBGColor.BackColor = colorDialog1.Color;
            }
        }

        private void cbStayOnTop_Click(object sender, EventArgs e)
        {
            bChangeStayOnTop = !bChangeStayOnTop;
        }

        private void cbStayOnTop_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void llblCopyright_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            System.Diagnostics.Process.Start("http://blog.iandreev.com");
        }
    }
}
