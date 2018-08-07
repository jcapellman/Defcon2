using Xamarin.Forms;

namespace Defcon2.lib.Views
{
	public partial class CustomNavigationPage : NavigationPage
	{
		public bool IgnoreLayoutChange { get; set; } = false;

		protected override void OnSizeAllocated(double width, double height)
		{
		    if (!IgnoreLayoutChange)
		    {
		        base.OnSizeAllocated(width, height);
		    }
		}

		public CustomNavigationPage() : base()
		{
			InitializeComponent();
		}

		public CustomNavigationPage(Page root) : base(root)
		{
			InitializeComponent();
		}
	}
}