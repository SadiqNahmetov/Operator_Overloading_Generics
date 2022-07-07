using System;
//using static BookList;

namespace LessonReview
{
    class Program
    {
        static void Main(string[] args)
        {
            #region Implicit Explicit
            //Manat manat = new Manat(340);
            // Dollar dollar = manat;
            // Console.WriteLine(dollar.Usd);

            //Dollar dollar = new Dollar(500);

            //Manat manat = (Manat)dollar;

            //Console.WriteLine(manat.Azn);

            #endregion

            #region Implicit Explicit
            // name = "123S";
            //Console.WriteLine(int.Parse(name).GetType());

            //int age = 99;
            //Console.WriteLine(age.ToString().GetType());

            //DateTime date = DateTime.Now;
            //var result = date.ToString("MM-dd-yyyy");
            //Console.WriteLine(result);

            //var n = Convert.ToInt32(name);
            //Console.WriteLine(n);

            #endregion

            #region StrinIntLists
            //StringList stringList = new StringList();
            //stringList.AddElements("Sadiq");
            //stringList.AddElements("Esqin");

            //stringList.GetAll();



            //IntList intList = new IntList();
            //intList.AddElements(11);
            //intList.AddElements(55);
            //intList.AddElements(222);

            //intList.GetAll();
            #endregion

            #region BookList
            //    BookList bookList = new BookList();

            //    Book book1 = new Book()
            //    {
            //        Name = "Xosrov ve Shrin",
            //        Author = "Nizami Gencevi"
            //    };

            //    Book book2 = new Book()
            //    {
            //        Name = " Yeddi Gozel",
            //        Author = "Nizami Gencevi"
            //    };
            //    Book book3 = new Book()
            //    {
            //        Name = "Leyli ve Mecnun",
            //        Author = "Nizami Gencevi"
            //    };
            //    bookList.AddElements(book1);
            //    bookList.AddElements(book2);
            //    bookList.AddElements(book3);

            //     bookList.GetAll();
            //}
            #endregion

            #region Datalist

            //DataList<string> stringList = new DataList<string>();
            //stringList.AddElements("Sadiq");
            //stringList.AddElements("Esqin");
            //stringList.AddElements("Ramil");
            //stringList.AddElements("Mirsamir");

            //stringList.GetAll();


            //DataList<int> IntList = new DataList<int>();
            //IntList.AddElements(25);
            //IntList.AddElements(33);
            //IntList.AddElements(44);

            //IntList.GetAll();

            //DataList<Book> bookList = new DataList<Book>();
            //bookList.AddElements(new Book { Author = "Sadiq", Name = "Proqramlasdirma" });
            //bookList.AddElements(new Book { Author = "Ramin", Name = "Qasqay" });
            //bookList.GetAll();
            #endregion

            #region Generics
            //Employee<string> emp1 = new Employee<string>();
            //Employee<int> emp2 = new Employee<int>();
            //Employee<Person> emp3 = new Employee<Person>();
            //Employee<Test> emp4 = new Employee<Test>();

            //Employee<Person, Common> employee = new Employee<Person, Common>();
            #endregion
            #region Operator Overloading
            //Employee employee = new Employee(22, "Sadiq");
            //Student student = new Student(25, "Ramin");
            //var result = employee > student;
            //Console.WriteLine(result);
            #endregion


        }
        #region StringIntLists
        //    public class StringList
        //    {
        //        private string[] arr;

        //        public StringList()
        //        {
        //            arr = new string[0];
        //        }

        //        public void AddElements(string str)
        //        {
        //            Array.Resize(ref arr, arr.Length + 1);
        //            arr[arr.Length - 1] = str;
        //        }


        //        public void GetAll()
        //        {
        //            foreach (var item in arr)
        //            {
        //                Console.WriteLine(item);
        //            }
        //        }
        //    }
        //}

        //public class IntList
        //{
        //    private int[] arr;

        //    public IntList()
        //    {
        //        arr = new int[0];
        //    }

        //    public void AddElements(int m)
        //    {
        //        Array.Resize(ref arr, arr.Length + 1);
        //        arr[arr.Length - 1] = m;
        //    }


        //    public void GetAll()
        //    {
        //        foreach (var item in arr)
        //        {
        //            Console.WriteLine(item);
        //        }

        //    }
        #endregion

    }
    #region  Operator Overloading
    //public class Student
    //{
    //    public string Name { get; set; }
    //    public int Age { get; set; }

    //    public Student(int age, string name)
    //    {
    //        Name = name;
    //        Age = age;
    //    }
    //}

    //public class Employee
    //{
    //    public string Name { get; set; }
    //    public int Age { get; set; }

    //    public Employee(int age, string name)
    //    {
    //        Name = name;
    //        Age = age;
    //    }

    //    public static bool operator > (Employee employee, Student student)
    //    {
    //        return employee.Age > student.Age;
    //    }

    //    public static bool operator < (Employee employee, Student student)
    //    {
    //        return employee.Age < student.Age;
    //    }
    //}
    #endregion


    #region Generics
    //public class Employee<T,U> // where T : ITest
    //                          // where T : struct
    //                         // where T : Common
    //                         // where T : ITest
    //                         // where T : new()
    //                         //  where T:U
    //{

    //}


    //public class Person : Common
    //{

    //}

    //public class Common
    //{

    //}
    //public class Test : ITest
    //{

    //}

    //public interface ITest
    //{

    //}
    #endregion

    #region BookLists
    //public class BookList
    //{

    //  private Book[] arr;

    //  public BookList()
    //  {
    //   arr = new Book[0];
    //  }

    //   public void AddElements(Book book)
    //   {
    //     Array.Resize(ref arr, arr.Length + 1);
    //     arr[arr.Length - 1] = book;
    //   }


    //public void GetAll()
    //{
    //    foreach (var item in arr)
    //    {
    //        Console.WriteLine(item.Name + ":" + item.Author);
    //    }

    //}

    //public class Book
    //{
    //    public string Name { get; set; }
    //    public string Author { get; set; }
    //}
    #endregion

    #region DataList
    //public class DataList<T>
    //{

    //    private T[] arr;

    //    public DataList()
    //    {
    //        arr = new T[0];
    //    }

    //    public void AddElements(T data)
    //    {
    //        Array.Resize(ref arr, arr.Length + 1);
    //        arr[arr.Length - 1] = data;
    //    }


    //    public void GetAll()
    //    {
    //        foreach (var item in arr)
    //        {
    //            Console.WriteLine(item);
    //        }

    //    }
    #endregion



}
#region DataList
//public class Book
//{
//    public string Name { get; set; }
//    public string Author { get; set; }
//}
#endregion

