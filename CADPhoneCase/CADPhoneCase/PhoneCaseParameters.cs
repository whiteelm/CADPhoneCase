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
        public PhoneCaseParameters(double caseLength, double caseWidth, double caseHeight, 
            double cameraHoleWidth, double cameraHoleLength, double cameraRightGap, double cameraTopGap, 
            double chargerHoleWidth, double chargerHoleHeight, double miniJackDiameter, 
            double miniJackGap, double sideButtonsHoleHeight, double sideButtonsHoleWidth, 
            double sideButtonsGap)
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
        }

        /// <summary>
        /// Валидация параметров по диапазону значения.
        /// </summary>
        private void TypeValidation()
        {
            var errorMessage = new List<string>();

            CheckValue(errorMessage, CaseLength, "Длина чехла", 100, 500);
            CheckValue(errorMessage, CaseWidth, "Ширина чехла", 100, 400);
            CheckValue(errorMessage, CaseHeight,"Высота чехла", 10, 20);
            CheckValue(errorMessage, CameraHoleWidth,"Ширина отверстия для камеры", 10, 50);
            CheckValue(errorMessage, CameraHoleLength,"Длина отверстия для камеры", 10, 50);
            CheckValue(errorMessage, CameraRightGap, "Зазор между отверстием для камеры и правой стенкой чехла", 
                5, 20);
            CheckValue(errorMessage, CameraTopGap,"Зазор между отверстием для камеры и верхней стенкой чехла", 
                5, 20);
            CheckValue(errorMessage, ChargerHoleWidth,"Ширина отверстия для зарядки", 10, 20);
            CheckValue(errorMessage, ChargerHoleHeight,"Высота отверстия для зарядки", 3, 6);
            var s = CaseWidth / 2 - MiniJackDiameter / 2 - ChargerHoleWidth / 2 - 5;
            CheckValue(errorMessage, MiniJackGap,"Зазор между отверстием для наушников и левой стенкой чехла", 
                2, s);
            CheckValue(errorMessage, MiniJackDiameter,"Диаметр отверстия для наушников", 3.5, 6);
            CheckValue(errorMessage, SideButtonsHoleHeight,"Высота отверстия для боковых кнопок", 2, CaseHeight - 2);
            CheckValue(errorMessage, SideButtonsHoleWidth,"Ширина отверстия для боковых кнопок", 
                5, CaseLength - SideButtonsGap - 20);
            CheckValue(errorMessage, SideButtonsGap,"Зазор между отверстием для боковых кнопок и верхним правым углом",
                5, 20);

            if (errorMessage.Count > 0)
            {
                throw new ArgumentException(string.Join("\n", errorMessage));
            }
        }

        /// <summary>
        /// Заполнения списка исключений.
        /// </summary>
        /// <param name="errorList">Список ошибок.</param>
        /// <param name="value">Значение.</param>
        /// <param name="name">Название параметра.</param>
        /// <param name="min">Минимальный размер.</param>
        /// <param name="max">Максимальный размер.</param>
        private static void CheckValue(ICollection<string> errorList, double value, string name, 
            double min, double max)
        {
            if (value < min || value > max)
            {
                errorList.Add($"{name} не может быть меньше {min} или больше {max}.\n");
            }
        }
    }
}
