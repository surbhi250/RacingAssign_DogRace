using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RacingAssign_DogRace
{
    public partial class Form1 : Form
    {
        int y = 0;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            timer1.Start();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (y < 100)
            {
                y = y + 10;
                progressBar1.Value = y;
            }
            else {
                GreyhoundPlays obj = new GreyhoundPlays();
                obj.Visible=true;
                timer1.Stop();
            }
        }
    }
}
