2 - Lectura de la imagen

Los ficheros binarios es cuando tenemos cualquier tipo de informacion, no solo texto.

Ejemplo: imagenes, videoos, musica, etc

-Tenemos dos:

	-FileStream(bytes y bloques de bytes)

	-BinaryReader/BinaryWriter(datos nativos)

1-Primero declaramos la variable del tipo (Leer un byte)

	FileStream fichero = File.OpenRoad("imagen.bmp");

2-Leer los bytes(Forzamos su conversion a bytes)

	byte datos = (byte)fichero.ReadByte();

3-Cerramos el fichero

	fichero.Close();

NOTA: ReadByte devuelve en entero, porque en caso de error su valor sera -1

