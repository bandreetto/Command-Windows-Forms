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
        public Trade Trade { get; set; }

        public CTS()
        {
            InitializeComponent();
            Trade = new Trade();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            TradeFrm = new TradeFrm(Trade);
            TradeFrm.Save = new SaveCommand(TradeFrm);
            TradeFrm.Cancel = new CancelCommand(TradeFrm);
            TradeFrm.Release = new ReleaseCommand(TradeFrm);
            TradeFrm.ShowDialog();
        }
    }
}