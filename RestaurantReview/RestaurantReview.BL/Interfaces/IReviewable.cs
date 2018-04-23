using RestaurantReview.BL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RestaurantReview.BL.Interfaces
{
    interface IReviewable
    {
        void AddReview(Review newReview);
        void RespondToReview(Review rReview);
        float CalculateAVerageRating();
    }
}
