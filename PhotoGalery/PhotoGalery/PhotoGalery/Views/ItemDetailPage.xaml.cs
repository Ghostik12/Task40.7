using PhotoGalery.ViewModels;
using System.ComponentModel;
using Xamarin.Forms;

namespace PhotoGalery.Views
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