using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using StarWarsMobile.Models;
using StarWarsMobile.Services;

namespace StarWarsMobile.ViewModels
{
    public class MoviesViewModel : INotifyPropertyChanged
    {
        private readonly SwapiService _swapiService;
        public ObservableCollection<Movie> Movies { get; set; } = new();

        public MoviesViewModel()
        {
            _swapiService = new SwapiService();
            LoadMovies();
        }

        private async void LoadMovies()
        {
            var movies = await _swapiService.GetMoviesAsync();
            foreach (var movie in movies)
            {
                Movies.Add(movie);
            }
        }

        public event PropertyChangedEventHandler PropertyChanged;
        protected void OnPropertyChanged([CallerMemberName] string propertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}