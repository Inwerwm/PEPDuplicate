using PEPlugin;
using PEPlugin.Pmx;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DuplicateModel
{
    public partial class CtrlForm : Form
    {
        IPERunArgs args;

        public CtrlForm(IPERunArgs input)
        {
            InitializeComponent();
            args = input;
        }

        private void CtrlForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (e.CloseReason == CloseReason.UserClosing)
            {
                e.Cancel = true;
                Visible = false;
            }
        }

        private void buttonRun_Click(object sender, EventArgs e)
        {
            var pmx = args.Host.Connector.Pmx.GetCurrentState();

            for (int i = 1; i < numericDupNum.Value; i++)
            {
                var vertices = pmx.Vertex.Select(v => (IPXVertex)v.Clone()).ToList();
            }
        }
    }
}