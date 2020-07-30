﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace VxFormGenerator.Components
{

    public class BootstrapFormElementComponent<TFormElement> : FormElementComponent<TFormElement>
    {
        public BootstrapFormElementComponent()
        {
           // DefaultFieldClasses = new List<string>() { "form-control"};
            CssClasses = new List<string>() { "form-group", "row" };
        }
    }
}
