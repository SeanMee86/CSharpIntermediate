using System;

namespace Inheritance
{
    public class Customer
    {
        public int Id { get; set; }
        public string Name { get; set; }

        public void Promote()
        {
            bool excludeOrders = true;
            var rating = CalculateRating(excludeOrders);
            if(rating == 0)
                Console.WriteLine("Promoted to level 1");
            else
                Console.WriteLine("Promoted to level 2");
        }

        private int CalculateRating(bool excludeOrders)
        {
            return 0;
        }
    }
}
