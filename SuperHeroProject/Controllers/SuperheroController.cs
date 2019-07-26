using SuperHeroProject.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace SuperHeroProject.Controllers
{
    public class SuperheroController : Controller
    {
		ApplicationDbContext context;
		public SuperheroController()
		{
			context = new ApplicationDbContext();
		}
        // GET: Superhero
        public ActionResult Index()
        {
			IEnumerable<Superhero> superheroes = context.Superheroes;
            return View(superheroes);
        }

        // GET: Superhero/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: Superhero/Create
        public ActionResult Create()
        {
			Superhero superhero = new Superhero();
            return View(superhero);
        }

        // POST: Superhero/Create
        [HttpPost]
        public ActionResult Create(Superhero superhero)
        {
            try
            {
				context.Superheroes.Add(superhero);
				context.SaveChanges();
                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: Superhero/Edit/5
        public ActionResult Edit(int id)
        {
			Superhero superhero = context.Superheroes.Where(e => e.Id == id).FirstOrDefault();
            return View(superhero);
        }

        // POST: Superhero/Edit/5
        [HttpPost]
        public ActionResult Edit(int id, Superhero superhero)
        {
            try
            {
				Superhero foundSuperhero = context.Superheroes.Where(e => e.Id == id).FirstOrDefault();
				foundSuperhero.FirstName = superhero.FirstName;
				foundSuperhero.LastName = superhero.LastName;
				foundSuperhero.AlterEgo = superhero.AlterEgo;
				foundSuperhero.SuperheroAbility = superhero.SuperheroAbility;
				foundSuperhero.SecondSuperheroAbility = superhero.SecondSuperheroAbility;
				foundSuperhero.Catchphrase = superhero.Catchphrase;
				context.SaveChanges();
                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: Superhero/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: Superhero/Delete/5
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
