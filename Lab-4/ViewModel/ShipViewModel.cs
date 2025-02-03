using Lab_4.Model;
using System.ComponentModel;
using Lab_4.Resources;
namespace Lab_4.ViewModel
{
    public class ShipViewModel : INotifyPropertyChanged
    {
        private ShipModel _shipModel;

        public int PosicionY
        {
            get { return _shipModel.PosicionY; }
        }

        public ShipViewModel()
        {
            _shipModel = new ShipModel();
            _shipModel.PosicionYChanged += (s, e) => OnPropertyChanged(nameof(PosicionY)); // Suscribirse al evento
        }

        // Comando para mover el sprite hacia arriba
        public void MoveUp()
        {
            _shipModel.MoveUp();
            ResourceManager.MoveSound.Play(); // Reproducir sonido
        }

        // Comando para mover el sprite hacia abajo
        public void MoveDown()
        {
            _shipModel.MoveDown();
            ResourceManager.MoveSound.Play(); // Reproducir sonido
        }

        // Implementación de INotifyPropertyChanged
        public event PropertyChangedEventHandler PropertyChanged;
        protected void OnPropertyChanged(string propertyName)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}