using CRUD_application_2.Models;
using System.Linq;
using System.Web.Mvc;
 
namespace CRUD_application_2.Controllers
{
    public class UserController : Controller
    {
        public static System.Collections.Generic.List<User> userlist = new System.Collections.Generic.List<User>();
        // GET: User
        [HttpGet]
        public ActionResult Index()
        {
            // return all the users from userlist
            return View(userlist);
        }

        // GET: User/Details/5
        [HttpGet]
        public ActionResult Details(int id)
        {
            var user = userlist.FirstOrDefault(u => u.Id == id);
            return View(user);
        }

        // GET: User/Create
        [HttpGet]
        public ActionResult Create()
        {
            // create a new user
            User newUser = new User();
            return View(newUser);
        }

        // POST: User/Create
        [HttpPost]
        public ActionResult Create(User user)
        {
            // add the user to the userlist
            userlist.Add(user);
            return View(user);
        }

        // GET: User/Edit/5
        // specify the route for the Edit method

        [HttpGet]
        public ActionResult Edit(int id)
        {
            // This method is responsible for displaying the view to edit an existing user with the specified ID.
            // It retrieves the user from the userlist based on the provided ID and passes it to the Edit view.
            var userToUpdate = userlist.FirstOrDefault(u => u.Id == id);
            return View(userToUpdate);

        }

        // POST: User/Edit/5
        [HttpPost]
        public ActionResult Edit(int id, User user)
        {
            // This method is responsible for handling the HTTP POST request to update an existing user with the specified ID.
            // It receives user input from the form submission and updates the corresponding user's information in the userlist.
            // If successful, it redirects to the Index action to display the updated list of users.
            // If no user is found with the provided ID, it returns a HttpNotFoundResult.
            // If an error occurs during the process, it returns the Edit view to display any validation errors.
            var userToUpdate = userlist.FirstOrDefault(u => u.Id == id);
            userToUpdate.Name = user.Name;
            userToUpdate.Email = user.Email;
            return View(userToUpdate);
        }
 
        // GET: User/Delete/5
        public ActionResult Delete(int id)
        {
            // delete the user from the userlist
            var userToDelete = userlist.FirstOrDefault(u => u.Id == id);
            userlist.Remove(userToDelete);
            return View(userToDelete);
        }

        // POST: User/Delete/5
        [HttpPost]
        public ActionResult Delete(int id, FormCollection collection)
        {
            // Implement the Delete method (POST) here

            // This method is responsible for handling the HTTP POST request to delete an existing user with the specified ID.
            // It retrieves the user from the userlist based on the provided ID and removes it from the list.

            var userToDelete = userlist.FirstOrDefault(u => u.Id == id);
            userlist.Remove(userToDelete);
            return View(userToDelete);
        }
    }
}
