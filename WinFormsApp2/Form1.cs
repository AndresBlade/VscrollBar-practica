namespace WinFormsApp2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnAdd_Click(object sender, EventArgs e)
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

            
            lstNames.Items.Add(txtName.Text);
        }

        private void txtName_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyValue == 13) //If the user pressed enter
            {
                btnAdd_Click(new Object(), new EventArgs());
            }
        }
    }
}