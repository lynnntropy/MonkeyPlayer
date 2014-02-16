using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace MonkeyGamerGUI
{
    public partial class LogWindowForm : Form
    {
        public static string lastLogLine = "";

        public LogWindowForm()
        {
            InitializeComponent();
        }

        private void LogWindowForm_Load(object sender, EventArgs e)
        {
            this.TopMost = true;
        }
    }
}
