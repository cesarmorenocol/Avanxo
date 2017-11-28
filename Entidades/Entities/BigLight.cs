using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities
{
    public class BigLight : Light
    {
        #region Class variables

        private decimal price;

        #endregion Class variables

        #region Properties

        public override Material LightMaterial
        {
            get { return Material.Glass; }
            set { }
        }

        public override Size LightSize
        {
            get {  return Size.Big; }
            set { }
        }

        public override decimal Price
        {
            get { return price; }
            set { price = value; }
        }

        #endregion Properties
    }
}
