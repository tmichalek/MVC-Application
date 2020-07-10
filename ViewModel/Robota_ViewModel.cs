using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Data.Entity;
using System.Linq;
using System.Web;
using Zgloszenie_WebApplication.Models;

namespace Zgloszenie_WebApplication.ViewModel
{
    public class Robota_ViewModel
    {
        [Display (Name ="Numer pracy")]
        public short numer;

        [Display (Name = "Rok")]
        public short rok;

        public string nazwaFirmy;
        public string nazwaGmina;

        [Display(Name = "Obreb")]
        public string nazwaObreb { get; set; }

        public string numerDzialki;
        public int celPracy;
        public DateTime dataZgloszenia;
        public DateTime dataZakonczeniaPrac;

       
    }
}