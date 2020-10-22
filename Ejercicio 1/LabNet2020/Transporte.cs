using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LabNet2020
{
    public abstract class Transporte
    {
        #region Atributos
        private int pasajeros;
        #endregion

        #region Constructor
        public Transporte(int pasajeros) 
        {
            this.pasajeros = pasajeros;
        }
        #endregion

        #region Métodos Públicos
        public int Pasajeros 
        { 
            get { return this.pasajeros; }
            set { this.pasajeros = value; }
        }

        public abstract string Avanzar();
        public abstract string Detenerse();
        #endregion
    }
}
