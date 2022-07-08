using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Tsmc.Interface;

namespace Tsmc.Tioc.Controllers
{
    public class ProjectInfoController : Controller
    {
        public IProjectInfo _ProjectInfo { get; set; }
        // GET: ProjectInfo
        public ActionResult Index()
        {
            _ProjectInfo.Itest();
            return Content("123123123123");
        }
    }
}