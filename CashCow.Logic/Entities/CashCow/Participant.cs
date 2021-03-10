using CashCow.Contracts.Persistence.CashCow;
using System;
using System.Collections.Generic;
using System.Text;

namespace CashCow.Logic.Entities.CashCow
{
    internal partial class Participant : VersionEntity, IParticipant
    {
        public string Name { get; set; }
        public void CopyProperties(IParticipant other)
        {
            Id = other.Id;
            RowVersion = other.RowVersion;
            Name = other.Name;
        }
    }
}
