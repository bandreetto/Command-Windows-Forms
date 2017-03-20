namespace CTS
{
    using System.Windows.Forms;

    public class ReleaseCommand : ITradeCommand
    {
        private readonly TradeFrm _tradeFrm;
        public ReleaseCommand(TradeFrm tradeFrm)
        {
            _tradeFrm = tradeFrm;
        }
        public void Execute()
        {
            _tradeFrm.Trade.Status = TradeStatus.Released;
            MessageBox.Show(_tradeFrm, "Boleta Exportada com Sucesso!");
            _tradeFrm.Close();
        }
    }
}