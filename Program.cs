namespace atm
{
    class Program
    {



        static void Main()
        {
            Console.WriteLine("Please Insert your atm card");
            Console.ReadLine();
            int Count = 0;
            int Pin;
            for (int i = 0; i < 4; i++)
            {
                Console.Write("Please Enter your Pin Number :");
                Pin = int.Parse(Console.ReadLine());
                if (Pin == 2541)
                {

                    Console.WriteLine("Please Enter Your Amount: ");
                    Count = 1;
                    break;

                }
                else
                {
                    Console.WriteLine("Enter Vailid Pin ");


                }

            }
            if (Count != 1)
            {
                Console.WriteLine(" Your Card is Blocked Please Contact your Bank");

            }

            Console.ReadLine();



        }

    }

}



