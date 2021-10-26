using System;
using System.Collections.Generic;
using ServiceMail;

namespace AppMailing
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Mail> mails = new List<Mail>();
            mails.Add(new Mail()
            {
                AdresseMail = "Vincent.bost@afpa.fr",
                Sujet = "Entretien CDI",
                Corps = "Bonjour...."
            });
            mails.Add(new Mail()
            {
                AdresseMail = "Vincent.bost@campus.afpa.fr",
                Sujet = "Entretien CDI",
                Corps = "Bonjour...."
            });
            mails.Add(new Mail()
            {
                AdresseMail = "Vincent.bost@afpa.fr",
                Sujet = "Entretien CDI",
                Corps = "Bonjour...."
            });
            ApplicationMail.RealiserMailing(mails);
        }
    }
    public static class ApplicationMail
    {
       public static void RealiserMailing(IList<Mail> mails)
        {
            EnvoiMailsGroupes mailing = new EnvoiMailsGroupes(new MailService(), mails);
            mailing.EnvoiMailing();

        }
    }
}
