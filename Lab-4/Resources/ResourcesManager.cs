using System.Drawing;
using System.Media;

namespace Lab_4.Resources
{
    public static class ResourceManager
    {
        // Imágenes del sprite
        public static Image Idle => Properties.Resources.Idle__1_;
        public static Image MoveUp => Properties.Resources.Jump;
        public static Image MoveDown => Properties.Resources.Idle__1_;

        // Sonido de movimiento
        public static SoundPlayer MoveSound => new SoundPlayer(Properties.Resources.move_sound);
    }
}