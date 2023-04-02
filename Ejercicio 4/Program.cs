//Permita el ingreso de frases, finalizando cuando el usuario ingresa “fin”.

var frase = "";

do
{
    Console.WriteLine("Por favor, ingrese una frase. Si ingresa la palabra fin, el programa finalizará.");
    frase = Console.ReadLine();
} while (frase.ToUpper() != "FIN");
