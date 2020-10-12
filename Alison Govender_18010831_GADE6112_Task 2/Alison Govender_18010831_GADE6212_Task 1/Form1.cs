using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Alison_Govender_18010831_GADE6212_Task_1
{
    public partial class GoblimsGame_Frm : Form
    {

        public Obstacle Obstacle = new Obstacle();
        public Game_Engine game_Engine = new Game_Engine();
        public EmptyTile emptyTile = new EmptyTile();
        public Hero hero = new Hero();
        public Map map = new Map();
        public Goblim goblim = new Goblim();
        public Character character = new Character();




        public GoblimsGame_Frm()
        {
            InitializeComponent();
        }

        private void GoblimsGame_Frm_Load(object sender, EventArgs e)
        {

        }
    }
}
