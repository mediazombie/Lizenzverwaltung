using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NetzwerkInventur
{
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();
            Load += new EventHandler(frmMain_Load);
        }

        private void frmMain_Load(object sender, System.EventArgs e)
        {
            ToolTip ToolTipHandler = new ToolTip();

            ToolTipHandler.AutoPopDelay = 5000;
            ToolTipHandler.InitialDelay = 500;
            ToolTipHandler.ReshowDelay = 500;

            ToolTipHandler.SetToolTip(this.textBoxSuchbegriffFiltern, "Hier einen Suchbegriff eingeben." + Environment.NewLine + "Kann Seriennummer, WS-Name, Softwarebezeichnung usw. sein.");
            ToolTipHandler.SetToolTip(this.checkBoxDuplikateFiltern, "Hebt doppelt vergebene Seriennummern hervor.");
            ToolTipHandler.SetToolTip(this.textBoxSuchbegriffEdit, "Hier einen Suchbegriff eingeben." + Environment.NewLine + "Kann Seriennummer, WS-Name, Softwarebezeichnung usw. sein.");
            ToolTipHandler.SetToolTip(this.checkBoxDuplikateEdit, "Zeigt doppelt vergebene Seriennummern an.");
        }

        private void btnNewUser_Click(object sender, EventArgs e)
        {
            this.pnlNewUser.Visible = true;
            this.pnlNewWorkstation.Visible = false;
            this.pnlNewSWLicense.Visible = false;
        }

        private void btnNewWorkstation_Click(object sender, EventArgs e)
        {
            this.pnlNewUser.Visible = false;
            this.pnlNewWorkstation.Visible = true;
            this.pnlNewSWLicense.Visible = false;
        }

        private void btnNewSWLicense_Click(object sender, EventArgs e)
        {
            this.pnlNewUser.Visible = false;
            this.pnlNewWorkstation.Visible = false;
            this.pnlNewSWLicense.Visible = true;
        }



    }
}
