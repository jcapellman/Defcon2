using System.Collections.ObjectModel;

using Defcon2.lib.Objects;
using Defcon2.lib.Views;

namespace Defcon2.lib.ViewModels
{
    public class MasterViewModel : BaseViewModel
    {
        public ObservableCollection<MasterViewMenuItem> MenuItems { get; set; }

		public MasterViewModel()
        {
            MenuItems = new ObservableCollection<MasterViewMenuItem>(new[]
            {
                new MasterViewMenuItem { Id = 0, Title = "Home", TargetType = typeof(MainGamePage) }
            });
        }
    }
}