using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PetStore
{
    public class ProductLogic
    {
        private List<Product> _products;
        private Dictionary<string, DogLeash> dictionaryDog;
        private Dictionary<string, CatFood> dictionaryCat;
        public ProductLogic()
        {
            _products = new List<Product>();
            dictionaryDog = new Dictionary<string, DogLeash>();
            dictionaryCat = new Dictionary<string, CatFood>();
        }

        public void AddProduct(Product product)
        {
            if(product is DogLeash) 
            {
                dictionaryDog.Add(product.Name, product as DogLeash);
            } 
            else if(product is CatFood) 
            {
                dictionaryCat.Add(product.Name, product as CatFood);
            }
            _products.Add(product);
        }

        public DogLeash GetDogLeashByName(string name) 
        {
            try
            {
                return dictionaryDog[name];
            }
            catch (Exception ex)
            {
                return null;
            }
        }

        public List<Product> GetAllProducts()
        { 
            return _products; 
        }
        


    }
}
