using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Services;
using Entities;

namespace BuisenessLayer
{
    class NotRegisteredUserController
    {
        private FeedbackService feedbackService = new FeedbackService();
        private ProductService productServcie = new ProductService();

        public List<Feedback> getAllFeedbacks()
        {
            return feedbackService.getAll();
        }

        public List<Product> getAllProducts()
        {
            return productServcie.getAll();
        }

        public List<Feedback> getAllFeedbacksWithProudct(int productId)
        {
            return feedbackService.getAll().FindAll(x=>x.product.id.Equals(productId));
        }

    }

    
}
