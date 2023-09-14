// See https://aka.ms/new-console-template for more information
using csharp_lista_indirizzi;
using System.IO;

List <Indirizzo> listAddress = new List<Indirizzo>();

try
{
    StreamReader fileAddress = File.OpenText("C:\\Users\\katia\\source\\repos\\csharp-lista-indirizzi\\csharp-lista-indirizzi\\my-addresses.csv");

    int lineNumber = 0;
 

    // finchè la lettura del file non sarà terminata
    while (!fileAddress.EndOfStream)
    {
        string line = fileAddress.ReadLine();

        if (lineNumber != null && lineNumber != 0)
        {
            string[] stringSplits = line.Split(',');

            if(stringSplits.Length != 6)
            {
                throw new Exception("Il numero dei valori inseriti non rispettano il numero di campi richiesti!");
            } else
            {
                string name = stringSplits[0];
                string surname = stringSplits[1];
                string street = stringSplits[2];
                string city = stringSplits[3];
                string province = stringSplits[4];
                string zip = stringSplits[5];

                Console.WriteLine($"Indirizzo completo: {name}, {surname}, {street}, {city}, {province}, {zip}");

                Indirizzo newAddress = new Indirizzo(name, surname, street, city, province, zip);

                listAddress.Add(newAddress);
            }

        }
        lineNumber++;
    }

    fileAddress.Close();

} catch (ArgumentNullException ex)
{
    Console.WriteLine($"Attenzione si è verificato un errore:" + ex.Message);
}



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
    Console.WriteLine("C'è stata un'ecceczione");
}


