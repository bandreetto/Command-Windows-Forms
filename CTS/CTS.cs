namespace CTS
{
    using System;
    using System.Windows.Forms;
    using Commands;

    public partial class CTS : Form
    {
        public CTS()
        {
            InitializeComponent();
            Trade = new Trade
            {
                Id = 1,
                Status = TradeStatus.Draft
            };
        }

        public TradeFrm TradeFrm { get; set; }
        public Trade Trade { get; set; }

        private void button1_Click(object sender, EventArgs e)
        {
            TradeFrm = new TradeFrm(Trade)
            {
                Save = new SaveCommand(),
                Cancel = new CancelCommand(),
                Release = new ReleaseCommand()
            };
            TradeFrm.ShowDialog();
        }
    }
}