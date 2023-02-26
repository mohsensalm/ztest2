using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ISP
{
    public interface IOrder
    {
        void AddToCart();
    }

    public interface IOnlineOrder
    {
        void CcProcess();
    }

    public class OnlineOrder : IOrder, IOnlineOrder
    {
        public void AddToCart()
        {
            //Do Add to Cart
        }

        public void CcProcess()
        {
            //process through credit card
        }
    }

    public class OfflineOrder : IOrder
    {
        public void AddToCart()
        {
            //Do Add to Cart
        }
    }
}
