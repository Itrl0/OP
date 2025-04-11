using OP;

internal class ProductRepository : IRepository<Product>
{
    private List<Product> products = new List<Product>();

    public void Add(Product item)
    {
        products.Add(item);
    }

    public void Remove(string name)
    {
        var product = products.FirstOrDefault(p => p.Name == name);
        if (product != null)
        {
            products.Remove(product);
        }
    }

    public Product GetByName(string name)
    {
        return products.FirstOrDefault(p => p.Name == name);
    }

    public List<Product> GetAll()
    {
        return products;
    }
}
