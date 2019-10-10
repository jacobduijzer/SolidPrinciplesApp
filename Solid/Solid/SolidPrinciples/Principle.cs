using System.Collections.Generic;

namespace Solid.Models
{
    public class Principle
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string ShortDescription { get; set; }
        public string Description { get; set; }
        public string Recognize { get; set; }
        public List<string> GoodExamples { get; set; }
        public List<string> BadExamples { get; set; }
    }
}
