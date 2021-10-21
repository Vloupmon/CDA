using Bibliotheque.BOL;
using NUnit.Framework;
using System.Linq;

namespace Bibliotheque.Test
{
    [TestFixture]
    public class TestAdherent
    {
        

        [Test]
        public void NomAdherentTropCourt()
        {
            Adherent adherent = new Adherent
            {
                NomAdherent = "b"
            };
            
            Assert.IsTrue(ValidationService.ValidateModel(adherent).Any(
                va => va.MemberNames.Contains("NomAdherent") &&
             va.ErrorMessage.Contains("2")));
        }
    }
}