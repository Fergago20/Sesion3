namespace Ejercicio1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            agregar();
        }
        public void agregar()
        {

            string nombre = tbNombre.Text.Trim();
            if (string.IsNullOrEmpty(nombre))
            {
                MessageBox.Show("No se puede quedar vacío el nombre");
                tbNombre.Focus();
                return;
            }
            cmbNombres.Items.Add(nombre);
            tbNombre.Text = " ";
            tbNombre.Focus();
            return;
        }

        private void btMover_Click(object sender, EventArgs e)
        {
            int cant= cmbNombres.Items.Count;
            for (int i = 0; i < cant; i++)
            {
                string nombre = cmbNombres.Items[i].ToString();
                cmbNombre2.Items.Add(nombre);
            }
        }
    }
}
