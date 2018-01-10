using static System.Console;
using static System.Convert;
namespace CSharpBeginnerExercises
{
    class ConsecutiveNumberDetector
    {
        public bool IsAscendent { get; set; }
        public string[] Input { get; set; }
        public void GetNumbers()
        {
            WriteLine("Insert numbers separated by hyphens:");
            Input = ReadLine()?.Split('-');
        }
        public bool CheckIfAscendentOrDescendent()
        {
            for (var i = 0; i < Input.Length; i++)
            {
                if (ToInt16(Input[i]) < ToInt16(Input[i]) + 1)
                    IsAscendent = true;
                else if (ToInt16(Input[i]) > ToInt16(Input[i]) - 1)
                    IsAscendent = false;
            }

            return IsAscendent;
        }

        public void ReturnIfNumberSecuenceIsConsecutiveOrNot()
        {
            var firstValue = ToInt16(Input[0]);
            var isConsecutive = true;

            if (ToInt16(Input[0]) > ToInt16(Input[1]))
            {
                for (int i = 0; i < Input.Length; i++)
                {
                    if (ToInt32(Input[i]) + i == firstValue) continue;
                    isConsecutive = false;
                    break;
                }
            }
            else
            {
                for (int i = 0; i < Input.Length; i++)
                {
                    if (ToInt32(Input[i]) - i == firstValue) continue;
                    isConsecutive = false;
                    break;
                }
            }

            if (isConsecutive)
                WriteLine("The number secuence is consecutive.");
            else
                WriteLine("The number secuence is not consecutive.");
        }
    }
}
