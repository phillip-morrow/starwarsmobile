using System.ComponentModel;
using System.Runtime.CompilerServices;
using StarWarsMobile.Models;

namespace StarWarsMobile.ViewModels
{
    public class DetailsViewModel : INotifyPropertyChanged
    {
        private DetailsModel _details;
        public DetailsModel Details
        {
            get => _details;
            set
            {
                _details = value;
                OnPropertyChanged();
            }
        }

        public DetailsViewModel(DetailsModel details)
        {
            Details = details;
        }

        public event PropertyChangedEventHandler? PropertyChanged;
        protected void OnPropertyChanged([CallerMemberName] string propertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}