using System;
using System.Collections;
using System.Collections.Generic;

namespace PersistanceIService
{
    /// <summary>
/// Contrat de service pour persistance 
/// </summary>
    public interface ISauvegarde
    {
        /// <summary>
        /// Contrat Sauvegarde
        /// </summary>
        /// <typeparam name="T">Type de l'objet de la collection</typeparam>
        /// <param name="pathRepData">Emplacement physique</param>
        /// <param name="objetASauvegarder">Collection à sauvegarder</param>
        void Save<T>(string pathRepData, IEnumerable<T> objetASauvegarder) where T : class;
        /// <summary>
        /// Contrat Chargement des données
        /// </summary>
        /// <typeparam name="T">Corrélation Type Nom du fichier sans extension</typeparam>
        /// <param name="pathRepData">Emplacement du fichier</param>
        /// <returns></returns>
        IEnumerable<T> Load<T>(string pathRepData) where T : class;

    }
}
