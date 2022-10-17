using MyMiniBoard.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MyMiniBoard.Controllers
{
    public class BoardController : Controller
    {
        // GET: Board
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Board()
        {
            List<Board> boardList = new List<Board>
            {
                new Board {Id = 1, State = "오픈", Title = "DB의 약자는 무엇인가요?", CreatedDate = DateTime.Now, Writer = "오해석", Views = 1},
                new Board {Id = 2, State = "오픈", Title = "DB의 약자는 무엇인가요?", CreatedDate = DateTime.Now, Writer = "고수임", Views = 10},
                new Board {Id = 3, State = "접수됨", Title = "제약조건의 종류는 어떤 것이 있나요?", CreatedDate = DateTime.Now, Writer = "오인경", Views = 43},
                new Board {Id = 4, State = "진행중", Title = "DB의 약자는 무엇인가요?", CreatedDate = DateTime.Now, Writer = "오해석", Views = 16},
                new Board {Id = 5, State = "완료됨", Title = "DB의 약자는 무엇인가요?", CreatedDate = DateTime.Now, Writer = "오해석", Views = 22},
                new Board {Id = 6, State = "완료됨", Title = "DB의 약자는 무엇인가요?", CreatedDate = DateTime.Now, Writer = "오해석", Views = 56},
                new Board {Id = 7, State = "완료됨", Title = "DB의 약자는 무엇인가요?", CreatedDate = DateTime.Now, Writer = "오해석", Views = 17},

            };
            
            ViewBag.SearchType = new List<SelectListItem>
            {
                new SelectListItem { Text = "제목", Value = "제목" },
                new SelectListItem { Text = "내용", Value = "내용" },
                new SelectListItem { Text = "번호", Value = "번호" },
                new SelectListItem { Text = "작성자", Value = "작성자" },
            };

            ViewData["State"] = new List<SelectListItem>
            {
                new SelectListItem { Text = "오픈", Value = "오픈" },
                new SelectListItem { Text = "접수됨", Value = "접수됨" },
                new SelectListItem { Text = "진행중", Value = "진행중" },
                new SelectListItem { Text = "완료됨", Value = "완료됨" },
            };

            return View(boardList);
        }

        public ActionResult PostBoard()
        {
            return View();
        }

        public ActionResult BoardDetail()
        {
            return View();
        }

        public ActionResult Post(Board board)
        {
            board.Writer = "박지현";

            return View("BoardDetail", board);
        }
    }
}