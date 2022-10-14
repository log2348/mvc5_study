using MVCTodo.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MVCTodo.Controllers
{
    public class TodoController : Controller
    {
        // GET: Todo
        public ActionResult Todo()
        {
            List<Todo> todoList = new List<Todo>();

            Todo t1 = new Todo();
            t1.Date = "2022-10-14";
            t1.Content = "해야 할 일1";

            Todo t2 = new Todo();
            t2.Date = "2022-10-15";
            t2.Content = "해야 할 일2";

            Todo t3 = new Todo();
            t3.Date = "2022-10-16";
            t3.Content = "해야 할 일3";

            Todo t4 = new Todo();
            t4.Date = "2022-10-17";
            t4.Content = "해야 할 일4";

            Todo t5 = new Todo();
            t5.Date = "2022-10-18";
            t5.Content = "해야 할 일5";

            todoList.Add(t1);
            todoList.Add(t2);
            todoList.Add(t3);
            todoList.Add(t4);
            todoList.Add(t5);

            return View(todoList);
        }

    }
}