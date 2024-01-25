using System.ComponentModel;
using WeatherFy.ViewModels;
using Xamarin.Forms;

namespace WeatherFy.Views
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