using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Zgloszenie_WebApplication.Models;
using Zgloszenie_WebApplication.ViewModel;

namespace Zgloszenie_WebApplication.Controllers
{
    public class HomeController : Controller
    {
        private Zglaszanie_prac _db = new Zglaszanie_prac();
        public ActionResult Index()
        {
            return View();
        }

        //public ActionResult Zgloszenie(string nazwa)
        //{

        //    return View(nazwa);
        //}

        //public ActionResult Przeglad()
        //{
        //    IEnumerable<Robota_ViewModel> praca = (from pr in _db.Praca
        //                                           join ob in _db.Obreb on pr.ObrebId equals ob.ObrebId
        //                                           join gm in _db.Gmina on pr.GminaId equals gm.GminaId
        //                                           join wk in _db.Wykonawca on pr.WykonawcaId equals wk.WykonawcaId
        //                                           join sa in _db.Asortyment on pr.AsortymentId equals sa.AsortymentId
        //                                           join px in _db.Prefiks on pr.PrefiksId equals px.PrefiksId
        //                                           join st in _db.Status on pr.StatusId equals st.StatusId
        //                                           //where
        //                                           //(pr.Numer.ToString().StartsWith(numer))
        //                                           //&& (pr.Rok.ToString().StartsWith(rok))

        //                                           // && (sa.CelPracy.ToString().Contains(cel))

        //                                           //&& (ob.NazwaObreb.Contains(nazwaObreb))
        //                                           orderby pr.Rok, pr.Numer
        //                                           select new Robota_ViewModel
        //                                           {
        //                                               numer = pr.Numer,
        //                                               rok = pr.Rok,
        //                                               nazwaFirmy = wk.NazwaFirmy,
        //                                               nazwaGmina = gm.NazwaGmina,
        //                                               nazwaObreb = ob.NazwaObreb,

        //                                               numerDzialki = pr.NumerDzialki,
        //                                               celPracy = sa.CelPracy,
        //                                               dataZgloszenia = pr.DataZgloszenia,
        //                                               dataZakonczeniaPrac = pr.DataZakonczeniaPrac

        //                                           }).ToList();
        //    return View(praca);
        //}
        [Authorize]
        [HttpGet]
        public ActionResult Przeglad( )
        {
            
            //IEnumerable<Robota_ViewModel> praca = (from pr in _db.Praca
            //                                       join ob in _db.Obreb on pr.ObrebId equals ob.ObrebId
            //                                       join gm in _db.Gmina on pr.GminaId equals gm.GminaId
            //                                       join wk in _db.Wykonawca on pr.WykonawcaId equals wk.WykonawcaId
            //                                       join sa in _db.Asortyment on pr.AsortymentId equals sa.AsortymentId
            //                                       join px in _db.Prefiks on pr.PrefiksId equals px.PrefiksId
            //                                       join st in _db.Status on pr.StatusId equals st.StatusId
            //                                       where wk.AdresEmail==User.Identity.Name
            //                                       //(pr.Numer.ToString().StartsWith(numer))
            //                                       //&& (pr.Rok.ToString().StartsWith(rok))

            //                                       ////// && (sa.CelPracy.ToString().Contains(cel))

            //                                       //&& (ob.NazwaObreb.StartsWith(obreb))
            //                                       orderby pr.Rok, pr.Numer
            //                                       select new Robota_ViewModel
            //                                       {
            //                                           numer = pr.Numer,
            //                                           rok = pr.Rok,
            //                                           nazwaFirmy = wk.NazwaFirmy,
            //                                           nazwaGmina = gm.NazwaGmina,
            //                                           nazwaObreb = ob.NazwaObreb,

            //                                           numerDzialki = pr.NumerDzialki,
            //                                           celPracy = sa.CelPracy,
            //                                           dataZgloszenia = pr.DataZgloszenia,
            //                                           dataZakonczeniaPrac = pr.DataZakonczeniaPrac

            //                                       }).ToList();
            return View();
        }
        [Authorize]
        public ActionResult TableSearch(string numer="", string rok="", string obreb="")
        {
            IEnumerable<Robota_ViewModel> praca;
            if (User.Identity.Name== "admin@admin.pl")
                {
                                              praca = (from pr in _db.Praca
                                                       join ob in _db.Obreb on pr.ObrebId equals ob.ObrebId
                                                       join gm in _db.Gmina on pr.GminaId equals gm.GminaId
                                                       join wk in _db.Wykonawca on pr.WykonawcaId equals wk.WykonawcaId
                                                       join sa in _db.Asortyment on pr.AsortymentId equals sa.AsortymentId
                                                       join px in _db.Prefiks on pr.PrefiksId equals px.PrefiksId
                                                       join st in _db.Status on pr.StatusId equals st.StatusId
                                                       where

                                                       
                                                       (pr.Numer.ToString().StartsWith(numer))
                                                       && (pr.Rok.ToString().StartsWith(rok))

                                                       //// && (sa.CelPracy.ToString().Contains(cel))

                                                       && (ob.NazwaObreb.StartsWith(obreb))
                                                       orderby pr.Rok, pr.Numer
                                                       select new Robota_ViewModel
                                                       {
                                                           numer = pr.Numer,
                                                           rok = pr.Rok,
                                                           nazwaFirmy = wk.NazwaFirmy,
                                                           nazwaGmina = gm.NazwaGmina,
                                                           nazwaObreb = ob.NazwaObreb,

                                                           numerDzialki = pr.NumerDzialki,
                                                           celPracy = sa.CelPracy,
                                                           dataZgloszenia = pr.DataZgloszenia,
                                                           dataZakonczeniaPrac = pr.DataZakonczeniaPrac

                                                       }).ToList();
            }
            else
            {
                                              praca = (from pr in _db.Praca
                                                       join ob in _db.Obreb on pr.ObrebId equals ob.ObrebId
                                                       join gm in _db.Gmina on pr.GminaId equals gm.GminaId
                                                       join wk in _db.Wykonawca on pr.WykonawcaId equals wk.WykonawcaId
                                                       join sa in _db.Asortyment on pr.AsortymentId equals sa.AsortymentId
                                                       join px in _db.Prefiks on pr.PrefiksId equals px.PrefiksId
                                                       join st in _db.Status on pr.StatusId equals st.StatusId
                                                       where

                                                       wk.AdresEmail == User.Identity.Name &&
                                                       (pr.Numer.ToString().StartsWith(numer))
                                                       && (pr.Rok.ToString().StartsWith(rok))

                                                       //// && (sa.CelPracy.ToString().Contains(cel))

                                                       && (ob.NazwaObreb.StartsWith(obreb))
                                                       orderby pr.Rok, pr.Numer
                                                       select new Robota_ViewModel
                                                       {
                                                           numer = pr.Numer,
                                                           rok = pr.Rok,
                                                           nazwaFirmy = wk.NazwaFirmy,
                                                           nazwaGmina = gm.NazwaGmina,
                                                           nazwaObreb = ob.NazwaObreb,

                                                           numerDzialki = pr.NumerDzialki,
                                                           celPracy = sa.CelPracy,
                                                           dataZgloszenia = pr.DataZgloszenia,
                                                           dataZakonczeniaPrac = pr.DataZakonczeniaPrac

                                                       }).ToList();
            }

            return PartialView(praca);
        }
        [Authorize]
        public ActionResult ZgloszeniePracy()
        {

            IEnumerable<Gmina> gm = _db.Gmina.ToList();
            IEnumerable<Obreb> ob = _db.Obreb.ToList();

            Gmina_ObrebViewModel gO = new Gmina_ObrebViewModel()
            {
                Gminas = gm,
                Obrebs=ob
           
           };
           
        
            return View(gO);
        }

        [HttpPost]
        public ActionResult DodajZgloszenie(Praca praca)
        {
            praca.Aktualne = true;
            if (ModelState.IsValid)
            {
                _db.Praca.Add(praca);
                _db.SaveChanges();
                return RedirectToAction("Index");
            }

            ViewBag.RodzpracyId = new SelectList(_db.RodzPracy, "RodzPracyId", "RodzPracyId", praca.RodzpracyId);
            ViewBag.PrefiksId = new SelectList(_db.Prefiks, "PrefiksId", "NazwaAtrubutu", praca.PrefiksId);
            ViewBag.UzytkownikId = new SelectList(_db.Uzytkownik, "UzytkownikId", "Imie", praca.UzytkownikId);
            ViewBag.WykonawcaId = new SelectList(_db.Wykonawca, "WykonawcaId", "NazwaFirmy", praca.WykonawcaId);
            return View(praca);
        }
        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}