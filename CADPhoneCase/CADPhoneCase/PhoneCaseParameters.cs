using System;
using System.Collections.Generic;

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
            TypeValidation();
            ValueValidation();
        }

        /// <summary>
        /// Валидация параметров по типу данных.
        /// </summary>
        private void TypeValidation()
        {
            var errorMessage = new List<string>();

            CheckValue(errorMessage, A, "Длина чехла");
            CheckValue(errorMessage, B, "Ширина чехла");
            CheckValue(errorMessage, H, "Высота чехла");
            CheckValue(errorMessage, A1, "Ширина отверстия для камеры");
            CheckValue(errorMessage, B1, "Длина отверстия для камеры");
            CheckValue(errorMessage, S0, "Зазор между отверстием для камеры и правой стенкой чехла");
            CheckValue(errorMessage, S1, "Зазор между отверстием для камеры и верхней стенкой чехла");
            CheckValue(errorMessage, A2, "Ширина отверстия для зарядки");
            CheckValue(errorMessage, B2, "Высота отверстия для зарядки");
            CheckValue(errorMessage, S2, "Зазор между отверстием для наушников и левой стенкой чехла");
            CheckValue(errorMessage, D, "Диаметр отверстия для наушников");
            CheckValue(errorMessage, A3, "Высота отверстия для боковых кнопок");
            CheckValue(errorMessage, B3, "Ширина отверстия для боковых кнопок");
            CheckValue(errorMessage, S3, "Зазор между отверстием для боковых кнопок и верхним правым углом");
            if (errorMessage.Count > 0)
            {
                throw new ArgumentException(string.Join("\n", errorMessage));
            }
        }

        /// <summary>
        /// Проверка значения на NaN и Infinity.
        /// </summary>
        /// <param name="errorList">Список ошибок.</param>
        /// <param name="value">Значение.</param>
        /// <param name="name">Название параметра.</param>
        private void CheckValue(List<string> errorList, double value, string name)
        {
            if (double.IsNaN(value) || double.IsInfinity(value))
            {
                errorList.Add($"{name} не должно быть бесконечным или несуществующим.\n");
            }
        }

        /// <summary>
        /// Валидация параметров по диапазону значения.
        /// </summary>
        private void ValueValidation()
        {
            var errorMessage = new List<string>();

            if (A < 100 || A > 500)
            {
                errorMessage.Add("Длина чехла должна быть не меньше 100 мм " +
                                 "и не больше 500 мм");
            }
            if (B < 100 || B > 400)
            {
                errorMessage.Add("Ширина чехла должна быть не меньше 100 мм " +
                                 "и не больше 400 мм");
            }
            if (H < 10 || H > 20)
            {
                errorMessage.Add("Высота чехла должна быть не меньше 10 мм " +
                                 "и не больше 20 мм");
            }
            if (A1 < 10 || A1 > 50)
            {
                errorMessage.Add("Ширина отверстия для камеры должна быть " +
                                 "не меньше 10 мм и не больше 50 мм");
            }
            if (B1 < 10 || B1 > 50)
            {
                errorMessage.Add("Длина отверстия для камеры должна быть " +
                                 "не меньше 10 мм и не больше 50 мм");
            }
            if (S0 < 5 || S0 > 20)
            {
                errorMessage.Add("Зазор между отверстием для камеры и " +
                                 "правой стенкой чехла должна быть " + 
                                 " не меньше 5 мм и не больше 20 мм");
            }
            if (S1 < 5 || S1 > 20)
            {
                errorMessage.Add("Зазор между отверстием для камеры и " +
                                 "верхней стенкой чехла должна быть " +
                                 " не меньше 5 мм и не больше 20 мм");
            }
            if (A2 < 10 || A2 > 20)
            {
                errorMessage.Add("Ширина отверстия для зарядки должна быть " +
                                 "не меньше 10 мм и не больше 20 мм");
            }
            if (B2 < 3 || B2 > 6)
            {
                errorMessage.Add("Высота отверстия для зарядки должна быть " +
                                 "не меньше 3 мм и не больше 6 мм");
            }
            if (A3 < 2 || A3 > H - 2)
            {
                errorMessage.Add("Высота отверстия для боковых кнопок зарядки " +
                                 "должна быть не меньше 2 мм и не больше высоты чехла минус 2 мм");
            }
            if (B3 < 5 || B3 > A - S3 - 20)
            {
                errorMessage.Add("Ширина отверстия для боковых кнопок " +
                                 "должна быть не меньше 5 мм и не больше " +
                                 " ширины чехла-зазор для отверстия минус 20  мм");
            }
            if (D < 3.5 || D > 6)
            {
                errorMessage.Add("Диаметр отверстия для наушников " +
                                 "должна быть не меньше 3.5 мм и не больше 6 мм");
            }
            if (S2 < 3.5 || S2 > 6)
            {
                errorMessage.Add("Зазор между отверстием для наушников и левой стенкой чехла " +
                                 "должна быть не меньше половины диаметра + 2 мм и не больше " +
                                 "половины ширины чехла минус радиус отверстия для наушников - " +
                                 "пол ширины отверстия для зарядки минус 5 мм");
            }
            if (errorMessage.Count > 0)
            {
                throw new ArgumentException(string.Join("\n", errorMessage));
            }
        }
    }
}
