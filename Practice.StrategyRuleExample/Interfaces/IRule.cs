using System;
using System.Collections.Generic;
using System.Text;

namespace Practice.StrategyRuleExample.Interfaces
{
    public interface IRule
    {
        bool IsMatch(string bakedGoodTypeName);
    }
}
