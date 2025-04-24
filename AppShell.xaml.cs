using StarWarsMobile.Views;

namespace StarWarsMobile;

public partial class AppShell : Shell
{
    public AppShell()
    {
        InitializeComponent();
        Routing.RegisterRoute(nameof(CharactersPage), typeof(CharactersPage));
        Routing.RegisterRoute(nameof(ShipsPage), typeof(ShipsPage));
        Routing.RegisterRoute(nameof(MoviesPage), typeof(MoviesPage));
        Routing.RegisterRoute(nameof(DetailsPage), typeof(DetailsPage));
    }
}
