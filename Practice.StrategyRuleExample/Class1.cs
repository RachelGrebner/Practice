using Practice.StrategyRuleExample.Models;
using System;

namespace Practice.StrategyRuleExample
{
    public class Class1
    {
        public void BakeRecipeExample()
        {
            //add all needed types to make the nagic work
            //but anyways, here's th pseudo-code
            var recipe = new Recipe();

            var bakingWrapper = new BakingWrapper(recipe);

            bakingWrapper.Prep();
            bakingWrapper.Bake();
        }
    }
}
