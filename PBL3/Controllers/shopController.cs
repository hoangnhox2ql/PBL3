using PagedList;
using PBL3.Models.BUS;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace PBL3.Controllers
{
    public class shopController : Controller
    {
        // GET: shop
        public ActionResult Index(int page = 1,int pagesize = 8)
        {
            var DB = PBLBus.DanhSach().ToPagedList(page, pagesize);
            return View(DB);
        }

        // GET: shop/Details/5
        public ActionResult Details(string  id)
        {
            var DB = PBLBus.Chitiet(id);
            return View(DB);
        }

        // GET: shop/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: shop/Create
        [HttpPost]
        public ActionResult Create(FormCollection collection)
        {
            try
            {
                // TODO: Add insert logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: shop/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: shop/Edit/5
        [HttpPost]
        public ActionResult Edit(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add update logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: shop/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: shop/Delete/5
        [HttpPost]
        public ActionResult Delete(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add delete logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }
    }
}
