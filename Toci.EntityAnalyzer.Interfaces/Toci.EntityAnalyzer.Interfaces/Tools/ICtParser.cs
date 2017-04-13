using System.Collections;
using System.Collections.Generic;
using Toci.EntityAnalyzer.Interfaces.Entities;

namespace Toci.EntityAnalyzer.Interfaces.Tools
{
    public interface ICtParser
    {
        List<ICtParsed> ParseCt(string allCt);


    }
}