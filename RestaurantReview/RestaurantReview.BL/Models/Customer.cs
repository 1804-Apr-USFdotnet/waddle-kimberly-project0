using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RestaurantReview.BL.Models
{
    public class Customer
    {
        public readonly string Name;
        
        public Customer(string newName)
        {
            Name = newName;
        }
        public void SubmitReview(Restaurant restaurant)
        {
            Review newReview = new Review(this.Name, "Customer Review", 5);
            restaurant.AddReview(newReview);
        }
    }
}
