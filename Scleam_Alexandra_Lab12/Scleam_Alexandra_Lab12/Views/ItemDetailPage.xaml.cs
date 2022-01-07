using Scleam_Alexandra_Lab12.ViewModels;
using System.ComponentModel;
using Xamarin.Forms;

namespace Scleam_Alexandra_Lab12.Views
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