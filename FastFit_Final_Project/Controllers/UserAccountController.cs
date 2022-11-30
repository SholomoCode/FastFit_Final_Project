using Fast_Fit_Final_Project.Model;
using Fast_Fit_Final_Project.ViewModels;
using Microsoft.AspNetCore.Mvc;

namespace Fast_Fit_Final_Project.Controllers
{
    public class UserAccountController : Controller
    {
        // GET: /<controller>/
        public IActionResult Index()
        {
            return View();
        }
        public IActionResult Add()
        {
            AddUserAccountViewModel userAccountViewModel = new AddUserAccountViewModel();
            return View(userAccountViewModel);
        }
        [HttpPost]
        public IActionResult Add(AddUserAccountViewModel addUserAccountViewModel)
        {
            if (ModelState.IsValid)
            {
                UserAccount user = new UserAccount
                {
                    Username = addUserAccountViewModel.UserName,
                    Password = addUserAccountViewModel.Password,
                    Email = addUserAccountViewModel.Email,
                };
                return Redirect("/UserAccount");
            }
            return View(addUserAccountViewModel);
        }


    }
}
