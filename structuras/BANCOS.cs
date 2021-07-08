using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace structuras
{
   public struct InfoBancaria
    {
        public string NoCuenta { get; set; }

        public string TitularCuenta { get; set; }

        public double MontoActual { get; set; }
    }

    public class GuardarCuenta
    {
        public List<InfoBancaria> CuentasBanco = new List<InfoBancaria>();


        public void GuardarInfo(string No,string titular,double monto)
        {
            CuentasBanco.Add(new InfoBancaria() { NoCuenta =No,TitularCuenta=titular,MontoActual=monto }); 
        }


    }


   
}

