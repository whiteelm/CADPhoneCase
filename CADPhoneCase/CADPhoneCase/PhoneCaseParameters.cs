
namespace CADPhoneCase
{
    /// <summary>
    /// Размеры чехла.
    /// </summary>
    public class PhoneCaseParameters
    {
        /// <summary>
        /// Длина чехла.
        /// </summary>
        public double A { get; set; }

        /// <summary>
        /// Ширина чехла.
        /// </summary>
        public double B { get; set; }

        /// <summary>
        /// Высота чехла.
        /// </summary>
        public double H { get; set; }

        /// <summary>
        /// Ширина отверстия для камеры.
        /// </summary>
        public double A1 { get; set; }

        /// <summary>
        /// Длина отверстия для камеры.
        /// </summary>
        public double B1 { get; set; }

        /// <summary>
        /// Зазор между отверстием для камеры и правой стенкой чехла.
        /// </summary>
        public double S0 { get; set; }

        /// <summary>
        /// Зазор между отверстием для камеры и верхней стенкой чехла.
        /// </summary>
        public double S1 { get; set; }

        /// <summary>
        /// Ширина отверстия для зарядки.
        /// </summary>
        public double A2 { get; set; }

        /// <summary>
        /// Высота отверстия для зарядки.
        /// </summary>
        public double B2 { get; set; }

        /// <summary>
        /// Диаметр отверстия для наушников.
        /// </summary>
        public double D { get; set; }

        /// <summary>
        /// Зазор между отверстием для наушников и левой стенкой чехла.
        /// </summary>
        public double S2 { get; set; }

        /// <summary>
        /// Высота отверстия для боковых кнопок.
        /// </summary>
        public double A3 { get; set; }

        /// <summary>
        /// Ширина отверстия для боковых кнопок.
        /// </summary>
        public double B3 { get; set; }

        /// <summary>
        /// Зазор между отверстием для боковых кнопок и верхним правым углом.
        /// </summary>
        public double S3 { get; set; }

        /// <summary>
        /// Установка параметров.
        /// </summary>
        /// <param name="a">Длина чехла.</param>
        /// <param name="b">Ширина чехла.</param>
        /// <param name="h">Высота чехла.</param>
        /// <param name="a1">Ширина отверстия для камеры.</param>
        /// <param name="b1">Длина отверстия для камеры.</param>
        /// <param name="s0">Зазор между отверстием для камеры и правой стенкой чехла.</param>
        /// <param name="s1">Зазор между отверстием для камеры и верхней стенкой чехла.</param>
        /// <param name="a2">Ширина отверстия для зарядки.</param>
        /// <param name="b2">Высота отверстия для зарядки.</param>
        /// <param name="d">Диаметр отверстия для наушников.</param>
        /// <param name="s2">Зазор между отверстием для наушников и левой стенкой чехла.</param>
        /// <param name="a3">Высота отверстия для боковых кнопок.</param>
        /// <param name="b3">Ширина отверстия для боковых кнопок.</param>
        /// <param name="s3">Зазор между отверстием для боковых кнопок и верхним правым углом.</param>
        public PhoneCaseParameters(double a, double b, double h, double a1, double b1, double s0, double s1, 
            double a2, double b2, double d, double s2, double a3, double b3, double s3)
        {
            A = a;
            B = b;
            H = h;
            A1 = a1;
            B1 = b1;
            S0 = s0;
            S1 = s1;
            A2 = a2;
            B2 = b2;
            D = d;
            S2 = s2;
            A3 = a3;
            B3 = b3;
            S3 = s3;
        }

    }
}
