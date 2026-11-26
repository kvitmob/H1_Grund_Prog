// int time = 22;
// if (time < 10) 
// {
//   Console.WriteLine("Good morning.");
// } 
// else if (time < 20) 
// {
//   Console.WriteLine("Good day.");
// } 
// else 
// {
//   Console.WriteLine("Good evening.");
// }
// Outputs "Good evening."



//Ternary operator

// int time = 20;
// string result = (time < 18) ? "Good day." : "Good evening.";
// Console.WriteLine(result);

//Switch

int day = 4;
switch (day) 
{
  case 1 && 4:
    Console.WriteLine("Monday");
    break;
  case 2:
    Console.WriteLine("Tuesday");
    break;
  case 3:
    Console.WriteLine("Wednesday");
    break;
  case 4:
    Console.WriteLine("Thursday");
    break;
  case 5:
    Console.WriteLine("Friday");
    break;
  case 6:
    Console.WriteLine("Saturday");
    break;
  case 7:
    Console.WriteLine("Sunday");
    break;
}
// Outputs "Thursday" (day 4)