using CoursXamarin.ViewModels;
using System.ComponentModel;
using Xamarin.Forms;

namespace CoursXamarin.Views
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