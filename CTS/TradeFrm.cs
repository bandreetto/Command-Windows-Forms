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
    public partial class TradeFrm : Form
    {
        public Trade Trade { get; set; }
        public ITradeCommand Save { get; set; }
        public ITradeCommand Cancel { get; set; }
        public ITradeCommand Release { get; set; }
        public TradeFrm(Trade trade)
        {
            InitializeComponent();
            Trade = trade;

            CreateButtons();
        }

        private void CreateButtons()
        {
            Button btn;
            switch (Trade.Status)
            {
                case TradeStatus.Draft:
                    btn = new Button {Text = "Salvar", Dock = DockStyle.Left};
                    btn.Click += (sender, args) => Save.Execute();
                    splitContainer1.Panel1.Controls.Add(btn);
                    break;
                case TradeStatus.PendAppr:
                    btn = new Button {Text = "Salvar", Dock = DockStyle.Left};
                    btn.Click += (sender, args) => Save.Execute();
                    splitContainer1.Panel1.Controls.Add(btn);
                    btn = new Button {Text = "Cancelar", Dock = DockStyle.Fill};
                    btn.Click += (sender, args) => Cancel.Execute();
                    splitContainer1.Panel1.Controls.Add(btn);
                    break;
                case TradeStatus.PendInfo:
                    btn = new Button { Text = "Released", Dock = DockStyle.Left };
                    btn.Click += (sender, args) => Release.Execute();
                    splitContainer1.Panel1.Controls.Add(btn);
                    btn = new Button { Text = "Cancelar", Dock = DockStyle.Fill };
                    btn.Click += (sender, args) => Cancel.Execute();
                    splitContainer1.Panel1.Controls.Add(btn);
                    break;
                default:
                    throw new ArgumentOutOfRangeException();
            }


        }
    }
}