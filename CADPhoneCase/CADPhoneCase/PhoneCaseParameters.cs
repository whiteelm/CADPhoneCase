using System;
using System.Collections.Generic;

namespace CADPhoneCase
{
    /// <summary>
    /// Параметры чехла в виде списка.
    /// </summary>
    public class PhoneCaseParameters
    {
        /// <summary>
        /// Список параметров.
        /// </summary>
        private readonly List<Parameter> _parameters = new List<Parameter>
        {
            new Parameter(200, ParameterName.CaseLength, 100, 
                500, "Длина чехла "),
            new Parameter(100, ParameterName.CaseWidth, 100, 
                400, "Ширина чехла"),
            new Parameter(15, ParameterName.CaseHeight, 10, 
                20, "Высота чехла"),
            new Parameter(20, ParameterName.CameraHoleWidth, 10, 
                50, "Ширина отверстия для камеры"),
            new Parameter(30, ParameterName.CameraHoleLength, 10, 
                50, "Длина отверстия для камеры"),
            new Parameter(20, ParameterName.CameraTopGap, 5, 20, 
                "Зазор между отверстием для камеры и верхней стенкой чехла"),
            new Parameter(20, ParameterName.CameraRightGap, 5, 
                20, "Зазор между отверстием для камеры и правой" +
                    " стенкой чехла "),
            new Parameter(5, ParameterName.ChargerHoleHeight, 3, 
                6, "Высота отверстия для зарядки"),
            new Parameter(15, ParameterName.ChargerHoleWidth, 10,
                20, "Ширина отверстия для зарядки"),
            new Parameter(3.5, ParameterName.MiniJackDiameter, 3.5,
                6, "Диаметр отверстия для наушников"),
            new Parameter(20, ParameterName.MiniJackGap, 2, 400, 
                "Зазор между отверстием для наушников и левой стенкой чехла"),
            new Parameter(20, ParameterName.SideButtonsGap, 5, 
                20, "Зазор между отверстием для боковых кнопок " +
                    "и верхним правым углом"),
            new Parameter(4, ParameterName.SideButtonsHoleHeight, 2, 
                20, "Высота отверстия для боковых кнопок"),
            new Parameter(30, ParameterName.SideButtonsHoleWidth, 
                10, 500, "Ширина отверстия для боковых кнопок")
        };

        /// <summary>
        /// Индексатор.
        /// </summary>
        /// <param name="parameterName">Имя параметра.</param>
        /// <returns>Значение параметра.</returns>
        public double this[ParameterName parameterName]
        {
            get => GetParameter(parameterName).Value;
            set
            {
                double min = 0;
                double max = 0;
                var name = "";
                switch (parameterName)
                {
                    case ParameterName.MiniJackGap:
                        min = 2 + GetParameter(
                            ParameterName.MiniJackDiameter).Value / 2;
                        max = GetParameter(ParameterName.CaseWidth).Value /
                            2 - GetParameter(ParameterName.MiniJackDiameter).Value /
                            2 - GetParameter(ParameterName.ChargerHoleWidth).Value /
                            2 - 5;
                        name = "Зазор между отверстием для наушников " +
                              "и левой стенкой чехла";
                        break;
                    case ParameterName.SideButtonsHoleHeight:
                        min = 2;
                        max = GetParameter(ParameterName.CaseHeight).Value - 2;
                        name = "Высота отверстия для боковых кнопок";
                        break;
                    case ParameterName.SideButtonsHoleWidth:
                        min = 5;
                        max = GetParameter(ParameterName.CaseLength).Value -
                              GetParameter(ParameterName.SideButtonsGap).Value -
                              20;
                        name = "Ширина отверстия для боковых кнопок";
                        break;
                }
                if (name != "" && (value < min || value > max))
                {
                    throw new ArgumentException(
                        $"{name} не может быть меньше {min} " +
                        $"и не может быть больше {max}"
                    );
                }
                GetParameter(parameterName).Value = value;
            }
        }

        /// <summary>
        /// Получение параметра по имени.
        /// </summary>
        /// <param name="parameterName">Имя параметра.</param>
        /// <returns>Параметр.</returns>
        private Parameter GetParameter(ParameterName parameterName) =>
            _parameters.Find((parameter) => parameter.Name.Equals(
                parameterName));
    }
}
