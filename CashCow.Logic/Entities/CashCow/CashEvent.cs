using CashCow.Contracts.Persistence.CashCow;
using System;
using System.Collections.Generic;
using System.Text;

namespace CashCow.Logic.Entities.CashCow
{
    internal partial class CashEvent : VersionEntity, ICashEvent
    {
        public string Title { get; set; }
        public string Description { get; set; }
        public string Currency { get; set; }
        public List<IParticipant> Participants { get; set; }
        public string Category { get; set; }
        public void CopyProperties(ICashEvent other)
        {
            Id = other.Id;
            Title = other.Title;
            RowVersion = other.RowVersion;
            Description = other.Description;
            Currency = other.Currency;
            Participants = other.Participants;
        }
    }
}
