using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GerenateurProcStoc
{
    public class StoredProc
    {
        
        public string Name { get; set; }
        public string Schema { get; set; }
       

    }
    public class Table
    {
        public Table()
        {
            Columns = new HashSet<Column>();
            Key = new HashSet<KeyColumn>();
        }
        public string Name { get; set; }
        public string Schema { get; set; }
        public HashSet<Column> Columns { get; set; }
        public HashSet<KeyColumn> Key { get; set; }

    }
    public class Column
    {
        public int OrdinalPos { get; set; }
        public string Name { get; set; }
        public string Type { get; set; }
        public int Length { get; set; }
        public bool IsIdentity { get; set; }
        public bool AcceptNull { get; set; }
    }
    public class KeyColumn
    {
        public int OrdinalPosKey { get; set; }
        public string Name { get; set; }
    }
    public class Histo
    {
        List<Entree> _entrees = new List<Entree>();

        public List<Entree> Entrees { get => _entrees; set => _entrees = value; }

        public class Entree
        {
            public string TableName { get; set; }
            public string Operation { get; set; }
            public bool Resultat { get; set; }
            public string ErreurText { get; set; }
        }

    }
    internal class Parametre
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string DataType { get; set; }
        public bool IsOutputParameter { get; set; }
        public bool HasDefaultValue { get; set; }
        public string DefaultValue { get; set; }
        public int MaxBytes { get; set; }
        public int Scale { get; set; }
        public int Precision { get; set; }


    }

}
    
