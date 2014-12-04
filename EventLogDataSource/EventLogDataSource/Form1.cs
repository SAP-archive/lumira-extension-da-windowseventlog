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
        public Form1()
        {
            InitializeComponent();
        }

        private void ok_button_Click(object sender, EventArgs e)
        {
            EventLogWriter writer = new EventLogWriter();
            writer.NumRows = Decimal.ToInt32(numrows_numericUpDown.Value);
            writer.Write();
            Close();
        }
    }
}
