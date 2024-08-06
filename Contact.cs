using System;
using System.Collections.Generic;

    public class Contact : IComparable<Contact>
    {
        public string Name { get; set; }
        public string Surname { get; set; }
        public string Number { get; set; }

        public Contact(string name, string surname, string number) //liste oluşturmak için
        {
            Name = name;
            Surname = surname;
            Number = number;
        }

        // IComparable<Contact> arayüzünü implement ediyoruz
        public int CompareTo(Contact? other)
        {
            if (other == null)
                return 1; // Kendisi null'dan büyük

            // Adlara göre karşılaştırma
            return string.Compare(Name, other.Name, StringComparison.OrdinalIgnoreCase);
        }
             // ToString metodu
        public override string ToString()
        {
            return $"{Name} {Surname}: {Number}";
        }
    }
