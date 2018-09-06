using System;
using System.Collections.Generic;
using System.Text;

namespace Practice.StrategyRuleExample.Models
{
    public class RecipeIngredient
    {
        public int RecipeId { get; set; }
        public int IngredientId { get; set; }
        public float IngredientAmount { get; set; }
    }
}
