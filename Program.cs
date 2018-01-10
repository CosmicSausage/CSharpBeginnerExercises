using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpBeginnerExercises
{
    class Program
    {
        static void Main(string[] args)
        {
            var consecutiveNumberDetector = new ConsecutiveNumberDetector();
            consecutiveNumberDetector.GetNumbers();
            consecutiveNumberDetector.CheckIfAscendentOrDescendent();
            Console.WriteLine(consecutiveNumberDetector.CheckIfAscendentOrDescendent());
            //consecutiveNumberDetector.ReturnIfNumberSecuenceIsConsecutiveOrNot();
        }
    }
}
