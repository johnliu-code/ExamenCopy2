using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace Evaluation01
{
    internal class Client
    {
		private string clientId;
		private string nomCompagnie;
		private string nomContact;
		private string titreContact;
		private string adresse; 
		private string ville;
		private string province;
		private string codePostal; 
		private string pays;
		private string telephone; 
		public Client () { }
        public Client(
            string clientId, 
	        string nomCompagnie,
	        string nomContact,
	        string titreContact,  
	        string adresse,
	        string ville,
	        string province,
	        string codePostal,
	        string pays,
	        string telephone)
        {
		this.clientId = clientId;
		this.nomCompagnie = nomCompagnie;
		this.nomContact = nomContact;
		this.titreContact = titreContact;
		this.adresse = adresse;
		this.ville = ville;
		this.province = province;
		this.codePostal = codePostal;
		this.pays = pays;
		this.telephone = telephone;
    	}

		public string GetClientId () { return clientId; }   //Get value from initial parameters
		public string NomCompagnie { set; get; }
		public string NomContact { set; get; }
		public string TitreContact { set; get; }
		public string Adresse { set; get; }
		public string Ville{ set; get; }
		public string Province{ set; get; }
		public string CodePostal{ set; get; }
		public string Pays{ set; get; }
		public string Telephone{ set; get; }

		public void	Print ()
        {
			WriteLine("{0},  {1},  {2},   {3},   {4},   {5},   {6},   {7},   {8},   {9}",
				clientId,
				nomCompagnie,
				nomContact, 
				titreContact,  
				adresse, 
				ville, 
				province,
				codePostal, 
				pays,
				telephone
				);
        }
	}
}
