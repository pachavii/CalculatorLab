using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CPE200Lab1
{
    class RPNCalculatorEngine : CalculatorEngine
    {
        public string Process(string str)
        {
            string result = string.Empty;
            Stack<string> rpnstack = new Stack<string>();
            //split string to list array
            List<string> parts = str.Split(' ').ToList<string>();
            //loop for each element --> till when?
            //if isNumber
            //Push to stack
            //if isOperation
            //pop second operand
            //pop first operand
            //result = calculate(operator,first,second)
            //push result
            foreach (string item in parts)
            {
                if (isNumber(item))
                {
                    rpnstack.Push(item);
                }
                if (isOperator(item))
                {
                    String second = rpnstack.Pop();
                    string first = rpnstack.Pop();
                    result = calculate(item, first, second);
                    rpnstack.Push(result);
                }
            }


            return result;
        }

    }
}