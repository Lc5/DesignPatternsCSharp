namespace DesignPatterns.Other.Behavioral.Specification
{
    using System;

    public class Invoice
    {
        public Invoice(int id, decimal amount, DateTime dueDate)
        {
            this.Id = id;
            this.Amount = amount;
            this.DueDate = dueDate;
        }

        public decimal Amount { get; set; }

        public DateTime DueDate { get; set; }

        public int Id { get; set; }

        public int NoticeCount { get; set; }

        public bool SentToCollectionAgency { get; set; }

        public void SendToCollection()
        {
            this.SentToCollectionAgency = true;

            Console.WriteLine("Invoice {0} was sent to collection.", this.Id);
        }
    }
}