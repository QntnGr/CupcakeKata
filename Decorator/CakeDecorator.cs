
namespace Decorator;

public abstract class CakeDecorator : Cake
{
    public Cake _cakeType;
    public void InitCakeType(Cake cakeType)
    {
        _cakeType = cakeType;
    }
    public override string GetName()
    {
        return _cakeType.GetName();
    }
    public override decimal GetPrice()
    {
        return _cakeType.GetPrice();
    }

}
