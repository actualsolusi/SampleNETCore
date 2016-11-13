using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

using SampleNETCore.Models;
using SampleNETCore.DAL;

// For more information on enabling MVC for empty projects, visit http://go.microsoft.com/fwlink/?LinkID=397860

namespace SampleNETCore.Controllers
{
    public class CategoriesController : Controller
    {
        // GET: /<controller>/
        public IActionResult Index()
        {
            CategoryDAL categoryDAL = new CategoryDAL();
            return View(categoryDAL.GetAll());
        }
    }
}
