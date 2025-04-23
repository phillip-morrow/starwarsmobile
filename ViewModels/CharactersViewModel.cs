using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using StarWarsMobile.Models;
using StarWarsMobile.Services;

namespace StarWarsMobile.ViewModels
{
    public class CharactersViewModel : INotifyPropertyChanged
    {
        private readonly SwapiService _swapiService;
        public ObservableCollection<Character> Characters { get; set; } = new();

        public CharactersViewModel()
        {
            _swapiService = new SwapiService();
            LoadCharacters();
        }

        private async void LoadCharacters()
        {
            var characters = await _swapiService.GetCharactersAsync();
            foreach (var character in characters)
            {
                Characters.Add(character);
            }
        }

        public event PropertyChangedEventHandler PropertyChanged;
        protected void OnPropertyChanged([CallerMemberName] string propertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}