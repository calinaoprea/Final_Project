using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using yes.classes;

namespace yes
{
    public partial class form2 : Form
    {
        private static ArrayList conturi = new ArrayList();
        private ConnectionConturi conectare = new ConnectionConturi();
        public form2()
        {
            InitializeComponent();
            nume2.ForeColor = Color.Gray;
            nume2.Text = "Introduceți numele";
            parola2.ForeColor = Color.Gray;
            parola2.Text = "Introduceți parola";
            parola2.UseSystemPasswordChar = false;
            email.ForeColor = Color.Gray;
            email.Text = "Introduceți emailul";
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Form2_Load(object sender, EventArgs e)
        {
           
        }

        private async void button1_ClickAsync(object sender, EventArgs e)
        {
            if (nume2.Text.Equals("Introduceți numele") && parola2.Text.Equals("Introduceți parola") && email.Text.Equals("Introduceți emailul"))
            {

                nume2.Text = "Nu ați introdus numele";
                nume2.BackColor = Color.LightSteelBlue;
                parola2.Text = "Nu ați introdus parola";
                parola2.BackColor = Color.LightSteelBlue;
                parola2.Enabled = false;
                nume2.Enabled = false;
                email.Text = "Nu ați introdus emailul";
                email.BackColor = Color.LightSteelBlue;
                email.Enabled = false;
                await Task.Delay(1000);
                nume2.Enabled = true;
                parola2.Enabled = true;
                email.Enabled = true;
                nume2.Text = "Introduceți numele";
                nume2.BackColor = Color.White;
                email.BackColor =Color.White;
                email.Text = "Introduceți emailul";
                parola2.Text = "Introduceți parola";
                parola2.BackColor = Color.White;
            }
            else 
            if (nume2.Text.Equals("Introduceți numele") && parola2.Text.Equals("Introduceți parola") && !email.Text.Equals("Introduceți emailul"))
            {

                nume2.Text = "Nu ați introdus numele";
                nume2.BackColor = Color.LightSteelBlue;
                parola2.Text = "Nu ați introdus parola";
                parola2.BackColor = Color.LightSteelBlue;
                parola2.Enabled = false;
                nume2.Enabled = false;         
                await Task.Delay(1000);
                nume2.Enabled = true;
                parola2.Enabled = true;
                nume2.Text = "Introduceți numele";
                nume2.BackColor = Color.White;
                parola2.Text = "Introduceți parola";
                parola2.BackColor = Color.White;
            }
            else
                if (!nume2.Text.Equals("Introduceți numele") && parola2.Text.Equals("Introduceți parola") && email.Text.Equals("Introduceți emailul"))
            {

                parola2.Text = "Nu ați introdus parola";
                parola2.BackColor = Color.LightSteelBlue;
                parola2.Enabled = false;
                email.Text = "Nu ați introdus emailul";
                email.BackColor = Color.LightSteelBlue;
                email.Enabled = false;
                await Task.Delay(1000);
                parola2.Enabled = true;
                email.Enabled = true;
                email.BackColor = Color.White;
                email.Text = "Introduceți emailul";
                parola2.Text = "Introduceți parola";
                parola2.BackColor = Color.White;
            }
            else
                if (nume2.Text.Equals("Introduceți numele") && !parola2.Text.Equals("Introduceți parola") && email.Text.Equals("Introduceți emailul"))
            {

                nume2.Text = "Nu ați introdus numele";
                nume2.BackColor = Color.LightSteelBlue;
                nume2.Enabled = false;
                email.Text = "Nu ați introdus emailul";
                email.BackColor = Color.LightSteelBlue;
                email.Enabled = false;
                await Task.Delay(1000);
                nume2.Enabled = true;
                email.Enabled = true;
                nume2.Text = "Introduceți numele";
                nume2.BackColor = Color.White;
                email.BackColor = Color.White;
                email.Text = "Introduceți emailul";
            }
            else if (!nume2.Text.Equals("Introduceți numele") && !parola2.Text.Equals("Introduceți parola") && email.Text.Equals("Introduceți emailul"))
            {

                email.Text = "Nu ați introdus emailul";
                email.BackColor = Color.LightSteelBlue;
                email.Enabled = false;
                await Task.Delay(1000);
                email.Enabled = true;
                email.BackColor = Color.White;
                email.Text = "Introduceți emailul";
            }
            else if (!nume2.Text.Equals("Introduceți numele") && parola2.Text.Equals("Introduceți parola") && !email.Text.Equals("Introduceți emailul"))
            {

                parola2.Text = "Nu ați introdus parola";
                parola2.BackColor = Color.LightSteelBlue;
                parola2.Enabled = false;
                await Task.Delay(1000);
                parola2.Enabled = true;
                parola2.BackColor = Color.White;
                parola2.Text = "Introduceți parola";
            }
            else if (nume2.Text.Equals("Introduceți numele") && !parola2.Text.Equals("Introduceți parola") && !email.Text.Equals("Introduceți emailul"))
            {

                nume2.Text = "Nu ați introdus numele";
                nume2.BackColor = Color.LightSteelBlue;
                nume2.Enabled = false;
                await Task.Delay(1000);
                nume2.Enabled = true;
                nume2.BackColor = Color.White;
                nume2.Text = "Introduceți numele";
            }
            else
            {
                Cont contNou = new Cont(nume2.Text, email.Text, parola2.Text);
                conturi.Add(contNou);
                conectare.adaugaCont(nume2.Text, email.Text, parola2.Text);
                this.Close();

            }



        }

        private void nume2_MouseEnter(object sender, EventArgs e)
        {
            if (nume2.Text == "Introduceți numele")
            {
                nume2.ForeColor = Color.Black;
                nume2.Text = "";
            }
        }

        private void email_MouseEnter(object sender, EventArgs e)
        {
            if (email.Text == "Introduceți emailul")
            {
                email.ForeColor = Color.Black;
                email.Text = "";
            }
        }

        private void parola2_MouseEnter(object sender, EventArgs e)
        {
            if (parola2.Text == "Introduceți parola")
            {
                parola2.UseSystemPasswordChar = true;
                parola2.ForeColor = Color.Black;
                parola2.Text = "";
            }
        }

        private void nume2_MouseLeave(object sender, EventArgs e)
        {
            if (nume2.Text == "")
            {
                nume2.ForeColor = Color.Gray;
                nume2.Text = "Introduceți numele";
            }
        }

        private void email_MouseLeave(object sender, EventArgs e)
        {
            if (email.Text == "")
            {
                email.ForeColor = Color.Gray;
                email.Text = "Introduceți emailul";
            }
        }


        private void parola2_MouseLeave(object sender, EventArgs e)
        {
            if (parola2.Text == "")
            {
                parola2.UseSystemPasswordChar = false;
                parola2.ForeColor = Color.Gray;
                parola2.Text = "Introduceți parola";
            }
        }
    }
}
