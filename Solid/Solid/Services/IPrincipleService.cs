using System.Collections.Generic;
using Solid.Models;

namespace Solid.Services
{
    public interface IPrincipleService
    {
        IEnumerable<Principle> GetPrinciples();

        Principle GetPrinciple(int id);
    }
}
