using System;
using System.Collections.Generic;

namespace upn_fundamentos_t3_equipo_06.Enunciado_2
{
    public class BLEnunciadoDos
    {
        private List<double> listaNumeros = new List<double>();

        public void AgregarNumero(double numero)
        {
            try
            {
                listaNumeros.Add(numero);
            }
            catch (FormatException ex)
            {
                throw ex;
            }
        }

        public int BuscarNumero(double numero, int indice)
        {
            try
            {
                if (indice >= listaNumeros.Count) return -1;

                if (listaNumeros[indice] == numero) return indice;

                return BuscarNumero(numero, indice + 1);
            }
            catch (IndexOutOfRangeException ex)
            {
                throw ex;
            }
        }

        public List<double> OrdenarAscendenteDescendente(bool ascendente)
        {
            try
            {
                List<double> newListaNumeros = listaNumeros;
                int n = newListaNumeros.Count;

                for (int i = 0; i < n - 1; i++)
                {
                    for (int j = 0; j < n - 1 - i; j++)
                    {
                        bool intercambiar = false;

                        if (ascendente)
                        {
                            if (newListaNumeros[j] > newListaNumeros[j + 1])
                                intercambiar = true;
                        }
                        else
                        {
                            if (newListaNumeros[j] < newListaNumeros[j + 1])
                                intercambiar = true;
                        }

                        if (intercambiar)
                        {
                            double temp = newListaNumeros[j];
                            newListaNumeros[j] = newListaNumeros[j + 1];
                            newListaNumeros[j + 1] = temp;
                        }
                    }
                }

                return newListaNumeros;
            }
            catch (IndexOutOfRangeException ex)
            {
                throw ex;
            }
        }

        public bool EliminarNumero(double numero)
        {
            try
            {
                bool encontrado = false;

                for (int i = 0; i < listaNumeros.Count; i++)
                {
                    if (listaNumeros[i] == numero)
                    {
                        listaNumeros.RemoveAt(i);
                        encontrado = true;
                        break;
                    }
                }

                return encontrado;
            }
            catch (FormatException ex)
            {
                throw ex;
            }
        }

        public List<double> ObtenerListaNumeros()
        {
            return listaNumeros;
        }
    }
}
