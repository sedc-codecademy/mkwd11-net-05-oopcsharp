# Bonus Homework - ATM 📒



## Requirements
Create new console application called “ATM”. It should simulate simple ATM that will allow the user to check its balance and withdraw money. When the console application start it should give the user an option to select one of the three options.

1. Check balance
* If the user choose option 1, than a message "You have $$ on your account."
2. Withdraw money
* If the user choose option 2, than you should ask him what amount of money he/she needs.
    * After input the amount, if the amount is smallar than the balance a message should appear like "You have successfully withdrawn $$ and you left $$$ on your account".
    * If the amount is bigger than the balance, a message should appear like "You cannot withdraw $$ because your balance is $$$. Please try again with appropriate amount!"

**Bonus**
* Try and validate all the user inputs so that if wrong input is entered you will provide an error message

**Extra bonus**
* Try to make the whole workflow infinite. After each user action is finished ask him if he want to take some other actions like: Do you want to take some other actions (Y/N). If he enters N, then quit the program, otherwise return him to the start of the program where the two options are displayed: Check balance or withdraw money
