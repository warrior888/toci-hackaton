﻿using System;
using System.Collections.Generic;
using Toci.EntityAnalyzer.Interfaces.Parametrization;

namespace Toci.EntityAnalyzer.Interfaces.Entities
{
    /// <summary>
    /// Contains data about field collected from custom tags in SQL script
    /// </summary>
    public interface IModelFieldMetadata
    {
        string Tag { get; set; }

        int ScreenId { get; set; }

        string Model { get; set; }

        string Name { get; set; }

        string Value { get; set; }

        Type Type { get; set; }

        string RegularValidator { get; set; }

        string CustomValidator { get; set; }

        Dictionary<string, IEntityData> FillObligationDependentFields { get; set; }

        Dictionary<string, IEntityData> LoadFieldsForFields { get; set; }
    }
}