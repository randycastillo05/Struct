using structuras;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pruebas
{
    public class Program
    {
        //static Dueño dueño = new Dueño();
        //static mascota mascota = new mascota();
        //static Producto Producto = new Producto();
        static GuardarCuenta Bancaria = new GuardarCuenta();
        static tienda Tienda = new tienda();
        static DatosDeMascotaYDueño datosDeMascotaYDueño = new DatosDeMascotaYDueño();
        // static Color Color = new Color();
        static void Main(string[] args)

        {
            //inventarioTienda();
            Veterinaria();
        }

        static void CuentaBanco()
        {
            string No;
            string titular;
            double monto;

            for (int i = 0; i < 1; i++)
            {
                Console.WriteLine("Escriba el numero de cuenta");
                No = Console.ReadLine();
                Console.WriteLine("Escriba el nombre del titular");
                titular = Console.ReadLine();
                Console.WriteLine("Escriba el monto a depositar");
                monto = double.Parse(Console.ReadLine());

                Bancaria.GuardarInfo(No, titular, monto);
            }

            foreach (var item in Bancaria.CuentasBanco)
            {
                Console.WriteLine("");
            }
        }
            
        static void Veterinaria()
        {
            string Nom;
            string tipo;
            string NomDueño;
            for (int i = 0; i <1; i++)
            {
                Console.WriteLine("Escriba el nombre de la mascota");
                Nom = Console.ReadLine();
                Console.WriteLine("Escriba el tipo de mascota");
                tipo = Console.ReadLine();
                Console.WriteLine("Escriba el nombre del dueño");
                NomDueño = Console.ReadLine();
                datosDeMascotaYDueño.Guardarinfo(Nom,tipo,NomDueño);
            }

            foreach (var item in datosDeMascotaYDueño.dueñoYMascotas)
            {
                Console.WriteLine("Nombre de la mascota es "+item.mascotas.Nombre+" el tipo es "+item.mascotas.Tipo+" el nombre del dueño es "+item.NombreDueño);
            }
        }
        static void inventarioTienda()
        {
            string Nom;
            string Cog;
            int Can;
            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine("Escriba el nombre del Producto");
                Nom = Console.ReadLine();
                Console.WriteLine("Escriba el codigo del Producto");
                Cog = Console.ReadLine();
                Console.WriteLine("Escriba la cantidad del Producto");
                Can =int.Parse( Console.ReadLine());
                Tienda.InitInventario(Cog,Can,Nom);
            }
            foreach (var item in Tienda.Inventario)
            {
                Console.WriteLine("");
            }
            
            
        }
        
    }

}
