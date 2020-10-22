using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LabNet2020
{
    class Avion:Transporte
    {
        #region Constructor
        public Avion(int pasajeros) : base(pasajeros) { }
        #endregion

        #region Métodos Públicos
        public override string Avanzar()
        {
            return "El avión está avanzando";
        }

        public override string Detenerse()
        {
            return "El avión se ha detenido";
        }
        #endregion
    }
}
