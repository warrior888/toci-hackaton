using System;

namespace Toci.EntityAnalyzer.Interfaces.Parametrization
{
    [Flags]
    public enum FieldKinds
    {
        Properties = 1, 
        Fields = 2,
        Consts = 4,
        Statics = 8
    }
}