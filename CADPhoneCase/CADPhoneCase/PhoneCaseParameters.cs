using System;

namespace CADPhoneCase
{
    /// <summary>
    /// Размеры чехла.
    /// </summary>
    public class PhoneCaseParameters
    {
        /// <summary>
        /// Длина чехла должна быть не меньше 100 мм и не больше 500 мм.
        /// </summary>
        public double CaseLength
        {
            get => _caseLength;
            
            set
            {
                CheckValue(value, "Длина чехла", 100, 500);
                _caseLength = value;
            }
        }
        
        /// <summary>
        /// Ширина чехла должна быть не меньше 100 мм и не больше 400 мм.
        /// </summary>
        public double CaseWidth 
        { 
            get => _caseWidth;
            set
            {
                CheckValue(value, "Ширина чехла", 100, 400);
                _caseWidth = value;
            }
        }
        
        /// <summary>
        /// Высота чехла должна быть не меньше 10 мм и не больше 20 мм.
        /// </summary>
        public double CaseHeight 
        { 
            get => _caseHeight;
            set
            {
                CheckValue(value, "Высота чехла", 10, 20);
                _caseHeight = value;
            }
        }

        /// <summary>
        /// Ширина отверстия для камеры должна быть не меньше 10 мм и не больше 50 мм.
        /// </summary>
        public double CameraHoleWidth
        {
            get => _cameraHoleWidth;
            set
            {
                CheckValue(value, "Ширина отверстия для камеры", 10, 50);
                _cameraHoleWidth = value;
            }
        }
        
        /// <summary>
        /// Длина отверстия для камеры должна быть не меньше 10 мм и не больше 50 мм.
        /// </summary>
        public double CameraHoleLength 
        { 
            get => _cameraHoleLenght;
            set
            {
                CheckValue(value, "Длина отверстия для камеры", 10, 50);
                _cameraHoleLenght = value;
            }
        }
        
        /// <summary>
        /// Зазор между отверстием для камеры и правой стенкой чехла должен быть не меньше 5 мм и не больше 20 мм.
        /// </summary>
        public double CameraRightGap 
        { 
            get => _cameraRightGap;
            set
            {
                CheckValue(value, "Зазор между отверстием для камеры и правой стенкой чехла", 5, 20);
                _cameraRightGap = value;
            }
        }

        /// <summary>
        /// Зазор между отверстием для камеры и верхней стенкой чехла должен быть не меньше 5 мм и не больше 20 мм.
        /// </summary>
        public double CameraTopGap
        {
            get => _cameraTopGap;
            set
            {
                CheckValue(value, "Зазор между отверстием для камеры и верхней стенкой чехла", 5, 20);
                _cameraTopGap = value;
            }
        }

        /// <summary>
        /// Ширина отверстия для зарядки должна быть не меньше 10 мм и не больше 20 мм.
        /// </summary>
        public double ChargerHoleWidth
        {
            get => _chargerHoleWidth;
            set
            {
                CheckValue(value, "Ширина отверстия для зарядки", 10, 20);
                _chargerHoleWidth = value;
            }
        }

        /// <summary>
        /// Высота отверстия для зарядки должна быть не меньше 3 мм и не больше 6 мм.
        /// </summary>
        public double ChargerHoleHeight
        {
            get => _chargerHoleHeight;
            set
            {
                CheckValue(value, "Высота отверстия для зарядки", 3, 6);
                _chargerHoleHeight = value;
            }
        }
        
        /// <summary>
        /// Диаметр отверстия для наушников должен быть не меньше 3.5 мм и не больше 6 мм.
        /// </summary>
        public double MiniJackDiameter
        {
            get => _miniJackDiameter;
            set
            {
                CheckValue(value, "Диаметр отверстия для наушников", 3.5, 6);
                _miniJackDiameter = value;
            }
        }

        /// <summary>
        /// Зазор между отверстием для наушников и левой стенкой чехла должен быть не меньше 2 мм и не больше
        /// половины ширины чехла минус половина диаметра минус пол ширины отверстия для зарядки минус 5 мм.
        /// </summary>
        public double MiniJackGap
        {
            get => _miniJackGap;
            set
            {
                 //TODO: RSDN
                var s = CaseWidth / 2 - MiniJackDiameter / 2 - ChargerHoleWidth / 2 - 5;
                CheckValue(value, "Зазор между отверстием для наушников и левой стенкой чехла", 2, s);
                _miniJackGap = value;
            }
        }

        /// <summary>
        /// Высота отверстия для боковых кнопок должна быть не меньше 2 мм и не больше высоты чехла минус 2 мм.
        /// </summary>
        public double SideButtonsHoleHeight
        {
            get => _sideButtonsHoleHeight;
            set
            {
                CheckValue(value, "Высота отверстия для боковых кнопок", 2, CaseHeight - 2);
                _sideButtonsHoleHeight = value;
            }
        }
        
        /// <summary>
        /// Ширина отверстия для боковых кнопок должна быть не меньше 5 мм и
        /// не больше длины чехла минус зазор боковых кнопок минус 20 мм.
        /// </summary>
        public double SideButtonsHoleWidth
        {
            get => _sideButtonsHoleWidth;
            set
            {
                CheckValue(value, "Ширина отверстия для боковых кнопок", 5, CaseLength - SideButtonsGap - 20);
                _sideButtonsHoleWidth = value;
            }
        }
        
        /// <summary>
        /// Зазор между отверстием для боковых кнопок и верхним правым углом
        /// должен быть не меньше 5 мм и не больше 20 мм.
        /// </summary>
        public double SideButtonsGap
        {
            get => _sideButtonsGap;
            set
            {
                CheckValue(value, "Зазор между отверстием для боковых кнопок и верхним правым углом", 5, 20);
                _sideButtonsGap = value;
            }
        }
        
        /// <summary>
        /// Проверка исключений.
        /// </summary>
        /// <param name="value">Значение.</param>
        /// <param name="name">Название параметра.</param>
        /// <param name="min">Минимальный размер.</param>
        /// <param name="max">Максимальный размер.</param>
        private static void CheckValue(double value, string name, 
            double min, double max)
        {
            if (min <= value && value <= max) return;

            var message = $"{name} не может быть меньше {min} или больше {max}.\n";
            throw new ArgumentException(string.Join("\n", message));
        }

        /// <summary>
        /// Длина чехла.
        /// </summary>
        private double _caseLength;

        /// <summary>
        /// Ширина чехла.
        /// </summary>
        private double _caseWidth;

        /// <summary>
        /// Высота чехла.
        /// </summary>
        private double _caseHeight;

        /// <summary>
        /// Ширина отверстия для камеры.
        /// </summary>
        private double _cameraHoleWidth;

        /// <summary>
        /// Высота отверстия для зарядки.
        /// </summary>
        private double _chargerHoleHeight;

        /// <summary>
        /// Ширина отверстия для боковых кнопок.
        /// </summary>
        private double _sideButtonsHoleWidth;

        /// <summary>
        /// Длина отверстия для камеры.
        /// </summary>
        private double _cameraHoleLenght;

        /// <summary>
        /// Зазор между отверстием для камеры и правой стенкой чехла.
        /// </summary>
        private double _cameraRightGap;

        /// <summary>
        /// Зазор между отверстием для камеры и верхней стенкой чехла.
        /// </summary>
        private double _cameraTopGap;

        /// <summary>
        /// Ширина отверстия для зарядки.
        /// </summary>
        private double _chargerHoleWidth;

        /// <summary>
        /// Диаметр отверстия для наушников.
        /// </summary>
        private double _miniJackDiameter;

        /// <summary>
        /// Зазор между отверстием для наушников и левой стенкой чехла.
        /// </summary>
        private double _miniJackGap;

        /// <summary>
        /// Высота отверстия для боковых кнопок.
        /// </summary>
        private double _sideButtonsHoleHeight;

        /// <summary>
        /// Зазор между отверстием для боковых кнопок и верхним правым углом.
        /// </summary>
        private double _sideButtonsGap;
    }
}
