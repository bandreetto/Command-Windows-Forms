namespace CTS
{
    using System.Windows.Forms;

    public class SaveCommand : ITradeCommand
    {
        private TradeFrm _tradeFrm;

        public SaveCommand(TradeFrm tradeFrm)
        {
            _tradeFrm = tradeFrm;
        }
        
        public void Execute()
        {
            _tradeFrm.Trade.Status = TradeStatus.PendAppr;
            MessageBox.Show(_tradeFrm, "Boleta Salva com Sucesso!");
            _tradeFrm.Close();
        }
    }
}