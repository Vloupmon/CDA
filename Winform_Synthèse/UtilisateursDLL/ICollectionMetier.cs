using Utilitaires;

namespace SalariesDll {

    internal interface ICollectionMetier {

        /// <summary>
        /// Sauvegarde des entités
        /// </summary>
        /// <param name="pathRepData">Chemin complet du dossier</param>
        void Save(ISauvegarde sauvegarde, string pathRepData);

        /// <summary>
        /// Extraction des entités
        /// </summary>
        /// <param name="pathRepData">Chemin complet du dossier</param>
        void Load(ISauvegarde sauvegarde, string pathRepData);
    }
}