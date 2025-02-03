using System;
public class Hello{
	public static void Main(){
		/*int[] number = new int[5] {2,6,3,7,8};
		int maximum = number[0];
		int biggerIndex = 0;
		for (int i = 1; i < number.Length; i++)
		{
			if (number[i] > maximum){
				biggerIndex = i;
				maximum = number[i];
			}
		}
		Console.WriteLine(maximum);*/

		/*int[] number = {1,2,3,4,5,6,7};
		for(int i=number.Length-1;i>=0;i--){
			Console.Write($"{number[i]} ");
		}*/

		//List<int> number = new List<int>();
		/*List<string> name = new List<string>();

		number.Add(10);
		number.Add(20);
		number.Add(30);
		name.Add("Kamoliddin");
		name.Add("Kamol");
		name.Add("Kamol2");

		int firstNumber= number[0];
		string firstName = name[0];

		number.Remove(10);
		number.RemoveAt(1);
		name.RemoveAt(0);
		name.Remove("Kamol");
		int count = number.Count;

		for(int i=0; i<number.Count;i++){
			Console.WriteLine($"{number[i]} {name[i]}");
		}
		foreach(int i in number){
			Console.WriteLine(i);
		}
		foreach(string hell in name){
			Console.WriteLine(hell);
		}

		number.Sort();
		number.Clear();
		
		name.Sort();
		name.Clear();*/

		/*List<int> numbers = new List<int> { 1, 2, 3, 4, 5 };
int total = 0;
foreach (int i in numbers)
{
    if (i % 2 == 0) // Check if the current number (i) is even
    {
        total += i; // Add the even number to the total
    }
}
Console.WriteLine(total);*/

/*int N = int.Parse(Console.ReadLine()); 
int[] number = new int[N];

for (int i = 0; i < number.Length; i++)
{
    number[i] = int.Parse(Console.ReadLine()); 

    if (number[i]>0)
    {
        number[i] = 0;
    }
}

for (int i = 0; i < number.Length; i++)
{
    Console.Write($"{number[i]} "); 
}*/

/*int N = int.Parse(Console.ReadLine());
int[] number = new int[N];
for (int i = 0; i < number.Length; i++)
{
    number[i] = int.Parse(Console.ReadLine());
}
for (int i = number.Length - 1; i >= 0; i--)
{
    Console.WriteLine($"{number[i]} ");
}*/

/*int N = int.Parse(Console.ReadLine());
int[] number = new int[N];

for (int i = 0; i < number.Length; i++)
{
    number[i] = int.Parse(Console.ReadLine());
}

int result = 0;

for (int i = 0; i < N - 1; i++)
{
    if ((number[i] > 0 && number[i + 1] > 0) || (number[i] < 0 && number[i + 1] < 0))
    {
        result = 1;
        break;
    }
}

if (result == 1)
{
    Console.WriteLine("YES");
}
else
{
    Console.WriteLine("NO");
}*/


/*int N = int.Parse(Console.ReadLine());
int B = int.Parse(Console.ReadLine());
int[] number = new int[N];
int same = 0;
bool foundB = false;

for (int i = 0; i < number.Length; i++)
{
    number[i] = int.Parse(Console.ReadLine());
    if (number[i] == B)
    {
        same++;
        foundB = true;
    }
}

if (foundB)
{
    Console.WriteLine($"{same}"); 
}
else
{
    
    int maxCount = 0;
    for (int i = 0; i < number.Length; i++)
    {
        int count = 0;
        for (int j = 0; j < number.Length; j++)
        {
            if (number[i] == number[j])
            {
                count++;
            }
        }
        if (count > maxCount)
        {
            maxCount = count;
        }
    }

    Console.WriteLine($"{maxCount-1}"); 
}*/

/*int N = Convert.ToInt32(Console.ReadLine()); 
int[] number = new int[N];
int total = 0;

for (int i = 0; i < number.Length; i++)
{
    number[i] = Convert.ToInt32(Console.ReadLine()); 
}


for (int i = 0; i < number.Length; i++)
{
    total += number[i]; 
}

Console.WriteLine(total);

}*/
}
/*Student ahmad = new Student();
ahmad.FirstName = "Ahmad";
ahmad.LastName = "Ahmadov";
ahmad.Age=16;
ahmad.Grades= new double [] {55,66,77,88,88};

Student kamol = new Student();
kamol.FirstName = "Kamoliddin";
kamol.LastName = "Kadirov";
kamol.Age=16;
kamol.Grades= new double [] {55,66,77,88,88};

Console.WriteLine($"{ahmad.GetFullName()}:{ahmad.GetAverageGrade()}");
Console.WriteLine($"{kamol.GetFullName()}:{kamol.GetAverageGrade()}");*/


