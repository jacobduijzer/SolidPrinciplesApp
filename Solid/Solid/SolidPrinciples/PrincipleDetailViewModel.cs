using Microsoft.AppCenter.Analytics;
using Microsoft.Extensions.Logging;
using MvvmHelpers;
using Solid.Models;

namespace Solid.SolidPrinciples
{
    public class PrincipleDetailViewModel : BaseViewModel
    {
        public PrincipleDetailViewModel(Principle principle, ILogger<PrincipleDetailViewModel> logger)
        {
            Analytics.TrackEvent($"{nameof(PrincipleDetailViewModel)}-{principle.Name}");

            Principle = principle;
            Title = Principle.Name;
            
        }

        public Principle Principle { get; }
    }
}
