namespace upn_fundamentos_t3_equipo_06.Enunciado_1
{
    public class MascotaModel
    {
        public string Codigo { get; set; }
        public string Nombre { get; set; }
        public string Edad { get; set; }
        public string Raza { get; set; }
        public PersonaModel Duenio { get; set; }

        public MascotaModel(string codigo, string nombre, string edad, string raza, PersonaModel duenio)
        {
            Codigo = codigo;
            Nombre = nombre;
            Edad = edad;
            Raza = raza;
            Duenio = duenio;
        }
    }
}
