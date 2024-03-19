using System.Text.Json;
using System.Text.Json.Serialization;

namespace IEnumerableExtension;

class Program
{
    static void Main()
    {
        var person1 = new Person("Tom", 50);
        var person2 = new Person("Jack", 30);
        var person3 = new Person("Bob", 40);
        var person4 = new Person("Michael", 43);
        var person5 = new Person("Nick", 70);
        var person6 = new Person("Dave", 37);
        var person7 = new Person("Chack", 20);

        var collection = new List<Person>() { person1, person2, person3, person4, person5, person6, person7 };
        var result = collection.Top(50, el => el.Age);

        foreach (var res in result)
        {
            Console.WriteLine(res.Age);
        }
    }
}