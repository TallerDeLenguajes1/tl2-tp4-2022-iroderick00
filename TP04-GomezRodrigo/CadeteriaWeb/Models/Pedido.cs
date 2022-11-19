namespace CadeteriaWeb.Models
{
    public class Pedido
    {
        private static int numeroPedido = 0;
        private int id;
        private string observacion;
        private Cliente cliente;
        private string estado;
        public static int NumeroPedido { get => numeroPedido; set => numeroPedido = value; }
        public int Id { get => id; set => id = value; }
        public string Observacion { get => observacion; set => observacion = value; }
        public Cliente Cliente { get => cliente; set => cliente = value; }
        public string Estado { get => estado; set => estado = value; }
        public Pedido() { }
        public Pedido(string observacion, Cliente cliente, string estado)
        {
            Id = NumeroPedido++;
            this.Observacion = observacion;
            this.Cliente = cliente;
            this.Estado = estado;
        }
    }
}
