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
        public double CaseLength { get; set; }

        /// <summary>
        /// Ширина чехла.
        /// </summary>
        public double CaseWidth { get; set; }

        /// <summary>
        /// Высота чехла.
        /// </summary>
        public double CaseHeight { get; set; }

        /// <summary>
        /// Ширина отверстия для камеры.
        /// </summary>
        public double CameraHoleWidth { get; set; }

        /// <summary>
        /// Длина отверстия для камеры.
        /// </summary>
        public double CameraHoleLength { get; set; }

        /// <summary>
        /// Зазор между отверстием для камеры и правой стенкой чехла.
        /// </summary>
        public double CameraRightGap { get; set; }

        /// <summary>
        /// Зазор между отверстием для камеры и верхней стенкой чехла.
        /// </summary>
        public double CameraTopGap { get; set; }

        /// <summary>
        /// Ширина отверстия для зарядки.
        /// </summary>
        public double ChargerHoleWidth { get; set; }

        /// <summary>
        /// Высота отверстия для зарядки.
        /// </summary>
        public double ChargerHoleHeight { get; set; }

        /// <summary>
        /// Диаметр отверстия для наушников.
        /// </summary>
        public double MiniJackDiameter { get; set; }

        /// <summary>
        /// Зазор между отверстием для наушников и левой стенкой чехла.
        /// </summary>
        public double MiniJackGap { get; set; }

        /// <summary>
        /// Высота отверстия для боковых кнопок.
        /// </summary>
        public double SideButtonsHoleHeight { get; set; }

        /// <summary>
        /// Ширина отверстия для боковых кнопок.
        /// </summary>
        public double SideButtonsHoleWidth { get; set; }

        /// <summary>
        /// Зазор между отверстием для боковых кнопок и верхним правым углом.
        /// </summary>
        public double SideButtonsGap { get; set; }

        /// <summary>
        /// Установка параметров.
        /// </summary>
        /// <param name="caseLength">Длина чехла.</param>
        /// <param name="caseWidth">Ширина чехла.</param>
        /// <param name="caseHeight">Высота чехла.</param>
        /// <param name="cameraHoleWidth">Ширина отверстия для камеры.</param>
        /// <param name="cameraHoleLength">Длина отверстия для камеры.</param>
        /// <param name="cameraRightGap">Зазор между отверстием для камеры и правой стенкой чехла.</param>
        /// <param name="cameraTopGap">Зазор между отверстием для камеры и верхней стенкой чехла.</param>
        /// <param name="chargerHoleWidth">Ширина отверстия для зарядки.</param>
        /// <param name="chargerHoleHeight">Высота отверстия для зарядки.</param>
        /// <param name="miniJackDiameter">Диаметр отверстия для наушников.</param>
        /// <param name="miniJackGap">Зазор между отверстием для наушников и левой стенкой чехла.</param>
        /// <param name="sideButtonsHoleHeight">Высота отверстия для боковых кнопок.</param>
        /// <param name="sideButtonsHoleWidth">Ширина отверстия для боковых кнопок.</param>
        /// <param name="sideButtonsGap">Зазор между отверстием для боковых кнопок и верхним правым углом.</param>
        public PhoneCaseParameters(double caseLength, double caseWidth, double caseHeight, double cameraHoleWidth, double cameraHoleLength, double cameraRightGap, double cameraTopGap, 
            double chargerHoleWidth, double chargerHoleHeight, double miniJackDiameter, double miniJackGap, double sideButtonsHoleHeight, double sideButtonsHoleWidth, double sideButtonsGap)
        {
            CaseLength = caseLength;
            CaseWidth = caseWidth;
            CaseHeight = caseHeight;
            CameraHoleWidth = cameraHoleWidth;
            CameraHoleLength = cameraHoleLength;
            CameraRightGap = cameraRightGap;
            CameraTopGap = cameraTopGap;
            ChargerHoleWidth = chargerHoleWidth;
            ChargerHoleHeight = chargerHoleHeight;
            MiniJackDiameter = miniJackDiameter;
            MiniJackGap = miniJackGap;
            SideButtonsHoleHeight = sideButtonsHoleHeight;
            SideButtonsHoleWidth = sideButtonsHoleWidth;
            SideButtonsGap = sideButtonsGap;
            TypeValidation();
            ValueValidation();
        }

        /// <summary>
        /// Валидация параметров по типу данных.
        /// </summary>
        private void TypeValidation()
        {
            var errorMessage = new List<string>();

            CheckValue(errorMessage, CaseLength, "Длина чехла");
            CheckValue(errorMessage, CaseWidth, "Ширина чехла");
            CheckValue(errorMessage, CaseHeight, "Высота чехла");
            CheckValue(errorMessage, CameraHoleWidth, "Ширина отверстия для камеры");
            CheckValue(errorMessage, CameraHoleLength, "Длина отверстия для камеры");
            CheckValue(errorMessage, CameraRightGap, "Зазор между отверстием для камеры и правой стенкой чехла");
            CheckValue(errorMessage, CameraTopGap, "Зазор между отверстием для камеры и верхней стенкой чехла");
            CheckValue(errorMessage, ChargerHoleWidth, "Ширина отверстия для зарядки");
            CheckValue(errorMessage, ChargerHoleHeight, "Высота отверстия для зарядки");
            CheckValue(errorMessage, MiniJackGap, "Зазор между отверстием для наушников и левой стенкой чехла");
            CheckValue(errorMessage, MiniJackDiameter, "Диаметр отверстия для наушников");
            CheckValue(errorMessage, SideButtonsHoleHeight, "Высота отверстия для боковых кнопок");
            CheckValue(errorMessage, SideButtonsHoleWidth, "Ширина отверстия для боковых кнопок");
            CheckValue(errorMessage, SideButtonsGap, "Зазор между отверстием для боковых кнопок и верхним правым углом");
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

            if (CaseLength < 100 || CaseLength > 500)
            {
                errorMessage.Add("Длина чехла должна быть не меньше 100 мм " +
                                 "и не больше 500 мм");
            }

            if (CaseWidth < 100 || CaseWidth > 400)
            {
                errorMessage.Add("Ширина чехла должна быть не меньше 100 мм " +
                                 "и не больше 400 мм");
            }

            if (CaseHeight < 10 || CaseHeight > 20)
            {
                errorMessage.Add("Высота чехла должна быть не меньше 10 мм " +
                                 "и не больше 20 мм");
            }

            if (CameraHoleWidth < 10 || CameraHoleWidth > 50)
            {
                errorMessage.Add("Ширина отверстия для камеры должна быть " +
                                 "не меньше 10 мм и не больше 50 мм");
            }

            if (CameraHoleLength < 10 || CameraHoleLength > 50)
            {
                errorMessage.Add("Длина отверстия для камеры должна быть " +
                                 "не меньше 10 мм и не больше 50 мм");
            }

            if (CameraRightGap < 5 || CameraRightGap > 20)
            {
                errorMessage.Add("Зазор между отверстием для камеры и " +
                                 "правой стенкой чехла должна быть " + 
                                 " не меньше 5 мм и не больше 20 мм");
            }

            if (CameraTopGap < 5 || CameraTopGap > 20)
            {
                errorMessage.Add("Зазор между отверстием для камеры и " +
                                 "верхней стенкой чехла должна быть " +
                                 " не меньше 5 мм и не больше 20 мм");
            }

            if (ChargerHoleWidth < 10 || ChargerHoleWidth > 20)
            {
                errorMessage.Add("Ширина отверстия для зарядки должна быть " +
                                 "не меньше 10 мм и не больше 20 мм");
            }

            if (ChargerHoleHeight < 3 || ChargerHoleHeight > 6)
            {
                errorMessage.Add("Высота отверстия для зарядки должна быть " +
                                 "не меньше 3 мм и не больше 6 мм");
            }

            if (SideButtonsHoleHeight < 2 || SideButtonsHoleHeight > CaseHeight - 2)
            {
                errorMessage.Add("Высота отверстия для боковых кнопок " +
                                 $"зарядки должна быть не меньше {CaseHeight - 2} мм");
            }

            if (SideButtonsHoleWidth < 5 || SideButtonsHoleWidth > CaseLength - SideButtonsGap - 20)
            {
                errorMessage.Add("Ширина отверстия для боковых кнопок " +
                                 "должна быть не меньше 5 мм и не больше " +
                                 $" {CaseLength - SideButtonsGap - 20} мм");
            }

            if (MiniJackDiameter < 3.5 || MiniJackDiameter > 6)
            {
                errorMessage.Add("Диаметр отверстия для наушников " +
                                 "должна быть не меньше 3.5 мм и не больше 6 мм");
            }

            var s = CaseWidth / 2 - MiniJackDiameter / 2 - ChargerHoleWidth / 2 - 5;
            if (MiniJackGap < 2 || MiniJackGap > s)
            {
                errorMessage.Add("Зазор между отверстием для наушников и левой стенкой чехла " +
                                 $"должна быть не меньше половины диаметра + 2 мм и не больше {s} мм");
            }

            if (errorMessage.Count > 0)
            {
                throw new ArgumentException(string.Join("\n", errorMessage));
            }
        }
    }
}
