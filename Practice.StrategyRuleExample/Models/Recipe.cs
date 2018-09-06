using System;
using System.Collections.Generic;
using System.Text;

namespace Practice.StrategyRuleExample.Models
{
    public class Recipe
    {
        public int RecipeId { get; set; }
        public List<RecipeIngredient> Ingredients { get; set; }
        public int BakeTempature { get; set; }
        public int BakeTime { get; set; }
        public BakedGoodType BakedGoodType { get; set; }
    }
}
