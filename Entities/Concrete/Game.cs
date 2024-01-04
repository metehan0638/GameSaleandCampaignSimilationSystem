using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameProject.Entities.Concrete
{
    internal class Game
    {
        public int GameId { get; set; }
        public string GameName { get; set; }
        public string GameVersion { get; set; }
        public string GameCategory { get; set; }
        public string GameDescription { get; set; }
    }
}
