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
    public class CampController : Controller
    {
        [HttpGet]
        public IActionResult GenerateMadLibs(string name, string campName, string adjective1, string activity1, 
        string activity2, string pluralNoun, string adjective2, string noun, string nickName)
        {
            CampMadLib campMadLib = new CampMadLib() 
            {
                Name = name, CampName = campName, Adjective1 = adjective1, Activity1 = activity1, Activity2 = activity2,
                PluralNoun = pluralNoun, Adjective2 = adjective2, Noun = noun, NickName = nickName
            };
            return View("GenerateMadLibs", campMadLib);
        }

        [HttpGet]
        public IActionResult DisplayMadLibs()
        {
            return View("DisplayMadLibs");
        }

        [HttpPost]
        public IActionResult DisplayMadLibs(CampMadLib campMadLib)
        {
            if (ModelState.IsValid)
            {
                return View("DisplayMadLibs", campMadLib);
            }
            else
            {
                return View("GenerateMadLibs");
            }
        }
    }
}