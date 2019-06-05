using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Muusikapood.Models
{
    public class Muusikapoed
    {

            public int Id { get; set; }
        // mis instrumendi müüki paneb. 
            public string instrument { get; set; }
        // lisada kvaliteet.
            public kvaliteedid Kvaliteet { get; set; }
        // Lisada hind instrumendile.
            public int hind { get; set; }
        //Kirjeldab oma instrumenti.
            public string kirjeldus { get; set; }


        // Tegin nii, et kasutaja ei saaks ise kirjutada suvalist teksti "kvaliteedi" alla vaid peab valima.  
        public enum kvaliteedid
        {
            hea,
            keskmine,
            halb
        }

	}
}
    