using ORM.Models;
using System.Linq;

namespace ORM {

    internal class Order {

        public int OrderID {
            get; set;
        }

        public decimal OrderPaid {
            get;
            set;
        }
    }

    internal class Program {

        private static void Main(string[] args) {
            using (ComptoirAnglaisEntities dbContext = new ComptoirAnglaisEntities()) {
                int ca = 2500;
                var CA = dbContext.Orders.Select(o => new {
                    o.OrderId,
                    o.CustomerId,
                    o.Customer.CompanyName,
                    CA = o.OrderDetails.Sum(y => ((float)y.UnitPrice * (1.0f - y.Discount)) * y.Quantity)
                }).ToList();
                foreach (var item in CA) {
                    System.Console.WriteLine(item.CompanyName + " " + item.CA + "\n");
                }
                var CA2 = CA.GroupBy(co => new { co.CustomerId, co.CompanyName }).Select(t =>
                      new {
                          t.Key.CustomerId,
                          t.Key.CompanyName,
                          CaTotal = t.Sum(o => o.CA)
                      }).Where(c => c.CaTotal > ca).ToList();
            }
        }
    }
}