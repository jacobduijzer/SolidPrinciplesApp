using System;
using System.Collections.Generic;
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
                    Description = "Some Description",
                    Examples = new List<string>
                    {
                        "example 1",
                        "example 2"
                    }
                },
                new Principle
                {
                    Id = 2,
                    Name = "Open/Closed Principle",
                    Description = "Some Description",
                    Examples = new List<string>
                    {
                        "example 1",
                        "example 2"
                    }
                },
                new Principle
                {
                    Id = 3,
                    Name = "Liskov Substitution Principle",
                    Description = "Some Description",
                    Examples = new List<string>
                    {
                        "example 1",
                        "example 2"
                    }
                },
                new Principle
                {
                    Id = 4,
                    Name = "Interface Segregation Principle",
                    Description = "Some Description",
                    Examples = new List<string>
                    {
                        "example 1",
                        "example 2"
                    }
                },
                new Principle
                {
                    Id = 5,
                    Name = "Dependency Inversion Principle",
                    Description = "Some Description",
                    Examples = new List<string>
                    {
                        "example 1",
                        "example 2"
                    }
                }
            };
        }

        public Principle GetPrinciple(int id)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Principle> GetPrinciples()
        {
            throw new NotImplementedException();
        }
    }
}
