using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaAccesoDatos
{
    public partial class RestaurantEntities
    {
        public RestaurantEntities(bool lazyLoad) : base("name=RestaurantEntities2")
        {
            this.Configuration.LazyLoadingEnabled = lazyLoad;
        }
    }
}
