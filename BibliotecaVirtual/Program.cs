// See https://aka.ms/new-console-template for more information
using Biblioteca;

int opcion = 0;
LibroRepository repo = new LibroRepository();
List<Libro> libros = new List<Libro>();
do
{
    Console.Clear();
    Console.WriteLine("Bienvenido a la Biblioteca Virtual");
    Console.WriteLine("---Seleccione una opcion: ---");
    Console.WriteLine("1. Agregar Libro");
    Console.WriteLine("2. Listar Libros");
    Console.WriteLine("3. Buscar Libro");
    Console.WriteLine("4. Eliminar Libro");
    Console.WriteLine("5. Prestamo de Libro");
    Console.WriteLine("10. Salir");

    opcion = int.Parse(Console.ReadLine());



    switch (opcion)
    {


        case 1:
            //Agregar Libro
            Console.Clear();
            libros = repo.CrearLibro(libros);
            repo.ListarLibros(libros);
            break;
        case 2:
            //Listar Libros
            Console.Clear();
            repo.ListarLibros(libros);

            break;
        case 3:
            Console.Clear();
            Console.WriteLine("Ingrese el título del libro a buscar:");
            string Titulo = Console.ReadLine();
            repo.BuscarLibro(Titulo, libros);
            
            break;
        case 4:
            //Eliminar Libro
            break;

        default:
            System.Console.WriteLine("Saliendo...");
            break;
    }

}while(opcion != 10);







