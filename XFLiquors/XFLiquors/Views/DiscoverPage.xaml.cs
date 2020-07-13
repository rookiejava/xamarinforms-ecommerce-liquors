using System.Diagnostics;
using Xamarin.Forms;
using Xamarin.Forms.Internals;
using Xamarin.Forms.Xaml;
using XFLiquors.ViewModels;

namespace XFLiquors.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class DiscoverPage : ContentPage
    {
        public DiscoverPage()
        {
            InitializeComponent();
            BindingContext = new DiscoverPageViewModel(Navigation);
            entry.Completed += (s, e) =>
            {
                listProducts.ScrollTo(2);
                listProducts.ScrollTo(0);
                bestPrices.ScrollTo(2);
                bestPrices.ScrollTo(0);
            };
        }
    }
}