using System;
using System.Threading.Tasks;
using System.Text.Json;

/* 
    Task: calculate the net salary given gross value

1.) There is no taxation for any amount lower or equal to 1000 Imagiaria Dolars (IDR).

2.) Income tax of 10% is incurred to the excess (amount above 1000).

3.) Social contributions of 15% are expected to be made as well. As for the previous case, the
taxable income is whatever is above 1000 IDR but social contributions never apply to amounts higher
than 3000.

NOTE: the excess has to be greater than $3000 to not pay social contributions
    
*/


/*
note the console appication will accept the following parameters:

personsName: Brandon,
Salary: 2500 IDR
*/

namespace Inesia
{
    class Task2
    {
        static void Main(string[] args)
        {
            string name = "";
            int salary = 0;
            int excess = 0;
            double taxes = 0;

            Console.WriteLine("Enter Your Name: ");
            name = Console.ReadLine();

            Console.WriteLine("\nWelcome " + name + ". Let's do your Taxes!");

            Console.WriteLine("Please enter your salary (in IDR): ");
            salary = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("\nThe salary entered was: " + salary + " IDR.\n");

            if (salary <= 1000)
            {
                Console.WriteLine(name + ", You do not need to pay Taxes!");
            }
            else
            {
                excess = salary - 1000;
                Console.WriteLine(name + ", Your salary is above 1000 IDR and are going to be taxed 10 % of your excess which is: " + excess);
                taxes += excess * (0.1);
                System.Threading.Thread.Sleep(1000);
                Console.WriteLine("That would be " + taxes + " added to your tax deduction.\n");
                System.Threading.Thread.Sleep(1000);

                if (excess <= 3000)
                {
                    if (excess > 2000)
                    {
                        excess = 2000;
                    }

                    System.Threading.Thread.Sleep(1000);
                    Console.WriteLine(name + ", Your excess is below 3000 IDR and are expected to also give 15% to social contribution.");
                    taxes += excess * (0.15);
                    System.Threading.Thread.Sleep(1000);
                    Console.WriteLine("That would be " + taxes + " added to your tax deduction.\n");
                }
            }
            System.Threading.Thread.Sleep(1000);
            Console.WriteLine(name + " , you were taxed " + taxes + " IRD. You are walking away with: " + (salary - taxes));
            System.Threading.Thread.Sleep(1000);
            Console.WriteLine("\nThank you for using our services " + name + " . Hope to see you again!");

            var TaxInfo = new Taxinfo
            {
                Name = name,
                Salary = salary,
                taxDeductions = taxes,
                netSalary = Convert.ToInt32(salary - taxes),
            };

            // The program saves all of this information in a Json file for easy access and creates it based on the persons name
            
            string fileName = name + "TaxInfo.json"; 
            string jsonString = JsonSerializer.Serialize(TaxInfo);
            File.WriteAllText(fileName, jsonString); 

        }
    }
}

