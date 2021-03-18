﻿using System;
using Kompas6API5;

namespace CADPhoneCase
{
    /// <summary>
    /// Подключение к компасу.
    /// </summary>
    public class KompasInteractor
    {
        /// <summary>
        /// Интерфейс API КОМПАС 3D.
        /// </summary>
        public KompasObject Kompas { get; set; }

        /// <summary>
        /// Запуск Компас 3D.
        /// </summary>
        public void OpenKompas()
        {
            if (Kompas == null)
            {
                var type = Type.GetTypeFromProgID("KOMPAS.Application.5");
                Kompas = (KompasObject)Activator.CreateInstance(type);
            }
            if (Kompas == null) return;
            Kompas.Visible = true;
            Kompas.ActivateControllerAPI();
        }
    }
}