using GameProject.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameProject.Business.Abstract
{
    internal interface ISaleService
    {
        public void SaleGame(Person person,List<Game>games);
    }
}
