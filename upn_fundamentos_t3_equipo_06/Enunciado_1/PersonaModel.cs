namespace upn_fundamentos_t3_equipo_06.Enunciado_1
{
    public class PersonaModel
    {
        public string Codigo { get; set; }
        public string Nombre { get; set; }
        public string Direccion { get; set; }
        public string Telefono { get; set; }

        public PersonaModel(string codigo, string nombre, string direccion, string telefono)
        {
            Codigo = codigo;
            Nombre = nombre;
            Direccion = direccion;
            Telefono = telefono;
        }
    }
}
