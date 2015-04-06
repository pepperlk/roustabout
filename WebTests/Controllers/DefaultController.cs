using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace WebTests.Controllers
{
    public class DefaultController : Controller
    {
        private StringService _svc;

        public DefaultController(StringService svc)
        {
            _svc = svc;
        }

        protected override void Execute(System.Web.Routing.RequestContext requestContext)
        {
            base.Execute(requestContext);
        }

        protected override IAsyncResult BeginExecute(System.Web.Routing.RequestContext requestContext, AsyncCallback callback, object state)
        {
            return base.BeginExecute(requestContext, callback, state);
        }

        // GET: Default
        [Route("")]
        public ActionResult Index()
        {
            return Json( _svc.Get(), JsonRequestBehavior.AllowGet);
        }
    }
}