namespace Strategy
{
    class Auto 
    {
        IBuy _buy;

        public void SetStrategy(IBuy buy)
        {
            _buy = buy;
        }
        public IBuy ExecuteStrategy()
        {
            return _buy.Buy();
        }
    }
}
