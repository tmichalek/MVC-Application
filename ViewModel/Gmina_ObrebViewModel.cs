using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Zgloszenie_WebApplication.Models;

namespace Zgloszenie_WebApplication.ViewModel
{
    public class Gmina_ObrebViewModel
    {
        public IEnumerable<Gmina> Gminas {get; set;}
       
        public IEnumerable<Obreb> Obrebs { get; set; }
     

    }
}