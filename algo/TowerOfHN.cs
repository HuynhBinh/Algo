using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace algo
{
    class TowerOfHN
    {
        
        public void move(int numberOdDisc, String startPeg, String sparePeg, String endPeg)
        {
            if(numberOdDisc == 1)
            {
                print(numberOdDisc, startPeg, endPeg, "BASE");
                //System.Console.WriteLine(startPeg + " -> " + endPeg);
            }
            else
            {
                move(numberOdDisc - 1, startPeg, endPeg, sparePeg);
                print(numberOdDisc, startPeg, endPeg, "RE  ");
                //System.Console.WriteLine(startPeg + " -> " + endPeg);
                move(numberOdDisc - 1, sparePeg, startPeg, endPeg);
            }
        }


        public void print(int n, String startPeg, String endPeg, String where)
        {
            System.Console.WriteLine( where + " : " + "move disc " + n + " from " + startPeg + " to " + endPeg);
        }
    }
}
