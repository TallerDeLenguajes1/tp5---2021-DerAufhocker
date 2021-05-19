¿String es un tipo por valor o por referencia?
	String es un tipo por referencia porque al declarar una variable de este tipo 
	no tiene un tamaño determinado, por lo tanto se necesita reservar memoria del heap y para ello 
	se necesita referenciar la variable.

	Vemos éste fenomeno cuando por ejemplo se pasa una variable de tipo string a una funcion:

	public class Persona 
{
	public string Nombre;
	public string Apellidos;
	public int Edad;
}

public static void CambiaNombre(Persona per) {
	per.Nombre = per.Nombre + "José";
}

Persona p = new Persona();
p.Nombre = "Exequiel";
p.Apellidos = "Diaz";
p.Edad = 27;

Console.WriteLine(p.Nombre + p.Apellidos); //acá aparecerá "Exequiel Diaz"
CambiaNombre(p);
Console.WriteLine(p.Nombre + p.Apellidos);// acá aparecerá "Exequiel José Diaz"

	Como dije anteriormente al referenciar la variable paso una copia de la direccion de la variable
	por lo tanto a modificarla en la funcion se modifica afuera de ella tambien porque modifico el 
	contenido de direccion. Al contrario pasa con los tipos de datos simples que pasan una copia del contenido
	y no siempre se ven afectados fuera de la funcion

¿Qué secuencias de escape tiene el tipo string?

	\n		Salto de linea
	\"		Permite escribir comillas dobles
	\'		Permite escribir comilas simples
	\t		Genera un tabulacion horizontal
	\\		Muestra un barra invertida

¿Qué sucede cuando utiliza el carácter @ antes de una cadena de texto?
	
	@ es un literal de cadena, cuando este literal de cadena se coloca por delante de un string
	hace que no se tengan en cuenta las secuencias de escape y se tome al texto literalmente.
	Esto es util en casdo de que queramos escribir alguna direccion de un archivo
	por ej
		Con el literal de cadena seria algo asi
			@"c:\Docs\Source\a.txt"
		lo que significaria lo mismo que
			@"c:\\Docs\\Source\\a.txt"