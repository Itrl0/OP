using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OP
{ 


    public class Reduce
    {
    private ProductRepository _repository;

        public Reduce(ProductRepository repository)
        {
            _repository = repository;
        }
        public void ReduceProductQuantity(string productName, int quantity)
        {
            var products = _repository.GetAll();
            var product = products.FirstOrDefault(p => p.Name.Equals(productName, StringComparison.OrdinalIgnoreCase));


                product.Quantity -= quantity;
                _repository.Update(product);
            

            
        }
    }
}
