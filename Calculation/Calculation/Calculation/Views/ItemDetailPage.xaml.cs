using System.ComponentModel;
using Xamarin.Forms;
using Calculation.ViewModels;

namespace Calculation.Views
{
    public partial class ItemDetailPage : ContentPage
    {
        public ItemDetailPage()
        {
            InitializeComponent();
            BindingContext = new ItemDetailViewModel();
        }
    }
}