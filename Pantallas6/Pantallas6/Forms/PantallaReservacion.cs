using Esquizofrenia.Dao;
using Esquizofrenia.modelo;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Pantallas6.Forms
{
    public partial class PantallaReservacion : Form
    {
        private bool arrastre = false;
        private Point mouseOffset;
        private Panel[] mesas;
        Cliente cliente = new Cliente();

        public PantallaReservacion()
        {
            InitializeComponent();
            botonMoverMesas.Click += botonMoverMesas_Click;

            mesas = new Panel[] { mesa1, mesa2, mesa3, mesa4, mesa5, mesa6, mesa7, mesa8, mesa9 };

            foreach (Panel mesa in mesas)
            {
                mesa.MouseDown += mesa_MouseDown;
                mesa.MouseMove += mesa_MouseMove;
                mesa.MouseUp += mesa_MouseUp;
            }
        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void panel8_Paint(object sender, PaintEventArgs e)
        {

        }

        private void botonMoverMesas_Click(object sender, EventArgs e)
        {
            arrastre = true;
        }

        private void mesa_MouseDown(object sender, MouseEventArgs e)
        {
            mouseOffset = new Point(-e.X, -e.Y);
        }

        private void mesa_MouseMove(object sender, MouseEventArgs e)
        {
            if (arrastre)
            {
                Panel panel = sender as Panel;
                Point mousePos = Control.MousePosition;
                mousePos.Offset(mouseOffset.X, mouseOffset.Y);
                panel.Location = panel.Parent.PointToClient(mousePos);
            }
        }

        private void mesa_MouseUp(object sender, MouseEventArgs e)
        {
            arrastre = false;
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void PantallaReservacion_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e) //botonConfirmar
        {
            string correo = txtCorreo.Text;

            String nroTelefono = txtNumeroTelefono.Text;
            if (nroTelefono.Length != 10)
            {
                MessageBox.Show("Ingrese un número de telefono válido");
                return;
            }

            string hora = txtHora.Text;
            DateTime date;

            if (DateTime.TryParse(hora, out date))
            {
                // La conversión fue exitosa, 'date' ahora tiene el valor de tipo DateTime.
            }
            else
            {
                MessageBox.Show("Formato de hora inválido. Ingrese la hora en un formato correcto.");
                return;
            }
            string mesaSeleccion = txtMesaSeleccion.Text;

            if (string.IsNullOrWhiteSpace(mesaSeleccion))
            {
                MessageBox.Show("Complete el campo de selección de mesa.");
                return;
            }

            if (!int.TryParse(mesaSeleccion, out int nroMesa) || nroMesa < 1 || nroMesa > 9)
            {
                MessageBox.Show("Ingrese un número de mesa válido entre 1 y 9.");
                return;
            }

           

                Reserva reservita = new Reserva(date, hora);
                Cliente cli = new Cliente(correo, nroTelefono);
                Mesa mesita = new Mesa(nroMesa);
                
                ReservaDAO rDAO = new ReservaDAO();
                rDAO.reservarMesa(cli, mesita, reservita);

                MesaDAO mesaReservada = new MesaDAO();
                cambiarColorDeLaMesa(nroMesa);
                mesaReservada.modificarEstadoReservada(nroMesa);
            
        }

        public void cambiarColorDeLaMesa(int num)
        {
            string nombrePanel = "mesa" + num; 
            Control[] foundControls = this.Controls.Find(nombrePanel, true);

            if (foundControls.Length > 0 && foundControls[0] is Panel)
            {
                Panel panelMesa = (Panel)foundControls[0]; 
                panelMesa.BackColor = Color.Red;
            }


        }
    }
}
