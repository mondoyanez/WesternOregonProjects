using System;
using System.ComponentModel.DataAnnotations;

namespace MadLibs.Models
{
    public class CampMadLib
    {
        [Required]
        public string Name { get; set; }
        [Required]
        public string CampName { get; set; }
        [Required]
        public string Adjective1 { get; set; }
        [Required]
        public string Activity1 { get; set; }
        [Required]
        public string Activity2 { get; set; }
        [Required]
        public string PluralNoun { get; set; }
        [Required]
        public string Adjective2 { get; set; }
        [Required]
        public string Noun { get; set; }
        [Required]
        public string NickName { get; set; }
    }
}