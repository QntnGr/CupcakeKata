
namespace Composite;

public class Composite : Component
{

    List<Component> children = new List<Component>();
    public override void Add(Component component)
    {
        children.Add(component);
    }

    public override string GetName()
    {
        return string.Join(" + ", children.Select(c => c.GetName()));
    }

    public override decimal GetPrice()
    {
        return children.Sum(c => c.GetPrice());
    }
}
