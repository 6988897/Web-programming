using System.Text;
using System.Threading.Tasks;

namespace WebProg
{
    internal class kyu5_3
    {
        //Вес строки равен сумме весов всех её цифр.
        //Вам нужно отсортировать строки в порядке возрастания веса.
       public static string orderWeight(string str)
        {
            
            string[] numbers = str.Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);

            
            for (int i = 0; i < numbers.Length - 1; i++)
            {
                for (int j = i + 1; j < numbers.Length; j++)
                {
                    int weightA = 0;
                    foreach (char c in numbers[i])
                    {
                        weightA += c - '0';
                     }
                    int weightB = 0;

                    foreach (char c in numbers[j])
                    {
                        weightB += c - '0';
                    }

                    if (weightA > weightB || (weightA == weightB && string.Compare(numbers[i], numbers[j], StringComparison.Ordinal) > 0))
                    {
                        
                        string temp = numbers[i];
                        numbers[i] = numbers[j];
                        numbers[j] = temp;
                    }
                }
            }

            return string.Join(" ", numbers);
        }

     
    }
}