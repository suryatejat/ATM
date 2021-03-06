using System;
using System.Collections.Generic;

namespace Bank
{   
    public class Options
    {
        public void OptionsPrinter(List<BankDetails> l,int userPin,int userAccount){
            // Available options for the user.
            string[] options={"Deposit Amount","Withdraw Amount","Transfer Amount","Print Transaction History","LogOut"};
            Console.WriteLine("\n");
            for(int i=0;i<options.Length;i++) // Printing the Available options.
            {
                Console.WriteLine("("+(i+1)+") "+options[i]);
            }
            Console.WriteLine("\nPlease select an option");
            string userOption=Console.ReadLine();
            Choose choice=new Choose();
            choice.ChooseOptions(userOption,l,userPin,userAccount); // Calling the Choice class.
        }
    }
}