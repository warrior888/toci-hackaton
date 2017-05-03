using System.Collections.Generic;
using System.Linq;

namespace GhostRider.Zaba.Bll.BusinessLogicLayer
{
    public class ProductsBll
    {
        public List<Products> GetAllProducts()
        {
            Entities ent = new Entities();

            return ent.Products.Select(m => m).ToList();
        }

        public List<ProductFeaturesValue> GetProductFeaturesValuesForId(int productId)
        {
            Entities ent = new Entities();
           return  ent.ProductFeaturesValue.Where(m => m.ProductFeaturesMap.Products.Id == productId).ToList();
        }
    }
}