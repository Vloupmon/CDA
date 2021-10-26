using Bibliotheque.BOL;
using NUnit.Framework;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Text.Json;

namespace Bibliotheque.Test {
    [TestFixture]
    public class TestAdherent {

        [TestCase("a", false)]
        [TestCase("aaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaa", false)]
        [TestCase("Toto", true)]
        public void NomAdherent_Length(string Nom, bool expected) {
            Adherent adherent = new Adherent {
                NomAdherent = Nom
            };
            Assert.AreNotEqual(ValidationService.ValidateModel(adherent).Any(
                va => va.MemberNames.Contains("NomAdherent") &&
             va.ErrorMessage.Contains("2")), expected);
        }

        [TestCase("42", "Toto", "Titi", true)]
        [TestCase("42", "Toto", "!@#$%^&*()`~", false)]
        [TestCase("-1", "Toto", "Titi", false)]
        [TestCase("42", "ÅÍÎÏ˝ÓÔÒÚÆ☃", "Œ„´‰ˇÁ¨ˆØ∏”’Œ„´‰ˇÁ¨ˆØ∏”’Œ„´‰ˇÁ¨ˆØ∏”’Œ„´‰ˇÁ¨ˆØ∏”’", false)]
        [TestCase("42", "𐐜 𐐔𐐇𐐝𐐀𐐡𐐇𐐓 𐐙𐐊𐐡𐐝𐐓/𐐝𐐇𐐗𐐊𐐤𐐔 𐐒𐐋𐐗 𐐒𐐌 𐐜 𐐡𐐀𐐖𐐇𐐤𐐓𐐝 𐐱𐑂 𐑄 𐐔𐐇𐐝𐐀𐐡𐐇𐐓 𐐏𐐆𐐅𐐤𐐆𐐚𐐊𐐡𐐝𐐆𐐓𐐆", "Titi", false)]
        public void NomAdherent_Format(string ID, string Prenom, string Nom, bool expected) {
            Adherent adherent = new Adherent {
                IdAdherent = ID,
                NomAdherent = Nom,
                PrenomAdherent = Prenom
            };
            Assert.AreEqual(ValidationService.ValidateModel(adherent).Any(
                va => va.ErrorMessage == null), expected);
        }

        [Test]
        public void Test_EntityClone() {
            Adherent test = new Adherent {
                NomAdherent = "Titi",
                PrenomAdherent = "Toto"
            };

            Assert.IsTrue(test == test.Clone() as Adherent);
        }
    }
}