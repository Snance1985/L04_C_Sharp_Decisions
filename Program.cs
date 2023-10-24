// //RELATIONAL OPERATOR EXAMPLES: 
// int num = 23;
// int num2 = 3;

// string firstName = "Jamie";

// // Displaying results based on relational operations
// Console.WriteLine("num == num2: " + (num == num2));
// //Equality ==
// Console.WriteLine("num != num2: " + (num != num2));
// //Inequality !=
// Console.WriteLine("num > 3: " + (num > 3));
// //Greater than >
// Console.WriteLine("num2 >=  5: " + (num2 >= 5));
// //Greater than or equal to >=
// Console.WriteLine("num < 2: " + (num < 2));
// //Less than <
// Console.WriteLine("num2 <= 5: " + (num2 <= 5));
// //Less than or equal to <=
// Console.WriteLine("firstName == \"Jamie\": " + (firstName == "Jamie"));
// //Equality
// Console.WriteLine("firstName != \"Tom\": " + (firstName != "Tom"));
// //Inequality


// //_________________________________
// //LOGICAL OPERATOR EXAMPLE:
// int a = 14;
// int b = 30;
// int c = 20;

// Console.WriteLine("a < b && a < c (checking if a is the smallest number) : " + (a < b && a < c ));
// //AND &&
// Console.WriteLine("a < b || a < c (checking if a is less than b or c) : " + (a < b || a < c));
// //OR ||


// //________________________________
// //IF STATEMENT EXAMPLES:
// //Example: Checking Inputs
// Console.WriteLine("Enter a Number between 1-100: ");
// int value = int.Parse(Console.ReadLine());

// if (value > 100 || value < 1) {
//     Console.WriteLine("The number your entered is outside the range");
// }

// if (value >= 1 && value <= 100) {
//     Console.WriteLine("The number you entered is within the range specified");
// }

// //Example 2: Comparing Numbers
// Console.WriteLine("Enter the First Number: ");
// int number1 = int.Parse(Console.ReadLine());
// Console.WriteLine("Enter the Second Number: ");
// int number2 = int.Parse(Console.ReadLine());

// if (number1 > number2) {
//     Console.WriteLine("Number 1 is bigger");
// }

// if (number2 > number1) {
//     Console.WriteLine("Number 2 is bigger");
// }

// if (number1 == number2) {
//     Console.WriteLine("Both numbers are equal");
// }


// //________________________________
// //IF/ELSE STATEMENTS
// //Checking Inputs with If/Else
// Console.WriteLine("Enter a Number between 1-100: ");
// int value = int.Parse(Console.ReadLine());

// if (value > 100 || value < 1) {
//     Console.WriteLine("The number your entered is outside the range");
// }
// else 
// {
//     Console.WriteLine("The number you entered is within the range specified");
// }


// //________________________________
// //NESTED IF STATEMENTS
// Console.WriteLine("Video Game Character Status");
// Console.WriteLine("Enter Health (0-100): ");
// int hitPoints = int.Parse(Console.ReadLine());
// Console.WriteLine("Enter Stamina (0-100): ");
// int stamina = int.Parse(Console.ReadLine());

// if (hitPoints >= 0) {
//     if (stamina >= 20) {
//         Console.WriteLine("Player is still alive!");
//     }
//     else {
//         Console.WriteLine("Player is dead: lack of stamina");
//     }
// }
// else {
//     Console.WriteLine("Player is dead: no more health");
// }


// //________________________________
// //IF/ELSE IF/ELSE STATEMENTS
// Console.WriteLine("Enter a letter of choice: ");
// try {
//     char ch = char.Parse(Console.ReadLine());

//     if (ch == 'A' || ch == 'a')
//     {
//         Console.WriteLine("Vowel A");
//     }
//     else if (ch == 'E' || ch == 'e')
//     {
//         Console.WriteLine("Vowel E");
//     }
//     else if (ch == 'I' || ch == 'i') 
//     {
//         Console.WriteLine("Vowel I");
//     }
//     else if (ch == 'O' || ch == 'o')
//     {
//         Console.WriteLine("Vowel O");
//     }
//     else if (ch == 'U' || ch == 'u')
//     {
//         Console.WriteLine("Vowel U");
//     }
//     else
//     {
//         Console.WriteLine("Consonant");
//     }
// } catch (Exception) {
//     Console.WriteLine("Your input was not a single letter.");
// }


// //________________________________
// //SWITCH-CASE STATEMENTS
// Console.WriteLine("Enter a letter of choice: ");
// try {
//     char ch = char.Parse(Console.ReadLine());

//     switch(ch) {
//         case 'A':
//         case 'a':
//             Console.WriteLine("Vowel A");
//             break;
//         case 'E':
//         case 'e':
//             Console.WriteLine("Vowel E");
//             break;
//         case 'I':
//         case 'i':
//             Console.WriteLine("Vowel I");
//             break;
//         case 'O':
//         case 'o':
//             Console.WriteLine("Vowel O");
//             break;
//         case 'U':
//         case 'u':
//             Console.WriteLine("Vowel U");
//             break;    
//         default:
//             Console.WriteLine("Consonant");
//             break;
//     }
    
// } catch (Exception) {
//     Console.WriteLine("Your input was not a single letter.");
// }


//________________________________
//TERNARY OPERATORS
Console.WriteLine("Enter Number 1: ");
int number1 = int.Parse(Console.ReadLine());

Console.WriteLine("Enter Number 2: ");
int number2 = int.Parse(Console.ReadLine());

// Using if else
if (number1 == number2) {
    Console.WriteLine("The numbers are equal (using if-else)");
}
else {
    Console.WriteLine("The numbers are not equal (using if-else)");
}

Console.WriteLine();

string result = number1 == number2 ? "The numbers are equal (using ternary)" : "The numbers are not equal (using ternary)";
Console.WriteLine(result);