namespace CodeFirstApproach
{
    public class Program
    {
        public static void Main(string[] args)
        {
            ElectricityBillModel electricityBillModel = new ElectricityBillModel();
            electricityBillModel.ContactNumber = "1234567890";
            electricityBillModel.Location = "Chennai";
            electricityBillModel.UnitConsumed = 200;

            EBBillDatabaseOperation eBBillDatabaseOperation = new EBBillDatabaseOperation();
            //eBBillDatabaseOperation.InsertEbBill(electricityBillModel);

            int IdToDisplay = 1;
            eBBillDatabaseOperation.DisplayEbBill(IdToDisplay);
        }
    }
}
