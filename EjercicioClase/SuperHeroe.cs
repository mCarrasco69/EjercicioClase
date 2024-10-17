

namespace EjercicioClase
{
    internal class SuperHeroe
    {
        public string Nombre { get; set; }
        public string IdentidadSecreta { get; set; }
        public string Ciudad { get; set; }
        public Boolean PuedeVolar { get; set; }
        public string SuperPoder { get; set; }
     
        public void Imprimir(){

            Console.WriteLine($"Nombre:{ Nombre} ");
            Console.WriteLine($"IdentidadSecreta:{IdentidadSecreta} ");
            Console.WriteLine($"Ciudad:{Ciudad} ");
            Console.WriteLine($"PuedeVolar:{PuedeVolar} ");
           Console.WriteLine($"SuperPoder:{SuperPoder} ");             
        }       
    }
}
