﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;
using VxFormGenerator;

namespace VxFormGeneratorTests
{
    public class TestModel
    {
        [Display(Name = "Kind of food")]
        public FoodKind KindOfFood { get; set; }
        [Display(Name = "Note")]
        [MinLength(5)]
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
        public ValueReferences<FoodKind> ThrowingUpDict { get; set; } = new ValueReferences<FoodKind>();
    }

    public enum FoodKind
    {
        SOLID,
        LIQUID
    }
}
