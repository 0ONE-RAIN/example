using System;
using System.ComponentModel;

public class ShipViewModel : INotifyPropertyChanged
{
    private SpaceShip _shipModel;

    public int PosicionY
    {
        get { return _shipModel.PosicionY; }
        private set
        {
            if (_shipModel.PosicionY != value)
            {
                _shipModel.PosicionY = value;
                OnPropertyChanged(nameof(PosicionY));
            }
        }
    }

    public ShipViewModel()
    {
        _shipModel = new SpaceShip();
    }

    public void MoveUp()
    {
        _shipModel.MoveUp();
        OnPropertyChanged(nameof(PosicionY)); // Notificar que la posición cambió
    }

    public void MoveDown()
    {
        _shipModel.MoveDown();
        OnPropertyChanged(nameof(PosicionY)); // Notificar que la posición cambió
    }

    public event PropertyChangedEventHandler? PropertyChanged;
    protected void OnPropertyChanged(string propertyName)
    {
        PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
    }
}