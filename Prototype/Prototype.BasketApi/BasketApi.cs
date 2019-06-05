using Prototype.BasketApi.Model;
using System;

namespace Prototype.BasketApi
{
    public class BasketEndPoint
    {
        public  BasketMatch Get()
        {
            return new BasketMatch(1, "Raptors", "Warriors", 104, 109);
        }
    }
}
