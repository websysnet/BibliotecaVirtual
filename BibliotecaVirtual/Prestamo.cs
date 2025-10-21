namespace Biblioteca
{
    class Prestamo
    {
      public int Id { get; set; }
        public Cliente Cliente { get; set; }
        public Libro Libro { get; set; }
        public DateTime FechaPrestamo { get; set; }

        public Prestamo()
        {
            this.Id = 0;
            this.Cliente = null;
            this.Libro = null;
            this.FechaPrestamo = DateTime.Now;
        }
        public Prestamo(int id, Cliente cliente, Libro libro)
        {
            Id = id;
            Cliente = cliente;
            Libro = libro;
            FechaPrestamo = DateTime.Now;
        }
        
        
    }
    
}