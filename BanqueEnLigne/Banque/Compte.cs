using System;
using System.Globalization;
using System.Numerics;
using System.Text;
using System.Text.RegularExpressions;

namespace Banque {

    /// <summary>
    /// Compte en banque
    /// </summary>
    public class Compte {

        #region Champs

        private string _cleRIB;
        private string _codeBanque;
        private string _codeClient;
        private string _codeGuichet;
        private string _libelleCompte;
        private string _numero;

        #endregion Champs

        #region Propriétés

        public string CleRIB {
            get {
                return _cleRIB;
            }
            set {
                if (IsDigits(value)) {
                    if (value.Length < 2) {
                        value = value.PadLeft(2, '0');
                    }
                    _cleRIB = value;
                } else {
                    throw new FormatException(Properties.ErrorStrings.keyFormatError);
                }
            }
        }

        public string CodeBanque {
            get {
                return _codeBanque;
            }
            set {
                if (IsDigits(value)) {
                    if (value.Length < 5) {
                        value = value.PadLeft(5, '0');
                    }
                    _codeBanque = value;
                } else {
                    throw new FormatException(Properties.ErrorStrings.bankCodeError);
                }
            }
        }

        public string CodeClient {
            get {
                return _codeClient;
            }
            set {
                _codeClient = value;
            }
        }

        public string CodeGuichet {
            get {
                return _codeGuichet;
            }
            set {
                if (IsDigits(value)) {
                    if (value.Length < 5) {
                        value = value.PadLeft(5, '0');
                    }
                    _codeGuichet = value;
                } else {
                    throw new FormatException(Properties.ErrorStrings.deskCodeError);
                }
            }
        }

        public string LibelleCompte {
            get {
                return _libelleCompte;
            }
            set {
                _libelleCompte = value;
            }
        }

        public string Numero {
            get {
                return _numero;
            }
            set {
                value = value.ToUpper(); // To CAPS
                if (Regex.IsMatch(value, @"^[0-9A-Z]+$")) { // Alphanumerical
                    if (value.Length < 11) {
                        value = value.PadLeft(11, '0');
                    }
                    _numero = value;
                } else {
                    throw new FormatException(Properties.ErrorStrings.accountNumberError);
                }
            }
        }

        #endregion Propriétés

        /// <summary>
        ///  opérateur relationnel !=
        /// </summary>
        /// <param name="compteA">Instance Compte</param>
        /// <param name="compteB">Instance Compte</param>
        /// <returns>Vrai si différents</returns>
        public static bool operator !=(Compte compteA, Compte compteB) {
            if (compteA is null)
                return (object)compteB != null;
            return !compteA.Equals(compteB);
        }

        /// <summary>
        /// opérateur relationnel ==
        /// </summary>
        /// <param name="compteA">Instance Compte</param>
        /// <param name="compteB">Instance Compte</param>
        /// <returns>Vrai si égaux</returns>
        public static bool operator ==(Compte compteA, Compte compteB) {
            if (compteA is null)
                return compteB is null;
            return compteA.Equals(compteB);
        }

        /// <summary>
        /// Deux comptes sont égaux si codes client,Banque,Guichet et Numéros de compte
        /// sont identiques
        /// </summary>
        /// <returns>Vrai si les deux objets sont égaux</returns>
        public override bool Equals(Object compte) {
            Compte compteRef = compte as Compte;
            if (compteRef == null)
                return false;
            return compteRef.CodeClient == CodeClient
                      && compteRef.CodeBanque == CodeBanque
                      && compteRef.CodeGuichet == CodeGuichet
                     && compteRef.Numero == Numero;
        }

        public override int GetHashCode() {
            int hashCode;
            hashCode = string.IsNullOrEmpty(_codeClient) ? 0 : _codeClient.GetHashCode();
            hashCode = string.IsNullOrEmpty(_codeBanque) ? hashCode : hashCode ^ _codeBanque.GetHashCode();
            hashCode = string.IsNullOrEmpty(_codeGuichet) ? hashCode : hashCode ^ _codeGuichet.GetHashCode();
            hashCode = string.IsNullOrEmpty(_numero) ? hashCode : hashCode ^ _numero.GetHashCode();
            return hashCode;
        }

        /// <summary>
        /// Check if key calculated from the account number, the bank code and the desk code
        /// is equal to the key inputted by user
        /// </summary>
        /// <returns>True or False</returns>
        public bool KeyCheck() {
            StringBuilder sb = new StringBuilder();
            int iBuffer = 0;
            Console.WriteLine("Num : " + Numero + '\n');
            foreach (char c in Numero) {
                if (Hollerith.Transcoder(c, out iBuffer)) {
                    sb.Append(iBuffer.ToString());
                } else {
                    sb.Append(c);
                }
            }
            sb.Insert(0, CodeGuichet);
            sb.Insert(0, CodeBanque);
            if (!BigInteger.TryParse(sb.ToString(), out BigInteger keyset)) {
                return (false);
            }
            if (KeyCalc(keyset) == CleRIB) {
                return (true);
            }
            return (false);
        }

        /// <summary>
        /// Chaine représentant l'objet instancié.
        /// </summary>
        /// <returns></returns>
        public override string ToString() {
            return string.Format(CultureInfo.CurrentCulture, @"{0};{1};{2};{3};{4};{5}", this.CodeClient, this.CodeBanque, this.CodeGuichet, this.Numero, this.CleRIB, this.LibelleCompte);
        }

        /// <summary>
        /// Basic REGEX to check is a string is all digits.
        /// </summary>
        /// <param name="str"></param>
        /// <returns>Boolean</returns>
        private bool IsDigits(string str) {
            return (Regex.IsMatch(str, @"^\d+$"));
        }

        /// <summary>
        /// Computes key from an aribtrary int according to key aglorithm.
        /// Key is int between 0 and 99.
        /// </summary>
        /// <param name="keySet"></param>
        /// <returns>Key as a string</returns>
        private string KeyCalc(BigInteger keySet) {
            return ((97 - keySet * 100 % 97).ToString());
        }
    }
}