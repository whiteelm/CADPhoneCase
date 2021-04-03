using System;
using Kompas6API5;

namespace KompasInteractor
{
    /// <summary>
    /// Подключение к компасу.
    /// </summary>
    public class KompasConnector
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
            try
            {
                if (Kompas == null)
                {
                    var type = Type.GetTypeFromProgID("KOMPAS.Application.5");
                    Kompas = (KompasObject) Activator.CreateInstance(type);
                }

                if (Kompas == null) return;
                Kompas.Visible = true;
                Kompas.ActivateControllerAPI();
            }
            catch
            {
                Kompas = null;
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
}