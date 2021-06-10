using System;
using System.Collections;
using System.Collections.Generic;

namespace SalariesDll {

    internal interface ISerializeEntities {

        void Save(IEnumerable item, string path);

        IEnumerable Load(Type item, string path);
    }
}