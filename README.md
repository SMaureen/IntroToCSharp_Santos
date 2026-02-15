PRELIM ACTIVITY 01: CODAC LOGISTICS DELIVERY AND FUEL AUDITOR
Name: Santos, Maureen C.
Course and Section: BSIT 3.2

Task Description: 
This task helps to track a driver’s fuel expenses, analyze fuel efficiency, and generate a summary report. It collects the driver’s name, weekly fuel budget, total distance traveled, and daily fuel expenses. The program calculates average expenses, fuel efficiency, and checks if the driver stayed within the budget. Finally, it prints a detailed audit report.

Features:

Input driver’s full name and weekly fuel budget.
Validate total distance traveled (1–5000 km).
Track fuel expenses for 5 days.
Calculate average daily fuel expense and fuel efficiency (km per unit of fuel).
Rate efficiency as High, Standard, or Low.
Check if the driver stayed within the weekly budget.
Print a complete audit report showing all data and calculations.

How to Use:
1. Run the code.
2. Enter the driver’s full name.
3. Enter the weekly fuel budget.
4. Enter the total distance traveled (must be between 1 and 5000 km).
5. Enter fuel expenses for each of the 5 days.
6. Review the audit report displayed at the end.

Technical Details: 

Data types used:
• string – for driver’s name.
• decimal – for weekly fuel budget and daily expenses (accurate for money).
• double – for total distance (supports decimals).

Loops used:
• while loop – validates total distance input.
• for loop – collects daily fuel expenses and prints them in the report.

Conditional statements:
• if-else – determines efficiency rating based on km per unit of fuel.
