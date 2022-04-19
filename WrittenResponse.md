# Guessing Game Written Response

The format for this document are taken directly from the AP Computer Science
Principles [Student Handout](../support/ap-csp-student-task-directions.pdf).

## 3a

Provide a written response that does all three of the following:

### 3a i.

The purpose of the program is to give the user a trick question and make them laugh at the responses they get.


### 3a ii.

The project displays the question in which then the user answers and depending on the user's answer they recieve a response.



### 3a iii.

The input is yes or no and the output is a random response

## 3b

Capture and paste two program code segments you developed during the
administration of this task that contain a list (or other collection type) being
used to manage complexity in your program.

### 3b i.

The first program code segment must show how data have been stored in the list.

```csharp

             string Response1;
            Random generator1 = new Random();

            int NOIndex = generator.Next(0, NORESPONSES.Count);
            string randomNORESPONSE = NORESPONSES[NOIndex];
```

### 3b ii.

The second program code segment must show the data in the same list being used,
such as creating new data from the existing data or accessing multiple elements
in the list, as part of fulfilling the program's purpose.

```csharp
 do
            {
                Console.WriteLine($"{prompt}");
                input = Console.ReadLine().ToLower();

                if (input == "no")
                {
                    Console.WriteLine($"{randomNORESPONSE}");
                }
                else if (input == "yes")
                {
                    Console.WriteLine($"{randomYESRESPONSE}");
                }
                if (input == null) throw new Exception("Please answer yes or no");
            }
            while((input == "yes" || input == "no") == false);
```

### 3b iii.

Then provide a written response that does all three of the following:

Identifies the name of the list being used in this response

The list is stored in the variable randomNORESPONSE

### 3b iv.


Responses to the input "no" are stored in the list

### 3b v.

It would be impossible to run the code without this list because there would be no output/random response to make the user laugh

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
 public static string MakeUserSmart(string prompt)
        {

            List<string> NORESPONSES = new List<string>();

            NORESPONSES.Add("GENIUS!");
            NORESPONSES.Add("YOU'RE JUST TOO SMART");
            NORESPONSES.Add("CORRECT");



            List<string> YESRESPONSES = new List<string>();

            YESRESPONSES.Add("YOU'RE WRONG");
            YESRESPONSES.Add("INCORRECT");

            string Response;
            Random generator = new Random();

            int YESIndex = generator.Next(0, YESRESPONSES.Count);
            string randomYESRESPONSE = YESRESPONSES[YESIndex];

            Response = $"{randomYESRESPONSE}";

            string Response1;
            Random generator1 = new Random();

            int NOIndex = generator.Next(0, NORESPONSES.Count);
            string randomNORESPONSE = NORESPONSES[NOIndex];

            Response1 = $"{randomNORESPONSE}";
            string input;
            do
            {
                Console.WriteLine($"{prompt}");
                input = Console.ReadLine().ToLower();

                if (input == "no")
                {
                    Console.WriteLine($"{randomNORESPONSE}");
                }
                else if (input == "yes")
                {
                    Console.WriteLine($"{randomYESRESPONSE}");
                }
                if (input == null) throw new Exception("Please answer yes or no");
            }
            while((input == "yes" || input == "no") == false);

            return input;

        }

    }
```

### 3c ii.

The second program code segment must show where your student-developed procedure is being called in your program.

```csharp
 MakeUserSmart("Enter yes or no");
```

### 3c iii.

Describes in general what the identified procedure does and how it contributes to the overall functionality of the program.

When this method is called it asks the question and allows the user to input the answers "yes" or "no". Depending on the answer the program then outputs a random response to make the user laugh.

### 3c iv.

Explains in detailed steps how the algorithm implemented in the identified procedure works. Your explanation must be detailed enough for someone else to recreate it.

**TODO: In English, explain step by step what your procedure does. Be sure to use the word `Selection` and `Iteration` to explain what it does.**

1. The procedure asks the question
2. the procedure allows the user to input an answer
3. If yes the program displays a random yes response
4. If no the program displays a random no response
5. If the input is not yes or no the program iterates through steps 1-4 again


## 3d

Provide a written response that does all three of the following:

### 3d i.

Describes two calls to the procedure identified in written response 3c. Each call must pass a different argument(s) that causes a different segment of code in the algorithm to execute.

First call:
if (input == null) throw new Exception

**TODO: Complete this section**

Second call: if (input == "no")

**TODO: Complete this section**

### 3d ii.

Describes what condition(s) is being tested by each call to the procedure

Condition(s) tested by the first call: It tests that the answer needs to be yes or no
 
**TODO: Complete this section**

Condition(s) tested by the second call: It checks if the input is no

**TODO: Complete this section**

### 3d iii.

Result of the first call: "Please answer yes or no"

**TODO: Complete this section**

Result of the second call: randomNORESPONSE

**TODO: Complete this section**