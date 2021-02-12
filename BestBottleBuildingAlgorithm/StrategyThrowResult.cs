namespace BestBottleBuildingAlgorithm
{
    public class StrategyThrowResult : ThrowsResult
    {
        public int LastCheckedFloor { get; set; } = 0;
        public int LastGoodFloor { get; set; } = 0;
        public int BreakFloor { get; set; }
    }
}
