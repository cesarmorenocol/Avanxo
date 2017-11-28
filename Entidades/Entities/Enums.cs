using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities
{
    /// <summary>
    /// Enumeración que permite establecer el color del bombillo
    /// </summary>
    public enum Color
    {
        Transparent = 0,
        White = 1,
        Yellow = 2,
        Blue = 3
    }

    /// <summary>
    /// Enumeración que permite establecer el tamano del bombillo
    /// </summary>
    public enum Size
    {
        Small = 1,
        Medium = 2,
        Big = 3
    }

    /// <summary>
    /// Enumeración que permite establecer el Material del bombillo
    /// </summary>
    public enum Material
    {
        Plastic = 1,
        Glass = 2
    }

}
