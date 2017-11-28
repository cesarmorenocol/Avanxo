using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities
{
    public abstract class Light
    {
        public int LightPower { get; set; }
        public Color LightColor { get; set; }
        abstract public decimal Price { get; set; }
        abstract public Size LightSize { get; set; }
        abstract public Material LightMaterial { get; set; }
    }
}
