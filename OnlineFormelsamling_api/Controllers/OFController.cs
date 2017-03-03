using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using RepoOF;
using RepoOF.Helpers;

namespace OnlineFormelsamling_api.Controllers
{
    public class OFController : ApiController
    {
        // GET api/<controller>
        public IEnumerable<string> Get()
        {
            return new string[] { "value1", "value2" };
        }

        // GET api/<controller>/5
        public string Get(int id)
        {
            return "value";
        }

        // POST api/<controller>
        public void Post([FromBody]string value)
        {
        }

        // PUT api/<controller>/5
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE api/<controller>/5
        public void Delete(int id)
        {
        }

        Areal areal = new Areal();
        RumfangOgOverflade ROO = new RumfangOgOverflade();


        FormlerOFFac fof = new FormlerOFFac();

        // GET: Home
        [Route("api/OF/GetPosts")]
        [HttpGet]
        public IEnumerable<FormlerOF> GetPosts()
        {
            return fof.GetAll();
        }

        [Route("api/OF/Index/{id}")]
        [HttpGet]
        public FormlerOF Index(int id)
        {
            return fof.Get(id);
        }


        //▼▼▼Matematiske ting▼▼▼

        //▼▼▼Cirkel▼▼▼
        [Route("api/OF/Udregninger/{id}")]
        [HttpGet]
        public FormlerOF Cirkelstring (/*string radius1*/ int id)
        {
            //double rad1 = Convert.ToDouble(radius1);

            //double result1 = areal.CirkelAreal(rad1);

            return fof.Get(id);
        }

        //[HttpPost]
        //public ActionResult Cirkel(string radius1, string radius2, string diameter)
        //{
        //    //▼▼▼Cirklens Areal▼▼▼

        //    double rad1 = Convert.ToDouble(radius1);

        //    ViewBag.result1 = areal.CirkelAreal(rad1);

        //    //▼▼▼Cirklens Omkreds regnet med radius▼▼▼

        //    double rad2 = Convert.ToDouble(radius2);

        //    ViewBag.result2 = areal.CirkelOmkredsRad(rad2);


        //    //▼▼▼Cirklens Omkreds regned med diameter▼▼▼
        //    double dia = Convert.ToDouble(diameter);

        //    ViewBag.result3 = areal.CirkelOmkredDia(dia);

        //    return View();
        //}

        ////▼▼▼Rektangel▼▼▼

        //public ActionResult Rektangel()
        //{

        //    return View();
        //}

        //[HttpPost]
        //public ActionResult Rektangel(string laengde1, string bredte1, string laengde2, string bredte2)
        //{

        //    //▼▼▼Rektanglens Areal▼▼▼
        //    double laengd1 = Convert.ToDouble(laengde1);
        //    double bredt1 = Convert.ToDouble(bredte1);

        //    ViewBag.result1 = areal.RektangelAreal(laengd1, bredt1);

        //    //▼▼▼Rektanglens Omkreds▼▼▼
        //    double laengd2 = Convert.ToDouble(laengde2);
        //    double bredt2 = Convert.ToDouble(bredte2);

        //    ViewBag.result2 = areal.RektangelOmkreds(laengd2, bredt2);

        //    return View();
        //}


        ////▼▼▼Trapez▼▼▼

        //public ActionResult Trapez()
        //{

        //    return View();
        //}

        //[HttpPost]
        //public ActionResult Trapez(string hoejde, string side1, string side2)
        //{
        //    double hoejd = Convert.ToDouble(hoejde);
        //    double s1 = Convert.ToDouble(side1);
        //    double s2 = Convert.ToDouble(side2);

        //    ViewBag.result = areal.TrapezAreal(hoejd, s1, s2);

        //    return View();
        //}

        ////▼▼▼Parallelogram▼▼▼

        //public ActionResult Parallelogram()
        //{

        //    return View();
        //}

        //[HttpPost]
        //public ActionResult Parallelogram(string hoejde, string grundlinje)
        //{
        //    double hoejd = Convert.ToDouble(hoejde);
        //    double GL = Convert.ToDouble(grundlinje);

        //    ViewBag.result = areal.ParallelogramAreal(hoejd, GL);

        //    return View();
        //}

        ////▼▼▼Trekant▼▼▼

        //public ActionResult Trekant()
        //{

        //    return View();
        //}

        //[HttpPost]
        //public ActionResult Trekant(string hoejde, string grundlinje, string side1, string side2, string side3)
        //{

        //    //▼▼▼Trekantens Areal▼▼▼
        //    double hoejd = Convert.ToDouble(hoejde);
        //    double GL = Convert.ToDouble(grundlinje);

        //    ViewBag.result1 = areal.TrekantAreal(hoejd, GL);

        //    //▼▼▼Herons formel▼▼▼

        //    double s1 = Convert.ToDouble(side1);
        //    double s2 = Convert.ToDouble(side2);
        //    double s3 = Convert.ToDouble(side3);

        //    ViewBag.result2 = areal.HeronsFormel(s1, s2, s3);

        //    return View();
        //}

        ////▼▼▼En Kasse▼▼▼

        //public ActionResult Kasse()
        //{

        //    return View();
        //}

        //[HttpPost]
        //public ActionResult Kasse(string hoejde1, string laengde1, string bredte1, string hoejde2, string laengde2, string bredte2)
        //{

        //    //▼▼▼En Kasses Rumfang▼▼▼
        //    double hoejd1 = Convert.ToDouble(hoejde1);
        //    double laengd1 = Convert.ToDouble(laengde1);
        //    double bredt1 = Convert.ToDouble(bredte1);

        //    ViewBag.result1 = ROO.KasseRumfang(hoejd1, laengd1, bredt1);

        //    //▼▼▼En Kasses Overflade▼▼▼

        //    double hoejd2 = Convert.ToDouble(hoejde2);
        //    double laengd2 = Convert.ToDouble(laengde2);
        //    double bredt2 = Convert.ToDouble(bredte2);

        //    ViewBag.result2 = ROO.KasseOverflade(hoejd2, laengd2, bredt2);


        //    return View();
        //}

        ////▼▼▼En Prisme▼▼▼
        //public ActionResult Prisme()
        //{

        //    return View();
        //}

        //[HttpPost]
        //public ActionResult Prisme(string hoejde, string grundAreal)
        //{
        //    double hoejd = Convert.ToDouble(hoejde);
        //    double grundA = Convert.ToDouble(grundAreal);

        //    ViewBag.result = ROO.PrismeRumfang(hoejd, grundA);

        //    return View();
        //}

        ////▼▼▼En Cylinder▼▼▼

        //public ActionResult Cylinder()
        //{

        //    return View();
        //}

        //[HttpPost]
        //public ActionResult Cylinder(string radius1, string hoejde1, string radius2, string hoejde2)
        //{

        //    //▼▼▼En Cylinders Rumfang▼▼▼

        //    double rad1 = Convert.ToDouble(radius1);
        //    double hoejd1 = Convert.ToDouble(hoejde1);

        //    ViewBag.result1 = ROO.CylinderRumfang(rad1, hoejd1);

        //    //▼▼▼En Cylinders Krumme Overflade▼▼▼

        //    double rad2 = Convert.ToDouble(radius2);
        //    double hoejd2 = Convert.ToDouble(hoejde2);

        //    ViewBag.result2 = ROO.CylinderOverflade(rad2, hoejd2);

        //    return View();
        //}


        ////▼▼▼En Kegles/Pyramides Rumfang▼▼▼

        //public ActionResult Kegle()
        //{

        //    return View();
        //}

        //[HttpPost]
        //public ActionResult Kegle(string hoejde, string grundAreal)
        //{
        //    double hoejd = Convert.ToDouble(hoejde);
        //    double GA = Convert.ToDouble(grundAreal);

        //    ViewBag.result = ROO.KegleRumfang(hoejd, GA);

        //    return View();
        //}

        ////▼▼▼Kugle▼▼▼

        //public ActionResult Kugle()
        //{

        //    return View();
        //}

        //[HttpPost]
        //public ActionResult Kugle(string radius1, string radius2)
        //{

        //    //▼▼▼En Kugles Rumfang▼▼▼
        //    double rad1 = Convert.ToDouble(radius1);

        //    ViewBag.result1 = ROO.KugleRumfang(rad1);

        //    //▼▼▼En Kugles Overflade▼▼▼

        //    double rad2 = Convert.ToDouble(radius2);

        //    ViewBag.result2 = ROO.KugleOverflade(rad2);

        //    return View();
        //}
    }
}