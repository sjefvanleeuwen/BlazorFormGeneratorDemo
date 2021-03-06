﻿using Microsoft.AspNetCore.Components.Forms;
using System;
using System.Collections.Generic;
using System.Reflection;

namespace FormGeneratorDemo.Components.FormGenerator
{
    public class BootstrapInputCheckboxComponent : VxInputBase<bool>
    {
        public string Label { get; set; }

        protected override bool TryParseValueFromString(string value, out bool result, out string validationErrorMessage)
           => throw new NotImplementedException($"This component does not parse string inputs. Bind to the '{nameof(CurrentValue)}' property, not '{nameof(CurrentValueAsString)}'.");
    }

}
