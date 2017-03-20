namespace CTS.Commands
{
    public class SaveCommand : ITradeCommand
    {
        private Trade _trade;

        public void Execute()
        {
            switch (_trade.Status)
            {
                case TradeStatus.PendInfo:
                    _trade.Status = TradeStatus.PendAppr;
                    break;
                case TradeStatus.Draft:
                    _trade.Status = TradeStatus.PendInfo;
                    break;
            }
        }

        public void SetTrade(Trade trade)
        {
            _trade = trade;
        }
    }
}