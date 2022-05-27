using Microsoft.AspNetCore.Mvc;

namespace WebApplication1.Controllers
{
    public class HomeController:Controller
    {
        /*public ContentResult Index()
        {
            *//*return new ContentResult()
            {
                Content = "selam"
            };*//*
            return Content("selam");
        }*/
        public ViewResult Index()
        {
            var viewInd = new ViewResult();
            viewInd.ViewName = "Index";
            return viewInd;
        }


        public ViewResult About()
        {
            var view = new ViewResult();
            view.ViewName = "About";
            return view;
        }
    }
}
