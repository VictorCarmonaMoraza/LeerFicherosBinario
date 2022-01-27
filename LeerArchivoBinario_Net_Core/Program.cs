using System;
using System.IO;

namespace LeerArchivoBinario_Net_Core
{
    class Program
    {
        static void Main(string[] args)
        {
            FileStream fichero = new FileStream("optimista.png", FileMode.Open, FileAccess.Read);

            //Leemos fichero y almacenamos en el buffer. Le indicamos que inserte desde 0 hasta
            //su longitud total
            byte[] buffer = new byte[fichero.Length];

            fichero.Read(buffer, 0, buffer.Length);

            //Recorremos el fichero
            for (int i = 0; i < buffer.Length; i++)
            {
                Console.WriteLine(buffer[i]
            }

            fichero.Close();
        }
    }
}
