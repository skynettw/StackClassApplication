using System;

namespace MyAppClassTest1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            MyStack stack = new MyStack();
            string cmd;
            int x, y;
            int result;
            do
            {
                Console.Write(">>>");
                cmd = Console.ReadLine();
                if (cmd == "quit" || cmd == "exit")
                    break;
                else if (cmd == "pop")
                {
                    _ = stack.Pop();
                    stack.Show();
                }
                else if (cmd == "show")
                {
                    stack.Show();
                } else 
                {
                    if (cmd.Length == 1)
                    {
                        switch (cmd[0])
                        {
                            case '+':
                                x = Convert.ToInt32(stack.Pop());
                                y = Convert.ToInt32(stack.Pop());
                                result = x + y;
                                stack.Push(Convert.ToString(result));
                                Console.WriteLine(result);
                                stack.Show();
                                break;
                            case '-':
                                x = Convert.ToInt32(stack.Pop());
                                y = Convert.ToInt32(stack.Pop());
                                result = x - y;
                                stack.Push(Convert.ToString(result));
                                Console.WriteLine(x - y);
                                stack.Show();
                                break;
                            case '*':
                                x = Convert.ToInt32(stack.Pop());
                                y = Convert.ToInt32(stack.Pop());
                                result = x * y;
                                stack.Push(Convert.ToString(result));
                                Console.WriteLine(x * y);
                                stack.Show();
                                break;
                            case '/':
                                x = Convert.ToInt32(stack.Pop());
                                y = Convert.ToInt32(stack.Pop());
                                result = (int) ((double) x / (double) y);
                                stack.Push(Convert.ToString(result));
                                Console.WriteLine(result);
                                stack.Show();
                                break;
                            default:
                                bool isNumeric = int.TryParse(cmd, out _); 
                                if (isNumeric)
                                    stack.Push(cmd);
                                break;
                        }
                    }
                    else
                    {
                        bool isNumeric = int.TryParse(cmd, out _); 
                        if (isNumeric) 
                            stack.Push(cmd);
                    }
                        
                }
            } while (true);
        }
    }
}
