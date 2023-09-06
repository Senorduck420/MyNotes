public static class MyNotes
{
    public static string VariablesPageOne =
    @"
        Variables consist of a simple structure following: datatype name = value
        You can then later reference these saved values for use in programming

        An 'int' is a whole number, like 1, 2, 3, 4, 5, 6, 7, 8, 9, 0. 
        A 'string' is a sequence of characters, like ""Hello World"", ""I am a string"", and ""C# is awesome"". 
        A 'float' is a decimal number, like 1.234, 5.678, and 9.101112. 
        A 'bool' is a true or false value, like true and false.

        int age = 32;
        string name = ""Jesper"";
        float awesomeLevel = 99.9f;
        bool TooCoolForSchool = false;
    ";
    public static string loopspage =
    @"
        for Loop: Used for iterating a specific number of times. It consists of an initialization, condition, and increment/decrement expression.
        while Loop: Executes a block of code as long as a condition is true.
        do-while Loop: Similar to a while loop, but it guarantees at least one execution of the code block since the condition is checked after the block execution.
        foreach Loop: Used to iterate over elements of collections (arrays, lists, etc.) without explicitly using an index.
        break: Terminates the loop and exits it prematurely.
        continue: Skips the current iteration and proceeds to the next iteration of the loop.
        Infinite Loops: Be cautious when writing loops to avoid unintentional infinite loops. Make sure the loop's termination condition is reachable or break out of the loop when needed.
        Nested Loops: You can nest loops inside each other to perform more complex iterations.
        Best Practices:

        Use the appropriate loop construct based on the specific requirements of your code.
        Ensure that the loop control variable is properly initialized, and termination conditions are well-defined.
        Minimize the scope of loop variables whenever possible to avoid unintentional variable reuse.
        Loops are fundamental in programming and are used extensively for repetitive tasks and data processing. Understanding how to use them effectively is crucial in C# programming.
    ";

    public static string classespage =
        @"
            Class: A blueprint for creating objects, defining their structure and behavior.
            Members: Include fields, properties, methods, constructors, and events.
            Access Modifiers: Control visibility and accessibility (e.g., public, private).
            Inheritance: Allows a class to inherit properties and behaviors from another class.
            Encapsulation: Combines data and behavior within a class while controlling access.
            Abstraction: Hides complex implementation details, exposing only essential features.
            Polymorphism: Enables treating objects of different classes as if they were of a common base class.
            Static Members: Belong to the class itself rather than instances.
            Classes are fundamental for organizing code in C#, promoting reusability and maintainability.
        ";
    
}