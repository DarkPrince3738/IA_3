using System;

namespace Task6
{
    class Program
    {
        static void Main(string[] args)
        {
            int step = 1;
            string passInfo;
            string illInfo;
            string allerInfo;
            string depInfo;
            string insInfo;

            while (true)
            {                
                switch (step)
                {
                    case 1:
                        Console.WriteLine("Registration");
                        Console.WriteLine("Step 1 Write passport info");
                        passInfo = Console.ReadLine();
                        step++;
                        break;
                    case 2:
                        Console.WriteLine("Step 2 Write your ill yes/no");
                        var trueIllInfo = Console.ReadLine();
                        if (trueIllInfo == "Yes")
                        {
                            Console.WriteLine("Write all ill which you have");
                            illInfo = Console.ReadLine();
                        }
                        step++;
                        break;
                    case 3:
                        Console.WriteLine("Step 3 Write your allergie yes/no");
                        var trueAllerInfo = Console.ReadLine();
                        if (trueAllerInfo == "Yes")
                        {
                            Console.WriteLine("Write all allergie which you have");
                            allerInfo = Console.ReadLine();
                        }
                        step++;
                        break;
                    case 4:
                        Console.WriteLine("Step 4 Write your dependence yes/no");
                        var trueDepInfo = Console.ReadLine();
                        if (trueDepInfo == "Yes")
                        {
                            Console.WriteLine("Write all dep which you have");
                            depInfo = Console.ReadLine();
                        }
                        step++;
                        break;
                    case 5:
                        Console.WriteLine("Step 5 Write your insurance yes/no");
                        var trueInsInfo = Console.ReadLine();
                        if (trueInsInfo == "Yes")
                        {
                            Console.WriteLine("Write all ins which you have");
                            insInfo = Console.ReadLine();
                        }
                        step++;
                        break;

                    default:
                        Console.WriteLine("Do u want to finish");
                        string answer = Console.ReadLine();
                        if (answer == "Yes")
                        {
                            Console.WriteLine($"Step1 - {passInfo}, Step2 - {illInfo}, Step3 - {allerInfo}, Step4 - {depInfo}, Step5 - {insInfo}");
                        }
                        break;
                }
                Console.WriteLine("Do u want to change step");
                var trueChangeStep = Console.ReadLine();
                if (trueChangeStep == "Yes")
                {
                    Console.WriteLine("Choose step");
                    step = int.Parse(Console.ReadLine());
                }
            }


            

            

            

        }
    }
}
