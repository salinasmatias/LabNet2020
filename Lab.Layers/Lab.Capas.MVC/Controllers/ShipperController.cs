using Lab.Capas.MVC.Models;
using Lab.Demo.Logic;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Lab.Capas.MVC.Controllers
{
    public class ShipperController : Controller
    {
        // GET: Shipper
        public ActionResult Index()
        {
            var logic = new ShippersLogic();
            var shippers = logic.GetAll();
            List<ShipperView> shipperViews = (from shipper in shippers
                                              select new ShipperView()
                                              {
                                                  ShipperID = shipper.ShipperID,
                                                  CompanyName = shipper.CompanyName,
                                                  Phone = shipper.Phone
                                              }).ToList();
            return View(shipperViews);
        }
    }
}