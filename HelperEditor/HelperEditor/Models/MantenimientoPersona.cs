using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace HelperEditor.Models
{
    public class MantenimientoPersona
    {
        List<Persona> ListaPersona = new List<Persona>()
        {
            new Persona()
            {
                Codigo =1,
                Nombre = "Pedro",
                Peso = 67.3F,
                Trabaja = false,
                FechaNacimiento = new DateTime(2003,05,23)
            },
            new Persona()
            {
                Codigo = 2,
                Nombre = "Pablo",
                Peso = 89.7F,
                Trabaja = true,
                FechaNacimiento = new DateTime(1998,12,23)
            },
            new Persona()
            {
                Codigo =3,
                Nombre ="Lucas",
                Peso= 55.3F,
                Trabaja=false,
                FechaNacimiento= new DateTime(1985,05,19)
            }
        };
        public Persona Retornar(int cod)
        {
            foreach (var per in ListaPersona)
                if (per.Codigo == cod)
                    return per;
            return null; 
        }
    }
}