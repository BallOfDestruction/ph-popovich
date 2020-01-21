﻿using System;

namespace PhPopovich.Controllers.cms
{
    public class OneTwoManyAttribute : Attribute
    {
        public string PropertyName { get; set; }

        public OneTwoManyAttribute(string propertyName)
        {
            PropertyName = propertyName;
        }
    }
}
