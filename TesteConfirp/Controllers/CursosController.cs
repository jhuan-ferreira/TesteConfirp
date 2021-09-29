using System.Linq;
using System.Web.Mvc;
using TesteConfirp.Models;
using System.Data.Entity;

namespace TesteConfirp.Controllers
{
    public class CursosController : Controller
    {
        private TesteContext db = new TesteContext();
        // GET: Cursos
        public ActionResult Index()
        {
            var cursos = db.Cursos.ToList();

            return View(cursos);
        }

        public ActionResult Adicionar()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Adicionar(Cursos cursos)
        {
            if (ModelState.IsValid)
            {
                db.Cursos.Add(cursos);
                db.SaveChanges();
                return RedirectToAction("Index", "Cursos", "Index");
            }
            return View(cursos);
        }

        public ActionResult Atualizar(long id)
        {
            Cursos cursos = db.Cursos.Find(id);
            return View(cursos);
        }

        [HttpPost]
        public ActionResult Atualizar(Cursos cursos)
        {
            if (ModelState.IsValid)
            {
                db.Entry(cursos).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index", "Cursos", "Index");
            }
            return View(cursos);
        }

        [HttpPost]
        public string Excluir(long id)
        {
            try
            {
                Cursos curso = db.Cursos.Find(id);
                db.Cursos.Remove(curso);
                db.SaveChanges();
                return bool.TrueString;
            }
            catch
            {
                return bool.FalseString;
            }
        }

    }
}