Console.WriteLine("Chose \n + \n * \n - \n /");
string sOperator = Console.ReadLine();
Console.WriteLine("Welcome to the dark calculator");

Console.WriteLine("Geef een getal 1 in");
int iNumber1 = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Geef een getal 2 in");
int iNumber2 = Convert.ToInt32(Console.ReadLine());

switch(sOperator){
    default:
        Console.WriteLine("Geef een operator");
             break;

    case "+":
        Console.WriteLine($"{iNumber1} + {iNumber2} = {iNumber1 + iNumber2}");
        break;

    case "-":
         Console.WriteLine($"{iNumber1} - {iNumber2} = {iNumber1 - iNumber2}");
         break;

    case "*":
        Console.WriteLine($"{iNumber1} * {iNumber2} = {iNumber1 * iNumber2}");
        break;

    case "/":
        Console.WriteLine($"{iNumber1} / {iNumber2} = {iNumber1 / iNumber2}");
        break;
}
