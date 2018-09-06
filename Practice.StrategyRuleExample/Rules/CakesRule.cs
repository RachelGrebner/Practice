using Practice.StrategyRuleExample.Interfaces;
using Practice.StrategyRuleExample.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace Practice.StrategyRuleExample.Rules
{
    public class CakesRule : IConcoctRule
    {
        public void Bake(Recipe recipe)
        {
            throw new NotImplementedException();
        }

        public bool IsMatch(string bakedGoodTypeName)
        {
            return bakedGoodTypeName == "Cake";
        }

        public void Prep(Recipe recipe)
        {
            throw new NotImplementedException();
        }
    }
}
