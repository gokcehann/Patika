//04.08.2024 REHBER UYGULAMASI
//GÖKÇEHAN ÖZDEMİR

using System;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.Versioning;


internal class Program
{
    private static void Main(string[] args)
    {
        Console.OutputEncoding = System.Text.Encoding.UTF8;
        Console.InputEncoding = System.Text.Encoding.UTF8; //kodun türkçe çıktı alması ve vermesi için 

        // Contact nesnelerini saklayacak bir liste oluşturdum
        List<Contact> contacts = new List<Contact> //5 kişi ekledim.
            {
                new Contact("Selim", "Demir", "05527862585"),
                new Contact("Fazıla", "Özdemir", "05057932569"),
                new Contact("Nurdan", "Hayat", "05528754542"),
                new Contact("Efe", "Kaya", "05068524563"),
                new Contact("Hayat", "Yener", "05058642571")
            };

        PhoneBook phoneBook = new PhoneBook(contacts); //metodlar için 


        while (true)
        {
            Console.WriteLine("Yapmak istediğiniz işlemi seçiniz:\n1)Numara Kaydet \n2)Numara Sil \n3)Numara Güncelleme \n4)Rehberi Listele \n5)Numara Ara \n0)Çıkış Yap");
            var option = Console.ReadLine();// yapmak istediğim işlemi seçtim

            switch (option)
            {
                case "1": //1 nolu işlem
                    Console.Write("İsim: ");
                    var contactsName = Console.ReadLine();
                    Console.Write("Soyad: ");
                    var contactsSurname = Console.ReadLine();
                    Console.Write("Telefon Numarası: ");
                    var contactsNumber = Console.ReadLine();

                    if (contactsName != null && contactsSurname != null && contactsNumber != null)
                    {
                        phoneBook.numberSave(contactsName, contactsSurname, contactsNumber);
                        break;
                    }

                    else
                    {
                        Console.Write("Tüm bilgileri doldurunuz. Lütfen tekrar deneyiniz!");
                    }

                    break; //1.işlem tamam.

                case "2":
                    Console.WriteLine("Silmek istediğiniz kişinin adı ve soyadını giriniz: ");

                    var deleteName=Console.ReadLine().Split(" ");

                    if (deleteName[0]!=null && deleteName[1]!=null){
                    
                        if (deleteName.Length==2 ){
                            phoneBook.numberDelete(deleteName[0],deleteName[1]);
                        }
                        else{
                            Console.WriteLine("Geçersiz format. Tekrar deneyiniz.");
                        }
                    }

                    else{
                        Console.WriteLine("Başarısız.");
                    }
                     break;//2.işlemin sonu

                case "3":

                    Console.Write("Güncellemek istediğiniz kişinin ismini ve soyismini girin (örneğin: Ahmet Yılmaz): ");
                        var nameToUpdate = Console.ReadLine().Split(' ');
                        if (nameToUpdate.Length == 2)
                        {
                            phoneBook.numberUpdate(nameToUpdate[0], nameToUpdate[1]);
                        }
                        else
                        {
                            Console.WriteLine("Geçersiz giriş. Lütfen ismi ve soyismi doğru formatta girin.");
                        }
                        break;

                case "4":
                    phoneBook.contactsList();
                    break;

                case "5":
                    Console.WriteLine("1) İsim ve Soyad ile Ara\n2) Numara ile Ara");
                        var searchOption = Console.ReadLine();
                        if (searchOption == "1")
                        {
                            Console.Write("Aramak istediğiniz kişinin ismini ve soyismini girin (örneğin: Ahmet Yılmaz): ");
                            var nameToSearch = Console.ReadLine().Split(' ');
                            if (nameToSearch.Length == 2)
                            {
                                phoneBook.NumberSearchByName(nameToSearch[0], nameToSearch[1]);
                            }
                            else
                            {
                                Console.WriteLine("Geçersiz giriş. Lütfen ismi ve soyismi doğru formatta girin.");
                            }
                        }
                        else if (searchOption == "2")
                        {
                            Console.Write("Aramak istediğiniz numarayı girin: ");
                            var numberToSearch = Console.ReadLine();
                            phoneBook.NumberSearchByNo(numberToSearch);
                        }
                        else
                        {
                            Console.WriteLine("Hatalı tuşlama, bir daha deneyin!");
                        }
                        break;

                case "0":   //eğer çıkmak isterse
                    Console.WriteLine("Rehberden çıkış yapılıyor...");
                    return;
                default:
                    Console.WriteLine("Hatalı tuşlama bir daha deneyin!");
                    break;
            }
        }
    }
}