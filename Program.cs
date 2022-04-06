using System;

namespace MyAppClassTest1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //MyClass m = new (10, 15);

            //m.display();
            //Random rand = new Random();
            //BMI bmi = new BMI(Convert.ToDouble(rand.Next(60,120)), Convert.ToDouble(rand.Next(150, 190)));
            //Console.WriteLine(bmi.compute());
            //string name = "Richard";
            //Console.WriteLine("Hello, {0}, {1}", name, "You");
            //Random random = new Random();    
            //int answer = random.Next(1, 100);
            //int guess=0;
            //Console.WriteLine(answer);
            //do
            //{
            //    Console.Write("Please guess a number:");
            //    guess = Convert.ToInt32(Console.ReadLine());
            //    if (guess == answer)
            //    {
            //        Console.WriteLine("You are right!");
            //        break;
            //    }
            //    else
            //    {
            //        if (guess > answer)
            //        {
            //            Console.WriteLine("Too large, try again");
            //        }
            //        else
            //        {
            //            Console.WriteLine("Too small, try again");
            //        }
            //    }
            //} while (true);
            //Console.WriteLine("Thank you");
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
