using MVCTodo.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Web;
using System.Web.Mvc;

namespace MVCTodo.Controllers
{
    public class TestController : Controller
    {
        // GET: Test
        public ActionResult Test()
        {
            TestModel test = new TestModel();
            test.Id = 1;
            test.Name = "TEST";
            
            return View(test);
        }

        /**
         * ContentResult
         * Text 결과를 표현
         * ContentType 속성 변경 시 HTML 표현 가능
         */
        public ContentResult Content1()
        {
            ContentResult cr = new ContentResult();
            cr.Content = "MostiSoft 기술 세미나";
            return cr;
        }

        public ContentResult Content2()
        {
            ContentResult cr = new ContentResult();
            cr.ContentType = "text/html";
            cr.Content = "<font color='red'>MostiSoft</font> 입니다";

            return cr;
        }

        /*
        public FileStreamResult Content3()
        {
            // 파일 다운로드시 사용
            // 다운로드 가능한 파일을 Stream으로 표현
            System.IO.FileStream fs = new System.IO.FileStream(@"D:\Log\ServiceLayer\20150321.__Anonymous.1.log", System.IO.FileMode.Open);​

            FileStreamResult fsr = new FileStreamResult(fs, System.Net.Mime.MediaTypeNames.Application.Octet.ToString());​

            fsr.FileDownloadName = "myfile.log";​
    ​
            return fsr;​
        }
        */

        /**
         * HttpStatusCodeResult
         * Http 상태코드 반환
         * Application은 이 Response Code 값에 따라서 적절하게 반응
         */
        public HttpStatusCodeResult Content4()
        {
            return new HttpStatusCodeResult(401);
        }

        /**
         * JavaScriptResult
         * javascript 코드 return
         * 브라우저에 다운로드 된(view명 .js 파일)
         */
        public JavaScriptResult Content5()
        {
            JavaScriptResult jsr = new JavaScriptResult();
            jsr.Script = "<script>alert('MostiSoft 기술세미나');</script>";

            return jsr;
        }

        /**
         * JsonResult
         * Model을 json 형태로 반환
         */
        public JsonResult Content6()
        {
            TestModel tm = new TestModel();
            tm.Id = 1;
            tm.Name = "박지현";

            return Json(tm, JsonRequestBehavior.AllowGet);
        }

    }
}