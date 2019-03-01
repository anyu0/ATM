# ATM
project for COMS 3101

## Description
This Web based Visual Studio project simulates an ATM interface. Users can resigter acocunts, change passowrds, view balances, withdraw cash, and make deposits.

## Instructions
Users are only allowed to withdraw 20 dollar bills.
The account balance should be positive after the withdrawl, otherwise the transaction fails. 


## Test cases
- Account is unique (duplicate account numbers is illegal).
- Error message when the withdraws request isn’t in multiples of 20.
- Error message when users try to withdraw more than 10 000.
- Error message when they try to withdraw more than what they have in their account.
