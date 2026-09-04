using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Test_Your_Arithmetic_Knowledge
{
    public partial class MathGame : Form
    {
        //declaring variables
        Random random = new Random();
        int num1, num2, num3, num4, num5, num6, num7, num8;
        int ansA, ansB, ansC, ansD;

        //close button logic
        private void btnClose_Click_1(object sender, EventArgs e)
        {
            Application.Exit();
        }

        //restart button logic
        private void btnRestart_Click_1(object sender, EventArgs e)
        {
            errorProvider1.Clear();
            errorProvider2.Clear();
            errorProvider3.Clear();
            errorProvider4.Clear();
            txtAnsA.Clear();
            txtAnsB.Clear();
            txtAnsC.Clear();
            txtAnsD.Clear();
            GenerateGame();
        }

        //method to run the game
        public void GenerateGame()
        {
            //level 1 conditions
            int min = 1, max = 10;

            //level 2 conditions
            if (cmbLevel.SelectedIndex == 1)
            {
                min = 10;
                max = 100;
            }

            //level 3 conditions
            if (cmbLevel.SelectedIndex == 2)
            {
                min = 100;
                max = 1000;
            }

            //creating random numbers and operations
            num1 = random.Next(min, max);
            num2 = random.Next(min, max);
            num3 = random.Next(min, max);
            num4 = random.Next(min, num3);
            num5 = random.Next(min, max);
            num6 = random.Next(min, max);
            num8 = random.Next(1, max);
            num7 = num8 * random.Next(1, max / num8);


            //operations
            ansA = num1 + num2;
            ansB = num3 - num4;
            ansC = num5 * num6;
            ansD = num7 / num8;

            //display numbers and results in text boxes
            txtNum1.Text = num1.ToString();
            txtNum2.Text = num2.ToString();
            txtNum3.Text = num3.ToString();
            txtNum4.Text = num4.ToString();
            txtNum5.Text = num5.ToString();
            txtNum6.Text = num6.ToString();
            txtNum7.Text = num7.ToString();
            txtNum8.Text = num8.ToString();
            Score.Text = "";

        }

        //check button logic
        private void btnCheck_Click(object sender, EventArgs e)
        {
            //define variables
            int userAnsA, userAnsB, userAnsC, userAnsD;
            int count = 0;

            //answer one
            int.TryParse(txtAnsA.Text, out userAnsA);
            //define conditions
            if (userAnsA != ansA)
            {
                errorProvider1.SetError(txtAnsA, "" + ansA);
            }
            else if (userAnsA == ansA)
            {
                count = count + 1;
                txtAnsA.Text = ansA.ToString();
            }

            //answer two
            int.TryParse(txtAnsB.Text, out userAnsB);
            //define conditions
            if (userAnsB != ansB)
            {
                errorProvider2.SetError(txtAnsB, "" + ansB);
            }
            else if (userAnsB == ansB)
            {
                count = count + 1;
                txtAnsB.Text = ansB.ToString();
            }

            //answer three
            int.TryParse(txtAnsC.Text, out userAnsC);
            //define conditions
            if (userAnsC != ansC)
            {
                errorProvider3.SetError(txtAnsC, "" + ansC);
            }
            else if (userAnsC == ansC)
            {
                count = count + 1;
                txtAnsC.Text = ansC.ToString();
            }

            //answer four
            int.TryParse(txtAnsD.Text, out userAnsD);
            //define conditions
            if (userAnsD != ansD)
            {
                errorProvider4.SetError(txtAnsD, "" + ansD);
            }
            else if (userAnsD == ansD)
            {
                count = count + 1;
                txtAnsD.Text = ansD.ToString();
            }
            
            //display score
            Score.Text = count.ToString();
        }

        //main class
        public MathGame()
        {
            InitializeComponent();
            this.btnCheck.Click += new System.EventHandler(this.btnCheck_Click);
            this.btnRestart.Click += new System.EventHandler(this.btnRestart_Click_1);
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click_1);
            GenerateGame();
        }
    }
}
