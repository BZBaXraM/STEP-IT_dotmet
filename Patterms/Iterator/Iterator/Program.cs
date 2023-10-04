using System.Collections;

// MyCollection collection = new MyCollection();
// foreach (var item in collection)
// {
//     Console.Write($"{item} ");
// }
//
// class SomeCollection : IEnumerable<string>
// {
//     public IEnumerator<string> GetEnumerator()
//     {
//         throw new NotImplementedException();
//     }
//
//     IEnumerator IEnumerable.GetEnumerator()
//     {
//         return GetEnumerator();
//     }
// }
//
// class MyCollection : IEnumerable
// {
//     public List<int> list { get; set; } = new List<int>() {1, 2, 4, 50, 112, 552};
//
//     public IEnumerator GetEnumerator()
//     {
//         return list.GetEnumerator();
//     }
// }


Auditory students = new Auditory();

foreach (var item in students)
{
    Console.WriteLine(item);
}

public interface ITerator
{
    void getNext();
    bool hasMore();
}

public interface ITerableCollection
{
    ITerator creatTerator();
}

class Student
{
    private static int _id = 1;
    public int Id { get; set; } = _id;
    public string? Name { get; set; }

    public Student()
    {
        Id = _id++;
    }

    public override string ToString()
    {
        return $"Id: {Id} Name: {Name}";
    }
}

class Auditory : ITerableCollection
{
    List<Student> students = new List<Student>()
    {
        new Student()
        {
            Name = "Aida",
        },
        new Student()
        {
            Name = "Suleyman"
        },
        new Student()
        {
            Name = "Nadir"
        }
    };

    public ITerator creatTerator()
    {
        throw new NotImplementedException();
    }

    public IEnumerator<Student> GetEnumerator()
    {
        for (int i = 0; i < students.Count; i++)
        {
            yield return students[i];
        }
    }
}