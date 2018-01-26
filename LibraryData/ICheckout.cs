using LibraryData.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace LibraryData
{
    public interface ICheckout
    {
        IEnumerable<CheckOut> GetAll();
        CheckOut GetById(int checkoutId);
        void Add(CheckOut newCheckout);
        void CheckOutItem(int assetId, int LibraryCardId);
        void CheckInItem(int assetId, int libraryCardId);
        IEnumerable<CheckoutHistory> GetCheckoutHistory(int id);

        void PlaceHold(int assetId, int libraryCardId);
        CheckOut GetLatestCHeckout(int assetId);
        string GetCurrentHoldClientName(int id);
        DateTime GetCurrentHoldPlaced(int id);
        IEnumerable<Hold> GetCurrentHolds(int id);

        void MarkLost(int assetId);
        void MarkFound(int assetId);
    }
}
