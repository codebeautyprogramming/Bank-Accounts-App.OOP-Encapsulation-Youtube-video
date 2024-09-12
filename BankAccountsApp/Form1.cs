namespace BankAccountsApp
{
    public partial class Form1 : Form
    {
        List<BankAccount> BankAccounts = new List<BankAccount>();
        public Form1()
        {
            InitializeComponent();
        }

        private void CreateAccountBtn_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(OwnerTxt.Text))
                return;

            BankAccount bankAccount = new BankAccount(OwnerTxt.Text);
            BankAccounts.Add(bankAccount);

            RefreshGrid();
            OwnerTxt.Text = string.Empty;
        }

        private void RefreshGrid()
        {
            BankAccountsGrid.DataSource = null;
            BankAccountsGrid.DataSource = BankAccounts;
        }
    }
}
