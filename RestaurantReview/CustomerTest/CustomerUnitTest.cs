using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using RestaurantReview.BL;
using RestaurantReview.BL.Models;

namespace RestaurantReviewUnitTest
{
    [TestClass]
    public class RestaurantTest
    {
        [TestMethod]
        public void TestSubmitReview()
        {
            //Arrange
            Customer customer = new Customer("John Doe");
            Restaurant rest = new Restaurant("McDonald's");
            int numReviews = rest.Reviews.Count;

            //Act
            customer.SubmitReview(rest);

            //Assert
            Assert.IsTrue(numReviews + 1 == rest.Reviews.Count);
        }
    }
}
