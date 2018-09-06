using Practice.StrategyRuleExample.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace Practice.StrategyRuleExample
{
    public class BakingWrapper
    {
        private readonly BakingDeterminator _determinator = new BakingDeterminator();
        private readonly Recipe _recipe;
        private readonly IConcoct _rule;

        public BakingWrapper(Recipe recipe)
        {
            _recipe = recipe;
            _rule = _determinator.ReturnRule(_recipe);
        }

        public virtual void Prep()
        {
            _rule.Prep(_recipe);
        }

        public virtual void Bake()
        {
            _rule.Bake(_recipe);
        }
    }
}
