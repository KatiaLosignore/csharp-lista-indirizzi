using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace csharp_lista_indirizzi
{
    public class Indirizzo
    {
        public string Name { get; set; }
        public string Surname { get; set; }
        public string Street { get; set; }
        public string City { get; set; }
        public string Province { get; set; }
        public string Zip { get; set; }

        public Indirizzo(string name, string surname, string street, string city, string province, string zip) 
        {
            if (name == String.Empty)
            {
                throw new ArgumentNullException(nameof(name), $"Impossibile creare Indirizzo senza questo parametro");
            } else
            {
                this.Name = name;
            }

            if (surname == String.Empty)
            {
                throw new ArgumentNullException(nameof(surname), $"Impossibile creare Indirizzo senza questo parametro");
            } else
            {
                this.Surname = surname;
            }

            if (street == String.Empty)
            {
                throw new ArgumentNullException(nameof(street), $"Impossibile creare Indirizzo senza questo parametro");
            } else
            {
                this.Street = street;
            }

            if (city == String.Empty)
            {
                throw new ArgumentNullException(nameof(city), $"Impossibile creare Indirizzo senza questo parametro");
            } else
            {
                this.City = city;
            }

            if (province == String.Empty)
            {
                throw new ArgumentNullException(nameof(province), $"Impossibile creare Indirizzo senza questo parametro");
            } else
            {
                this.Province = province;
            }

            if (zip == String.Empty)
            {
                throw new ArgumentNullException(nameof(zip), $"Impossibile creare Indirizzo senza questo parametro");
            }
            else
            {
                this.Zip = zip;
            }

            if (!char.IsDigit(street[0]))
                throw new Exception($"Il campo {nameof(street)} deve iniziare per numero");
            else
                this.Street = street;
        }

        // METODI
        public override string ToString()
        {
            return $" {Name}, {Surname}, {Street}, {City}, {Province}, {Zip};";
           
                  
        }


        // METODO STATIC
        public static Indirizzo ParseFromLine(string line)
        {

            string[] stringSplits = line.Split(',');

            if (stringSplits.Length != 6)
            {
                throw new Exception($"L'indirizzo ({line}) non è leggibile!");
            }
            else
            {
                //definisco una variabile che ad ogni elemento valido aumenterà
                int counter = 0;

                for (int i = 0; i < stringSplits.Length; i++)
                {
                    stringSplits[i] = stringSplits[i].Trim();
                    if (stringSplits[i].Length > 0)
                    {
                        counter++;
                    }
                }

                if (counter == 6)
                {
                    string name = stringSplits[0];
                    string surname = stringSplits[1];
                    string street = stringSplits[2];
                    string city = stringSplits[3];
                    string province = stringSplits[4];
                    string zip = (stringSplits[5]);

                    Console.WriteLine($"Indirizzo di {name} {surname}: {street}, {city}, {province}, {zip};");

                    Indirizzo newAddress = new Indirizzo(name, surname, street, city, province, zip);
                    return newAddress;
                }
                else
                {
                    throw new Exception($"L'indirizzo ({line}) contiene valori non validi!");
                }
            }
        }

    }
}
