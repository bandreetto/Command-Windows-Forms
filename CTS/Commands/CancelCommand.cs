namespace CTS.Commands
{
    public class CancelCommand : ITradeCommand
    {
        private Trade _trade;

        public void Execute()
        {
            _trade.Status = TradeStatus.Canceled;
        }

        public void SetTrade(Trade trade)
        {
            _trade = trade;
        }
    }
}