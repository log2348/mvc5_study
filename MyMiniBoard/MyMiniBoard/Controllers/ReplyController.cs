using MyMiniBoard.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MyMiniBoard.Controllers
{
    public class ReplyController : Controller
    {
        public JsonResult Post(Reply reply)
        {
            reply.Writer = "박지현";
            reply.CreatedDate = DateTime.Now.ToString("yyyy-MM-dd");

            return Json(reply);
        }
    }
}