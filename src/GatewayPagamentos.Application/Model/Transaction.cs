using System.Collections.Generic;

namespace GatewayPagamentos.Application.Model
{
    public class Transaction
    {
        public TransactionStatus Status { get; set; }
        public List<int> Installments { get; set; }

        public Transaction()
        {

        }
        public Transaction(int numberOfInstallments)
        {
            Installments = new List<int> { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15, 16, 17, 18, 19, 20, 21, 22, 23, 24 };
        }
    }
}