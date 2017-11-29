using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entities;
using Services;

namespace BuisenessLayer
{
    public class Session
    {
        private User user;
        private FeedbackService feedbackService  = new FeedbackService();
        private UserService userService = new UserService();
        private ProductService productService = new ProductService();

        public Session(User user)
        {
            this.user = user;
        }

        public List<Feedback> getAllFeedbacksWithProudct(int productId)
        {
            return feedbackService.getAll().FindAll(x => x.product.id.Equals(productId));
        }

        public void changePassword(String password)
        {
            user.password = getHasedPassword(password);
            userService.update(user);
        }

        public List<Product> getAllProducts()
        {
            return productService.getAll();
        }

        public void leaveFeedback(int productId,String comment)
        {
            Feedback feedback = new Feedback();
            feedback.user = user;
            feedback.product = productService.getById(productId);
            feedback.comment = comment;
            feedback.date = DateTime.Now;
            feedbackService.add(feedback);

        }

        public bool checkPassword(String password)
        {
            return getHasedPassword(password).Equals(user.password);
        }


        public List<Feedback> getMyFeedbacks()
        {
            return feedbackService.getAllByUserId(user.id);
        }

        public List<Feedback> getAllFeedbacks()
        {
            return feedbackService.getAll();
        }

        private String getHasedPassword(String password)
        {
            var bytes = new UTF8Encoding().GetBytes(password);
            var hashBytes = System.Security.Cryptography.MD5.Create().ComputeHash(bytes);
            return Convert.ToBase64String(hashBytes);
        }
    }
}
