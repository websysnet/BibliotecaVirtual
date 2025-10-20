namespace Biblioteca
{
    class LibroRepository :ILibro
    {
        private List<Libro> libros = new List<Libro>();
        private int nextId = 1;

        public void CrearLibro()
        {
            Console.WriteLine("Ingrese el título del libro:");
            string titulo = Console.ReadLine();

            Console.WriteLine("Ingrese el autor del libro:");
            string autor = Console.ReadLine();

            Console.WriteLine("Ingrese el año de publicación del libro:");
            int anioPublicacion;
            while (!int.TryParse(Console.ReadLine(), out anioPublicacion))
            {
                Console.WriteLine("Por favor, ingrese un año válido:");
            }

            Libro nuevoLibro = new Libro(nextId, titulo, autor, anioPublicacion);
            libros.Add(nuevoLibro);
            nextId++;

            Console.WriteLine("Libro agregado exitosamente.");
        }

        public List<Libro>  ListarLibros()
        {
            List<Libro> lista = new List<Libro>();
            return lista;
        }
    }
}