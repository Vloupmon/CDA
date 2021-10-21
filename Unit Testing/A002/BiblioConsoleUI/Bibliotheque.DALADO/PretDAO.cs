using Bibliotheque.BOL;
using Bibliotheque.Repository;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Common;

namespace Bibliotheque.DALADO
{
    public class PretADO
    {
        private static PretADO _instance = null;
        private static object _verrou = new object();
        public static PretADO Instance
        {
            get
            {
                lock (_verrou)
                {
                    if (_instance == null)
                    {
                        _instance = new PretADO();
                    }
                }
                return _instance;
            }
        }

    }
}

