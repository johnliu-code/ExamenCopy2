using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace Evaluation01
{
    internal class Fournisseur
    {
		private int fournisseurId;
		private string nomCompagnie;
		private string nomContact;
		private string titreContact;
		private string adresse;
		private string ville;
		private string province;
		private string codePostal;
		private string pays;
		private string telephone;
		private string pageWeb;
		public Fournisseur() { }
		public Fournisseur(
			int fournisseurId,
			string nomCompagnie,
			string nomContact,
			string titreContact,
			string adresse,
			string ville,
			string province,
			string codePostal,
			string pays,
			string telephone,
		    string pageWeb
			)
		{
			this.fournisseurId = fournisseurId;
			this.nomCompagnie = nomCompagnie;
			this.nomContact	= nomContact;
			this.titreContact = titreContact;
			this.adresse = adresse;
			this.ville = ville;
			this.province = province;
			this.codePostal = codePostal;
			this.pays = pays;
			this.telephone = telephone;
			this.pageWeb = pageWeb;
		}

		public int FournisseurId { set; get; }
		public string NomCompagnie { set; get; }
		public string NomContact { set; get; } 
		public string TitreContact { set; get; } 
		public string Adresse { set; get; }  
		public string Ville { set; get; } 
		public string Province { set; get; } 
		public string CodePostal { set; get; } 
		public string Pays { set; get; } 
		public string Telephone { set; get; } 
		public string PageWeb { set; get; }

		public void Print()
		{
			WriteLine("{0},  {1},  {2},   {3},   {4},   {5},   {6},   {7},   {8},   {9}",
				 FournisseurId, 
				 NomCompagnie,
				 NomContact, 
				 TitreContact, 
				 Adresse,  
				 Ville, 
				 Province, 
				 CodePostal, 
				 Pays, 
				 Telephone, 
				 PageWeb
				);
		}
	}
}
