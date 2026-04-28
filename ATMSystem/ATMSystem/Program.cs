using System;

namespace ATMSystem
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("=== CTU SIMPLE ATM SYSTEM ===");
            Console.WriteLine();

            
            Console.Write("Hi, what is your name? ");
            string userName = Console.ReadLine();

            Console.WriteLine();
            Console.WriteLine($"Welcome {userName}!");
            Console.WriteLine();

            
            double balance;
            bool isValidBalance = false;

            do
            {
                Console.Write("Enter account balance: R");
                string input = Console.ReadLine();

                if (double.TryParse(input, out balance))
                {
                    if (balance >= 0)
                    {
                        isValidBalance = true;
                    }
                    else
                    {
                        Console.WriteLine("Error: Balance cannot be negative. Please try again.");
                    }
                }
                else
                {
                    Console.WriteLine("Error: Please enter a valid numeric amount.");
                }
            } while (!isValidBalance);

            Console.WriteLine();

            // Step 3: Enter withdrawal amount
            double amountToWithdraw;
            bool isValidWithdrawal = false;
            bool transactionSuccess = false;

            do
            {
                Console.Write("Enter withdrawal amount: R");
                string input = Console.ReadLine();

                if (double.TryParse(input, out amountToWithdraw))
                {
                    if (amountToWithdraw > 0)
                    {
                        if (amountToWithdraw <= balance)
                        {
                            isValidWithdrawal = true;
                            transactionSuccess = true;
                        }
                        else
                        {
                            Console.WriteLine("Insufficient balance. Please choose a lower amount.");
                            Console.WriteLine($"Your current balance is: R{balance:F2}");
                            transactionSuccess = false;
                        }
                    }
                    else
                    {
                        Console.WriteLine("Transaction failed. Amount must exceed 0.");
                        transactionSuccess = false;
                    }
                }
                else
                {
                    Console.WriteLine("Please enter a valid number amount.");
                    transactionSuccess = false;
                }
            } while (!isValidWithdrawal);

            Console.WriteLine();

            // Step 4: Display transaction result
            if (transactionSuccess)
            {
                // Update balance
                balance -= amountToWithdraw;
                DateTime transactionTime = DateTime.Now;

                Console.WriteLine("=== TRANSACTION SUCCESSFUL ===");
                Console.WriteLine($"Withdrawal of R{amountToWithdraw:F2} successful!");
                Console.WriteLine($"Updated Balance: R{balance:F2}");
                Console.WriteLine($"Transaction Time: {transactionTime.ToString("yyyy-MM-dd HH:mm:ss")}");
            }
            else
            {
                Console.WriteLine("=== TRANSACTION FAILED ===");
                Console.WriteLine("Withdrawal could not be completed.");
            }

            Console.WriteLine();
            Console.WriteLine("Thank you for using our ATM!");
            Console.WriteLine($"Goodbye, {userName}!");

            Console.WriteLine();
            Console.WriteLine("Press any key to exit...");
            Console.ReadKey();
        }
    }
}