using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace WisdomWaterServicePlatform.Controllers
{
    public class DefaultController : Controller
    {
        private readonly WaterContext _context;
        public DefaultController(WaterContext context)
        {
            _context = context;
        }
        // GET: Default
        public ActionResult Index()
        {
            return View();
        }

        // GET: Default/Details/5
        public ActionResult Details(string name, int id=0)
        {
            if (string.IsNullOrEmpty(name))
                return Redirect("../Sypumps/index");
            //获取设备数据
            var List = _context.Syep.Where(x=>x.id_name.Equals(name)).FirstOrDefault();
            if(List==null) return Redirect("../Sypumps/index");

            return View(List);
            //return View(await _context.Sypump.ToListAsync());

        }

        
        public ActionResult ForDetails(string name, int id = 0)
        {
            try
            {
                if (string.IsNullOrEmpty(name))
                return Json("Erorr：项目名称为空");
                //获取设备数据
                var List = _context.Syep.Where(x => x.id_name.Equals(name)).FirstOrDefault();
                //return Json(List);
                return View(List);
            }
            catch (Exception e) {
                return Json("Erorr："+e.Message);
            }
        }

        // GET: Default/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Default/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(IFormCollection collection)
        {
            try
            {
                // TODO: Add insert logic here

                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: Default/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: Default/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id, IFormCollection collection)
        {
            try
            {
                // TODO: Add update logic here

                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: Default/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: Default/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int id, IFormCollection collection)
        {
            try
            {
                // TODO: Add delete logic here

                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }
    }
}