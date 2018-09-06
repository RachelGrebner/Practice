using Practice.StrategyRuleExample.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace Practice.StrategyRuleExample
{
    public interface IConcoct
    {
        void Prep(Recipe recipe);
        void Bake(Recipe recipe);
    }
}
