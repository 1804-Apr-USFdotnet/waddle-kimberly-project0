using RestaurantReview.BL.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RestaurantReview.BL.Models
{
    public class Review : IReviewable
    {
        private string Reviewer;
        private string Text { get; set; }
        private List<Review> Responses = new List<Review>();

        public Review(string submitter, string newText, float rating)
        {
            Reviewer = submitter;
            Text = newText;
            Rating = rating;
        }

        public void AddReview(Review newReview)
        {
            Responses.Add(newReview);
        }

        public void RespondToReview(Review rReview)
        {
            
        }

        public float CalculateAVerageRating()
        {
            return 0;
        }

        public float Rating
        {
            get
            {
                return Rating;
            }
            set
            {

            }
        }
    }
}
