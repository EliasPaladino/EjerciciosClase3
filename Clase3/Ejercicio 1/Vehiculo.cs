using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clase3.Ejercicio_1
{
    public class Vehiculo
    {
        public string Marca {  get; private set; }
        public string Modelo { get; private set; }

        public Vehiculo(string marca, string modelo) {
            Marca = marca;
            Modelo = modelo;
        }
    }
}
