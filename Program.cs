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

    List<string> frutas = new List<string>();
    frutas.Add("Manzana");
    frutas.Add("Banana");
    frutas.Add("Naranja");
    frutas.Add("Uva");
    frutas.Insert(0, "Pera");
    frutas.Remove("Manzana");

    foreach (string fruta in frutas)
    {
        Console.WriteLine(fruta);
        
    }
    Console.WriteLine($"Posición de la banana: {frutas.IndexOf("Banana")}");

    Dictionary<string, int> inventario = new Dictionary<string, int>();
    inventario.Add("Uva", 50);
    inventario.Add("Banana", 20);
    inventario.Add("Manzana", 30);
    inventario.Remove("Banana");

    foreach (var inv in inventario)
    {
        Console.WriteLine($"Fruta: {inv.Key}, Cantidad: {inv.Value}");
    }
}
catch (FormatException ex)
{
    Console.WriteLine("Ocurrió un error de tipo Formato: " + ex.Message); // Muestra el mensaje de error si ocurre una excepción
}
catch(Exception ex)
{
    Console.WriteLine("Ocurrió un error inesperado: " + ex.Message);
}
finally
{
    Console.WriteLine("Fin del Programa");
}