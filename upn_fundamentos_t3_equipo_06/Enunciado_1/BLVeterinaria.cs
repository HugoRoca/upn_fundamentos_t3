using System.Collections.Generic;

namespace upn_fundamentos_t3_equipo_06.Enunciado_1
{
    public class BLVeterinaria
    {
        protected List<PersonaModel> listaDuenios = new List<PersonaModel>();
        protected List<MascotaModel> listaMascotas = new List<MascotaModel>();

        public List<PersonaModel> ObtenerDuenios()
        {
            return listaDuenios;
        }

        public List<MascotaModel> ObtenerMascotas()
        {
            return listaMascotas;
        }

        public MascotaModel BuscarMascota(string nombreMascota)
        {
            for (int i = 0; i < listaMascotas.Count; i++)
            {
                if (listaMascotas[i].Nombre == nombreMascota)
                {
                    return listaMascotas[i];
                }
            }

            return null;
        }

        public PersonaModel BuscarDuenio(string nombreDuenio)
        {
            for (int i = 0; i < listaDuenios.Count; i++)
            {
                if (listaDuenios[i].Nombre == nombreDuenio)
                {
                    return listaDuenios[i];
                }
            }

            return null;
        }

        public void RegistrarDuenio(PersonaModel model)
        {
            listaDuenios.Add(model);
        }

        public void RegistrarMascota(MascotaModel model)
        {
            listaMascotas.Add(model);
        }
    }
}
