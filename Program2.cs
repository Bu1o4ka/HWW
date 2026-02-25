using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;

namespace HomeWW
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> list = new List<int>() { 3, 30, 34, 5, 9 };
            string result = Biggest(list);
            Console.WriteLine(result);
        }

        static string Biggest(List<int> list)
        {
            List<string> listStr = new List<string>();
            for (int i = 0; i < list.Count; i++)
            {
                listStr.Add(list[i].ToString());
            }
            for (int i = 0; i < listStr.Count - 1; i++)
            {
                for (int j = 0; j < listStr.Count - 1 - i; j++)
                {
                    if (Bigger(listStr[j], listStr[j + 1]) == false)
                    {
                        string temp = listStr[j];
                        listStr[j] = listStr[j + 1];
                        listStr[j + 1] = temp;
                    }
                }
            }

            string u = "";
            for (int i = 0; i < listStr.Count; i++)
            {
                u+= listStr[i].ToString();
            }
            return u;
        }
        
         static bool Bigger(string a, string b)
        {
            string A = a + b;
            string B = b + a;
            if (A.Length == B.Length)
            {
                return string.Compare(A, B) > 0;
            }
            for (int i = 0; i < Math.Min(A.Length, B.Length); i++)
            {
                if (A[i] > B[i])
                    return true;
                if (A[i] < B[i])
                    return false;
            }

            return A.Length > B.Length;
        }
    }
}
