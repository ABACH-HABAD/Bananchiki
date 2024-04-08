using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Treugolnik.classes
{
    internal class Treugolnikk
    {
        double kатет1;
        double kатет2;

        public double Kатет1 { get => kатет1; set { if (value > 0) kатет1 = value; } }
        public double Kатет2 { get => kатет2; set { if (value > 0) kатет2 = value; } }

        public double Рассчёт()
        {
            return kатет1 * kатет2 * 0.5f;
        }
    }
}
