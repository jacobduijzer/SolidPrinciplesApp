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
                    Description = "A class should have only one responsibility which means a class should be highly cohesive and implement strongly related logic. A class implementing feature 1 AND feature 2 AND feature 3 (and so on) violates SRP.",
                    Recognize = "more than one contextually separated piece of code within single class • large setup in tests(TDD isvery useful when it comes to detecting SRP violation)",
                    GoodExamples = new List<string>
                    {
                        "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Integer malesuada lacus sed justo porta convallis. Morbi eget bibendum orci, vitae tempus mi. Nullam malesuada pulvinar lobortis. Suspendisse vulputate in magna sed iaculis. Donec ut facilisis justo. Phasellus in ex congue, placerat lorem sed, viverra velit.",
                        "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Nam mauris augue, cursus at rhoncus euismod, mattis ut metus.",
                        "Maecenas vitae euismod magna, ac convallis enim. Fusce in libero vitae nulla accumsan pharetra. Pellentesque iaculis commodo arcu quis fringilla.",
                        "Pellentesque in molestie nunc. Duis a maximus velit, non sodales urna. Sed eu ligula sed nisi luctus egestas eu mollis dolor.",
                        "{" +
                        "" +
                        "}"
                    }
                },
                new Principle
                {
                    Id = 2,
                    Name = "Open/Closed Principle",
                    ShortDescription = "Possible to extend a class’s behavior, without modifying it",
                    Description = "Some Description",
                    GoodExamples = new List<string>
                    {
                        "example 1",
                        "example 2"
                    }
                },
                new Principle
                {
                    Id = 3,
                    Name = "Liskov Substitution Principle",
                    ShortDescription = "Derived classes must be substitutable for their base classes",
                    Description = "Some Description",
                    GoodExamples = new List<string>
                    {
                        "example 1",
                        "example 2"
                    }
                },
                new Principle
                {
                    Id = 4,
                    Name = "Interface Segregation Principle",
                    ShortDescription = "Make fine grained interfaces that are client specific",
                    Description = "Some Description",
                    GoodExamples = new List<string>
                    {
                        "example 1",
                        "example 2"
                    }
                },
                new Principle
                {
                    Id = 5,
                    Name = "Dependency Inversion Principle",
                    ShortDescription = "Depend on abstrations, not on concretions",
                    Description = "Some Description",
                    GoodExamples = new List<string>
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

        public IEnumerable<Principle> GetPrinciples() =>
            _principles.OrderBy(x => x.Id).ToList();

    }
}
