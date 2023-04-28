using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Runtime.InteropServices;

namespace SafariParkApp
{
    public class Program
    {
        static void Main(string[] args)
        {
            var helen = new Person { FirstName = "Helen", LastName = "Troy", Age = 22 };
            var will = new Hunter("William", "Shakespeare", new Camera("Macbeth")) { Age = 457 };
            Console.WriteLine("List of people");
            List<Person> thepeople = new List<Person> { helen, will };

            foreach (var person in thepeople)
            {
                Console.WriteLine(person);
            }
            Console.WriteLine();

            List<int> nums = new List<int> { 5, 4, 3, 9, 0 };
            nums.Add(8);
            nums.Sort();
            nums.RemoveRange(1, 2);
            nums.Insert(2, 1);
            nums.Reverse();
            nums.Remove(9);

            foreach (var number in nums)
            {
                Console.Write(number);
            }

            Console.WriteLine("LinkedList of People");
            LinkedList<Person> thePeopleLinked = new LinkedList<Person>();
            thePeopleLinked.AddFirst(helen);
            thePeopleLinked.AddLast(will);
            thePeopleLinked.AddLast(new Person { FirstName = "Linda", LastName = "Smith", Age = 45 });
            thePeopleLinked.AddAfter(thePeopleLinked.Find(helen), new Person { FirstName = "John", LastName = "Green", Age = 45 });

            foreach(var person in thePeopleLinked)
            {
                Console.WriteLine(person);
            }

            var myQueue = new Queue<Person>();
            myQueue.Enqueue(helen);
            myQueue.Enqueue(will);
            myQueue.Enqueue(new Person("Cathy"));
            Console.WriteLine("\nQueue");
            foreach(var q in myQueue)
            {
                Console.WriteLine(q);
            }
            var first = myQueue.Peek();
            var serve = myQueue.Dequeue();
            var second = myQueue.Peek();
            var served = myQueue.Dequeue();

            int[] original = new int[] { 1, 2, 3, 4, 5 };
            int[] reversed = new int [ original.Length ];
            var stack = new Stack<int>();
            foreach(var n in original)
            {
                stack.Push(n);
            }
            foreach(var s in stack)
            {
                Console.WriteLine(s);
            }
            for (int i = 0; i< original.Length; i++)
            {
                reversed[i] = stack.Pop();
            }

            var peopleSet = new HashSet<Person>
            {
                helen, new Person("Jasmine"), new Person ("Andrei")
            };
            Console.WriteLine("HashSet");
            foreach(var entry in peopleSet)
            {
                Console.WriteLine(entry);
            }

            var successMartin = peopleSet.Add(new Person { FirstName = "Martin", LastName = "Beard" });
            var successHelen = peopleSet.Add(new Person { FirstName = "Helen", LastName = "Troy", Age = 22});

            var morePeople = new HashSet<Person> { new Person("Cathy"), new Person("Jasmine") };
            peopleSet.IntersectWith(morePeople);

            var personDict = new Dictionary<string, Person>
            {
                {"helen", helen },
                {"sherlock", new Person("Sherlock", "Jones"){Age = 40 } },
                
            };

            var p = personDict["sherlock"];
            personDict.Add("will", will);

            string input = "The cat in the hat comes back";
            input = input.Trim().ToLower();
            var countDict = new Dictionary<char, int>();
            foreach (var c in input)
            {

                if (countDict.ContainsKey(c))
                {
                    countDict[c]++;
                }
                else
                {
                    countDict.Add(c, 1);
                }
            }
            Console.WriteLine("Dictionary problem");
            foreach(var entry in countDict)
            {
                Console.WriteLine(entry);
            }
            Console.WriteLine("\nKeys");
            foreach(var key in countDict.Keys)
            {
                Console.WriteLine(key + " ");
            }
            Console.WriteLine("\nValues");
            foreach(var value in countDict.Values)
            {
                Console.WriteLine(value + " ");
            }


        }
        //static void Main(string[] args)
        //{
            //Person tony = new Person("Titanic", "Tony", 22);
            //Person anthony = new Person("Anthony", "Naguib", 22);
            //Console.WriteLine(tony.GetFullName());
            //Person lebron = new Person("Lebron");
            //Person titanic = new Person("Tony", "Titanic");
            //lebron.Age = 48;
            //Console.WriteLine(lebron.Age);
            //lebron.Age = 99;
            //Console.WriteLine($"But how does this affect {lebron.FullName} {lebron.Age} year old legacy");
            //var alex = new Person("Alex", "Blunt") { Age = 31 };
            //Console.WriteLine($"{alex.FullName} is {alex.Age} years old");
            //var list = new ShoppingList() { Bread = 2, Potato = 5, Milk = 2};

            //var manvir = new Person() { FirstName = "Manvir", LastName = "Nandra", Age = 25 };
            //Console.WriteLine($"{manvir.FullName} is {manvir.Age} years old");
            //Point3D p = new Point3D(3, 6, 2);
            //Console.WriteLine($"{p.x}x, {p.y}y, {p.z}z");

            //DemoMethod(p, manvir);
            //Console.WriteLine($"{manvir.FullName} is {manvir.Age} years old");
            //Console.WriteLine($"{p.x}x, {p.y}y, {p.z}z");

            //--------Inheritance---------
            //Hunter h = new Hunter("Marion", "Jones", "leica") { Age = 32 };
            //Console.WriteLine(h.Age);
            //Console.WriteLine(h.Shoot());
            //Console.WriteLine();

            //Hunter h2 = new Hunter("Marion", "Jones", "leica") { Age = 32 };
            //Console.WriteLine($"h Equals h2? {h.Equals(h2)}");
            //Console.WriteLine($"h hashCode: {h.GetHashCode()}");
            //Console.WriteLine($"h Type: {h.GetType()}");

            //Console.WriteLine($"h ToString: {h.ToString()}");
            //Console.WriteLine($"h {h}");

            //Rectangle rect = new Rectangle(3, 4);
            //Console.WriteLine(rect);
            //--------Inheritance LAB------------
            //Airplane a = new Airplane(200, 100, "JetsRUs"){ NumPassengers = 150}; 
            //a.Ascend(500); Console.WriteLine(a.Move(3)); 
            //Console.WriteLine(a); a.Descend(200); 
            //Console.WriteLine(a.Move()); a.Move();
            //Console.WriteLine(a);

            //---------Polymorphism-----------
            //POLYMORPHIC ARRAY
            //List<Object> gameObject = new List<Object>()
            //{
            //    new Person("Cathy", "French"),
            //    new Hunter("Stephano", "Naressi", "i30"),
            //    new Airplane(200, 100, "JetsRUs"){ NumPassengers = 150},
            //    new Vehicle(100, 10) {NumPassengers = 9},
            //    new Rectangle(3, 4)
            //};

            //foreach(var gameObj  in gameObject)
            //{
            //    Console.WriteLine(gameObj);
            //}

            //POLYMORPHIC METHOD
            //Console.WriteLine();
            //Hunter yolondo = new Hunter("Yolondo", "Young");
            //SpartaWrite(yolondo);

            //POLYMORPHIC TAASK
            //List<IMoveable> moveables = new List<IMoveable>()
            //{
            //    new Person("Cathy", "French"),
            //    new Hunter("Stephano", "Naressi", "i30"),
            //    new Airplane(200, 100, "JetsRUs"){ NumPassengers = 150},
            //    new Vehicle(100, 10) {NumPassengers = 9},
            //};
            //foreach (var moveable in moveables)
            //{
            //    Console.WriteLine(moveable.Move(3));
            //}
            //PolyMorphismLab();
            //ShootOut();

            //var robOne = new Person("Robert", "Sponge") { Age = 20 };
            //var robTwo = robOne;
            //var areSame = robOne.Equals(robTwo); //True

            //var robThree = new Person("Robert", "Sponge") { Age = 20 };
            //var areSameOneThree = robOne.Equals(robThree);

            //List<Person> personList =
            //    new List<Person>
            //    {
            //        new Person("Bobert", "Sponge"),

            //        new Person("Sandy", "Cheeks"){Age = 25},

            //        new Person("Robert", "Sponge"),

            //        new Person("Squilliam", "Squid"){Age = 32}
            //    };

            //foreach (var person in personList)
            //{
            //    Console.WriteLine(person);
            //}
            //var hasRob = personList.Contains(robOne);

            //var equals = robOne == robThree;
            //var notEquals = robOne != robThree;

            //personList.Sort();
            //foreach (var person in personList)
            //{
            //    Console.WriteLine(person);
            //}

        }

        //public static void PolyMorphismLab()
        //{
        //    List<IShootable> weapons = new List<IShootable>()
        //    {
        //        new LaserGun("RayGun"),
        //        new WaterPistol("Super Soaker"),
        //        new LaserGun("Red Laser"),
        //        new WaterPistol("PFC"),
        //        new Hunter("Sponge", "Da Bob", new Camera("Krabby Patty")),
        //        new Hunter("Patrick", "Star", new Camera("Stolen Squidward Nose")),
        //        new Hunter("Mr", "Krabs", new Camera("MONEEY")),
        //        new Hunter("a", "b", new LaserGun("Blue Laser")),
        //        new Camera("Kodak")
        //    };

        //    foreach (IShootable weapon in weapons)
        //    {
        //        Console.WriteLine(weapon.Shoot());
        //    }
        //}

        //public static void ShootOut()
        //{
        //    List<IShootable> weapons = new List<IShootable>()
        //    {
        //        //new LaserGun("RayGun"),
        //        //new WaterPistol("Super Soaker"),
        //        //new LaserGun("Red Laser"),
        //        //new WaterPistol("PFC"),
        //        new Hunter("Sponge", "Da Bob", new LaserGun("Krabby Patty")),
        //        new Hunter("Patrick", "Star", new WaterPistol("Stolen Squidward Nose")),
        //        new Hunter("Mr", "Krabs", new LaserGun("MONEEY")),
        //        new Hunter("Plank", "Ton", new LaserGun("Chum")),
        //        new Hunter("Mr", "Squidward", new WaterPistol("Clarinet"))
        //        //new Camera("Kodak")
        //    };


        //    while(weapons.Count > 1 )
        //    {
        //        Random rnd = new Random();
        //        int random1 = rnd.Next(0, weapons.Count - 1);
        //        int random2 = rnd.Next(0, weapons.Count - 1);
        //        Console.WriteLine($"{weapons[random1]} has shot {weapons[random2]}");
        //        weapons.Remove(weapons[random2]); 
        //    }

        //    Console.WriteLine();
        //    Console.WriteLine($"WINNER WINNER CHICKEN DINNER!!! \n{weapons[0]}, is FEASTINGGG");
        //}

        //public static void SpartaWrite(Object obj)
        //{
        //    Console.WriteLine(obj.ToString());
        //    if(obj is Hunter)
        //    {
        //        var hunterObj = (Hunter)obj;
        //        Console.WriteLine(hunterObj.Shoot());
        //    }
        //}

        //static void DemoMethod(Point3D pt, Person p)
        //{
        //    pt.y = 1000;
        //    p.Age = 92;
        //}
    //}
}