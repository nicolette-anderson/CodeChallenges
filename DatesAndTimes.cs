//Write a program that prompts the user to enter a date. 
//if the date is in the past, output how many days have passed
//if the date is in the future, output how many days it will be until the date
//if the user types 'exit', close the program. 

//variables we'll need
DateTime result;
DateTime currentDate = DateTime.Now;
double totalDays = 0;

Console.WriteLine("Enter a date, or 'exit' to exit the program.");
string userDate = Console.ReadLine();

if (userDate == "exit")
    return;

if(DateTime.TryParse(userDate, out result)){
    totalDays = (currentDate - result).TotalDays;
}
else{
    Console.WriteLine("Cannot parse this date");
}

if(totalDays > 0){
    Console.WriteLine($"It has been {(int)totalDays} days since {result:d}");
}
if (totalDays < 0){
    //use absolute value to get rid of the negative sign
    Console.WriteLine($"It will be {Math.Abs((int)totalDays)} days until {result:d}");
}
