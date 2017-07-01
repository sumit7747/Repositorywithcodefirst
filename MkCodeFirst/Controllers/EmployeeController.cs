using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using MkCodeFirst.Models;
using MkCodeFirst.UnitofWork;

namespace MkCodeFirst.Controllers
{
    public class EmployeeController : Controller
    {
        private UnitofWorks uow = null;
        //
        // GET: /Emloyees/

        public EmployeeController()
        {
            uow = new UnitofWorks();
        }

        public EmployeeController(UnitofWorks uow_)
        {
            this.uow = uow_;
        }

        public ActionResult Index()
        {
            return View(uow.Repository<Emloyee>().GetAll().ToList());
        }


        public ActionResult Create()
        {
            return View();
        }

        //
        // POST: /Emloyees/Create

        [HttpPost]
        public ActionResult Create(Emloyee Emloyee)
        {
            if (ModelState.IsValid)
            {
                uow.Repository<Emloyee>().Insert(Emloyee);
                uow.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(Emloyee);
        }









    }
}
