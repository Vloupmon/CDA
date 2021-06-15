﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Formatters.Binary;

namespace Bibliotheque.BOL
{

   [Serializable]
    public abstract class EntityBase : ICloneable, IEditableObject, INotifyPropertyChanged, IDataErrorInfo
    {
        protected object _clone = null;
        protected bool inTxn = false;
        protected bool _isValid = true;

        public bool IsValid
        {
            get
            {
                return isValid();
            }
        }
        public string this[string property]
        {
            get
            {
                var propertyDescriptor = TypeDescriptor.GetProperties(this)[property];
                if (propertyDescriptor == null)
                { return string.Empty; }

                var results = new List<ValidationResult>();
                var result = Validator.TryValidateProperty(
                                          propertyDescriptor.GetValue(this),
                                          new ValidationContext(this, null, null)
                                          { MemberName = property },
                                          results);
                if (!result)
                { return results.First().ErrorMessage; }
                return string.Empty;
            }
        }

        public string Error
        {
            get
            {
                var results = new List<ValidationResult>();
                _isValid = Validator.TryValidateObject(this,
                    new ValidationContext(this, null, null), results, true);
                if (!_isValid)
                {
                    return string.Join("\n", results.Select(x => x.ErrorMessage));
                }
                else
                {
                    return null;
                }
            }
        }
        private bool isValid()
        {
            
            return Validator.TryValidateObject(this,
                    new ValidationContext(this, null, null), null, true);
        }
        [field: NonSerialized]
        public event PropertyChangedEventHandler PropertyChanged;
        protected void NotifyPropertyChanged([CallerMemberName] string propertyName = "")
           => PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));

        public void BeginEdit()
        {
            if (!inTxn)
            {
                _clone = this.Clone();
                inTxn = true;
            }

        }
        public void CancelEdit()
        {
            Type t = this.GetType();
            PropertyInfo[] propInfos = t.GetProperties(BindingFlags.Public | BindingFlags.Instance);
            foreach (var propInfo in propInfos)
            {
                if (propInfo.CanRead && propInfo.CanWrite)
                {
                    propInfo.SetValue(this, propInfo.GetValue(_clone));
                }
            }
        }

        public object Clone()
        {
            IFormatter formatter = new BinaryFormatter();
            using (Stream stream = new MemoryStream())
            {
                formatter.Serialize(stream, this);
                stream.Seek(0, SeekOrigin.Begin);
                return formatter.Deserialize(stream);
            }
        }

        public void EndEdit()
        {
            if (inTxn)
            {
                _clone = this.Clone();
                inTxn = false;
            }
        }

        
    }

}
