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
            if (name == null || name == String.Empty)
            {
                throw new ArgumentNullException(nameof(name), $"Impossibile creare Indirizzo senza questo parametro");
            } else
            {
                this.Name = name;
            }

            if (surname == null || surname == String.Empty)
            {
                throw new ArgumentNullException(nameof(surname), $"Impossibile creare Indirizzo senza questo parametro");
            } else
            {
                this.Surname = surname;
            }

            if (street == null || street == String.Empty)
            {
                throw new ArgumentNullException(nameof(street), $"Impossibile creare Indirizzo senza questo parametro");
            } else
            {
                this.Street = street;
            }

            if (city == null || city == String.Empty)
            {
                throw new ArgumentNullException(nameof(city), $"Impossibile creare Indirizzo senza questo parametro");
            } else
            {
                this.City = city;
            }

            if (province == null || province == String.Empty)
            {
                throw new ArgumentNullException(nameof(province), $"Impossibile creare Indirizzo senza questo parametro");
            } else
            {
                this.Province = province;
            }

            if (zip == null || zip == String.Empty)
            {
                throw new ArgumentNullException(nameof(zip), $"Impossibile creare Indirizzo senza questo parametro");
            }
            else
            {
                this.Zip = zip;
            }

        }


        public override string ToString()
        {
            return $"L'indirizzo é il seguente: {Name} {Surname} {Street} {City} {Province} {Zip}";
                  
        }

    }
}
