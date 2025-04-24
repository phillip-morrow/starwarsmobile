using StarWarsMobile.Models;
using StarWarsMobile.ViewModels;

namespace StarWarsMobile.Views;

public partial class DetailsPage : ContentPage
{
    public DetailsPage(DetailsModel details)
    {
        InitializeComponent();
        BindingContext = new DetailsViewModel(details);
    }
}