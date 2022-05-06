using Microsoft.AspNetCore.Mvc;
using MyDBProject.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;


namespace MyDBProject.Controllers
{
    public class BankController : Controller
    {
        private readonly BankDbContext bk;
        public BankController(BankDbContext bb)
        {
            bk = bb;
        }

        public IActionResult Index()
        {
            return View(bk.Banks.ToList());
        }

        public IActionResult Detaile(int Id)
        {
            var a = bk.Banks.FirstOrDefault(g => g.Bank_id == Id);
            return View(a);
        }

        public IActionResult Create()
        {
          
            return View();
        }

        public IActionResult CreateBank(Bank obj)
        {
            bk.Banks.Add(obj);
            bk.SaveChanges();
            return RedirectToAction("Index");
            
        }

        public IActionResult Delete(int id)
        {
            var a = bk.Banks.FirstOrDefault(g => g.Bank_id == id);
            return View(a);
           
        }
        public IActionResult Deleted(Bank obj)
        {
            bk.Banks.Remove(obj);
            bk.SaveChanges();
            return RedirectToAction("Index");

        }

        public IActionResult Edit(int id)
        {
            var a = bk.Banks.FirstOrDefault(g => g.Bank_id == id);
            return View(a);

        }
        public IActionResult EditDetail(Bank obj)
        {
            bk.Entry(obj).State = Microsoft.EntityFrameworkCore.EntityState.Modified;
            bk.SaveChanges();
            return RedirectToAction("Index");

        }

    }
}
