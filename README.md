# Switch-Case
SOLID Switch case

## Client side
Create an instance of your **Condition**, then pass a condition to **Condition** object by *Switch()* function.

## Server side
1. Create a *condition action*. This interface defines how to execute a **Condition**.
2. Create list of cases you want. These classes must implement *condition action* and **ICase**.
  * **ICase** just holds a **Key** that it is used by *Switch()* function to navigate the cases.
3. Create a **Condition** class that it implements **SwitchCase** generic abstract class.
  * Add all cases witch you want to **Cases** property.
  * Define a *Switch()* function and navigate **Cases** property to find matches cases, then execute them as a *condition action*.
  
