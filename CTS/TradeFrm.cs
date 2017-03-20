namespace CTS
{
    using System;
    using System.Windows.Forms;
    using Commands;

    public partial class TradeFrm : Form
    {
        private ITradeCommand _cancel;

        private ITradeCommand _release;

        private ITradeCommand _save;

        public TradeFrm(Trade trade)
        {
            InitializeComponent();
            Trade = trade;

            InitializeButtons();

            textBox1.Text = Trade.Id.ToString();
            textBox2.Text = Trade.Status.ToString();
        }

        public Trade Trade { get; set; }

        public ITradeCommand Save
        {
            get { return _save; }
            set
            {
                _save = value;
                Save.SetTrade(Trade);
            }
        }

        public ITradeCommand Cancel
        {
            get { return _cancel; }
            set
            {
                _cancel = value;
                Cancel.SetTrade(Trade);
            }
        }

        public ITradeCommand Release
        {
            get { return _release; }
            set
            {
                _release = value;
                Release.SetTrade(Trade);
            }
        }

        private void InitializeButtons()
        {
            Button btn;
            switch (Trade.Status)
            {
                case TradeStatus.Draft:
                    btn = new Button {Text = @"Salvar", Dock = DockStyle.Fill};
                    btn.Click += (sender, args) => SaveTrade();
                    splitContainer1.Panel1.Controls.Add(btn);
                    break;
                case TradeStatus.PendInfo:
                    btn = new Button {Text = @"Salvar", Dock = DockStyle.Fill};
                    btn.Click += (sender, args) => SaveTrade();
                    splitContainer1.Panel1.Controls.Add(btn);
                    btn = new Button {Text = @"Cancelar", Dock = DockStyle.Left};
                    btn.Click += (sender, args) => CancelTrade();
                    splitContainer1.Panel1.Controls.Add(btn);
                    break;
                case TradeStatus.PendAppr:
                    btn = new Button {Text = @"Release", Dock = DockStyle.Fill};
                    btn.Click += (sender, args) => ReleaseTrade();
                    splitContainer1.Panel1.Controls.Add(btn);
                    btn = new Button {Text = @"Cancelar", Dock = DockStyle.Left};
                    btn.Click += (sender, args) => CancelTrade();
                    splitContainer1.Panel1.Controls.Add(btn);
                    break;
                case TradeStatus.Released:
                    btn = new Button {Text = @"Cancel", Dock = DockStyle.Fill};
                    btn.Click += (sender, args) => CancelTrade();
                    splitContainer1.Panel1.Controls.Add(btn);
                    break;
                case TradeStatus.Canceled:
                    Trade.Id++;
                    Trade.Status = TradeStatus.Draft;
                    InitializeButtons();
                    break;
                default:
                    throw new ArgumentOutOfRangeException();
            }
        }

        public void CancelTrade()
        {
            Cancel.Execute();
            MessageBox.Show(this, @"Trade Cancelado com Sucesso!");
            Close();
            Dispose();
        }

        public void ReleaseTrade()
        {
            Release.Execute();
            MessageBox.Show(this, @"Trade Exportado com Sucesso!");
            Close();
            Dispose();
        }

        public void SaveTrade()
        {
            Save.Execute();
            MessageBox.Show(this, @"Trade Salvo com Sucesso!");
            Close();
            Dispose();
        }
    }
}