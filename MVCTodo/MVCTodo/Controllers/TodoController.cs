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

            todoList.Add(new Models.Todo() { Id = 1, Date = "2022-10-14", Content = "해야 할 일1" });
            todoList.Add(new Models.Todo() { Id = 2, Date = "2022-10-15", Content = "해야 할 일2" });
            todoList.Add(new Models.Todo() { Id = 3, Date = "2022-10-16", Content = "해야 할 일3" });
            todoList.Add(new Models.Todo() { Id = 4, Date = "2022-10-17", Content = "해야 할 일4" });
            todoList.Add(new Models.Todo() { Id = 5, Date = "2022-10-18", Content = "해야 할 일5" });

            return View(todoList);
        }

    }
}