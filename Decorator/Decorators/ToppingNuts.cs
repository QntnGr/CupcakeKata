namespace Decorator.Decorators;

public class ToppingNuts : CakeDecorator
{

    public override string GetName()
    {
        return $"{base.GetName()} with Nuts";
    }

    public override decimal GetPrice()
    {
        return base.GetPrice() + 0.6m;
    }
}
