using Sylva.ViewModels;
using System.ComponentModel;
using Xamarin.Forms;

namespace Sylva.Views
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