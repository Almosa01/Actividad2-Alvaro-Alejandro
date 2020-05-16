using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ActividadEval2
{
    public static class CosasDeFechas
    {
        #region Métodos
        /// <summary>
        /// Te da el día de la semana
        /// </summary>
        /// <returns></returns>
        public static string DiaSemana()
        {
            return DateTime.Now.Day.ToString();
        }

        /// <summary>
        /// Te dice cuanto falta para tu cumpleaños :D
        /// </summary>
        /// <param name="fechaCumple"></param>
        /// <returns></returns>
        public static double Cuantofalta(DateTime? fechaCumple)
        {
            return Math.Truncate(Convert.ToDateTime(fechaCumple).Subtract(DateTime.Now).TotalDays) + 1;
        }
        #endregion
    }
}
