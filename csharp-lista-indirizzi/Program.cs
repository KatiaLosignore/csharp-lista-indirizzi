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

            // registro i dati solo se la riga non è null ed è diversa da 1
            if (lineNumber != null && lineNumber > 1)
            {
                string[] stringSplits = line.Split(',');

                if (stringSplits.Length != 6)
                {
                    Console.WriteLine($"L'indirizzo ({line}) non è leggibile!");
                }
                else
                {
                    string name = stringSplits[0];
                    string surname = stringSplits[1];
                    string street = stringSplits[2];
                    string city = stringSplits[3];
                    string province = stringSplits[4];
                    int zip = int.Parse(stringSplits[5]);

                    Console.WriteLine($"Indirizzo : {name}, {surname}, {street}, {city}, {province}, {zip}");

                    Indirizzo newAddress = new Indirizzo(name, surname, street, city, province, zip);

                    listAddress.Add(newAddress);
                }
                lineNumber++;
            }
            lineNumber++;
        }
    }
    catch (ArgumentNullException ex)
    {
        Console.WriteLine($"Attenzione si è verificato un errore:" + ex.Message);

        lineNumber++;
    }
    finally
    {
        fileAddress.Close();
    }

    // Dopo l'utilizzo chiudiamo il file
    fileAddress.Close();
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

        foreach (Indirizzo indirizzo in listAddress)
        {

            Console.WriteLine(indirizzo.ToString());
        }

        fileToWrite.Close();

    } catch
    {
        Console.WriteLine("C'è stata un'eccezione");
    }


