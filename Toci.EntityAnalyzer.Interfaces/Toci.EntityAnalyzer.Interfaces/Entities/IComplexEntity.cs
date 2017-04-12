﻿using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;

namespace Toci.EntityAnalyzer.Interfaces.Entities
{
    /// <summary>
    /// Class definition, contains all properties as ComplexProperties
    /// </summary>
    public interface IComplexEntity
    {
        string Name { get; set; }
        IList<IComplexProperty> ComplexProperties { get; set; }
    }
}