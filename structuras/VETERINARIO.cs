using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace structuras
{
    public struct Mascotas
    {
        public  string Nombre{ get; set; }
        public string Tipo{ get; set; }
    }

    public struct DueñoYMascota
    {
        public string NombreDueño { get; set; }
        public Mascotas mascotas { get; set; }
    }
    public class DatosDeMascotaYDueño
    {
        public List<Mascotas> Registro = new List<Mascotas>();
        public List<DueñoYMascota> dueñoYMascotas = new List<DueñoYMascota>();
        public void Guardarinfo(string nom, string tipo, string nomDueño)
        {
           //Registro = new List<DueñoYMascota>();
            var mascotas = new Mascotas { Nombre =nom, Tipo = tipo };
            dueñoYMascotas.Add(new DueñoYMascota{ mascotas = mascotas, NombreDueño = nomDueño }); 

        }
    }
    
}
