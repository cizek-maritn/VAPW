using System;
using System.CodeDom;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace vapw_cv2
{
    internal class character
    {
        private string name;
        private int attack;
        private int health;
        public character(string jmeno, int atk, int hp)
        {
            this.name = jmeno;
            this.attack = atk;
            this.health = hp;
        }

        public string getName()
        {
            return name;
        }

        public int getAttack()
        {
            return attack;
        }

        public int getHealth()
        {
            return health;
        }

        public void setHealth(int hp)
        {
            this.health = hp;
        }
    }
}
