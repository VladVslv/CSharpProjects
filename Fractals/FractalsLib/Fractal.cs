using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;


namespace FractalsLib
{
    /// <summary>
    /// ������� ����� ��� ���������.
    /// </summary>
    public abstract class Fractal
    {
        /// <summary>
        /// Canvas, ��� �������� ��� ��������.
        /// </summary>
        public static Canvas MainCanvas { get; set; }

        /// <summary>
        /// ������� ��������.
        /// </summary>
        public static int RecursionDepth { get; set; } = 5;

        /// <summary>
        /// ��������� ���� ���������.
        /// </summary>
        public static Color StartingColor { get; set; } = Colors.Black;

        /// <summary>
        /// �������� ���� ���������.
        /// </summary>
        public static Color EndingColor { get; set; } = Colors.Salmon;

        /// <summary>
        /// ������ ������ ��� ������� ���� ��������.
        /// </summary>
        public static List<Color> Gradient { get; set; }

        /// <summary>
        /// ��������� ������ ������.
        /// </summary>
        public static void ChangeGradient()
        {
            Gradient = new();
            for(int i = 0; i < RecursionDepth; i++)
            {
                Gradient.Add(Color.FromArgb(255,
                    (byte)(StartingColor.R - (StartingColor.R - EndingColor.R) * i / (RecursionDepth-1)),
                    (byte)(StartingColor.G - (StartingColor.G - EndingColor.G) * i / (RecursionDepth-1)),
                    (byte)(StartingColor.B - (StartingColor.B - EndingColor.B) * i / (RecursionDepth-1))));
            }
        }

        /// <summary>
        /// ��������� ��������.
        /// </summary>
        public abstract void DrawFractal();

    }
}
