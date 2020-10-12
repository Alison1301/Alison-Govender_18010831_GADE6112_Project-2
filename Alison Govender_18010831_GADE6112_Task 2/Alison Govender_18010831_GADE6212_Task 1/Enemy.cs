﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Alison_Govender_18010831_GADE6212_Task_1
{
    public abstract class Enemy : Character
    {
        protected Random random;

        public Enemy(int x,int y,int Damage,int HP,TILETYPE tileType) : base(x, y, TILETYPE.ENEMY)
        {
            this.Damage = Damage;
            this.HP = HP;
            this.maxHP = HP;
        }



        public override string ToString()
        {
            return GetType() + "at [" + x +","+ y +"](" + Damage +")";
        }
        


    }




}


