using MVCTodo.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Web;
using System.Web.Mvc;

namespace MVCTodo.Controllers
{
    public class GetPostTestController : Controller
    {
        // GET: GetPostTest

        public ActionResult Index()
        {
            return View();
        }

        // GET
        public string GetTest(string param1)
        {
            return param1;
        }

        // POST
        public string PostTest(string txtPost1, string txtPost2, string txtPost3)
        {
            StringBuilder sb = new StringBuilder();

            sb.Append(txtPost1);
            sb.Append(txtPost2);
            sb.Append(txtPost3);

            return sb.ToString();
        }

        public string PostModelTest(PostModel postModel)
        {
            return "아이디 : " + postModel.Id + " 제목 : " + postModel.Title;
        }
    }
}