using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ReproductorMusicaMichel
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            personalizarDiseno();
        }
        private void personalizarDiseno()
        {
            panelMediosSubMenu.Visible = false;
            panelListaReproduccion.Visible = false;
            panelEcualizador.Visible = false;
        }
        private void OcultarSubMenu()
        {
            if (panelMediosSubMenu.Visible == true)
            {
                panelMediosSubMenu.Visible = false;
            }
            if (panelListaReproduccion.Visible == true)
            {
                panelListaReproduccion.Visible = false;
            }
            if (panelEcualizador.Visible == true)
            {
                panelEcualizador.Visible = false;
            }
        }
        private void MostrarSubMenu(Panel menuReproductor)
        {
            if (menuReproductor.Visible == false)
            {
                OcultarSubMenu();
                menuReproductor.Visible = true;
            }
            else
            {
                menuReproductor.Visible = false;
            }

        }


        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnMedios_Click(object sender, EventArgs e)
        {
            MostrarSubMenu(panelMediosSubMenu);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            abrirhijo(new Form2());
            OcultarSubMenu();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            abrirhijo(new Form2());
            OcultarSubMenu();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            abrirhijo(new Form2());
            OcultarSubMenu();
        }

            private void button5_Click(object sender, EventArgs e)
        {
            abrirhijo(new Form2());
            OcultarSubMenu();
        }

        private void butListaReproduccion_Click(object sender, EventArgs e)
        {
            MostrarSubMenu(panelListaReproduccion); 
        }

        private void button9_Click(object sender, EventArgs e)
        {
            abrirhijo(new Form3());
            OcultarSubMenu();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            abrirhijo(new Form3());
            OcultarSubMenu();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            abrirhijo(new Form3());
            OcultarSubMenu();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            abrirhijo(new Form3());
            OcultarSubMenu();
        }

        private void btnEcualizador_Click(object sender, EventArgs e)
        {
            MostrarSubMenu(panelEcualizador); 
        }

        private void button14_Click(object sender, EventArgs e)
        {
            abrirhijo(new Form3());
            OcultarSubMenu();
        }

        private void button13_Click(object sender, EventArgs e)
        {
            abrirhijo(new Form3());
            OcultarSubMenu();
        }

        private void button12_Click(object sender, EventArgs e)
        {
            abrirhijo(new Form3());
            OcultarSubMenu();
        }

        private void button11_Click(object sender, EventArgs e)
        {
            abrirhijo(new Form3());
            OcultarSubMenu();
        }
        private Form FormularioActivo = null; 
        private void abrirhijo(Form Hijo)
        {
            if (FormularioActivo != null)
            {
                FormularioActivo.Close();
            }
                FormularioActivo = Hijo;
                Hijo.TopLevel = false;
                Hijo.FormBorderStyle = FormBorderStyle.None;
                panelHijo.Controls.Add(Hijo);
                Hijo.Dock = DockStyle.Fill;
                Hijo.BringToFront();
                Hijo.Show();
            
        }
    }
}
