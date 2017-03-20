using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CTS
{
    public partial class CTS : Form
    {
        public TradeFrm TradeFrm { get; set; }

        public CTS()
        {
            InitializeComponent();
            TradeFrm = new TradeFrm();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            TradeFrm.ShowDialog();
        }
    }
}