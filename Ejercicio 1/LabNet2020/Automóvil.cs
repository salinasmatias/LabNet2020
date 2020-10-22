using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LabNet2020
{
    class Automovil : Transporte
    {
        #region Constructor
        public Automovil(int pasajeros) : base(pasajeros) { }
        #endregion

        #region Métodos Públicos
        public override string Avanzar()
        {
            return "El automóvil está avanzando";
        }

        public override string Detenerse()
        {
            return "El automóvil se ha detenido";
        }
        #endregion
    }
}
