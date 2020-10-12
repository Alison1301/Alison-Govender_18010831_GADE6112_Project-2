﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Alison_Govender_18010831_GADE6212_Task_1
{
    public abstract class Character:Tile
    {
        protected int HP;
        protected int maxHP;
        protected int Damage;
        protected Tile[] vision = new Tile[4];
        protected MOVEMENT movement;
      
        public int hp
        {
            get { return HP; }
            set { HP = value; }
        }


        public enum MOVEMENT
        {
            NO_MOVEMNET,
            UP,
            DOWN,
            LEFT,
            RIGHT,
        }

        public Character(int x,int y,TILETYPE tileType) : base(x, y, tileType)
        {
            
        }


        public virtual void Attack(Character target)
        {
            target.HP = 20;
            target.HP -= this.Damage;
        }

        public bool IsDead()
        {
            return HP <= 0;
        }
       

        public virtual bool CheckRange(Character target)
        {
            return DistanceTo(target) <= 1;
        }

        private int DistanceTo(Character target)
        {
            return Math.Abs(x - target.X) + Math.Abs(Y - target.Y);
        }

        public void Move(MOVEMENT movement)
        {
            switch (movement)
            {
                case MOVEMENT.UP: y -= 1;break;
                case MOVEMENT.DOWN: y += 1;break;
                case MOVEMENT.LEFT: x -= 1;break;
                case MOVEMENT.RIGHT: x += 1;break; 
            }
        }

        public abstract MOVEMENT ReturnMove(MOVEMENT move = 0);


        //public abstract override string ToString();
      


    }
}
