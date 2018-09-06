using Practice.StrategyRuleExample.Interfaces;
using Practice.StrategyRuleExample.Models;
using Practice.StrategyRuleExample.Rules;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Practice.StrategyRuleExample
{
    public class BakingDeterminator
    {
        private List<IConcoctRule> _rules;

        public BakingDeterminator()
        {
            _rules = new List<IConcoctRule>();
            _rules.Add(new CookiesRule());
            _rules.Add(new CakesRule());
            _rules.Add(new MuffinsRule());
        }

        public IConcoct ReturnRule(Recipe recipe)
        {
            return _rules.First(r => r.IsMatch(recipe.BakedGoodType.BakedGoodTypeName));
        }
    }
}
