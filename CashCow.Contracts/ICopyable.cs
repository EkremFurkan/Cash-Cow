using System;
using System.Collections.Generic;
using System.Text;

namespace CashCow.Contracts
{
    public partial interface ICopyable<T>
    {
        void CopyProperties(T other);
    }
}
