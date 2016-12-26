# Switch-Case
SOLID Switch case

## Client side
Create an instance of your **Condition**, then pass a condition to **Condition** object by **SwitchCase()** function.

## Server side
1. Create a *case holder*. This abstract class defines how to execute a **Condition**.
2. Create list of cases you want. These classes must implement *case holder* and **ICase**.
  * **ICase** just holds a **Key** that it is used by **SwitchCase()** function to navigate the cases.
3. Create a **Condition** class that it implements **SwitchCase** generic abstract class.
  * Add all cases witch you want to **Cases** property.
  * Define a *Switch()* function and navigate **Cases** property to find matches cases, then execute them as a *case holder*.
  
