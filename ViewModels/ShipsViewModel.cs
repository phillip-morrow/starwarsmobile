using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using StarWarsMobile.Models;
using StarWarsMobile.Services;

namespace StarWarsMobile.ViewModels
{
    public class ShipsViewModel : INotifyPropertyChanged
    {
        private readonly SwapiService _swapiService;
        public ObservableCollection<Ship> Ships { get; set; } = new();

        public ShipsViewModel()
        {
            _swapiService = new SwapiService();
            LoadShips();
        }

        private async void LoadShips()
        {
            var ships = await _swapiService.GetShipsAsync();
            foreach (var ship in ships)
            {
                Ships.Add(ship);
            }
        }

        public event PropertyChangedEventHandler PropertyChanged;
        protected void OnPropertyChanged([CallerMemberName] string propertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}