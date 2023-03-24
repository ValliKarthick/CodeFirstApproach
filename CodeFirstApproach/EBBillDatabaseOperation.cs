using System;
using System.Data.SqlClient;
using System.Linq;

namespace CodeFirstApproach
{
    public class EBBillDatabaseOperation
    {
        public void InsertEbBill(ElectricityBillModel electricityBillModel)
        {
            var EbContext = new EBContext();
            EbContext.ElectricityBillModel.Add(electricityBillModel);
            EbContext.SaveChangesAsync();
            Console.WriteLine("Added Successfully");
            Console.ReadLine();
        }

        public void DisplayEbBill(int idToDisplay)
        {
            using (var EbContext = new EBContext())
            {
                var customerIdParameter = new SqlParameter("CustId", idToDisplay);


                var result = EbContext.ElectricityBillModel.SqlQuery
                    (
                    "exec GetResultsForEbBill @CustId", customerIdParameter)
                    .ToList<ElectricityBillModel>();

                foreach (var customer in result)
                {
                    Console.WriteLine(customer.CustomerId + "-" + customer.ContactNumber);
                }

                Console.ReadLine();
            }
        }
    }
}
