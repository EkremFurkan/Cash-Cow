using System;
using System.Collections.Generic;
using System.Text;

namespace CashCow.Contracts
{
    public partial interface IIdentifiable
    {
        public int Id { get; }
    }
}
