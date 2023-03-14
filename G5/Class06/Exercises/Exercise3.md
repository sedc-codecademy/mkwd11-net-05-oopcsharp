## Task 3

Create a class User with the following:

- Id - int
- Username - string
- Password - string
- Messages - Array of strings

Create an array of users and add 3 users to it manually ( hard-coded ).

Create a Console UI that will give the user two options to choose from:

- Log in - When selected the user should be asked for username and password. If the user is found print welcome message and the messages that the user has in the Messages property:
  - **Welcome NAME. Here are your messages:**
    - Message1
    - Message2
  - If not found, it should print an error message
- Register - When selected the user should be asked to enter ID, Username and password. It should then check if a there is already a username in the array of users like that. If there is, print a message that there is already a user called like that. If not, create a new user object from the information given in the console and add it to the Users array. Then print all the users by Id and Username
  - **Registration complete! Users:**
    - 23 Username1
    - 44 Username2
    - 1 Username3
    - 56 Username4\*\*
