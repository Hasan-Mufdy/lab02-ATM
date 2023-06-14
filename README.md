# lab02-ATM
this is a simple ATM interface, made with c#. this repo also includes the automated test files, that are made using xUnit. 

## functionality:
this application will allow users to:
- view their balance (will be zero at first).
- deposit money.
- withdraw money.

## how to use it:
after starting the application, users can interact with the interface directly.
the interface will provide the instructions, which are:
- pressing '1' to view their balance.
- pressing '2' to withdraw.
- pressing '3' to deposit.
- and they can press '4' any time to exit the application.

## code explanation:
### main ATM app:
the ActivateInterface() method is invoked in the main method, and will be executed when the application starts.
all the messages that will appear to the users are inside of the ActivateInterface() method, it also contains all the lines where the app expects users input.
there will be a couple of conditions that will be checked, and the application's behavior will be based on users input.
### unit test:
there are 6 tests in the automated testing file, these tests are for the below methods:
- ViewBalance()
- WithDraw()
- Deposit()
the tests will basically check if everything is working properly, whether the user inputs a positive or a negative value, if the value was negative, the balance will NOT be changed, and a warning will appear to the user. it will also insure that the user cannot withdraw more money than what's in the balance.
