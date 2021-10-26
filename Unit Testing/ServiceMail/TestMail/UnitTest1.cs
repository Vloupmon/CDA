using System.Collections.Generic;
using NUnit.Framework;
using Moq;
using ServiceMail;

namespace TestMail {
    public class Tests {
        [SetUp]
        public void Setup() {
        }

        [Test]
        public void Test_SendBadMails_Empty() {
            Mail mail = new(){
                AdresseMail = "",
                Sujet = "",
                Corps = ""
            };
            List<Mail> mails = new List<Mail> {
            };
            Mock<IMailService> mockIMailService = new();
            mockIMailService.Setup(x => x.SendMail(mail)).Returns(true);
            EnvoiMailsGroupes envoiMailsGroupes = new(mockIMailService.Object, mails);

            Assert.AreEqual(envoiMailsGroupes.EnvoiMailing(), 0);
        }

        [Test]
        public void Test_SendBadMail_Adresse() {
            List<Mail> mails = new List<Mail>{
               new Mail(){ AdresseMail = "", Sujet = "Coucou", Corps = "Ca va ?" }
            };
            Mock<IMailService> mockIMailService = new();
            mockIMailService.Setup(x => x.SendMail(mails[0])).Returns(true);
            EnvoiMailsGroupes envoiMailsGroupes = new(mockIMailService.Object, mails);

            Assert.Throws<MailException>(() => envoiMailsGroupes.EnvoiMailing());
        }

        [Test]
        public void Test_SendBadMail_Sujet() {
            List<Mail> mails = new List<Mail>{
               new Mail(){ AdresseMail = "a@a.com", Sujet = "", Corps = "Ca va ?" }
            };
            Mock<IMailService> mockIMailService = new();
            mockIMailService.Setup(x => x.SendMail(mails[0])).Returns(true);
            EnvoiMailsGroupes envoiMailsGroupes = new(mockIMailService.Object, mails);

            Assert.Throws<MailException>(() => envoiMailsGroupes.EnvoiMailing());
        }

        [Test]
        public void Test_SendBadMail_Corps() {
            List<Mail> mails = new List<Mail>{
               new Mail(){ AdresseMail = "a@a.com", Sujet = "Coucou", Corps = "" }
            };
            Mock<IMailService> mockIMailService = new();
            mockIMailService.Setup(x => x.SendMail(mails[0])).Returns(true);
            EnvoiMailsGroupes envoiMailsGroupes = new(mockIMailService.Object, mails);

            Assert.Throws<MailException>(() => envoiMailsGroupes.EnvoiMailing());
        }

        [Test]
        public void Test_SendMails() {
            List<Mail> mails = new List<Mail>{
               new Mail(){ AdresseMail = "a@b.com", Sujet = "Coucou", Corps = "Ca va ?" },
               new Mail(){ AdresseMail = "b@b.com", Sujet = "Coucou", Corps = "Ca va ?" },
               new Mail(){ AdresseMail = "c@b.com", Sujet = "Coucou", Corps = "Ca va ?" },
               new Mail(){ AdresseMail = "d@b.com", Sujet = "Coucou", Corps = "Ca va ?" },
            };
            Mock<IMailService> mockIMailService = new();
            mockIMailService.Setup(x => x.SendMail(mails[0])).Returns(true);
            EnvoiMailsGroupes envoiMailsGroupes = new(mockIMailService.Object, mails);

            Assert.IsTrue(envoiMailsGroupes.EnvoiMailing() == 4);
            mockIMailService.Verify(x => x.SendMail(mails[0]));
        }
    }
}