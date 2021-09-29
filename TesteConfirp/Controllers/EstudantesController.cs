using System.Linq;
using System.Web;
using System.Web.Mvc;
using TesteConfirp.Models;
using System.Data.Entity;

namespace TesteConfirp.Controllers
{
    public class EstudantesController : Controller
    {
        private TesteContext db = new TesteContext();
        // GET: Estudantes
        public ActionResult Index()
        {
            var estudantes = db.Estudantes.ToList();
            return View(estudantes);
        }

        public ActionResult Adicionar()
        {
            ViewBag.Cursos = new SelectList(db.Cursos, "Id", "Descricao","Id");
            return View();
        }

        [HttpPost]
        public ActionResult Adicionar(Estudantes estudante)
        {
            if(ModelState.IsValid)
            {
                db.Estudantes.Add(estudante);
                db.SaveChanges();
            }

            ViewBag.Cursos = new SelectList(db.Cursos, "Id", "Descricao");
            return RedirectToAction("Index", "Estudantes", "Index");
        }

        public ActionResult Atualizar(long id)
        {
            var estudante = db.Estudantes.Find(id);
            ViewBag.Cursos = new SelectList(db.Cursos, "Id", "Descricao");
            return View(estudante);
        }

        [HttpPost]
        public ActionResult Atualizar(Estudantes estudante)
        {
            if (ModelState.IsValid)
            {
                db.Entry(estudante).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index", "Estudantes", "Index");
            }
            return View(estudante);
        }
        
        [HttpPost]
        public string Delete (long id )
        {
            try
            {
                Estudantes estudante = db.Estudantes.Find(id);
                db.Estudantes.Remove(estudante);
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