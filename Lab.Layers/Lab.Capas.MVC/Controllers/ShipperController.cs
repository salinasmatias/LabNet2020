using Lab.Capas.MVC.Models;
using Lab.Demo.Data;
using Lab.Demo.Entities;
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

        public ActionResult Insert()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Insert(ShipperView shipper)
        {
            var logic = new ShippersLogic();
            var shipperEntity = new Shipper()
            {
                CompanyName = shipper.CompanyName,
                Phone = shipper.Phone
            };
            logic.Insert(shipperEntity);

            return RedirectToAction("Index");
        }

        public ActionResult Delete(int id)
        {
            var logic = new ShippersLogic();
            logic.Delete(logic.GetByID(id));
            return RedirectToAction("Index");
        }

        public ActionResult Update(int id)
        {
            return View(new ShipperView() {ShipperID = id });
        }
        
        [HttpPost]
        public ActionResult Update(ShipperView shipper)
        {
            var logic = new ShippersLogic();
            var shipperEntity = new Shipper()
            {
                ShipperID = shipper.ShipperID,
                CompanyName = shipper.CompanyName,
                Phone = shipper.Phone
            };
            logic.Update(shipperEntity);
            return RedirectToAction("Index");
        }
    }
}