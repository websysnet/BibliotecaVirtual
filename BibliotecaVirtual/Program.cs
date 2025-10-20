// See https://aka.ms/new-console-template for more information
using Biblioteca;

int opcion=0;
List<Libro> Libros = new List<Libro>();
while (opcion!=10)
{

   Console.Clear(); 
   Console.WriteLine("Bienvenido a la Biblioteca Virtual");
   Console.WriteLine("1. Agregar Libro");
   Console.WriteLine("2. Listar Libros");
   Console.WriteLine("3. Buscar Libro");
   Console.WriteLine("4. Eliminar Libro");
   Console.WriteLine("5. Prestamo de Libro");
   Console.WriteLine("10. Salir");
   opcion=int.Parse(Console.ReadLine());
   LibroRepository repo = new LibroRepository();

    switch (opcion)
   {

        case 1:
        //Agregar Libro
        
        repo.CrearLibro();
        break;
        case 2:
        //Listar Libros
        repo.ListarLibros();
        break;
        case 3:
        //Buscar Libro
        break;
        case 4:
        //Eliminar Libro
        break;

        default:
        System.Console.WriteLine("Saliendo...");
        break;
   }   
  
}





    

