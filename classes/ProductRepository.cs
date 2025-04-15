using OP;
using OP.classes;

public class ProductRepository
{
    private readonly IDataStorage<Product> _storage;

    public ProductRepository(IDataStorage<Product> storage)
    {
        _storage = storage;
    }

    public void Add(Product product)
    {
        _storage.Add(product);
        _storage.Save();
    }

    public void RemoveById(int id)
    {
        _storage.Delete(id);
        _storage.Save();
    }

    public Product GetById(int id) => _storage.GetById(id);

    public List<Product> GetAll() => _storage.GetAll();
}


