using System;

namespace upn_fundamentos_t3_equipo_06.Enunciado_1
{
    public class Commons
    {
        public string GenerarCodigoAleatorio()
        {
            const string f_caracteres = "ABCDEFGHIJKLMNOPQRSTUVWXYZ0123456789";
            const int f_longitudCodigo = 8;

            Random f_random = new Random();
            char[] f_codigoArray = new char[f_longitudCodigo];

            for (int i = 0; i < f_longitudCodigo; i++)
            {
                f_codigoArray[i] = f_caracteres[f_random.Next(f_caracteres.Length)];
            }

            string f_codigo = new string(f_codigoArray);
            return f_codigo;
        }

    }
}
