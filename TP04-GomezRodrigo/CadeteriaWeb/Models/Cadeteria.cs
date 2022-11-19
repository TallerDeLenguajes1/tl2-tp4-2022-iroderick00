using System.Collections.Generic;

namespace CadeteriaWeb.Models
{
    public class Cadeteria
    {
        private string nombre;
        private string telefono;
        private List<Cadete> cadetes;
        public string Nombre { get => nombre; set => nombre = value; }
        public string Telefono { get => telefono; set => telefono = value; }
        public List<Cadete> Cadetes { get => cadetes; set => cadetes = value; }

        public Cadeteria() { }
        public Cadeteria(string nombre, string telefono)
        {
            this.Nombre = nombre;
            this.Telefono = telefono;
            this.Cadetes = new List<Cadete>();
        }
        public void AltaCadete (string nombre, string direccion, string telefono)
        {
            var nuevoCadete = new Cadete(nombre, direccion, telefono);
            cadetes.Add(nuevoCadete);
        }
        public void AltaCadete (Cadete cadete)
        {
            if (cadete != null)
            {
                cadetes.Add(cadete);
            }
        }
        public void BajaCadete(int id)
        {
            var cadeteABorrar = cadetes.Find(cadete => cadete.Id == id);
            if (cadeteABorrar != null)
            {
                cadetes.Remove(cadeteABorrar);
            }
        }
    }
}
