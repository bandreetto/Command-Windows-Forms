namespace CTS.Commands
{
    public class ReleaseCommand : ITradeCommand
    {
        private Trade _trade;

        public void Execute()
        {
            _trade.Status = TradeStatus.Released;
        }

        public void SetTrade(Trade trade)
        {
            _trade = trade;
        }
    }
}