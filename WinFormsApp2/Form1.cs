using System.Globalization;

namespace WinFormsApp2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void addName()
        {
            if (string.IsNullOrWhiteSpace(txtName.Text.Trim()))
            {
                MessageBox.Show("El nombre debe incluir al menos una letra", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (lstNames.Items.Contains(txtName.Text))
            {
                MessageBox.Show("El nombre ya está incluido en la lista", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;


            }

            string name = txtName.Text.Substring(0, 1).ToUpper() + txtName.Text.Substring(1).ToLower();


            lstNames.Items.Add(name);
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            addName();
        }

        private void txtName_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyValue == 13) //If the user pressed enter
            {
                addName();
            }
        }
    }
}