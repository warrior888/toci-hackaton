using System.Collections.Generic;

namespace Toci.Generator.Test
{
    public class Graph<TKey> : Dictionary<TKey, Graph<TKey>>
    {
        public Graph<TKey> Field;


    }
}