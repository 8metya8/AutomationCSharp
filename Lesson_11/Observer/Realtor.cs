﻿namespace Lesson_11
{
    internal class Realtor : ISubscriber
    {
        public int ExpectedPrice;

        public Realtor(int expectedPrice)
        {
            ExpectedPrice = expectedPrice;
        }

        public void Update(Flat flat)
        {
            if( (flat.Price < ExpectedPrice) || (flat.Price == ExpectedPrice))
            {
                Console.WriteLine("Price has been decreased!");
                Console.WriteLine($"New price - {flat.Price}$, address - {flat.Address}");
            }            
        }
    }
}
