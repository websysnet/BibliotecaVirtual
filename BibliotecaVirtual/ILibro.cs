
namespace Biblioteca
{
    interface ILibro
    {

        List<Libro> CrearLibro(List<Libro> libros);
        void ListarLibros(List<Libro> libros);
        void BuscarLibro(string Titulo,List<Libro> libros);
        
    }   

}
