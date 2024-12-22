using Aspire.MauiApp.Models;
using Aspire.MauiApp.PageModels;

namespace Aspire.MauiApp.Pages
{
    public partial class MainPage : ContentPage
    {
        public MainPage(MainPageModel model)
        {
            InitializeComponent();
            BindingContext = model;
        }
    }
}