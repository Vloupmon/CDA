using System;
using System.Collections.Generic;
//using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Globalization;

namespace P001_V2
{

    /// <summary>
    /// Ensemble des salaries
    /// </summary>
    public class Salaries : List<Salarie>
    {
        /// <summary>
        /// Ajouter un salarié
        /// </summary>
        /// <param name="salarie"></param>
        new public void Add(Salarie salarie)
        {
            
            foreach (Salarie item in this)
            {
                if (item.Equals(salarie))
                {
                   return;
                }
                
            }
            
                base.Add(salarie);
                

            if (!this.Contains(salarie))
            { base.Add(salarie); }
        }
        /// <summary>
        /// Ajout une liste de salariés
        /// </summary>
        /// <param name="salaries">Tout type implémentant IEnumerable</param>
        new public void AddRange(IEnumerable<Salarie> salaries)
        {
            foreach (Salarie item in salaries)
            {
                this.Add(item);
            }
        }
        ///<summary>
        /// Extrait le salarié ayant le numéro de matricule fourni en argument
        /// </summary>
        /// <param name="Matricule"></param>
        /// <returns>Un salarié ou null si non trouvé</returns>

        public Salarie ExtraireSalarie(string matricule)
        {
            foreach (Salarie salarie in this)
            {
                if (salarie.Matricule == matricule)
                {
                    return salarie;
                }
            }
            
           // return null;
            return this.Find(s => s.Matricule == matricule);
        }
        /// <summary>
        /// Extraction d'une liste spécialisée de salariés
        /// </summary>
        /// <param name="DebutNom">Critère de recherche</param>
        /// <returns>Objet Salaries vide si aucun salarié trouvé</returns>
        public Salaries SalariesNomCommencePar(string DebutNom)
        {
            Salaries salaries = new Salaries();
            foreach (Salarie item in this)
            {
                if (item.Nom.StartsWith(DebutNom))
                {
                    salaries.Add(item);

                }
            }

          //  return salaries;
            return FindAll(s => s.Nom.StartsWith(DebutNom)) as Salaries;
        }

        /// <summary>
        /// Suppresion d'un salarié
        /// </summary>
        /// <param name="salarie">Objet salarié à supprimer</param>
        new public void Remove(Salarie salarie)
        {
            //int i = 0;
            //Salarie salrec = null;
            //do
            //{
            //    if (this[i].Equals(salarie))
            //    { salrec = this[i]; }
            //    i++;

            //} while (salrec == null && i < this.Count);


            //  if (salrec != null) base.Remove(salrec);
            //foreach (var item in this)
            //{
            //    if (item.Equals(salarie))
            //    {
            //        Remove(item);
            //    }
               
            //}
            base.Remove(salarie);

        }
        /// <summary>
        /// Suppression d'un salarié
        /// dont le nom est celui fourni en argument
        /// </summary>
        /// <param name="nom">Nom du salarié</param>
         public void RemoveNom(string nom)
        {
            //int i = this.Count-1;
            
            //do
            //{
            //    if (this[i].Nom == nom)
            //    {
            //        this.RemoveAt(i);
            //    }
            //    i--;

            //} while (i >=0);

            FindAll(s => s.Nom == nom).ForEach(s => Remove(s));
           

        }
        /// <summary>
        /// Suppresion d'un salarié
        /// </summary>
        /// <param name="matricule">Matricule du salarié</param>
        public void Remove(string matricule)
        {
            Salarie salrec = this.ExtraireSalarie(matricule);
            if (salrec != null) base.Remove(salrec);

        }

        /// <summary>
        /// Constructeur par défaut
        /// </summary>
        public Salaries()
            : base() {}
        
    }
}

