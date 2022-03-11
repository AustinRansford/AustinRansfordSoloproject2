# Guessing Game Written Response

The format for this document are taken directly from the AP Computer Science
Principles [Student Handout](../support/ap-csp-student-task-directions.pdf).

## 3a

Provide a written response that does all three of the following:

### 3a i.

Describes the overall purpose of the program.
* to provide entertainment to whoever is playing the game, and to finish the game is the least amount of turns.

**TODO: Complete this section**

### 3a ii.

Describes what functionality of the program is demonstrated in the video.

**TODO: Complete this section**
The video demonstrates that the player can input one of three difficulties, this difficulty will determine how many turns the player has to "score a goal". The program then enters the goalkick method which gives possible paths. Everytime a player enters a path the amount of turns left is decreased by 1 or two, if turnsleft ever reach 0 the program will terminate. These paths return anoter method that will continue the game or terminate it.  The player can navigate these methods untill turns left reaches zero or you score a Goal and the game is won. 

### 3a iii.

Describes the input and output of the program demonstrated in the video.

**TODO: Complete this section**
User can input a 1 of three difficulties. This difficulty will determine the amount of turns the user has. Then the program runs the goal kick method where they can chose 1 of 3 directions to pass the ball. This choice will move them to another method with multiple input options, and will reduce the amount of turns left by 1 or sometimes 2. This repeats untill a goal is scored or turnsleft reaches 0.

## 3b

Capture and paste two program code segments you developed during the
administration of this task that contain a list (or other collection type) being
used to manage complexity in your program.

### 3b i.

The first program code segment must show how data have been stored in the list.

```csharp
// TODO: Copy The line of code here for which you are adding data to a list
```

### 3b ii.

The second program code segment must show the data in the same list being used,
such as creating new data from the existing data or accessing multiple elements
in the list, as part of fulfilling the program's purpose.

```csharp
// TODO: Show a foreach loop accessing each element of the list from 3bi
```

### 3b iii.

Then provide a written response that does all three of the following:

Identifies the name of the list being used in this response

**TODO: Write, "The list is stored in the variable {INSERT VARIABLE NAME
HERE}"**

### 3b iv.

Describes what the data contained in the list represents in your program

**TODO: Write a sentence describing what is stored in the list**

### 3b v.

Explains how the selected list manages complexity in your program code by
explaining why your program code could not be written, or how it would be
written differently, if you did not use the list.

**TODO: Explain why it would be very difficult (or impossible) to write 
the program without using the list.**
this list manages the complexity because it is impossible to determine the path of the player through the program. so, I would have to use a bool variable for each possible input, which would, at the end of the program, return a string that corralates to that bool variable. Since, players can enter the same input mutiple times I would have to make a # of bool variable equal to the # of times the player makes that input. Since, I cant determine that number it would be impossible. 

## 3c.

Capture and paste two program code segments you developed during the
administration of this task that contain a student-developed procedure that
implements an algorithm used in your program and a call to that procedure.

### 3c i.

The first program code segment must be a student-developed procedure that:

- [ ] Defines the procedure's name and return type (if necessary)
- [ ] Contains and uses one or more parameters that have an effect on the functionality of the procedure
- [ ] Implements an algorithm that includes sequencing, selection, and iteration

```csharp
 public static bool ProbabilityMachine(int probability, int max)
        {
            if (probability < 0)
            {
                throw new Exception("The chance to succeed can not be negative.");
            }
            else
            {
                Random Generator = new Random();
                int chance = Generator.Next(0, max);
                while (chance > 100 || chance <= 0)
                {
                    chance = Generator.Next(0, max);
                }
                if (chance <= probability)
                {
                    return true;
                }
                else return false;

            }

        }
```

### 3c ii.

The second program code segment must show where your student-developed procedure is being called in your program.

```csharp
 if (input2.ToLower().Trim() == "yes")
                {
                    turnsleft = turnsleft - 1;
                    bool success = ProbabilityMachine(55, 100);


                    if (success == true)
                    {
                        Console.WriteLine("You successfully made the pass to the midfeild");
                        PassingPath.Add("Goal Kick");

                        return MidFeildKickRoom(turnsleft);

                    }
                    if (success == false)
                    {

                        Console.WriteLine("You lost the ball in the midfeild. The Counter attack is over.");
                        PassingPath.Add("Goal Kick");
                        return GameLost();
                    }



                }
```

### 3c iii.

Describes in general what the identified procedure does and how it contributes to the overall functionality of the program.

**TODO: Explain at a high level what this method does and when it is called**
The procedure takes 2 intger values: max and probability. The method generates a int value between 0 and max. If that generated number is less than or equal to the probability variable. the method returns true. Else the method returns false

### 3c iv.

Explains in detailed steps how the algorithm implemented in the identified procedure works. Your explanation must be detailed enough for someone else to recreate it.

**TODO: In English, explain step by step what your procedure does. Be sure to use the word `Selection` and `Iteration` to explain what it does.**
1. 
The procedure takes 2 intger values: max and probability. If either input is less than or equal to zero the method returns an exception. The method generates a int value between 0 and max.

## 3d

Provide a written response that does all three of the following:

### 3d i.

Describes two calls to the procedure identified in written response 3c. Each call must pass a different argument(s) that causes a different segment of code in the algorithm to execute.

First call:

**TODO: Complete this section**

Second call:

**TODO: Complete this section**

### 3d ii.

Describes what condition(s) is being tested by each call to the procedure

Condition(s) tested by the first call:
 
**TODO: Complete this section**

Condition(s) tested by the second call:

**TODO: Complete this section**

### 3d iii.

Result of the first call:

**TODO: Complete this section**

Result of the second call:

**TODO: Complete this section**