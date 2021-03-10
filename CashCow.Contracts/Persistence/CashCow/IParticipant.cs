using CommonBase.Attributes;
using System;
using System.Collections.Generic;
using System.Text;

namespace CashCow.Contracts.Persistence.CashCow
{
    [ContractInfo(ContextType = ContextType.Table)]
    public partial interface IParticipant : IVersionable, ICopyable<IParticipant>
    {
        [ContractPropertyInfo(Required = true)]
        public string Name { get; set; }
    }
}
