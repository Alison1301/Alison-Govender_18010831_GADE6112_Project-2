using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Alison_Govender_18010831_GADE6212_Task_1
{
     class Map
    {
        Tile[,] map;
        Hero hero;
        Enemy[] enemies;

        int WIDTH;
        int HEIGHT;
        Random random = new Random();

        public Map(int minWidth,int maxWidth,int minHeight,int maxHeight,int numenemies)
        {
            WIDTH = random.Next(minWidth, maxWidth + 1);
            HEIGHT = random.Next(minHeight, maxHeight + 1);

            map = new Tile[WIDTH, HEIGHT];
            enemies = new Enemy[numenemies];

            InitializeMap();
             
            hero = (Hero) Create(TILETYPE.HERO);
            for(int i =0;i < enemies.Length; i++)
            {
                enemies[i]= Create(TILETYPE.ENEMY);
            }
            UpdateVision();
        }

        private void InitializeMap()
        {
            for(int y = 0; y < HEIGHT; y++)
            {
                for(int x = 0; x < WIDTH; x++)
                {
                    if(x==0 || x == WIDTH - 1|| y == 0 || y == HEIGHT - 1)
                    {
                        map[x, y] = new Obstacle(x, y);
                    }
                    else
                    {
                        map[x, y] = new EmptyTile(x, y);
                    }
                 
                }
            }
        }
        public void UpdateVision()
        {

        }

        public Tile Create(TILETYPE tileType)
        {
            int x = random.Next(0, WIDTH);
            int y = random.Next(0, HEIGHT);

            while (map[x, y].tileType != TILETYPE.EMPTY)
            {
                x = random.Next(0, WIDTH);
                y = random.Next(0, HEIGHT);
            } 

            if(tileType == TILETYPE.HERO)
            {
                map[x, y] = new Hero(x, y, 10);
                
            }
            else if(tileType == TILETYPE.ENEMY)
            {
                map[x,y]= new Goblim(x, y);
            }

            return new EmptyTile(x, y);
            
        }

    }
}
