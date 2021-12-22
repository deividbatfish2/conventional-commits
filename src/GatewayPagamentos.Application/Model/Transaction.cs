using System;
using System.Collections.Generic;

namespace GatewayPagamentos.Application.Model
{
    public class Transaction
    {
        public TransactionStatus Status { get; set; }
        public List<Installment> Installments { get; set; }

        public Transaction()
        {

        }
        public Transaction(int numberOfInstallments)
        {
            Installments = CreateInstallments(numberOfInstallments, InstallmentStatus.WaitForPayment);
        }

        private List<Installment> CreateInstallments(int numberOfInstallments, InstallmentStatus installmentStatus)
        {
            var installments = new List<Installment>();
            for (int i = 0; i < numberOfInstallments; i++)
            {
                installments.Add(new Installment
                {
                    Status = installmentStatus
                });
            }
            return installments;
        }

        public void PayInstallment(int numberOfInstallment)
        {
            var installment = Installments[numberOfInstallment];
            installment.Status = InstallmentStatus.PaidOut;
            Installments[numberOfInstallment] = installment;
        }
    }
}