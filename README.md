## Client side
Create an instance of your **Condition**, then pass a condition to **Condition** object by *Switch()* function.


        int sense = 2;
        ConditionSense conditionSense = new ConditionSense();
        conditionSense.Switch(sense);

## Server side
1. Create a *condition action*. This interface defines how to execute a **Condition**.

        public interface IAction
        {
            void Do();
        }

2. Create list of cases you want. These classes must implement *condition action* and **ICase**; Keep them light.



            public class CaseCry : IAction, ICase<int?>
            {
                public int? Key { get { return 2; } }

                public void Do()
                {
                    Sense.Cry cry = new Sense.Cry();
                    cry.Act();
                }
            }


  * **ICase** just holds a **Key** that it is used by *Switch()* function to navigate the cases.

            public interface ICase<TCase>
            {
                TCase Key { get; }
            }

3. Create a **Condition** class that it Inherites **SwitchCase** generic abstract class.
  * Add all cases witch you want to **Cases** property.
  * Define a *Switch()* function and navigate **Cases** property to find matches cases, then execute them as a *condition action*.

            public class ConditionSense : SwitchCase<int?>
            {
                public ConditionSense()
                {
                    Cases = new List<ICase<int?>>
                    {
                        new CaseSmile(),
                        new CaseCry()
                    };

                    DefaultCases = new List<ICase<int?>> {
                        new CaseNoSense()
                    };
                }

                public void Switch(int? key)
                {
                    IEnumerable<IAction> matches = Cases.Where(p => p.Key.Equals(key))
                        .Select(p => p as IAction);
                    if (matches.Count() > 0)
                        foreach (IAction match in matches)
                            match.Do();
                    else
                        foreach (IAction defaultCase in DefaultCases)
                            defaultCase.Do();
                }
            }

**Smile**, **Cry**..., can be huge, don't worry about size of them; *condition action* and **ICase** keep them lazy load.

            public class Sense
            {
                public class Smile
                {
                    public void Act()
                    {
                        Console.WriteLine("I'm smiling :-)");
                    }
                }

                public class Cry
                {
                    public void Act()
                    {
                        Console.WriteLine("I'm crying :-(");
                    }
                }

                public class NoSense
                {
                    public void Act()
                    {
                        Console.WriteLine("I've no sense :-|");
                    }
                }
            }
