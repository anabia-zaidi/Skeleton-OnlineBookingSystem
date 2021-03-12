using System;

namespace ClassLibrary
{
    public class clsReports
    {
        public DateTime DateAdded { get; set; }
        public int EmployeeId { get; set; }
        public int Expenses { get; set; }
        public decimal Total { get; set; }
        public bool ProfitOrLoss { get; set; }

        public bool Find(int price)
        {
            throw new NotImplementedException();
        }
    }
}