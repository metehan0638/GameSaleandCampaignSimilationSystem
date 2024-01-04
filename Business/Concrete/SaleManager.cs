using GameProject.Business.Abstract;
using GameProject.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameProject.Business.Concrete
{
    internal class SaleManager : ISaleService
    {
        public void SaleGame(Person person, List<Game> games)
        {
            foreach (Game game in games)
            {
                Console.WriteLine(person.FirstName + " " + person.LastName + " adlı kişi " + " " + game.GameName + " oyununu satın almıştır" );
            }
         
        }
    }
}
