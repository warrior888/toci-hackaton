using System;
using System.Collections.Generic;

namespace Toci.EntityAnalyzer.UiGenerator.ControlsFeatures
{
    public abstract class Properties
    {
        public Dictionary<Type, Func<IList<string>>> TypeToPropertiesMapper { get; set; }

        protected abstract IList<string> GetProperties<T>();
    }
}