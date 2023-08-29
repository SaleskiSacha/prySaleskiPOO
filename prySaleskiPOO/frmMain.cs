using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace prySaleskiPOO
{
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();
        }

        private void btnCrear_Click(object sender, EventArgs e)
        {
            ClassPeronsaje objeto = new ClassPeronsaje();

            objeto.nombre = txtNombre.Text;
            objeto.fuerza = Convert.ToInt32(txtFuerza.Text);
            objeto.destreza = Convert.ToInt32(txtFuerza.Text);

            lblAqui.Text += objeto.nombre + "-" +
                            objeto.fuerza + "-" +
                            objeto.destreza + "\n";
        }
    }
}
