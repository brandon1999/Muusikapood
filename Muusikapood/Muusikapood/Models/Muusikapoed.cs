using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Muusikapood.Models
{
    public class Muusikapoed
    {

            public int Id { get; set; }
            public string instrument { get; set; }
            public string Kvaliteet { get; set; }
            public int hind { get; set; }
            public string kirjeldus { get; set; }
        }
    }