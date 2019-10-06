using MvvmHelpers;
using Solid.Models;

namespace Solid.SolidPrinciples
{
    public class PrincipleDetailViewModel : BaseViewModel
    {
        public PrincipleDetailViewModel(Principle principle)
        {
            Principle = principle;
            Title = Principle.Name;
        }

        public Principle Principle { get; }
    }
}
