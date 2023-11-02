
namespace Decorator;

public class Cookie : Cake
{
    public override string GetName()
    {
        return "Cookie";
    }

    public override decimal GetPrice()
    {
        return 2m;
    }
}
