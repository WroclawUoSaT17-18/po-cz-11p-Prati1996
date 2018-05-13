using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace snake
{
    public partial class Form1 : Form
    {
        private List<Circle> Snake = new List<Circle>();
        private Circle food = new Circle();
        public Form1()
        {
            InitializeComponent();
            new Settings();
            gameTimer.Interval = 1000 / Settings.Speed; //changing the game time to settings speed 
            gameTimer.Tick += updateScreeen;
            gameTimer.Start();

            startGame();
        }

        private void keyisdown(object sender, KeyEventArgs e)
        {

        }

        private void keyisup(object sender, KeyEventArgs e)
        {

        }

        private void updateGraphics(object sender, PaintEventArgs e)
        {

        }
    }
}
