using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace structuras
{
    
    public struct Producto
    { 
        public string Codigo { get; set; }

        public string Nombre { get; set; }

        public int Cantidad { get; set; }

    }

    public class tienda
    {
      
        public List<Producto> Inventario= new List<Producto>();

        public void InitInventario(string Cog,int Can,string Nom)
        {    
            Inventario.Add( new Producto { Codigo = Cog, Nombre = Nom });
            

            /*producto = new Producto { Codigo = "002", Nombre = "Coca Cola 12 onz" };
            Inventario.Add(new ProductoYcantidad { Producto = producto, Cantidad = 10 });

           /* var producto = new Producto { Codigo = "01", Nombre = "Arroz" };
            producto = new Producto { Codigo = "02", Nombre = "Habichuelas" };
            producto = new Producto { Codigo = "03", Nombre = "Espaguetis" };
            producto = new Producto { Codigo = "04", Nombre = "Galletas" };
            producto = new Producto { Codigo = "05", Nombre = "Pollo" };
           */



        }
                 
            
            
    }
    
}
