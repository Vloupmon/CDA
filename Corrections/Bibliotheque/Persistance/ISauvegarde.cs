using System;
using System.Collections;
using System.Collections.Generic;

namespace Persistance
{
    public interface ISauvegarde
    {
        void Save<T>(string pathRepData, IEnumerable<T> objetASauvegarder) where T : class;
        IEnumerable<T> Load<T>(string pathRepData) where T : class;

    }
}
