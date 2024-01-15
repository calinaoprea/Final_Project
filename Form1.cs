using Npgsql;
using System;
using NpgsqlTypes;
using System.Drawing;
using System.Threading.Tasks;
using System.Windows.Forms;
using yes.classes;

namespace yes
{
    public partial class loginPage : Form
    {
        private ConnectionConturi conectare = new ConnectionConturi();
        public loginPage()
        {
            InitializeComponent();
            nume.ForeColor = Color.Gray;
            nume.Text = "Introduceți numele";
            parola.ForeColor = Color.Gray;
            parola.Text = "Introduceți parola";
            parola.UseSystemPasswordChar = false;

        }



        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void nume_TextChanged(object sender, EventArgs e)
        {

        }

        private async void button1_Click(object sender, EventArgs e)
        {
            if (nume.Text.Equals("Introduceți numele") && parola.Text.Equals("Introduceți parola"))
            {

                nume.Text = "Nu ați introdus numele";
                nume.BackColor = Color.LightSteelBlue;
                parola.Text = "Nu ați introdus parola";
                parola.BackColor = Color.LightSteelBlue;
                parola.Enabled = false;
                nume.Enabled = false;
                await Task.Delay(1000);
                nume.Enabled = true;
                parola.Enabled = true;
                nume.Text = "Introduceți numele";
                nume.BackColor = Color.White;
                parola.Text = "Introduceți parola";
                parola.BackColor = Color.White;
            }
            else if (nume.Text.Equals("") && parola.Text.Equals(""))
            {

                nume.Text = "Nu ați introdus numele";
                nume.BackColor = Color.LightSteelBlue;
                parola.Text = "Nu ați introdus parola";
                parola.BackColor = Color.LightSteelBlue;
                parola.Enabled = false;
                nume.Enabled = false;
                await Task.Delay(1000);
                nume.Enabled = true;
                parola.Enabled = true;
                nume.Text = "Introduceți numele";
                nume.BackColor = Color.White;
                parola.Text = "Introduceți parola";
                parola.BackColor = Color.White;
            }
            else if (nume.Text.Equals("Introduceți numele") && parola.Text.Equals(""))
            {

                nume.Text = "Nu ați introdus numele";
                nume.BackColor = Color.LightSteelBlue;
                parola.Text = "Nu ați introdus parola";
                parola.BackColor = Color.LightSteelBlue;
                parola.Enabled = false;
                nume.Enabled = false;
                await Task.Delay(1000);
                nume.Enabled = true;
                parola.Enabled = true;
                nume.Text = "Introduceți numele";
                nume.BackColor = Color.White;
                parola.Text = "Introduceți parola";
                parola.BackColor = Color.White;
            }
            else if (nume.Text.Equals("") && parola.Text.Equals("Introduceți parola"))
            {

                nume.Text = "Nu ați introdus numele";
                nume.BackColor = Color.LightSteelBlue;
                parola.Text = "Nu ați introdus parola";
                parola.BackColor = Color.LightSteelBlue;
                parola.Enabled = false;
                nume.Enabled = false;
                await Task.Delay(1000);
                nume.Enabled = true;
                parola.Enabled = true;
                nume.Text = "Introduceți numele";
                nume.BackColor = Color.White;
                parola.Text = "Introduceți parola";
                parola.BackColor = Color.White;
            }
            else
            if (nume.Text.Equals("Introduceți numele") && !parola.Text.Equals("Introduceți parola"))
            {
                nume.Text = "Nu ați introdus numele";
                nume.BackColor = Color.LightSteelBlue;
                nume.Enabled = false;
                await Task.Delay(1000);
                nume.Text = "Introduceți numele";
                nume.BackColor = Color.White;
                nume.Enabled = true;
            }
            else
            if (parola.Text.Equals("Introduceți parola") && !nume.Text.Equals("Introduceți numele"))
            {
                parola.Text = "Nu ați introdus parola";
                parola.BackColor = Color.LightSteelBlue;
                parola.Enabled = false;
                await Task.Delay(1000);
                parola.Text = "Introduceți parola";
                parola.BackColor = Color.White;
                parola.Enabled = true;
            }
            else
            {
                if (conectare.login(nume.Text, parola.Text))
                {
                    Form3 form = new Form3();
                    form.Show();

                }
            }


        }

        private void button2_Click(object sender, EventArgs e)
        {
            form2 F2 = new form2();
            F2.Show();
        }

        private void LoginPage_Load(object sender, EventArgs e)
        {

        }

        private void parola_Enter(object sender, EventArgs e)
        {

            if (parola.Text == "Introduceți parola")
            {
                parola.UseSystemPasswordChar = true;
                parola.ForeColor = Color.Black;
                parola.Text = "";
            }


        }
        private void nume_Enter(object sender, EventArgs e)
        {

            if (nume.Text == "Introduceți numele")
            {
                nume.ForeColor = Color.Black;
                nume.Text = "";
            }

        }

        private void nume_MouseLeave(object sender, EventArgs e)
        {
            if (nume.Text == "")
            {
                nume.ForeColor = Color.Gray;
                nume.Text = "Introduceți numele";
            }
        }

        private void parola_MouseLeave(object sender, EventArgs e)
        {
            if (parola.Text == "")
            {
                parola.UseSystemPasswordChar = false;
                parola.ForeColor = Color.Gray;
                parola.Text = "Introduceți parola";
            }

        }

    }

}
