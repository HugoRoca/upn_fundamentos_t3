using System;
using System.Collections.Generic;

namespace upn_fundamentos_t3_equipo_06.Enunciado_1
{
    public class BLVeterinaria
    {
        protected List<PersonaModel> f_listaDuenios = new List<PersonaModel>();
        protected List<MascotaModel> f_listaMascotas = new List<MascotaModel>();

        public List<PersonaModel> ObtenerDuenios()
        {
            return f_listaDuenios;
        }

        public List<MascotaModel> ObtenerMascotas()
        {
            return f_listaMascotas;
        }

        public MascotaModel BuscarMascota(string f_nombreMascota)
        {
            try
            {
                for (int f_i = 0; f_i < f_listaMascotas.Count; f_i++)
                {
                    if (f_listaMascotas[f_i].Nombre.ToLower() == f_nombreMascota.ToLower())
                    {
                        return f_listaMascotas[f_i];
                    }
                }

                return null;
            }
            catch (IndexOutOfRangeException f_ex)
            {
                throw f_ex;
            }
        }

        public PersonaModel BuscarDuenio(string f_nombreDuenio)
        {
            try
            {
                for (int f_i = 0; f_i < f_listaDuenios.Count; f_i++)
                {
                    if (f_listaDuenios[f_i].Nombre == f_nombreDuenio)
                    {
                        return f_listaDuenios[f_i];
                    }
                }

                return null;
            }
            catch (IndexOutOfRangeException f_ex)
            {
                throw f_ex;
            }
        }

        public void RegistrarDuenio(PersonaModel f_model)
        {
            try
            {
                f_listaDuenios.Add(f_model);
            }
            catch (ArgumentException f_ex)
            {
                throw f_ex;
            }
        }

        public void RegistrarMascota(MascotaModel f_model)
        {
            try
            {
                f_listaMascotas.Add(f_model);
            }
            catch (ArgumentException f_ex)
            {
                throw f_ex;
            }
        }
    }
}
