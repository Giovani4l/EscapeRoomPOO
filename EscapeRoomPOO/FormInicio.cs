using System.Windows.Forms;

namespace EscapeRoomPOO
{
    public partial class FormInicio : Form
    {
        public FormInicio()
        {
            InitializeComponent();
            lblMejor.Text = $"Mejor puntaje: {RepositorioPuntajes.LeerMejorPuntaje()} pts";
        }

        private void btnJugar_Click(object sender, System.EventArgs e)
        {
            Hide();
            new FormJuego().ShowDialog(this);
            lblMejor.Text = $"Mejor puntaje: {RepositorioPuntajes.LeerMejorPuntaje()} pts";
            Show();
        }

        private void btnHistorial_Click(object sender, System.EventArgs e)
        {
            MessageBox.Show(
                RepositorioPuntajes.LeerHistorial(),
                "Historial",
                MessageBoxButtons.OK,
                MessageBoxIcon.Information);
        }
    }
}
