using System.Collections.Generic;

namespace Solid.Models
{
    public class Principle
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public List<string> Examples { get; set; }
    }
}
