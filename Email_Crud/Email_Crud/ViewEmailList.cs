using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Email_Crud
{
  public class ViewEmailList
    {
        List<Email> viewList = new List<Email>();
        public ViewEmailList(List<Email> emailList)
        {
            this.viewList = emailList;
        }
        public void ShowEmail()
        {
            if (viewList.Count > 0)
            {
                Console.WriteLine("EmailId\tName\tEmail\n");
                foreach(var view in viewList)
                {
                    Console.WriteLine("{0}\t{1}\t{2}",view.EmailId,view.Name,view.EmailAddress + "\n");
                }
            }
            else
            {
                Console.WriteLine("EmailId\tName\tEmail\n");
                Console.WriteLine("List is Empty please Go To Choise 1 for Add The Employees \n");
            }
        }
    }
}
