using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace G24_interface
{
    static class Calculations
    {
        private static int ExecuteMemory(int a, int memory, int b)
        {
            int val;
            switch(memory)
            {
                case 0:
                    val = a + b;
                    break;
                case 1:
                    val = a - b;
                    break;
                case 2:
                    val = a * b;
                    break;
                case 3:
                    int c;
                    val = a / b;
                    if (Math.DivRem(a, b, out c) > 0)
                    {
                        val++;
                    }

    
                    break;
                default:
                    val = 0;
                    break;

            }
            return val;
        }

        public static int EnterValue(string str)
        {
            int val = 0;
            int memory = -1;
            List<int> tmp = new List<int>();
            int count = 0;
            tmp.Add(0);
            foreach(char c in str)
            {
                switch(c)
                {
                    case '0':
                        tmp[count] *= 10;
                        tmp[count] += 0;
                        break;
                    case '1':
                        tmp[count] *= 10;
                        tmp[count] += 1;
                        break;
                    case '2':
                        tmp[count] *= 10;
                        tmp[count] += 2;
                        break;
                    case '3':
                        tmp[count] *= 10;
                        tmp[count] += 3;
                        break;
                    case '4':
                        tmp[count] *= 10;
                        tmp[count] += 4;
                        break;
                    case '5':
                        tmp[count] *= 10;
                        tmp[count] += 5;
                        break;
                    case '6':
                        tmp[count] *= 10;
                        tmp[count] += 6;
                        break;
                    case '7':
                        tmp[count] *= 10;
                        tmp[count] += 7;
                        break;
                    case '8':
                        tmp[count] *= 10;
                        tmp[count] += 8;
                        break;
                    case '9':
                        tmp[count] *= 10;
                        tmp[count] += 9;
                        break;
                    case '+':
                        
                        
                        if(memory > -1)
                        {
                            tmp[count] = ExecuteMemory(tmp[count - 1], memory, tmp[count]);
                            memory = -1;
                        }
                        tmp.Add(0);
                        count++;
                        memory = 0;
                        break;
                    case '-':
                        
                        if (memory > -1)
                        {
                            tmp[count] = ExecuteMemory(tmp[count - 1], memory, tmp[count]);
                            memory = -1;
                        }
                        tmp.Add(0);
                        count++;
                        memory = 1;
                        break;
                    case '*':
                        
                        if (memory > -1)
                        {
                            tmp[count] = ExecuteMemory(tmp[count - 1], memory, tmp[count]);
                            memory = -1;
                        }
                        tmp.Add(0);
                        count++;
                        memory = 2;
                        break;
                    case '/':
                        
                        if (memory > -1)
                        {
                            tmp[count] = ExecuteMemory(tmp[count - 1], memory, tmp[count]);
                            memory = -1;
                        }
                        tmp.Add(0);
                        count++;
                        memory = 3;
                        break;
                    default:
                        break;
                }

            }
            val = ExecuteMemory(tmp[count - 1], memory, tmp[count]);
            return val;
        }
    }
}
