using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FreeChalleng.MediaLibrary.Class
{
    public abstract class Media
    {
        public string Loanee { private get; set; }
        public bool OnLoan { private get; set; }
        public string GetDisplayText()
        {
            if (OnLoan)
            {
                if (String.IsNullOrEmpty(Loanee))
                {
                    return ToString() + " is currently loan";
                }

                return ToString() + $"is currently loan by: {Loanee}";

            }

            return ToString();
        }

        public void Loan(string loanee)
        {
            Loan();
            Loanee = loanee;
        }

        public void Loan()
        {
            OnLoan = true;
        }

    }
}
