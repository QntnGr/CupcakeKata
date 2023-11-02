
namespace Decorator;

public class CupCake : Cake
{

    public override string GetName()
    {
        return "CupCake";
    }

    public override decimal GetPrice()
    {
        return 10m;
    }
}
