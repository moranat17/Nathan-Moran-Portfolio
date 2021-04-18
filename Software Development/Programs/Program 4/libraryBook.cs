using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prog4
{
    class LibraryBook
    {
        //Boolean field for the checkout status
        public bool checkoutStatus = false;

        //precondition get: nothing
        //postcondition get: Returns value for title
        //precondition set: nothing
        //postcondition set: value set for title
        public string Title { get; set; }

        //precondition get: nothing
        //postcondition get: returns value for author
        //precondition set: nothing
        //postcondition set: value set for author
        public string Author { get; set; }

        //precondition get: nothing
        //postcondition get: returns value for publisher
        //precondition set: nothing
        //postcondition set: value set for publisher
        public string Publisher { get; set; }


        private int copyrightYear;
        public int CopyrightYear
        {
            //precondition: nothing
            //postcondition: returns value of copyrightYear
            get
            {
                return copyrightYear;
            }
            //precondition: tests if copyrightYear is greater than 0
            //postcondtition: Sets copyrightYear = to value of copyrightYear or 2018 dependig on if it is greater than 0
            set
            {
                if (copyrightYear >= 0)
                    copyrightYear = value;
                else
                    copyrightYear = 2018;
            }
        }

        //precondition get: nothing
        //postcondition get: returns value for call number
        //precondition set: nothing
        //postcondition set: value set for call number
        public string CallNumber { get; set; }

        //precondition: accepts 5 parameters to construct object
        //postocndition: object constructed with properties set above
        public LibraryBook(string t, string a, string p, int cy, string cn, bool co)
        {
            Author = a;
            Title = t;
            Publisher = p;
            CopyrightYear = cy;
            CallNumber = cn;
            co = IsCheckedOut();

        }


        //precondition: check out status is false
        //postcondition: check out status changed to true
        public void CheckOut()
        {

            checkoutStatus = true;

        }

        //precondition: check out status is true
        //postcondition: check out status is returned to false because book has been returned
        public void ReturnToShelf()
        {
            checkoutStatus = false;

        }


        //precondition: nothing
        //postcondition: returns boolean value of check out status
        public bool IsCheckedOut()
        {
            return checkoutStatus;
        }


        //precondition: ToString() method is in original form
        //postcondition: ToString() method is overridden returning string with object's properties and check out status
        public override string ToString()
        {
            return $"Title: {Title + Environment.NewLine}Author: {Author + Environment.NewLine}Publisher: {Publisher + Environment.NewLine}Copyright Year: {CopyrightYear + Environment.NewLine}Call Number: {CallNumber + Environment.NewLine}Check Out Status: {checkoutStatus + Environment.NewLine}";

        }
    }
}
