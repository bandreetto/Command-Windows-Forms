namespace CTS
{
    using System.Windows.Forms;

    public class CancelCommand : ITradeCommand
    {
        private readonly TradeFrm _tradeFrm;

        public CancelCommand(TradeFrm tradeFrm)
        {
            _tradeFrm = tradeFrm;
        }

        public void Execute()
        {
            _tradeFrm.Trade.Status = TradeStatus.Canceled;
            MessageBox.Show(_tradeFrm, "Boleta Cancelada com Sucesso!");
            _tradeFrm.Close();
        }
    }
}