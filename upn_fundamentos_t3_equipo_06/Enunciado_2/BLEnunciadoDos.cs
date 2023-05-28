using System;
using System.Collections.Generic;

namespace upn_fundamentos_t3_equipo_06.Enunciado_2
{
    public class BLEnunciadoDos
    {
        private List<double> f_listaNumeros = new List<double>();

        public void AgregarNumero(double f_numero)
        {
            try
            {
                f_listaNumeros.Add(f_numero);
            }
            catch (FormatException f_ex)
            {
                throw f_ex;
            }
        }

        public int BuscarNumero(double f_numero, int f_indice)
        {
            try
            {
                if (f_indice >= f_listaNumeros.Count) return -1;

                if (f_listaNumeros[f_indice] == f_numero) return f_indice;

                return BuscarNumero(f_numero, f_indice + 1);
            }
            catch (IndexOutOfRangeException f_ex)
            {
                throw f_ex;
            }
        }

        public List<double> OrdenarAscendenteDescendente(bool f_ascendente)
        {
            try
            {
                f_listaNumeros.Sort();

                if (!f_ascendente) f_listaNumeros.Reverse();

                return f_listaNumeros;
            }
            catch (IndexOutOfRangeException f_ex)
            {
                throw f_ex;
            }
        }

        public bool EliminarNumero(double f_numero)
        {
            try
            {
                bool f_encontrado = false;

                for (int f_i = 0; f_i < f_listaNumeros.Count; f_i++)
                {
                    if (f_listaNumeros[f_i] == f_numero)
                    {
                        f_listaNumeros.RemoveAt(f_i);
                        f_encontrado = true;
                        break;
                    }
                }

                return f_encontrado;
            }
            catch (FormatException f_ex)
            {
                throw f_ex;
            }
        }

        public List<double> ObtenerListaNumeros()
        {
            return f_listaNumeros;
        }
    }
}
