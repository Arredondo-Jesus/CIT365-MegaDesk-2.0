using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MegaDesk_3_JesusArredondo
{
    class Desk
    {
        public int width { get; set;}
        public int depth { get; set; }
        public int drawers { get; set; }
        public enum desktopMaterials {
            Oak = 200,
            Laminate = 100,
            Pine = 50,
            Rossewood = 300,
            Veneer = 150
        };

        public int size { get; set; }
    }
}
