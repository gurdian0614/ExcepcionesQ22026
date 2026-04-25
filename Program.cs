try
{
    // Console.WriteLine: Muestra el mensaje en la consola
    // Console.ReadLine: Lee la entrada del usuario desde la consola

    Console.WriteLine("Ingrese primer número:");
    double n1 = double.Parse(Console.ReadLine() ?? "0");// Lee la entrada del usuario y asigna "0" si es null

    Console.WriteLine("Ingrese segundo número:");
    double n2 = double.Parse(Console.ReadLine() ?? "0");

    double division = n1 / n2; // Realiza la división

    //Console.WriteLine("La división de " + n1 + " y " + n2 + " es: " + division);
    Console.WriteLine($"La división de {n1} / {n2} es: {division}"); // Utiliza interpolación de cadenas para mostrar el resultado

}
catch (Exception ex)
{
    Console.WriteLine("Ocurrió un error: " + ex.Message); // Muestra el mensaje de error si ocurre una excepción
}