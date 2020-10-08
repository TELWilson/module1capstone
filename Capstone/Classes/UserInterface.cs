using System;
using System.Collections.Generic;
using System.Text;

namespace Capstone.Classes
{
    /// <summary>
    /// This class provides all user communications, but not much else.
    /// All the "work" of the application should be done elsewhere
    /// ALL instances of Console.ReadLine and Console.WriteLine should 
    /// be in this class.
    /// </summary>
    public class UserInterface
    {
        private Catering catering = new Catering();

        public void RunInterface()
        {
            bool done = false;
            while (!done)
            {
                Console.WriteLine("This is the UserInterface");
                Console.ReadLine();
                // need to generate main menu
                //need to generate sub menu when 2 Order is selected
                //will need a swtich to turn the main menu on and off
                // will need a switch to turn sub menu on and off
                // see module 1 review user interface

                //need to generate a report that shows users transaction history when transaction completed
                //need item count, type, description, item price, and total for item as well as total for transaction
                //display main menu
            }

        }
    }
}
