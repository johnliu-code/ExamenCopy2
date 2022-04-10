using System;
using static System.Console;

namespace Evaluation01
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Evaluation 01 Yngajing Liu 803.");

            //This will work with GetClientId getter method, but not working with { set; get; } method !!
            Client client = new Client(
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

            WriteLine("{0},  {1},  {2},   {3},   {4},   {5},   {6},   {7},   {8},   {9}",
                    client.GetClientId(),
                    client.GetNomCompagnie(),
                    client.GetNomContact(),
                    client.GetTitreContact(),
                    client.GetAdresse(),
                    client.GetVille(),
                    client.GetProvince(),
                    client.GetCodePostal(),
                    client.GetPays(),
                    client.GetTelephone()
                    );

            ReadLine();

            // This will work with {set; get;} method !!
            Client client1 = new Client();
            client1.ClientId = "GROSR";
            client1.NomCompagnie = "GROSELLA - Restaurante";
            client1.NomContact = "Manuel Pereira";
            client1.TitreContact = "Owner";
            client1.Adresse = "5ª Ave.Los Palos Grandes";
            client1.Ville = "Caracas";
            client1.Province = "DF";
            client1.CodePostal = "1081";
            client1.Pays = "Venezuela(2)";
            client1.Telephone = "283 - 2951";
  
            client1.Print();
            ReadLine ();

            // Fournisseur 
            Fournisseur fournisseur1 = new Fournisseur();
            fournisseur1.FournisseurId = 1;
            fournisseur1.NomCompagnie = "Pavlova, Ltd.";
            fournisseur1.NomContact = "Ian Devling";
            fournisseur1.TitreContact = "Marketing Manager";
            fournisseur1.Adresse = "74 Rose St. Moonie Ponds";
            fournisseur1.Ville = "Melbourne";
            fournisseur1.Province = "Victoria";
            fournisseur1.CodePostal = "3058";
            fournisseur1.Pays = "Australia";
            fournisseur1.Telephone = "(03) 444-2343";

            fournisseur1.Print();
            ReadLine();

            //Commandes
            Commande commande1 = new Commande(client1);
            commande1.CommandeId = 10256;
            commande1.ClientId = client1.GetClientId();
            commande1.EmployeId = 3;
            commande1.DateCommande = new DateTime(1996 - 07 - 15);
            commande1.DateRequise = new DateTime(1996 - 08 - 12);
            commande1.DateEnvoi = new DateTime(1996 - 07 - 17);
            commande1.NomEnvoi = "Wellington Importadora";
            commande1.AdresseEnvoi = "Rua do Mercado, 12";
            commande1.VilleEnvoi = "Resende";
            commande1.CodePostalEnvoi = "08737-363";
            commande1.PaysEnvoi = "Brazil";

            commande1.Print();
            ReadLine();
        }
    }
}
