//Завдання 7
//Створіть запис Person. Необхідно зберігати інформацію про ім’я, прізвище, вік.
//Створіть масив записів Person.
//Напишіть код для пошуку людини із мінімальним і максимальним віком.
//Відобразіть середній вік людей (реалізуйте за допомогою extension method).
using Task_7;

Person[] p=new Person[5];
p[0] = new("Ivan", "Petrov", 27);
p[1] = new("Petr", "Prokopenko", 30);
p[2] = new("Ilona", "Ivanova", 20);
p[3] = new("Olga", "Kovalenko", 35);
p[4] = new("Sergei", "Kurkov", 40);
Person agemin = p[0], agemax = p[1];
Console.WriteLine("\n All persons: ");
foreach (Person person in p)
{
    Console.WriteLine(person);
    if (person.AgeSmallerThan(agemin)) agemin = person;
    if (person.AgeBiggerThan(agemax)) agemax = person;
}
Console.WriteLine($" The Person with minimum age: {agemin}");
Console.WriteLine($" The Person with maximum age: {agemax}");
Console.WriteLine($" Averange age: {p.AverangeAge()}");