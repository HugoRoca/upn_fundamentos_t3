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
                List<double> f_newListaNumeros = f_listaNumeros;
                int f_n = f_newListaNumeros.Count;

                for (int f_i = 0; f_i < f_n - 1; f_i++)
                {
                    for (int j = 0; j < f_n - 1 - f_i; j++)
                    {
                        bool f_intercambiar = false;

                        if (f_ascendente)
                        {
                            if (f_newListaNumeros[j] > f_newListaNumeros[j + 1])
                                f_intercambiar = true;
                        }
                        else
                        {
                            if (f_newListaNumeros[j] < f_newListaNumeros[j + 1])
                                f_intercambiar = true;
                        }

                        if (f_intercambiar)
                        {
                            double f_temp = f_newListaNumeros[j];
                            f_newListaNumeros[j] = f_newListaNumeros[j + 1];
                            f_newListaNumeros[j + 1] = f_temp;
                        }
                    }
                }

                return f_newListaNumeros;
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
