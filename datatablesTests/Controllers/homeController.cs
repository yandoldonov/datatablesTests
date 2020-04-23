using datatablesTests.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace datatablesTests.Controllers
{
    public class homeController : Controller
    {
        // GET: home
        public ActionResult index() 
        {
            return View();
        }

        public ActionResult multiColumnSearch()
        {
            dataCollectionModel _dataModel = new dataCollectionModel();
            _dataModel.generateData();
            return View(_dataModel);
        }

        public ActionResult multiPageSubmitForm()
        {
            dataCollectionModel _dataModel = new dataCollectionModel();
            _dataModel.generateData();
            return View(_dataModel);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult multiPageSubmitForm(dataCollectionModel model)
        {      
            return PartialView($"~/Views/home/_multiPageSubmitFormPartial.cshtml", model);
        }
    }
}