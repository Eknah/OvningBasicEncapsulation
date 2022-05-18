

using OvningBasicEncapsulation;

var lines = 5;
var persons = new List<Person>();
for (int i = 0; i < lines; i++)
{
	var cmdArgs = Console.ReadLine().Split();
	try
	{ 
	var person = new Person(cmdArgs[0], cmdArgs[1], int.Parse(cmdArgs[2]), decimal.Parse(cmdArgs[3]));
		persons.Add(person);
	}
	catch (Exception ex)
	{
		Console.WriteLine(ex.ToString());
	}
}

var bonus = decimal.Parse(Console.ReadLine());
persons.ForEach(p => p.IncreaseSalary(bonus));
persons.ForEach(p => Console.WriteLine(p));

//persons.OrderBy(p => p.FirstName)
//.ThenBy(p => p.Age)
//.ToList()
//.ForEach(p => Console.WriteLine(p.ToString()));