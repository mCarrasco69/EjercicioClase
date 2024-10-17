
namespace EjercicioClase
{
    public class Superpoder
    {      
        public string Descripcion { get; set; }
        public double Nivel { get; set; }

        public void Imprimir()
        {
            Console.WriteLine($"Descripcion:{Descripcion} ");
            Console.WriteLine($"Nivel:{Nivel} ");
        }
    }


}
