namespace Biblioteca
{
     class Libro
    {
        public int Id { get; set; }
        public string Titulo { get; set; }
        public string Autor { get; set; }
        public int AnioPublicacion { get; set; }

        public Libro()
        {   this.Id = 0;
            this.Titulo = string.Empty;
            this.Autor = string.Empty;
            this.AnioPublicacion = 0;
        }
        public Libro(int id, string titulo, string autor, int anioPublicacion)
        {
            Id = id;
            Titulo = titulo;
            Autor = autor;
            AnioPublicacion = anioPublicacion;
        }

     


        
    }
}