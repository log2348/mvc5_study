using MVCStudy.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MVCStudy.Controllers
{
    public class HelloWorldController : Controller
    {
        // GET: HelloWorld
        public ActionResult Index()
        {
            List<string> lstFruit = new List<string>();
            lstFruit.Add("사과");
            lstFruit.Add("바나나");
            lstFruit.Add("참외");

            IndexModel model = new IndexModel();
            model.Id = 1;
            model.Name = "Name";

            model.FruitList = lstFruit;

            return View(model);
        }

        public ActionResult BoardList()
        {
            // BoardListModel 인스턴스 생성
            // 5개 정도 데이터 작성
            // View에 반환
            // cshtml에 foreach문을 사용해서 데이터 바인딩

            List<BoardListModel> list = new List<BoardListModel>();

            List<string> boardList = new List<string>();

            BoardListModel model1 = new BoardListModel();
            model1.Title = "제목1";
            model1.Writer = "작성자1";
            model1.Content = "내용";

            BoardListModel model2 = new BoardListModel();
            model1.Title = "제목1";
            model1.Writer = "작성자1";
            model1.Content = "내용";

            BoardListModel model3 = new BoardListModel();
            model1.Title = "제목1";
            model1.Writer = "작성자1";
            model1.Content = "내용";

            list.Add(model1);
            list.Add(model2);
            list.Add(model3);

            return View(list);
        }
    }
}