
using System.Runtime.CompilerServices;

Person person = new Person ("Sofia", 20, 600);

GoodPesron good = new GoodPesron("Sofi", 5, 4, "good");

//за да достъпваме информация от нашият клас персон, е необходимо полетата, които са private да имат propartita

//person.Age = 10;
//person.Salary = 20;

Console.WriteLine($"{person.Age}");
bool result = person.IsOfLegalAge(person);
Console.WriteLine(result);
Console.WriteLine(person.Salary);
public class Person 
{
    private string _name;
    private int _age;
    double _salary;
    public Person(string name, int age, double salary)
    {
        this.Name = name;
        this.Age = age;
        this.Salary = salary;

        this.IsOfLegalAge(this);
    }
    public string Name
    {
        get
        {
            return _name;
        }
        set
        { 
            if(string.IsNullOrEmpty(value))
            {
                throw new ArgumentException("can not");
            }
            this._name = value;
        }
    }

    public int Age
    {
        get { return this._age; }

        set
        {
            if (value < 18)
            {
                throw new ArgumentException("Not");
            }
            this._age = value;
        }
    }

    public bool IsOfLegalAge(Person person)
    {
        return person.Age > 18;
    }

    public double Salary
    {
        get { return this._salary; }

        private set
        {
            if (value < 500)
            {
                throw new ArgumentException("The salary sould be 600");
            }
            this._salary = value;
        }
    }
}

//При наследяването на класовете се наследяват полета, пропъртита, метжди но не могат да се наследяват конструктори. 
//Конструкторите могат да се чейнват

public class GoodPesron:Person
{
    public GoodPesron(string name, int age, double salary, string charity) : base (name,age,salary)
    {
        this.Charity = charity;
    }

    public string Charity { get; set; }

}