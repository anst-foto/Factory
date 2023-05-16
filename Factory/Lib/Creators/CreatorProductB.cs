using Factory.Lib.Products;

namespace Factory.Lib.Creators;

public class CreatorProductB : CreatorProduct
{
    public override Product Create()
    {
        return new ProductB();
    }
}