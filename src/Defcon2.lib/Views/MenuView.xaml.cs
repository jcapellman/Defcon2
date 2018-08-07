using Defcon2.lib.ViewModels;

using Xamarin.Forms;

namespace Defcon2.lib.Views
{
	public partial class MenuView : ContentPage
	{
		public ListView ListView;

		public MenuView()
		{
			InitializeComponent();

			BindingContext = new MasterViewModel();
			ListView = menuItemsListView;
		}
	}
}