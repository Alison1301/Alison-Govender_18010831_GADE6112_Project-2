using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Alison_Govender_18010831_GADE6212_Task_1
{
    class Game_Engine:Map
    {
       
        public Game_Engine(char map,int x,int y):base(0,0,0,0,0)
        {
            
        }

        public  bool MovePlayer;

        public override string ToString()
        {
            return base.ToString();
        }

        public void EnemyAttacks()
        {

        }

        public void Save()
        {

        }

        public void Load()
        {

        }
    }
}
