using System;

namespace Lab_4.Model
{
    public class ShipModel
    {
        private int _posicionY;
        public int PosicionY
        {
            get { return _posicionY; }
            private set
            {
                if (_posicionY != value)
                {
                    _posicionY = value;
                    OnPosicionYChanged(); // Notificar que la posición cambió
                }
            }
        }

        public event EventHandler PosicionYChanged; // Evento para notificar cambios

        public ShipModel()
        {
            PosicionY = 0; // Posición inicial
        }

        // Método para mover el sprite hacia arriba
        public void MoveUp()
        {
            PosicionY -= 10; // Ajusta la posición
        }

        // Método para mover el sprite hacia abajo
        public void MoveDown()
        {
            PosicionY += 10; // Ajusta la posición
        }

        // Método para invocar el evento PosicionYChanged
        protected virtual void OnPosicionYChanged()
        {
            PosicionYChanged?.Invoke(this, EventArgs.Empty);
        }
    }
}