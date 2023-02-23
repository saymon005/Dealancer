using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Threading.Tasks;
using System.Net;
using System.Web;
using System.Web.Mvc;
using ProjectPrepared.Models;

namespace ProjectPrepared.Controllers
{
    public class viewapplicantsController : Controller
    {
        private projectDBEntities db = new projectDBEntities();

        // GET: viewapplicants
        public async Task<ActionResult> Index()
        {
            return View(await db.viewapplicants.ToListAsync());
        }

        // GET: viewapplicants/Details/5
        public async Task<ActionResult> Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            viewapplicant viewapplicant = await db.viewapplicants.FindAsync(id);
            if (viewapplicant == null)
            {
                return HttpNotFound();
            }
            return View(viewapplicant);
        }

        // GET: viewapplicants/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: viewapplicants/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> Create([Bind(Include = "appID,appName,appLocation,appPhone,appEmail,appRegDate,appTypes")] viewapplicant viewapplicant)
        {
            if (ModelState.IsValid)
            {
                db.viewapplicants.Add(viewapplicant);
                await db.SaveChangesAsync();
                return RedirectToAction("Index");
            }

            return View(viewapplicant);
        }

        // GET: viewapplicants/Edit/5
        public async Task<ActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            viewapplicant viewapplicant = await db.viewapplicants.FindAsync(id);
            if (viewapplicant == null)
            {
                return HttpNotFound();
            }
            return View(viewapplicant);
        }

        // POST: viewapplicants/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> Edit([Bind(Include = "appID,appName,appLocation,appPhone,appEmail,appRegDate,appTypes")] viewapplicant viewapplicant)
        {
            if (ModelState.IsValid)
            {
                db.Entry<viewapplicant>(viewapplicant).State = EntityState.Modified;
                await db.SaveChangesAsync();
                return RedirectToAction("Index");
            }
            return View(viewapplicant);
        }

        // GET: viewapplicants/Delete/5
        public async Task<ActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            viewapplicant viewapplicant = await db.viewapplicants.FindAsync(id);
            if (viewapplicant == null)
            {
                return HttpNotFound();
            }
            return View(viewapplicant);
        }

        // POST: viewapplicants/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> DeleteConfirmed(int id)
        {
            viewapplicant viewapplicant = await db.viewapplicants.FindAsync(id);
            db.viewapplicants.Remove(viewapplicant);
            await db.SaveChangesAsync();
            return RedirectToAction("Index");
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }
        public ActionResult viewearning()
        {
            return View();
        }

        public ActionResult viewtransaction()
        {

            var fetch = db.transacts.ToList();
            return View(fetch);
        }

    }
}
