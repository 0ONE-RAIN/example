using System;
using System.Windows.Forms;

public partial class shipView : Form
{
    private ShipViewModel _viewModel;

    public shipView()
    {
        InitializeComponent();
        _viewModel = new ShipViewModel();

        // Asignar la imagen inicial de la nave
        pictureBox1.Image = Properties.Resources.Idle__1_;
        pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;

        // Suscribirse a los cambios en la posición de la nave
        _viewModel.PropertyChanged += (s, e) =>
        {
            if (e.PropertyName == nameof(_viewModel.PosicionY))
            {
                // Actualizar la posición del PictureBox
                pictureBox1.Location = new Point(pictureBox1.Location.X, _viewModel.PosicionY);
            }
        };

        // Capturar las teclas presionadas
        this.KeyDown += (s, e) =>
        {
            if (e.KeyCode == Keys.Up)
            {
                _viewModel.MoveUp();
                // Cambiar la imagen cuando se presiona la tecla de arriba
                pictureBox1.Image = Properties.Resources.nave_arriba; // Nueva imagen
            }
            else if (e.KeyCode == Keys.Down)
            {
                _viewModel.MoveDown();
                // Restaurar la imagen original cuando se presiona la tecla de abajo
                pictureBox1.Image = Properties.Resources.Idle__1_; // Imagen original
            }
        };
    }

    private void label1_Click(object sender, EventArgs e)
    {
        // Lógica para el evento Click de label1
    }

    private void pictureBox1_Click(object sender, EventArgs e)
    {
        // Lógica para el evento Click de pictureBox1
    }

    private void label1_Click_1(object sender, EventArgs e)
    {
        // Lógica para el evento Click de label1
    }
}