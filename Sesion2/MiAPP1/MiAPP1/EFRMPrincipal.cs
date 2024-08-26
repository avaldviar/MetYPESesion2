using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MiAPP1.clases;


namespace MiAPP1
{
    public partial class EFRMPrincipal : Form
    {
        public EFRMPrincipal()
        {
            InitializeComponent();
        }

        private void EFRMPrincipal_Click(object sender, EventArgs e)
        {
            Persona persona = new Persona();
            persona.Nombre = tbNombre.Text;
            persona.FechaNac = dtpFechaNac.Text;
            Mesa

        }

    }
}
