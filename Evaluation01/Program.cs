using System;
using static System.Console;

namespace Evaluation01
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Evaluation 01 Yngajing Liu 803.\n");

            //This will work with GetClientId getter method, but not working with { set; get; } method !!
            Client client1 = new Client(
                    "GROSR",
                    "GROSELLA - Restaurante",
                    "Manuel Pereira",
                    "Owner",
                    "5ª Ave.Los Palos Grandes",
                    "Caracas",
                    "DF",
                    "1081",
                    "Venezuela(2)",
                    "283 - 2951"
                    );

            Client client2 = new Client(
                    "HANAR",
                    "Hanari Carnes",
                    "Mario Pontes",
                    "Accounting Manager",
                    "Rua do Paço, 67",
                    "Rio de Janeiro",
                    "RJ",
                    "05454-876",
                    "Brazil",
                    "(21) 555-0091"
                    );

            Client client3 = new Client(
                    "HILAA",
                    "HILARION-Abastos",
                    "Carlos Hernández",
                    "Sales Representative",
                    "Ville Center Plaza 516 Main St.",
                    "San Cristóbal",
                    "Táchira",
                    "5022",
                    "Venezuela",
                    "(5) 555-1340"
                    );

            client1.Print();
            client2.Print();
            client3.Print();
            ReadLine ();

            // Fournisseur 
            Fournisseur fournisseur1 = new Fournisseur (
                1,
                "Pavlova, Ltd.",
                "Ian Devling",
                "Marketing Manager",
                "74 Rose St. Moonie Ponds",
                "Melbourne",
                "Victoria",
                "3058",
                "Australia",
                "(03) 444-2343"
                );

            Fournisseur fournisseur2 = new Fournisseur(
                3,
                "Heli Süßwaren GmbH & Co. KG",
                "Petra Winkler",
                "Sales Manager",
                "Tiergartenstraße 5",
                "Berlin",
                "Baltimore",
                "10785",
                "Germany",
                "(010) 9984510"
                );

            Fournisseur fournisseur3 = new Fournisseur(
                2,
                "Refrescos Americanas LTDA",
                "Carlos Diaz",
                "Marketing Manager",
                "Av. das Americanas 12.890",
                "Sao Paulo",
                "Null",
                "5442",
                "Brazil",
                "(11) 555 4640"
                );

            fournisseur1.Print();
            fournisseur2.Print();
            fournisseur3.Print();

            ReadLine();

            //Commandes
            Commande commande1 = new Commande(
                10256,
                client1.GetClientId(),
                3,
                new DateTime(1996 - 07 - 15),
                new DateTime(1996 - 08 - 12),
                new DateTime(1996 - 07 - 17),
                "Wellington Importadora",
                "Rua do Mercado, 12",
                "Resende",
                "08737-363",
                "Brazil"
                );

            Commande commande2 = new Commande(
                10261,
                client2.GetClientId(),
                4,
                new DateTime(1996 - 07 - 19),
                new DateTime(1996 - 08 - 16),
                new DateTime(1996 - 07 - 30),
                "Que Delícia",
                "Rua da Panificadora, 12",
                "Rio de Janeiro",
                "02389-673",
                "Brazil"
                );

            Commande commande3 = new Commande(
                10264,
                client3.GetClientId(),
                6,
                new DateTime(1996 - 07 - 24),
                new DateTime(1996 - 08 - 21),
                new DateTime(1996 - 08 - 23),
                "Folk och fä HB",
                "Åkergatan 24",
                "Bräcke",
                "S-844 67",
                "Sweden"
                );

            commande1.Print();
            commande2.Print();
            commande3.Print();

            ReadLine();
        }
    }
}
