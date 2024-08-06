using System;
using System.Collections.Generic;
using System.Linq;

public class PhoneBook{
        private List<Contact> _contacts; //contacts öğelerine buradan ulaşabilmek için

        public PhoneBook(List<Contact> contacts)
        {
            _contacts = contacts;
        }

        public void Features(){
            Console.WriteLine("Şu an rehberdesiniz!");
        }

        public void numberSave(string name, string surname, string number){
            
            Contact newContact=new Contact(name, surname, number);
            _contacts.Add(newContact);
            _contacts.Sort();
            Console.WriteLine($"{name} {surname} başarıyla kaydedildi.");
        }

        public void numberDelete(string name, string surname){
            var contact = _contacts.Find(c => c.Name == name && c.Surname == surname);
            if (contact != null){
            _contacts.Remove(contact);
            Console.WriteLine($"{name} {surname} başarıyla silindi.");
            }
            else{
                Console.WriteLine("Kişi bulunamadı");
            }
        }

         public void numberUpdate(string name, string surname){
            var contact = _contacts.Find(c => c.Name == name && c.Surname == surname);

            if (contact != null)
            {
                Console.Write("Yeni İsim: ");
                contact.Name = Console.ReadLine();
                Console.Write("Yeni Soyad: ");
                contact.Surname = Console.ReadLine();
                Console.Write("Yeni Telefon Numarası: ");
                contact.Number = Console.ReadLine();

                _contacts.Sort();
                Console.WriteLine($"{contact.Name} {contact.Surname} başarıyla güncellendi.");
            }
            else {
                Console.WriteLine("Başarısız!");
            }

         }

         public void contactsList(){
            foreach (var contact in _contacts)
            {
                Console.WriteLine(contact);
            }
         }

         public void NumberSearchByName(string name, string surname){
            var contact = _contacts.Find(c => c.Name.Equals(name, StringComparison.OrdinalIgnoreCase) && c.Surname.Equals(surname, StringComparison.OrdinalIgnoreCase));
            if (contact != null){
                Console.WriteLine(contact);
            }
            else{
                Console.WriteLine("Kişi bulunamadı.");
            }
        }

        public void NumberSearchByNo(string number){
            var contact = _contacts.Find(c => c.Number == number);
            if (contact != null){
                Console.WriteLine(contact);
            }
            else{
                Console.WriteLine("Kişi bulunamadı.");
            }
    }
}
