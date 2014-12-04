using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EventLogDataSource
{
    public partial class Form1 : Form
    {
        private EventLogWriter logWriter;

        public Form1(EventLogWriter logWriter)
        {
            InitializeComponent();
            this.logWriter = logWriter;
            numrows_numericUpDown.Value = logWriter.NumRows;
        }

        private void ok_button_Click(object sender, EventArgs e)
        {
            logWriter.NumRows = Decimal.ToInt32(numrows_numericUpDown.Value);
            logWriter.Write();
            Close();
        }
    }
}
