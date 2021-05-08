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
    
    public partial class GreyhoundPlays : Form
    {
        RunningGround rg = new RunningGround();
        // declaration of var player name 

        string plyrNme = "";

        int dog = 0;
        int gany = 100, Richrd = 100, Prtlo = 100;

        Plyer Grny = null;

        Plyer richrd = null;

        Plyer pretlo = null;

        public GreyhoundPlays()
        {
            // setting location of dogs 

            InitializeComponent();
            
            Grny = new Plyer("Grany",0,0, gany);

            richrd = new Plyer("Richard", 0, 0, Richrd);
            
            pretlo = new Plyer("Pretlo", 0, 0, Prtlo);

            race_btn.Enabled = false;
        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {

        }

        // if one player is check then it disable other players 

        private void Grany_CheckedChanged(object sender, EventArgs e)
        {
            if (Grany.Checked == true) {
                plyrNme = "Grany";
                Richard.Checked = false;
                Pretlo.Checked = false;
            }
        }

        // if one dog is checked then it disable other dogs 

        private void Rambo_dog1_CheckedChanged(object sender, EventArgs e)
        {
            if (Rambo_dog1.Checked == true) {
                dog = 1;
                jacky_dog2.Checked = false;
                jimmy_dog4.Checked = false;
                johny_dog3.Checked = false;
            }
        }

        // if one player is checked then it disable other dogs 

        private void jacky_dog2_CheckedChanged(object sender, EventArgs e)
        {
            if (jacky_dog2.Checked == true)
            {
                dog = 2;
                Rambo_dog1.Checked = false;
                jimmy_dog4.Checked = false;
                johny_dog3.Checked = false;
            }
        }

        // if one dog is checked then it disable other dogs 

        private void johny_dog3_CheckedChanged(object sender, EventArgs e)
        {
            if (johny_dog3.Checked == true)
            {
                dog = 3;
                Rambo_dog1.Checked = false;
                jimmy_dog4.Checked = false;
                jacky_dog2.Checked = false;
            }

        }

        // if one dog is checked then it disable other dogs 
        private void jimmy_dog4_CheckedChanged(object sender, EventArgs e)
        {
            if (jimmy_dog4.Checked == true)
            {
                dog = 4;
                Rambo_dog1.Checked = false;
                johny_dog3.Checked = false;
                jacky_dog2.Checked = false;
            }
        }

        // set button check all conditons and then enable run button

        private void bet_set_button_Click(object sender, EventArgs e)
        {
            if (plyrNme.Equals("Grany") && dog > 0 && nmPrice.Value > 0 && nmPrice.Value < gany)
            {
                Grny = new Plyer("Grany", dog, Convert.ToInt32(nmPrice.Value), gany);
                race_btn.Enabled = true;
                grany_msg.Text = "Grany select " + Grny.dog + " with the Bet " + Grny.budget;
            }

            else if (plyrNme.Equals("Richard") && dog > 0 && nmPrice.Value > 0 && nmPrice.Value < Richrd)
            {
                richrd = new Plyer("Richard", dog, Convert.ToInt32(nmPrice.Value), Richrd);
                race_btn.Enabled = true;
                Richard_msg.Text = "Richard select " + richrd.dog + " with the Bet " + richrd.budget;
            }
            else if (plyrNme.Equals("Pretlo") && dog > 0 && nmPrice.Value > 0 && nmPrice.Value < Prtlo)
            {
                pretlo = new Plyer("Pretlo", dog, Convert.ToInt32(nmPrice.Value), Prtlo);
                race_btn.Enabled = true;
                pretlo_msg.Text = "Pretlo select " + pretlo.dog + " with the Bet " + pretlo.budget;

            }
            else {
                MessageBox.Show("Need to select the Details ");
            }

            dog = 0;
            plyrNme = "";


        }

        private void race_btn_Click(object sender, EventArgs e)
        {
            timer1.Start();
        }

        public void reset() {
            dog = 0;
            plyrNme = "";
            rambo1.Left = 0; rambo2.Left = 0; rambo3.Left = 0; rambo4.Left = 0;
            grany_msg.Text = "Grany has " + gany;
            Richard_msg.Text = "Richard has " + Richrd;
            pretlo_msg.Text = "Pretlo has " + Prtlo;
            race_btn.Enabled = false;
            nmPrice.Value = 0;
            Grany.Checked = false;Richard.Checked = false;Pretlo.Checked = false;
            Rambo_dog1.Checked = false;johny_dog3.Checked = false;jimmy_dog4.Checked = false; jacky_dog2.Checked = false;

            Grny = new Plyer("Grany", 0, 0, gany);

            richrd = new Plyer("Richard", 0, 0, Richrd);

            pretlo = new Plyer("Pretlo", 0, 0, Prtlo);

        }
        private void timer1_Tick(object sender, EventArgs e)
        {
            rg.step();
            rambo1.Left +=rg.jump;
            rg.step();
            rambo2.Left += rg.jump;
            rg.step();
            rambo3.Left += rg.jump;
            rg.step();
            rambo4.Left += rg.jump;
            if (rambo1.Left>rg.stp) {
                
                timer1.Stop();
                
                MessageBox.Show("Rambo won the race");

                if (Grny.dog > 0) {
                    gany = Grny.setBlnce(1);
                }
                if (richrd.dog>0) {
                    Richrd = richrd.setBlnce(1);
                }
                if (pretlo.dog > 0)
                {
                    Prtlo= pretlo.setBlnce(1);
                }
                reset();

            }

            if (rambo2.Left > rg.stp)
            {
                
                timer1.Stop();
                MessageBox.Show("Jacky won the race");

                if (Grny.dog > 0)
                {
                    gany = Grny.setBlnce(2);
                }
                if (richrd.dog > 0)
                {
                    Richrd = richrd.setBlnce(2);
                }
                if (pretlo.dog > 0)
                {
                    Prtlo = pretlo.setBlnce(2);
                }
                reset();
            }

            if (rambo3.Left > rg.stp)
            {
                
                timer1.Stop();
                MessageBox.Show("Jonny won the race");


                if (Grny.dog > 0)
                {
                    gany = Grny.setBlnce(3);
                }
                if (richrd.dog > 0)
                {
                    Richrd = richrd.setBlnce(3);
                }
                if (pretlo.dog > 0)
                {
                    Prtlo = pretlo.setBlnce(3);
                }
                reset();
            }

            if (rambo4.Left > rg.stp)
            {
                
                timer1.Stop();
                MessageBox.Show("Jimmy won the race");


                if (Grny.dog > 0)
                {
                    gany = Grny.setBlnce(4);
                }
                if (richrd.dog > 0)
                {
                    Richrd = richrd.setBlnce(4);
                }
                if (pretlo.dog > 0)
                {
                    Prtlo = pretlo.setBlnce(4);
                }
                reset();
            }


        }

        private void Richard_CheckedChanged(object sender, EventArgs e)
        {
            if (Richard.Checked == true)
            {
                plyrNme = "Richard";
                Grany.Checked = false;
                Pretlo.Checked = false;
            }


        }

        private void Pretlo_CheckedChanged(object sender, EventArgs e)
        {
            if (Pretlo.Checked == true)
            {
                plyrNme = "Pretlo";
                Grany.Checked = false;
                Richard.Checked = false;
            }
        }
    }
}
