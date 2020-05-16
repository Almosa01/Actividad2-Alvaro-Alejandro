using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ActividadEval2
{
    public class Operacion
    {
        #region Atributos y Propiedades
        private int oper1 = 0;
        private int oper2 = 0;

        private readonly int numMayor;
        #endregion

        #region Constructor
        public Operacion(int op1, int op2)
        {
            oper1 = op1;
            oper2 = op2;

            if (oper1 > oper2)
            {
                numMayor = oper1;
            }
            else
            {
                numMayor = oper2;
            }
        }
        #endregion

        #region Métodos
        /// <summary>
        /// Suma
        /// </summary>
        /// <returns>Un número</returns>
        public int Suma()
        {
            return oper1 + oper2;
        }


        /// <summary>
        /// Resta
        /// </summary>
        /// <returns>Un número</returns>
        public int Resta()
        {
            if (oper1 < oper2)
            {
                return oper1 - numMayor;
            }
            else
            {
                return oper2 - numMayor;
            }
        }

        /// <summary>
        /// Multiplica xd
        /// </summary>
        /// <returns>Un número</returns>
        public int Multiplicacion()
        {
            return oper1 * oper2;
        }

        /// <summary>
        /// Divide :D
        /// </summary>
        /// <returns>Un número</returns>
        public int Division()
        {
            return oper1 / oper2;
        }
        #endregion
    }
}
