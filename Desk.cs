
namespace MegaDesk
{
    public enum DesktopMaterial
    {
        Laminate,
        Oak,
        Rosewood,
        Veneer,
        Pine
    }

    public class Desk
    {
        public const int MINWIDTH = 24;
        public const int MAXWIDTH = 96;
        public const int MINDEPTH = 12;
        public const int MAXDEPTH = 48;

        public int width;
        public int depth;
        public int drawerNumber;
        public string surfaceType;
        public int area;
        
        public Desk()
        {
            width = 0;
            depth = 0;
            drawerNumber = 0;
            surfaceType = string.Empty;
        }

        public int calculateArea()
        {
            area = width * depth;
            return area;
        }

    }
}
