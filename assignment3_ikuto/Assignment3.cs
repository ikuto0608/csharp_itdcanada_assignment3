using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace assignment3_ikuto
{
    public partial class Assignment3 : Form
    {
        List<AccountHolder> accountHolders = new List<AccountHolder>();

        public Assignment3()
        {
            InitializeComponent();
        }

        private void Assignment3_Load(object sender, EventArgs e)
        {
            bankTabs.TabPages.Remove(mainTab);
        }

        private void loginBtn_Click(object sender, EventArgs e)
        {
            if (accountIDTbx.Text == "" || passwordTbx.Text == "")
            {
                MessageBox.Show("Your ID or Password is empty!");
                return;
            }

            int accountID = Convert.ToInt32(accountIDTbx.Text);
            string password = passwordTbx.Text;

            accountHolders = AccountHolder.findByAccountID(accountID);

            if (accountHolders.Count() > 0)
            {
                MessageBox.Show("Login succeded!");
                bankTabs.TabPages.Add(mainTab);
                bankTabs.TabPages.Remove(loginTab);

                displayAccountHolsers(accountHolders);
                displayTransactions(accountHolders.First().id);
            }
            else
            {
                MessageBox.Show("Your ID or Password is wrong!");
            }
        }

        private void logoutBtn_Click(object sender, EventArgs e)
        {
            accountHolders.Clear();
            bankTabs.TabPages.Add(loginTab);
            bankTabs.TabPages.Remove(mainTab);

            accountIDTbx.Clear();
            passwordTbx.Clear();
        }

        private void accountTypeCbx_SelectedIndexChanged(object sender, EventArgs e)
        {
            balanceLv.Text = "Blance: " + accountHolders[accountTypeCbx.SelectedIndex].balance.ToString();
            accountHolderIDLv.Text = accountHolders[accountTypeCbx.SelectedIndex].id.ToString();

            displayTransactions(accountHolders[accountTypeCbx.SelectedIndex].id);
        }

        private void submitBtn_Click(object sender, EventArgs e)
        {
            AccountHolder accountHolder = AccountHolder.findByID(Convert.ToInt32(accountHolderIDLv.Text));
            string transactType = transactTypeCbx.Text;
            string childClassName = accountHolder.GetType().Name;

            if (childClassName == "Visa")
            {
                Visa visaAccountHolder = accountHolder as Visa;
                if (visaAccountHolder.isOverLimit(Convert.ToInt32(amountTbx.Text)))
                {
                    MessageBox.Show("You cannot be over your credit limit!");
                    return;
                }
                if (transactType == "Deposit")
                {
                    MessageBox.Show("Visa account cannot deposit!");
                    return;
                }
            }

            if (transactType == "Withdraw" || transactType == "Transfer")
            {
                withdrawOrTranfer(accountHolder);
            }
            else
            {
                deposit(accountHolder);
            }

            accountHolders = AccountHolder.findByAccountID((int)accountHolder.account_number);
            displayAccountHolsers(accountHolders);
            displayTransactions((int)accountHolder.id);

            MessageBox.Show("Succeeded transaction!");
        }

        private void withdrawOrTranfer(AccountHolder accountHolder)
        {
            if (Convert.ToDouble(amountTbx.Text) > accountHolder.balance)
            {
                MessageBox.Show("You cannot be over your balance!");
                return;
            }

            Transcript transcript = new Transcript();
            transcript.transaction_type = transactTypeCbx.Text;
            transcript.amount = Convert.ToDouble(amountTbx.Text);
            transcript.account_holder_id = Convert.ToInt32(accountHolderIDLv.Text);
            transcript.save();

            accountHolder.balance -= transcript.amount;
            accountHolder.save();
        }

        private void deposit(AccountHolder accountHolder)
        {
            Transcript transcript = new Transcript();
            transcript.transaction_type = transactTypeCbx.Text;
            transcript.amount = Convert.ToDouble(amountTbx.Text);
            transcript.account_holder_id = Convert.ToInt32(accountHolderIDLv.Text);
            transcript.save();

            accountHolder.balance += transcript.amount;
            accountHolder.save();
        }

        private void displayAccountHolsers(List<AccountHolder> accountHolders)
        {
            accountTypeCbx.Items.Clear();

            foreach (AccountHolder accountHolder in accountHolders)
            {
                accountTypeCbx.Items.Add(accountHolder.GetType().Name);
            }

            accountIDLv.Text = accountHolders.First().account_number.ToString();
            accountHolderIDLv.Text = accountHolders.First().id.ToString();
            accountTypeCbx.Text = accountHolders.First().account_type.ToString();
            balanceLv.Text = "Blance: " + accountHolders.First().balance;
        }
  
        private void displayTransactions(int accountHolderID)
        {
            transactionLvx.Clear();

            foreach (string propertyName in Transcript.PROPERTY_NAMES)
            {
                if (propertyName == "ID")
                {
                    transactionLvx.Columns.Add(propertyName, 40, HorizontalAlignment.Left);
                }
                else
                {
                    transactionLvx.Columns.Add(propertyName, 110, HorizontalAlignment.Left);
                }
            }

            List<Transcript> transcripts = Transcript.findByAccountHolderID(accountHolderID);
            foreach (Transcript transcript in transcripts)
            {
                ListViewItem item = new ListViewItem(transcript.id.ToString());
                item.SubItems.Add(transcript.transacted_at.ToString());
                item.SubItems.Add(transcript.transaction_type);
                item.SubItems.Add(transcript.amount.ToString());
                item.SubItems.Add(transcript.account_holder_id.ToString());

                transactionLvx.Items.Add(item);
            }
        }
    }
}
