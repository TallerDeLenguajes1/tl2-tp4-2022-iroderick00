namespace CadeteriaWeb.Models
{
    public class Cadete
    {
        private static int numeroCadete = 0;
        private int id;
        private string? nombre;
        private string? direccion;
        private string telefono;
        private List<Pedido>? pedidos;
        public int Id { get => id; set => id = value; }
        public string? Nombre { get => nombre; set => nombre = value; }
        public string? Direccion { get => direccion; set => direccion = value; }
        public string Telefono { get => telefono; set => telefono = value; }
        public List<Pedido>? Pedidos { get => pedidos; set => pedidos = value; }
        public Cadete() 
        {
            this.id = numeroCadete++;
        }
        public Cadete(string nombre, string direccion, string telefono)
        {
            this.id = numeroCadete++;
            this.nombre = nombre;
            this.direccion = direccion;
            this.telefono = telefono;
            this.pedidos = new List<Pedido>();
        }
        public double JornalACobrar()
        {
            var total = 0;
            foreach (var pedido in pedidos)
            {
                if (pedido.Estado == "ENTREGADO")
                {
                    total += 300;
                }
            }
            return total;
        }
    }
}
