using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace Evaluation01
{
    internal class Commande
    {
        //4. Créer une classe Commande avec les variables membres suivantes :

        private Client client;
        private int commandeId;
        private string clientId;
        private int employeId;
        public DateTime dateCommande;
        public DateTime dateRequise;
        public DateTime dateEnvoi;
        public string nomEnvoi;
        public string adresseEnvoi;
        public string villeEnvoi;
        public string codePostalEnvoi;
        public string paysEnvoi;

        public Commande() { }
        public Commande(
            Client client,
            int commandeId,
            string clientId,
            int employeId,
            DateTime dateCommande,
            DateTime dateRequise,
            DateTime dateEnvoi,
            string nomEnvoi,
            string adresseEnvoi,
            string villeEnvoi,
            string codePostalEnvoi,
            string paysEnvoi)
        {
            this.client = client;
            this.commandeId = commandeId;
            this.clientId = clientId;
            this.employeId = employeId;
            this.dateCommande = dateCommande;
            this.dateRequise = dateRequise;
            this.dateEnvoi = dateEnvoi;
            this.nomEnvoi = nomEnvoi;
            this.adresseEnvoi = adresseEnvoi;
            this.villeEnvoi = villeEnvoi;
            this.codePostalEnvoi = codePostalEnvoi;
            this.paysEnvoi = paysEnvoi;
        }
        public int CommandeId { get; set; }
        public string ClientId { get; set; }
        public int EmployeId { get; set; }
        public DateTime DateCommande { get; set; }
        public DateTime DateRequise { get; set; }
        public DateTime DateEnvoi { get; set; }
        public string NomEnvoi { get; set; }
        public string AdresseEnvoi { get; set; }
        public string VilleEnvoi { get; set; }
        public string CodePostalEnvoi { get; set; }
        public string PaysEnvoi { get; set; }

        public Commande(Client client)
        {
            if (client != null)
            {
                this.client = client;
            }
            else
            {
                WriteLine("Client is not exist!!");
            }
        }
        public void Print()
        {
            WriteLine("{0}   {1}    {2}    {3}    {4}    {5}    {6}    {7}    {8}    {9}    {10}",
                 CommandeId,
                 ClientId,
                 EmployeId,
                 DateCommande,
                 DateRequise,
                 DateEnvoi,
                 NomEnvoi,
                 AdresseEnvoi,
                 VilleEnvoi,
                 CodePostalEnvoi,
                 PaysEnvoi
                );
        }
    }
}
