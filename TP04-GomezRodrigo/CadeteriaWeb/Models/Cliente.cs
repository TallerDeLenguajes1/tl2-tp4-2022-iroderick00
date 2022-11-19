namespace CadeteriaWeb.Models
{
    public class Cliente
    {
        private static int numeroCliente = 0;
        private int id;
        private string nombre;
        private string direccion;
        private int telefono;
        private string referenciaDireccion;
        public int Id { get => id; set => id = value; }
        public string Nombre { get => nombre; set => nombre = value; }
        public string Direccion { get => direccion; set => direccion = value; }
        public int Telefono { get => telefono; set => telefono = value; }
        public string ReferenciaDireccion { get => referenciaDireccion; set => referenciaDireccion = value; }
        public Cliente() { }
        public Cliente(string nombre, string direccion, int telefono, string referenciaDireccion)
        {
            Id = numeroCliente++;
            this.nombre = nombre;
            this.direccion = direccion;
            this.telefono = telefono;
            this.referenciaDireccion = referenciaDireccion;
        }
    }
}
