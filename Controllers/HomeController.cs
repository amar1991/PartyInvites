﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using PartyInvites.Models;


namespace PartyInvites.Controllers
{
    public class HomeController : Controller
    {
        /*GET: Home
        public ActionResult Index()
        {
            return View();
        }
         * */
        /*
        public string Index() {

            return "Hello World";    

        }
        */

        public ViewResult Index() { 

            int hour = DateTime.Now.Hour;           
            ViewBag.Greeting = hour < 12 ? "Good Morning" : "Good Afternoon";
            return View(); 
        }

        [HttpGet]
        public ViewResult RsvpForm() { 
           
            return View(); 
        
        }

        [HttpPost]
        public ViewResult RsvpForm(guestResponse GuestResponse)
        {

            if (ModelState.IsValid)
            {
                // TODO: Email response to the party organizer
                return View("Thanks", GuestResponse);
            }
            else
            {
                // there is a validation error
                return View();
            }
        }





    }
}