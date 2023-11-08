
namespace Composite;

public abstract class Component
{
    public abstract void Add(Component component);
    public abstract string GetName();
    public abstract decimal GetPrice();
}
