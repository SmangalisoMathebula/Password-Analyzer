namespace ITECAO_project
{
    public partial class StartForm : Form
    {
        public StartForm()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string name = txtName.Text;

            bool isValid = true;

            if (name == "")
            {
                isValid = false;
            }

            for (int i = 0; i < name.Length; i++)
            {
                char c = name[i];
                if (!char.IsLetter(c) && c != ' ')
                {
                    isValid = false;
                }
            }

            if (!isValid)
            {
                MessageBox.Show("Please enter a valid name (letters and spaces only).");
                return;
            }

            MainForm mainForm = new MainForm();
            mainForm.Show();
            this.Hide();
        }
    }
}
