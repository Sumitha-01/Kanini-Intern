using FirstAPI.INterface;
using FirstAPI.Models;

namespace FirstAPI.Services
{
    public class ProductRepo:IRepo<int,Product>

    {
        static IList<Product> products = new List<Product>()

        {
            new Product { Id = 101, Name = "pencil", Price = 12.5f, Quantity = 2 },
           new Product { Id = 102, Name = "Eraser", Price = 5.0f, Quantity = 3 }

        };

        public Product Add(Product item)
        {
            if (products.Contains(item))
                return null;
            else
                products.Add(item);
            return item;
        }

        public Product Delete(int key)
        {
            Product product = Get(key);
            if (product != null)
            {
                return product;
            }
            else
            {
                return null;
            }
        }

        public Product Get(int key)
        {
            Product product = products.SingleOrDefault(p => p.Id == key);
            return product;
        }

        public ICollection<Product> GetAll()
        {
            if (products.Count != 0)
            {
                return products;
            }
            else
            {
                return null;
            }
        }

        public Product update(Product item)
        {
            Product product = Get(item.Id);
            if (product != null)
            {
                product.Name = item.Name;
                product.Price = item.Price;
                product.Quantity = item.Quantity;
                return product;
            }
            else
            {
                return null;
            }
        }
    }
}
