// getters and setters for enemy stats
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C__MonsterHunter_V2
{
    public interface IEnemy
    {
        string Name { get; set; }
        int HP { get; set; }
    }
}
