﻿using System.ComponentModel.DataAnnotations.Schema;

namespace Recipe_Api.Data.Entities
{
    public class Step
    {
        public int Id { get; }
        public string Description { get; set; }
        //public int RecipeId { get; set; }

        //public Step(int stepId, string stepDescription)
        //{
        //    StepId = stepId;
        //    StepDescription = stepDescription;
        //}
        
    }
}
