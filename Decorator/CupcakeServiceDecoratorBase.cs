using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Decorator;

public abstract class CupcakeServiceDecoratorBase : ICupcakeService
{
    private readonly ICupcakeService _cupcakeService;

    public CupcakeServiceDecoratorBase(ICupcakeService cupcakeService)
    {
        _cupcakeService = cupcakeService;
    }

    public virtual string GetName()
    {
        return _cupcakeService.GetName();
    }

    public virtual decimal GetPrice()
    {
        return _cupcakeService.GetPrice();
    }
}
