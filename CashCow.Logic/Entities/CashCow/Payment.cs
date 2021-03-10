using CashCow.Contracts.Persistence.CashCow;
using System;
using System.Collections.Generic;
using System.Text;

namespace CashCow.Logic.Entities.CashCow
{
    internal partial class Payment : VersionEntity, IPayment
    {
        public DateTime Date { get; set; }
        public IParticipant Participant { get; set; }
        public double Amount { get; set; }
        public string Title { get; set; }

        public void CopyProperties(IPayment other)
        {
            Id = other.Id;
            Participant = other.Participant;
            Amount = other.Amount;
            RowVersion = other.RowVersion;
            Title = other.Title;
            Date = other.Date;
        }
    }
}
}
