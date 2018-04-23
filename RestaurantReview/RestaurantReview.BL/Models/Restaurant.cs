using RestaurantReview.BL.Interfaces;
using System;
using System.Collections.Generic;
using System.Collections;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using RestaurantReview.BL.Models;

namespace RestaurantReview.BL
{
    public class Restaurant : IReviewable
    {
        public readonly string Name;
        public string Address { get; set; }
        public float AvgRating { get; set; }
        public List<Review> Reviews = new List<Review>();

        public Restaurant(string _name)
        {
            Name = _name;
        }

        public void AddReview(Review newReview)
        {
            Reviews.Add(newReview);
        }

        public void RespondToReview(Review rReview)
        {
            Review newReview = new Review(this.Name, "Response Review", 5);
            rReview.AddReview(newReview);
        }

        public float CalculateAVerageRating()
        {
            float total = 0.0f;
            float avg = 0.0f;
            foreach(Review r in Reviews)
            {
                total += r.Rating;
            }

            avg = total / Reviews.Count;

            return avg;
        }
    }
}
