using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2013105920
{
    public class RanuraDeposito
    {
        
        private int _deposito;

        public int deposito
        {
            get { return _deposito; }
            set { _deposito = value; }
        }

        public RanuraDeposito()
        {

        }
        public RanuraDeposito(int CantidadDeposito)
        {
            deposito = CantidadDeposito;
        }
    
    }
}
