// See https://aka.ms/new-console-template for more information
using csharp_lista_indirizzi;
using System;
using System.IO;
using System.Reflection;

List <Indirizzo> listAddress = new List<Indirizzo>();

try
{
    // leggo il file nel percorso indicato
    StreamReader fileAddress = File.OpenText("C:\\Users\\katia\\source\\repos\\csharp-lista-indirizzi\\csharp-lista-indirizzi\\my-addresses.csv");

    // variabile per la riga del file
    int lineNumber = 0;

    try
    {
        // finchè la lettura del file non è terminata
        while (!fileAddress.EndOfStream)
        {
            // leggo il mio file
            string line = fileAddress.ReadLine();
            lineNumber++;

            // inizio a registrare i dati dalla seconda riga
            if (lineNumber > 1)
            {
                try
                {
                    Indirizzo addressReaded = Indirizzo.ParseFromLine(line);
                    listAddress.Add(addressReaded);
                }
                catch (ArgumentNullException ex)
                {
                    Console.WriteLine($"Attenzione si è verificato un errore:" + ex.Message);
                }
            }

        }
    } 
     catch (Exception e)
    {
        Console.WriteLine(e.Message);
    } 
    finally
    {
        // Dopo l'utilizzo chiudiamo il file
        fileAddress.Close();
    }

}
catch (Exception e)
{
    Console.WriteLine("Si è verificato un problema: " + e.Message);

}

Console.WriteLine(Environment.NewLine);




    // Leggo e stampo la lista dei miei indirizzi e la scrivo in un file:

    try
    {
        StreamWriter fileToWrite = File.CreateText("C:\\Users\\katia\\source\\repos\\csharp-lista-indirizzi\\csharp-lista-indirizzi\\my-newlistaddresses.csv");

        for (int i = 0; i < listAddress.Count; i++)
        {
            Console.WriteLine($"{i + 1}. {listAddress[i]}");
            fileToWrite.WriteLine($"{i + 1}. {listAddress[i]}");
        }


        fileToWrite.Close();

    } catch
    {
        Console.WriteLine("C'è stata un'eccezione");
    }


