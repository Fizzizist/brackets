using System;

namespace brackets
{
    class Program
    {
        static void Main(string[] args)
        {
            string brack = Console.ReadLine();
            bool isEven = true;
            int curly = 0;
            int round = 0;
            int square = 0;
            char temp;

            //Check for even number of chars, if not then already false
            if (brack.Length % 2 != 0) isEven = false;

            //Check that each bracket it open and closed
            for (int i = 0; i < brack.Length;i++){
                if (brack[i] == '(') round++;
                if (brack[i] == '{') curly++;
                if (brack[i] == '[') square++;
                if (brack[i] == ')') round--;
                if (brack[i] == '}') curly--;
                if (brack[i] == ']') square--;
            }

            //Check that an open bracket is not proceeded by a closed bracket of the wrong type
            for (int j = 0; j < brack.Length - 1;j++){
                temp = brack[j];
                switch (temp){
                    case '(':
                        if (brack[j + 1] == ']' || brack[j + 1] == '}') isEven = false;
                        break;
					case '[':
                        if (brack[j + 1] == ')' || brack[j + 1] == '}') isEven = false;
						break;
                    case '{':
                        if (brack[j + 1] == ']' || brack[j + 1] == ')') isEven = false;
						break;
                    default:
                        break;
                }
            }

            //Final output
            if (isEven) Console.WriteLine("Yes");
            if (!isEven) Console.WriteLine("No");
        }
    }
}
