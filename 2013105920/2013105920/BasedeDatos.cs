using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2013105920
{
    public class BasedeDatos
    {
     private List<Cuenta> _Cuentas;
        public List<Cuenta> Cuentas
        {
            get { return _Cuentas; }
            set { _Cuentas = value; }
        }

        public BasedeDatos()
        {
            Cuentas = new List<Cuenta>();
        }

     
        public BasedeDatos(int maxNumCuentas)
        {
            
            Cuentas = new List<Cuenta>(maxNumCuentas);
        }

        public bool AutenticarUsuario(int numeroCuenta,int pin)
        {
            
            int max= _Cuentas.Count;
           
            for (int i = 0; i <= max; i++ )
            {
                if (_Cuentas[i].NumeroCuenta == numeroCuenta && _Cuentas[i].Pin == pin)
                {
                    
                    return true;
                }
                else
                {
                    return false;
                }
            }
            
            return false;
        }

        public decimal ObtenerSaldoDisponible(int numeroCuenta)
        {
            int max = _Cuentas.Count;
            for (int i = 0; i <= max; i++)
            {
                if (_Cuentas[i].NumeroCuenta == numeroCuenta)
                {
                    return _Cuentas[i].Monto;
                }
                else
                {
                    return 0.0M;
                }
            }
            return 0.0M;
        }

        public void Creditar(int numeroCuenta, decimal monto)
        {
            
            int max = _Cuentas.Count;
            for (int i = 0; i < max; i++)
            {
                if (_Cuentas[i].NumeroCuenta == numeroCuenta)
                {
                   
                    _Cuentas[i].Monto -= monto;

                }
                
            }

        }
    }
}
