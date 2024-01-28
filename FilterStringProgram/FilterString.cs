using System;
using System.Collections.Generic;

class StartsWithStrategy
{
    private string stringStartsWith;

    public void SetStartsWith(string key)
    {
        stringStartsWith = key;
    }

    public bool Invoke(string item)
    {
        return item.StartsWith(stringStartsWith);
    }
}

class ConsoleDisplayController
{
    private List<string> content;

    public void SetContent(List<string> message)
    {
        content = message;
    }

    public void Display()
    {
        Console.Write(string.Join(", ", content));
    }
}

class StringListFilterController
{
    private StartsWithStrategy predicate = new StartsWithStrategy();

    public List<string> Filter(List<string> stringList)
    {
        List<string> filteredList = new List<string>();
        predicate.SetStartsWith("b");

        for (int i = 0; i < stringList.Count; i++)
        {
            if (predicate.Invoke(stringList[i]))
            {
                filteredList.Add(stringList[i]);
            }
        }

        return filteredList;
    }
}

class ArrayFilter
{
    static void Main(string[] args)
    {
        List<string> inputString = new List<string>
        {
            "war",
            "boy",
            "toy",
            "car",
            "far"
        };

        StringListFilterController stringListFilterControllerObj = new StringListFilterController();
        ConsoleDisplayController consoleDisplayControllerObj = new ConsoleDisplayController();

        List<string> filteredList = stringListFilterControllerObj.Filter(inputString);

        consoleDisplayControllerObj.SetContent(filteredList);
        consoleDisplayControllerObj.Display();
    }
}
