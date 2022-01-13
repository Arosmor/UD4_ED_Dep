using System;
class ArrayExample
{
    static void Main()
    {
        //Define una raid de caracteres llamado letters
        //Se reserva memoria para 10 elemoentos de tipo char
        //Tenemos un "for" donde se van añadiendo los elementos de uno en uno hasta que llegue a los 10
        //Finalmente el programa van poniendo por pantalla el mensaje "hello" en una linea con la priemra sentencia hasta
        // que termina todods los elementos.
        char[] letters = { 'f', 'r', 'e', 'd', ' ', 's', 'm', 'i', 't', 'h' };
        string name = "";
        int[] a = new int[10];
        for (int i = 0; i < letters.Length; i++)
        {
            name += letters[i];
            a[i] = i + 1;
            SendMessage(name, a[i]);
        }
        Console.ReadKey();
    }
    static void SendMessage(string name, int msg)
    {
        Console.WriteLine("Hello, " + name + "! Count to " + msg);
    }
}