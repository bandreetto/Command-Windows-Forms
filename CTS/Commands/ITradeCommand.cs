namespace CTS.Commands
{
    public interface ITradeCommand
    {
        void Execute();

        void SetTrade(Trade trade);
    }
}