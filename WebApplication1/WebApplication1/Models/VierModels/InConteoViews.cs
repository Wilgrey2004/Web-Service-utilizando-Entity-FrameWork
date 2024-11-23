using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebApplication1.Models.VierModels
{
        public class InConteoViews
        {
                public int Id { get; set; }
                public string Nombre { get; set; }
                public int Catidad { get; set; }

        }

        public class IConteoPost {
                public string Nombre { get; set; }
                public int Cantidad { get; set; }
        }
}