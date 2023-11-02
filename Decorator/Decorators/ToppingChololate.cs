namespace Decorator.Decorators;

public class ToppingChololate : CakeDecorator
{
    public override string GetName()
    {
        return $"{base.GetName()} with Chocolate";
    }

    public override decimal GetPrice()
    {
        return base.GetPrice() + 5m;
    }
}
