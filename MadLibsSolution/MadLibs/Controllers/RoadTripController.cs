using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using MadLibs.Models;

namespace MadLibs.Controllers
{
    public class RoadTripController : Controller
    {

        [HttpGet]
        public IActionResult GenerateMadLibs(string n1, string aj1, string n2, string aj2, string aj3, string v1, string v2, int num1, string v3, string av1,
        string n3, string c1, string v4, string n4, string e1, string v5, string av2, string n5, string v6, string v7, string n6, string pn, string v8, 
        string name, string v9, string n7, string v10, string aj4, string av3, string av4, string n8, string v11, string n9, string aj5)
        {
            RoadTripMadLib roadTrip = new RoadTripMadLib() 
            {
                Noun1 = n1, Adjective1 = aj1, Noun2 = n2, Adjective2 = aj2, Adjective3 = aj3, Verb1 = v1, Verb2 = v2, Number1 = num1, Verb3 = v3, Adverb1 = av1, Noun3 = n3, 
                Color1 = c1, Verb4 = v4, Noun4 = n4, Exlamation1 = e1, Verb5 = v5, Adverb2 = av2, Noun5 = n5, Verb6 = v6, Verb7 = v7, Noun6 = n6, PluralNoun = pn,  Verb8 = v8, 
                Name = name, Verb9 = v9, Noun7 = n7, Verb10 = v10, Adjective4 = aj4, Adverb3 = av3, Adverb4 = av4, Noun8 = n8, Verb11 = v11, Noun9 = n9, Adjective5 = aj5
            };
            return View("GenerateMadLibs", roadTrip);
        }

        [HttpGet]
        public IActionResult DisplayMadLibs()
        {
            return View("DisplayMadLibs");
        }

        [HttpPost]
        public IActionResult DisplayMadLibs(RoadTripMadLib roadTrip)
        {
            if (ModelState.IsValid)
            {
                return View("DisplayMadLibs", roadTrip);
            }
            else
            {
                return View("GenerateMadLibs");
            }
        }
    }
}