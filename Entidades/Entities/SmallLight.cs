using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities
{
    public class SmallLight : Light
    {
        #region Class variables

        private Material material;
        private decimal price;

        #endregion Class variables

        #region Properties

        public string Shape { get; set; }

        public override Material LightMaterial
        {
            get { return material; }
            set { material = value; }
        }

        public override Size LightSize
        {
            get { return Size.Small; }
            set { }
        }

        public override decimal Price
        {
            get
            {
                if (Equals(Shape, string.Empty))
                    return (price * (decimal)0.1);
                else
                    return price;
            }

            set { price = value; }
        }

        #endregion Properties
    }
}
