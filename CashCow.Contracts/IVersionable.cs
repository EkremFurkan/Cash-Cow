using System;
using System.Collections.Generic;
using System.Text;

namespace CashCow.Contracts
{
    public partial interface IVersionable : IIdentifiable
    {
        public byte[] RowVersion { get; set; }
    }
}
