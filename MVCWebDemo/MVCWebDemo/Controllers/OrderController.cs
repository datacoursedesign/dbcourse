using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MVCWebDemo.Controllers
{
    public class OrderController : Controller
    {
        //
        // GET: /Order/
        public ActionResult Index()
        {
            return View();
        }

        public void QueryOrder(string order_id)
        {

        }


        public void TracePackage(string order_id)
        {
            
        }

        //新建订单 所有信息 
        public void CreateOrder(Dictionary<string,string> info)
        {
           
        }

        //修改订单信息
        public void EditOrder()
        {

        }
        
	}
}