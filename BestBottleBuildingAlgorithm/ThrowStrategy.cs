using System;
using System.Collections.Generic;
using System.Linq;

namespace BestBottleBuildingAlgorithm
{
    public abstract class ThrowStrategy
    {
        //Gets minimum throws using current strategy to find a floor where the bottle breaks; 
        protected abstract List<StrategyThrowResult> GoWithStrategy(int breakFloor);
        public List<ThrowsResult> UseStrategy(int breakFloor)
        {
            List<StrategyThrowResult> strategyResults = GoWithStrategy(breakFloor);
            List<ThrowsResult> output = new List<ThrowsResult>();
            foreach (StrategyThrowResult strategyResult in strategyResults)
            {
                int neededThrows = strategyResult.Throws + breakFloor - strategyResult.LastGoodFloor;
                if (strategyResult.LastCheckedFloor == breakFloor)
                    neededThrows -= 1;
                output.Add(new ThrowsResult()
                {
                    StrategyThrowResult = strategyResult,
                    Throws = neededThrows
                });
            }
            return output;
        }
    }
}
