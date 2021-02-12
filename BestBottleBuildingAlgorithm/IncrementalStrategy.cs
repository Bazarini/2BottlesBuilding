using System.Collections.Generic;

namespace BestBottleBuildingAlgorithm
{
    public class IncrementDynamicStrategy : ThrowStrategy
    {
        protected override List<StrategyThrowResult> GoWithStrategy(int breakFloor)
        {
            List<StrategyThrowResult> output = new List<StrategyThrowResult>();
            int minIncrement = 1;
            int maxIncrement = 100;

            int incrementChange = 1;
                for (int i = minIncrement; i < maxIncrement; i++)
                {
                    StrategyThrowResult result = new StrategyThrowResult();
                    int throws = 0;
                    int currentFloor = 0;
                    int usedIncrement = i;
                    do
                    {
                        usedIncrement = usedIncrement - incrementChange > 0 ? usedIncrement - incrementChange : 1;
                        result.LastGoodFloor = currentFloor;
                        currentFloor = currentFloor + usedIncrement;
                        result.LastCheckedFloor = currentFloor;
                        throws++;
                    }
                    while (currentFloor < breakFloor);
                    result.Throws = throws;
                    output.Add(result);
                }
            return output;
        }
    }
        public class IncrementalStrategy : ThrowStrategy
        {
            protected override List<StrategyThrowResult> GoWithStrategy(int breakFloor)
            {
                List<StrategyThrowResult> output = new List<StrategyThrowResult>();
                int minIncrement = 1;
                int maxIncrement = 100;
                for (int i = minIncrement; i < maxIncrement; i++)
                {
                    StrategyThrowResult result = new StrategyThrowResult() { BreakFloor = breakFloor};
                    int throws = 0;
                    int currentFloor = 0;
                    do
                    {
                        result.LastGoodFloor = currentFloor;
                        currentFloor = currentFloor + i;
                        result.LastCheckedFloor = currentFloor;
                        throws++;
                    }
                    while (currentFloor < breakFloor);
                    result.Throws = throws;
                    output.Add(result);
                }
                return output;
            }
        }
    }
