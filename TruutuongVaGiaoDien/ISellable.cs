using System;

namespace TruutuongVaGiaoDien
{
    public interface ISellable
    {
        void Sell(int quantity);
        bool IsInStock();

    }
}
