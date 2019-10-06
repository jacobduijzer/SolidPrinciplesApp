using System;
using System.Collections.ObjectModel;
using System.Diagnostics;
using System.Windows.Input;
using MvvmHelpers;
using MvvmHelpers.Commands;
using Solid.Models;
using Solid.Services;

namespace Solid.SolidPrinciples
{
    public class PrinciplesViewModel : BaseViewModel
    {
        public PrinciplesViewModel(IPrincipleService principleService)
        {
            Title = "Principle";
            _principleService = principleService;

            LoadItemsCommand = new Command(ExecuteLoadItemsCommand);
        }

        public ObservableCollection<Principle> Items { get; set; } = new ObservableCollection<Principle>();
        public ICommand LoadItemsCommand { get; set; }

        private readonly IPrincipleService _principleService;

        public void ExecuteLoadItemsCommand()
        {
            if (IsBusy)
                return;

            IsBusy = true;

            try
            {
                Items.Clear();
                var items =  _principleService.GetPrinciples();
                foreach (var item in items)
                {
                    Items.Add(item);
                }
            }
            catch (Exception ex)
            {
                Debug.WriteLine(ex);
            }
            finally
            {
                IsBusy = false;
            }
        }
    }
}