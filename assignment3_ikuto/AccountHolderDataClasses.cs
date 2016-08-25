using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;

namespace assignment3_ikuto
{
    partial class AccountHolder
    {
        public bool save()
        {
            AccountHolderDataClassesDataContext dc = new AccountHolderDataClassesDataContext();
            if (this.id > 0)
            {
                AccountHolder accountHolder = dc.AccountHolders.Single(a => a.id == this.id);
                accountHolder.account_number = this.account_number;
                accountHolder.account_type = this.account_type;
                accountHolder.balance = this.balance;
                accountHolder.client_id = this.client_id;

                dc.SubmitChanges();
            }
            else
            {
                dc.AccountHolders.InsertOnSubmit(this);
            }

            return true;
        }

        public static AccountHolder findByID(int id)
        {
            AccountHolderDataClassesDataContext dc = new AccountHolderDataClassesDataContext();
            var results = from accountHolder in dc.AccountHolders
                          where accountHolder.id == id
                          select accountHolder;

            return results.First<AccountHolder>();
        }

        public static List<AccountHolder> findByAccountID(int id)
        {
            AccountHolderDataClassesDataContext dc = new AccountHolderDataClassesDataContext();
            var results = from accountHolder in dc.AccountHolders
                          where accountHolder.account_number == id
                          select accountHolder;

            return results.ToList<AccountHolder>();
        }
    }

    partial class Visa
    {
        public bool isOverLimit(int amount)
        {
            if (this.credit_limit < amount)
            {
                return true;
            }
            return false;
        }
    }

    public partial class Transcript
    {
        public static string[] PROPERTY_NAMES = new string[] { "ID", "Transacted At", "Transaction Type", "Amount", "Account Holder ID" };
        
        public static List<Transcript> findByAccountHolderID(int accountHolderID)
        {
            AccountHolderDataClassesDataContext dc = new AccountHolderDataClassesDataContext();
            var results = from transcript in dc.Transcripts
                          where transcript.account_holder_id == accountHolderID
                          select transcript;
            
            return results.ToList<Transcript>();
        }

        public bool save()
        {
            AccountHolderDataClassesDataContext dc = new AccountHolderDataClassesDataContext();
            if (this.id > 0)
            {
                Transcript transcript = dc.Transcripts.Single(t => t.id == this.id);
                // Todo
                dc.SubmitChanges();
            }
            else
            {
                this.transacted_at = DateTime.Now;
                dc.Transcripts.InsertOnSubmit(this);
                dc.SubmitChanges();
            }
            
            return true;
        }
    }
}