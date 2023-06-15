// See https://aka.ms/new-console-template for more information

using EspacioPersonaje;

Personaje nuevo;
FabricaDePersonajes fp = new FabricaDePersonajes() ;
nuevo=fp.crearPersonaje();
Console.WriteLine(nuevo.Nombre);