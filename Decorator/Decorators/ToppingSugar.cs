namespace Decorator.Decorators;

public class ToppingSugar : CakeDecorator
{

    public override string GetName()
    {
        return $"{base.GetName()} with Sugar";
    }

    public override decimal GetPrice()
    {
        return base.GetPrice() + .5m;
    }
}
