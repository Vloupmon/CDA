using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.Serialization;

namespace ServiceMail {
    #region Exception
    /// <summary>
    /// Exeption lors de la transmission d'un mail
    /// </summary>
    public class MailException : Exception, ISerializable {
        public MailException() {
        }
        public MailException(string message) : this() { }
        public MailException(string message, Exception inner) : this(message) { }

        // Pour pouvoir propager l'exception dans le cadre d'un échange hors processus 
        protected MailException(SerializationInfo info,
            StreamingContext context) {
        }
    }
    #endregion
    #region Service
    /// <summary>
    /// Service de mailing
    /// </summary>
    public class MailService : IMailService {
        /// <summary>
        /// Service Mail bidon : à remplacer par un vrai service
        /// </summary>
        /// <param name="email"></param>
        /// <param name="sujet"></param>
        /// <param name="corps"></param>
        /// <returns></returns>
        public bool SendMail(Mail email) {
            return true;
        }
    }
    #endregion
    #region Interface
    /// <summary>
    /// Interface du service Mail
    /// </summary>
    public interface IMailService {
        bool SendMail(Mail email);
    }

    public class Mail {
        public string AdresseMail {
            get; set;
        }
        public string Sujet {
            get; set;
        }
        public string Corps {
            get; set;
        }
    }
    #endregion
    #region Mailing
    public class EnvoiMailsGroupes {
        private IMailService _serviceMail;
        private ICollection<Mail> _mailsAEnvoyer;

        public EnvoiMailsGroupes(IMailService serviceMail, ICollection<Mail> mails) {
            _serviceMail = serviceMail;
            _mailsAEnvoyer = mails;
        }
        public int EnvoiMailing() {
            int nombreMails = 0;
            foreach (Mail mail in _mailsAEnvoyer) {
                if (string.IsNullOrEmpty(mail.AdresseMail) || string.IsNullOrEmpty(mail.Sujet)
                    || string.IsNullOrEmpty(mail.Corps)) {
                    throw new MailException("Un élément manquant dans le mail");
                } else {
                    _serviceMail.SendMail(mail);
                    nombreMails++;
                }

            }
            return nombreMails;
        }
    }
    #endregion
}
