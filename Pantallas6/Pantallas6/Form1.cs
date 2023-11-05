using Pantallas6.Forms;
using Esquizofrenia.Dao;
using Esquizofrenia.modelo;
using System.Collections;

namespace Pantallas6
{
    public partial class Form1 : Form
    {
        PantallaSideBar pSideBar;
        PantallaRegister pRegister;
        Form pSideBarAdmin;
        bool dragging = false;
        Point dragCursorPoint;
        Point dragFormPoint;


        Cliente cliente = new Cliente();
        ClienteDAO bd = new ClienteDAO();
        public Form1()
        {
            InitializeComponent();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            pRegister = new PantallaRegister();
            pRegister.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (credencialesValidas())
            {
                ArrayList datos = bd.logins(enviar());
                if (datos.Count > 0)
                {
                    string ID = datos[0].ToString();
                    MessageBox.Show("Bienveni2");
                    pSideBar = new PantallaSideBar();
                    pSideBar.Show();
                    this.Hide();
                }
                else
                {
                    MessageBox.Show("Error: Usuario y/o contraseña incorrectos.");
                }
            }
            else
            {
                MessageBox.Show("Error: Ingrese usuario y contraseña válidos.");
            }

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        public Cliente enviar()
        {
            cliente.User = nombreBox.Text;
            cliente.Password = contraBox.Text;
            return cliente;
        }

        public bool credencialesValidas()
        {
            if (nombreBox.Text.TrimStart() == String.Empty)
            {
                MessageBox.Show("Ingrese un nombre de usuario válido.");
            }
            else if (contraBox.Text.TrimStart() == String.Empty)
            {
                MessageBox.Show("Ingrese una contraseña válida.");
            }
            else
            {
                return true;
            }

            return false;
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void Form1_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {

                dragging = true;
                dragCursorPoint = Cursor.Position;
                dragFormPoint = this.Location;

            }
        }

        private void Form1_MouseMove(object sender, MouseEventArgs e)
        {
            if (dragging)
            {
                Point dif = Point.Subtract(Cursor.Position, new Size(dragCursorPoint));
                this.Location = Point.Add(dragFormPoint, new Size(dif));

            }
        }

        private void Form1_MouseUp(object sender, MouseEventArgs e)
        {
            dragging = false;
        }

    }
}