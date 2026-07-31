#  C# Guessing Game

A simple **Guessing Game built with C# and .NET**.

The player has to guess a secret animal word. The game provides different hints after each incorrect answer until the player finds the correct answer or runs out of hints.

This project was created to practice the fundamentals of C# programming.

## 🎯 What I Practiced

* Arrays
* `for` loops
* `if / else` statements
* Methods
* Variables
* Strings
* User input with `Console.ReadLine()`
* Returning values from methods
* Passing parameters to methods

## 🎮 How the Game Works

The secret word is:

```text
lion
```

The game starts by showing the first hint:

```text
It is a member of the cat family
```

The player enters their answer.

* If the answer is correct → the game displays **"correct"** and ends.
* If the answer is incorrect → the next hint is displayed.
* If all hints are used → the player loses.

### Example

```text
It is a member of the cat family

enter your answer : tiger
It lives mostly in Africa, try again !

enter your answer : dog
It has a powerful roar, try again !

enter your answer : lion
correct
```

## 🧠 C# Concepts Used

### Array

The hints are stored inside a string array:

```csharp
string[] help =
{
    "It is a member of the cat family",
    "It lives mostly in Africa, try again !",
    "It has a powerful roar, try again !",
    "Male ones usually have a large mane, try again !",
    "It is known as the king of the jungle, try again !"
};
```

### For Loop

A `for` loop is used to go through the hints:

```csharp
for (int i = 1; i < help.Length; i++)
{
    // game logic
}
```

### If / Else

The player's answer is checked using an `if` statement:

```csharp
if (answer == secretWord)
{
    Console.WriteLine("correct");
    return;
}
else
{
    Console.WriteLine(help[i]);
}
```

### Methods

The game uses separate methods for different tasks.

`Playeranswer()` gets the player's input:

```csharp
static string Playeranswer()
{
    Console.Write("enter your answer : ");
    string useranswer = Console.ReadLine();

    return useranswer;
}
```

`WinCondition()` controls the guessing logic:

```csharp
static void WinCondition(string secretWord, string[] help)
{
    // guessing logic
}
```

## 🛠️ Technologies

* **C#**
* **.NET**
* **Console Application**

## 📚 What I Learned

This project helped me understand how to:

* Store multiple values using arrays
* Repeat code using `for` loops
* Make decisions using `if / else`
* Create and call methods
* Pass data between methods using parameters
* Get user input from the console
* Build a small game using basic C# concepts

## 👨‍💻 Author

**Yassin Nassrallah**

Learning C# and building small projects to improve my programming skills.
