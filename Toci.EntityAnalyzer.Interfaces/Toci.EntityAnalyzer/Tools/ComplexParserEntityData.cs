using Toci.EntityAnalyzer.Interfaces.Entities;

namespace Toci.EntityAnalyzer.Tools
{
    public class ComplexParserEntityData : ComplexParser<IEntityData>
    {
        protected override void Parse(string tableCreates, IComplexEntity entity)
        {
            
            //GetColumnName();

            /*if (entity.ComplexProperties.ContainsKey())
            {
                
            }
            else
            {
                entity.ComplexProperties.Add();
            }*/
        }
    }
}