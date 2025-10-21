using System.Text;

namespace Biblioteca
{
    class LibroRepository :ILibro
    {
        private int nextId = 1;

        public List<Libro> CrearLibro(List<Libro> libros)
        {
            string titulo = "";
            string autor = "";
            Console.WriteLine("Ingrese el título del libro:");
            titulo = Console.ReadLine() ?? string.Empty;

            Console.WriteLine("Ingrese el autor del libro:");
            autor = Console.ReadLine() ?? string.Empty;

            Console.WriteLine("Ingrese el año de publicación del libro:");
            int anioPublicacion;
            while (!int.TryParse(Console.ReadLine(), out anioPublicacion))
            {
                Console.WriteLine("Por favor, ingrese un año válido:");
            }

            Libro nuevoLibro = new Libro(nextId, titulo, autor, anioPublicacion);
            libros.Add(nuevoLibro);
            nextId++;

            return libros;

        }

        public void  ListarLibros(List<Libro> libros)
        {
            Console.Clear();
            if (libros == null)
            {
                Console.WriteLine("Sin libros....");
            }
            else
            {
                Console.WriteLine("---------------------------------------");
                Console.WriteLine("Listado de libros");
                foreach (var item in libros)
                {
                    
                    Console.WriteLine($"{item.Id}  {item.Titulo}   {item.Autor}   {item.FechaPublicacion}");
                }
                Console.WriteLine("----------------------------------------");

            }
            Console.ReadKey();           
           
                
        }

        public void BuscarLibro(string Titulo, List<Libro> libros)
        {
            Libro? libroenc = libros.FirstOrDefault(l => l.Titulo.Equals(Titulo, StringComparison.OrdinalIgnoreCase));
            if (libroenc != null)
            {
                Console.WriteLine($"Libro encontrado: {libroenc.Id} -- {libroenc.Titulo} -- {libroenc.Autor} -- {libroenc.FechaPublicacion}");
            }
            else
            {
                Console.WriteLine("Libro no encontrado.");
            }
            Console.ReadKey();
        }
        
        public void EliminarLibro(int Id, List<Libro> libros)
        {
            Libro? libroenc = libros.FirstOrDefault(l => l.Id == Id);
            if (libroenc != null)
            {
                libros.Remove(libroenc);
                Console.WriteLine("Libro eliminado exitosamente.");
            }
            else
            {
                Console.WriteLine("Libro no encontrado.");
            }
            Console.ReadKey();
        }
    }
}