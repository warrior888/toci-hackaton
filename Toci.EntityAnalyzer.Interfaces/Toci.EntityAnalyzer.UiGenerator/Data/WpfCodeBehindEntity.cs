using System;
using System.Collections.Generic;
using Toci.EntityAnalyzer.UiGenerator.Interfaces.Data;

namespace Toci.EntityAnalyzer.UiGenerator.Data
{
    public class WpfCodeBehindEntity<T> : ICodeBehindEntity
    {
        public IList<string> Properties { get; set; }
        public IList<string> Handlers { get; set; }
        public WpfCodeBehindEntity()
        {
            Handlers = Interfaces.ControlsConsts.Handlers.TypeToHandlersMapper[typeof(T)].Invoke();
        }

    }
}