using System;
using System.Collections.Generic;
using System.Text;

namespace ShoppingFacade
{
    public interface IUserOrder
    {
        int AddToCart(int itemId, int qty);
        int PlaceOrder(int cartID, int userID);
    }

}