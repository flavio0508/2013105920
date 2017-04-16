using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2013105920
{
    public class Program
    {
        static void Main(string[] args)
        {
    
            int cuenta, pin,ope,montoRetiro;
            Retiro creditar = new Retiro();
            ATM cajero = new ATM();
            cajero.BaseDatos = new BasedeDatos();
            
            Cuenta user01 = new Cuenta(12345, 1234, 5000.0M);
            cajero.BaseDatos.Cuentas.Add(user01);
            Console.WriteLine("Bienvenido al Cajero Automatico");
            
            do
            {
                Console.WriteLine("Ingrese su numero de Cuenta:  ");
              do
              {
                 cuenta =  Int32.Parse(Console.ReadLine());
              }
              while (cuenta == null);
              
              Console.WriteLine("Ingrese su Contraseña ");
            
              do 
              { 
                 pin = Int32.Parse(Console.ReadLine()); 
              } 
              while (pin == null);
                
              if (cajero.BaseDatos.AutenticarUsuario(cuenta,pin)==false)
              {
                  Console.WriteLine("Datos Incorrectos Intente Nuevamente");
                  Console.WriteLine("");
              }
            }
            while (cajero.BaseDatos.AutenticarUsuario(cuenta, pin) == false);
         
            Console.WriteLine("Bienvenido cliente");
            do
            {
                Console.WriteLine("Seleccione una operacion a realizar");
                Console.WriteLine("");
                Console.WriteLine("1) Obtener Saldo disponible");
                Console.WriteLine("2) Obtener Saldo Total");
                Console.WriteLine("3) Debitar");
                Console.WriteLine("4) Acreditar");
                ope = Int32.Parse(Console.ReadLine());
            }
         
            while (ope != 4 );
            Console.WriteLine("Ingrese el monto a retirar");
            montoRetiro = Int32.Parse(Console.ReadLine());
            cajero.BaseDatos.Creditar(cuenta, montoRetiro);
            Console.WriteLine("retiro exitoso");
            
            Console.WriteLine("nuevo saldo:  "+ cajero.BaseDatos.ObtenerSaldoDisponible(cuenta).ToString());
            Console.ReadLine();
        }
    }
}
