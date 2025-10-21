namespace Biblioteca
{
    class Cliente
    {
        public int Id { get; set; }
        public string Nombre { get; set; }
        public string Email { get; set; }

        public List<Libro> LibrosPrestados { get; set; }

        public Cliente(int id, string nombre, string email)
        {
            Id = id;
            Nombre = nombre;
            Email = email;
            LibrosPrestados = new List<Libro>();
        }
    }

}



