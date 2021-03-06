﻿using FormGeneratorDemo.Components.FormGenerator;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace FormGeneratorDemo.Data
{
    public class FeedingSession
    {
        [Display(Name = "Kind of food")]
        public FoodKind KindOfFood { get; set; }
        [Display(Name = "Note")]
        public string Note { get; set; }
        [Display(Name = "Amount")]
        public decimal Amount { get; set; }
        [Display(Name = "Start")]
        public DateTime Start { get; set; }
        [Display(Name = "End")]
        public DateTime End { get; set; }
        [Display(Name = "Throwing up")]
        public bool ThrowingUp { get; set; }

        [Display(Name = "Throwing up dict")]
        public List<ValueReference<FoodKind, bool>> ThrowingUpDict { get; set; }
    }

    public enum FoodKind
    {
        SOLID,
        LIQUID
    }
}
