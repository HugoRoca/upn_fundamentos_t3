using System;

namespace upn_fundamentos_t3_equipo_06.Enunciado_1
{
    public class Commons
    {
        public string GenerarCodigoAleatorio()
        {
            const string caracteres = "ABCDEFGHIJKLMNOPQRSTUVWXYZ0123456789";
            const int longitudCodigo = 8;

            Random random = new Random();
            char[] codigoArray = new char[longitudCodigo];

            for (int i = 0; i < longitudCodigo; i++)
            {
                codigoArray[i] = caracteres[random.Next(caracteres.Length)];
            }

            string codigo = new string(codigoArray);
            return codigo;
        }

    }
}
