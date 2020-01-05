using System;
using System.Collections.Generic;
using System.Linq;
using Solid.Models;

namespace Solid.Services
{
    public class OfflinePrincipleService : IPrincipleService
    {
        private readonly IEnumerable<Principle> _principles;

        public OfflinePrincipleService()
        {
            _principles = new List<Principle>
            {
                new Principle
                {
                    Id = 1,
                    Name = "Single Responsibility Principle",
                    ShortDescription = "A class should have one, and only one, reason to change",
                    Description = "# Single Responsibility Principle\n\nA class should have only one responsibility which means a class should be highly cohesive and implement strongly related logic. A class implementing feature 1 AND feature 2 AND feature 3 (and so on) violates SRP."

        },
                new Principle
                {
                    Id = 2,
                    Name = "Open/Closed Principle",
                    ShortDescription = "Possible to extend a class’s behavior, without modifying it",
                    Description = "# Open/Closed Principle\n\nIn programming, the open/closed principle states that software entities (classes, modules, functions, etc.) should be open for extensions, but closed for modification. We should write our modules so that they can be extended, without requiring them to be modified. In other words, we want to be able to change what the modules do, without changing the source code of the modules.",
                },
                new Principle
                {
                    Id = 3,
                    Name = "Liskov Substitution Principle",
                    ShortDescription = "Derived classes must be substitutable for their base classes",
                    Description = "# Liskov Substitution Principle\n\nObjects in a program should be replaceable with instances of their subtypes without altering the correctness of that program.",
                },
                new Principle
                {
                    Id = 4,
                    Name = "Interface Segregation Principle",
                    ShortDescription = "Make fine grained interfaces that are client specific",
                    Description = "# Interface Segregation Principle\n\nNo client should be forced to depend on methods it does not use. Put more simply: Do not add additional functionality to an existing interface by adding new methods. Instead, create a new interface and let your class implement multiple interfaces if needed.",
                },
                new Principle
                {
                    Id = 5,
                    Name = "Dependency Inversion Principle",
                    ShortDescription = "Depend on abstrations, not on concretions",
                    Description = "Dependency Inversion Principle\n\nHigh-level modules should not depend on low-level modules. Both should depend on abstractions. Abstractions should not depend on details. Details should depend on abstractions. Dependency Inversion is the strategy of depending upon interfaces or abstract functions and classes, rather than upon concrete functions and classes.",
                }
            };
        }

        public Principle GetPrinciple(int id)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Principle> GetPrinciples() =>
            _principles.OrderBy(x => x.Id).ToList();

    }
}
