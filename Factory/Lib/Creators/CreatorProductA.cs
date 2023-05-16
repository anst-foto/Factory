using Factory.Lib.Products;

namespace Factory.Lib.Creators;

public class CreatorProductA : CreatorProduct
{
    public override Product Create()
    {
        return new ProductA();
    }
}