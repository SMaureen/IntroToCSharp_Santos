/*
 * Prelim Activity 01: Codac Logistics Delivery & Fuel Auditor
 * Description:
 * Collect driver info, validate distance,
 * record daily fuel expenses, calculate totals,
 * and display a final report. 
 */

using System;

class Program
{
    static void Main()
    {
        // Task 1 – Driver Profile & Distance Validation
        Console.Write("Enter Driver Full Name: ");
        string fullName = Console.ReadLine(); // we used string to store the driver's name (text)

        Console.Write("Enter Weekly Fuel Budget: ");
        decimal weeklyBudget = Convert.ToDecimal(Console.ReadLine()); // decimal to store weekly fuel budget (for financial values)

        double totalDistance; // we use double for distance in km

        // whil to repeat until a valid distance is entered
        while (true)
        {
            Console.Write("Enter Total Distance (1 - 5000 km): ");
            totalDistance = Convert.ToDouble(Console.ReadLine());

            if (totalDistance >= 1.0 && totalDistance <= 5000.0)
                break; // stop loop when the input is valid
            else
                Console.WriteLine("Invalid distance. Try again.");
        }

        // Task 2 – Fuel Expense Tracking
        int numberOfDays = 5; // number of days to track the expenses
        decimal[] fuelExpenses = new decimal[numberOfDays]; // store daily fuel expenses
        decimal totalFuelSpent = 0; // total fuel spent

        // loop for each day to get fuel expenses
        for (int i = 0; i < numberOfDays; i++)
        {
            Console.Write($"Enter fuel expense for Day {i + 1}: ");
            fuelExpenses[i] = Convert.ToDecimal(Console.ReadLine());
            totalFuelSpent += fuelExpenses[i];
        }

        // Task 3 – Performance Analysis
        decimal averageExpense = totalFuelSpent / numberOfDays; // average of daily fuel expense
        double efficiency = totalDistance / (double)totalFuelSpent; // km per unit of fuel

        string efficiencyRating;

        // to dtermine the efficiency rating
        if (efficiency > 15)
            efficiencyRating = "High Efficiency";
        else if (efficiency >= 10)
            efficiencyRating = "Standard Efficiency";
        else
            efficiencyRating = "Low Efficiency / Maintenance Required";

        bool stayedUnderBudget = totalFuelSpent <= weeklyBudget; // true if its within the budget

        // Task 4 – The Audit Report
        Console.WriteLine("\nDRIVER AUDIT REPORT");
        Console.WriteLine($"Driver Name: {fullName}");

        Console.WriteLine("\nFuel Expenses:");
        for (int i = 0; i < numberOfDays; i++)
        {
            Console.WriteLine($"Day {i + 1}: {fuelExpenses[i]}");
        }

        Console.WriteLine($"\nTotal Fuel Spent: {totalFuelSpent}");
        Console.WriteLine($"Average Daily Expense: {averageExpense}");
        Console.WriteLine($"Efficiency Rating: {efficiencyRating}");
        Console.WriteLine($"Stayed Under Budget: {stayedUnderBudget}");
    }
}
