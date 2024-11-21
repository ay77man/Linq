using L2O___D09;
using System.Collections;
using System.Linq;
using static L2O___D09.ListGenerators;
namespace LinQ

{
    public class Program
    {
        static void Main(string[] args)
        {
           
            var Nums  = new List<int> { 1,2,3,4,5,6,7,8,9,10};
            var words = new List<string> { "one", "two", "three", "four", "five" };
            #region  Regular Syntax 


            //List<int> A = new List<int>();
            //foreach (int i in Nums)
            //{
            //    if (i % 2 == 0)
            //    {
            //        A.Add(i);

            //    }
            //}
            //foreach (int i in A)
            //{
            //    Console.WriteLine(i);
            //}
            #endregion
            #region Query Syntax
            //IEnumerable<int> EvenNums = from num in Nums
            //               where num % 2== 0
            //               select num;

            //foreach (var num in EvenNums)
            //{
            //    Console.WriteLine(num);
            //}

            #endregion
            #region  Method Syntax
            //var Even = Nums.Where(n => n % 2 == 0).ToList(); // Ex Mehtod // immidiate excution .
            //var e = Enumerable.Where(Nums, n => n % 2 == 0); // Static Method Withn Static Class
            //Nums.Remove(2);
            //foreach (var num in Even)
            //{ Console.Write($"{num}  "); }
            #endregion
            #region More Complex Query
            // List<Employees> employees = new List<Employees>
            //{
            //    new Employees{Name = "AYman" , Salary = 5000  , City = "Alex"},
            //    new Employees{Name = "Ali" , Salary = 10000000  , City = "London"},
            //    new Employees{Name = "Sayed" , Salary = 110000  , City = "Gaza"}
            //};
            // // Query Syntax
            // var Emps = from n in employees
            //            where n.Salary > 10000
            //            orderby n.Salary
            //            select n;
            // foreach (var emp in Emps)
            // {
            //     Console.WriteLine($"{emp.Name}  : {emp.Salary}");
            // }   
            // // Method Syntax
            // var emps = employees.Where(e=> e.Salary > 1000).OrderByDescending(e => e.Salary).Select(e => new {e.Name, e.Salary});
            // foreach(var emp in emps)
            // { Console.WriteLine(emp); }
            #endregion

            #region 1.Where(Filtering)
            //var result = ProductList.Where(p => p.UnitsInStock == 0);
            //result = ProductList.Where((p, i) => p.UnitsInStock == 0 && i < 10);

            //var result = from p in ProductList
            //             where p.UnitsInStock == 0 && p.ProductID < 10
            //             select p;
            //foreach (var item in result)
            //{
            //    Console.WriteLine(item);
            //}
            #endregion
            #region 2.Select(Projection/Transformation Operator)
            // Projection / Transform every Element in input seq to a New Element in output seq of new datatype or (same type)

            //var result = ProductList.Select(p => p.ProductName);
            //// Product => String
            //result = from p in ProductList
            //         select p.ProductName;

            // var result = ProductList.Where(p => p.UnitsInStock == 0).Select(p => new { id = p.ProductID, Name = p.ProductName });
            // product => anyonms type

            //result = from p in ProductList
            //            where p.UnitsInStock == 0 
            //            select new { id = p.ProductID, p.ProductName };

            // var discoutndList = ProductList.Select(p=> new Product() { ProductID = p.ProductID, UnitsInStock = p.UnitsInStock , Category = p.Category, ProductName = p.ProductName, UnitPrice = p.UnitPrice * 0.9m });
            //// product => product
            //discoutndList = from p in ProductList
            //                select new Product() { ProductID = p.ProductID, UnitsInStock = p.UnitsInStock, Category = p.Category, ProductName = p.ProductName, UnitPrice = p.UnitPrice * 0.9m };

            //var result = ProductList.Select((p, i) => new { p.ProductName , Index = i}).Where(p=>p.Index <=5); // indexd select. 

            //var result = ProductList.Select(p => new { p.ProductName, Price = p.UnitPrice * 1.5m }).Where(p => p.Price > 20);

            //var r1 = ProductList.Select(p => new { p.ProductName, Price = p.UnitPrice * 1.5m });
            //var r2 = r1.Where(p => p.Price > 20);

            //var r3 = from p in ProductList
            //         select new { p.ProductName, Price = p.UnitPrice * 1.5m };
            //var r4 = from p in r3
            //         where p.Price > 20
            //         select p;

            //var r5 = from p in ProductList
            //         select new { p.ProductName, Price = p.UnitPrice * 1.5m }
            //         into Taxprd
            //         where Taxprd.Price > 20
            //         select Taxprd;


            #endregion
            #region 3. Ordering Elements > orderby , orderbyDescending , thenby , thenby descending 
            //var result = ProductList.OrderByDescending(p => p.UnitPrice).Select(p => new {Name = p.ProductName, p.UnitPrice});

            // result = from p in ProductList
            //         orderby p.UnitPrice descending
            //         select new { Name = p.ProductName, p.UnitPrice };

            //var result1 = ProductList.OrderByDescending(p => p.UnitsInStock).ThenBy(p=>p.UnitPrice).Select(p => new { Name = p.ProductName, p.UnitPrice , p.UnitsInStock });

            //result1 = from p in ProductList
            //         orderby p.UnitsInStock descending , p.UnitPrice 
            //         select new { Name = p.ProductName, p.UnitPrice, p.UnitsInStock };
            #endregion
            #region 4.Element Operators(First , Last , FirstOrDefult , LastOrDefult , ElementAt , ElementAtDefult  , Single , SingleOrDefult)- Imidiate Execution 
            //List<Product> products = new List<Product>();
            //products.Add(ProductList[0]);

            //var Result = ProductList.First();
            //Result = ProductList.Last();
            //Result = ProductList.First(p=>p.UnitsInStock == 0); // if emty throw exeption 
            //Result = ProductList.Last(p=>p.UnitsInStock == 0);
            //Result = ProductList.FirstOrDefault(); // no throw exeption 
            //Result = ProductList.LastOrDefault(); // no throw exeption 
            //Result = ProductList.LastOrDefault(p=>p.UnitPrice == 500); // no throw exeption 

            //// Hyprid Syntax (Query Syntax).Method Syntax
            //var R = (from p in ProductList
            //         where p.UnitsInStock == 0
            //         select p).First();

            //Result = ProductList.ElementAt(1555);// exption 
            //Result = ProductList.ElementAtOrDefault(1555);

            ////Result = ProductList.Single(p=>p.UnitsInStock == 0); // Exption if no ELemnt or more one .
            ////Result = ProductList.SingleOrDefault( p=> p.UnitsInStock == 0); // Exption if more one .

            //Console.WriteLine(Result?.ProductName ?? "Na");
            #endregion
            #region 5.Aggregate Operators (min max sum avg count) - imidiat exction 
            //var Result = ProductList.Count();
            //    Result = ProductList.Count(p=>p.UnitsInStock == 0);
            //var Result = ProductList.Max();  // you must imp IComparable.
            //var Result1 = ProductList.Min(p => p.UnitsInStock);
            //Result = ProductList.Min();
            //var Result2 = ProductList.Average(p => p.UnitPrice);
            //Result2 = ProductList.Sum(p=>p.UnitPrice);
            //Console.WriteLine(Result2);
            #endregion

            #region 6. Generator Operators (Range , Empty , DefaultIfEmpty , Repeat) 
            // Generating Output seq From Nothing
            // Only Way To Call Them is a Static Member from Enumarable Class.
           // var result = Enumerable.Range(0, 11);
           // //var result1 = Enumerable.Empty<Product>;
           //// var result2 = Enumerable.Repeat(3, 10);
           // var res = result.DefaultIfEmpty(100);
           // foreach (var res1 in res )
           // {
           //     Console.WriteLine(res1);
           // }
            #endregion
            #region 7.Select Many (Projection And Flatten for  (Collection Of Collection ) )
            List<string> names = new List<string>() { "Ayman Hussien", "Noran Ali" , "Ahmed Elsayed"};
            // Output Seq Count > Input Seq Count
            // Transform Each Elemnt In input Seq to Sub Seq
            //var num = new List<List<int>>()
            //{
            //    new List<int> { 1, 2, 3, 4, 5, 6, 7},
            //    new List<int> { 1,2, 3, 4,4, 5, 6,7}
            //};
            //var result  = num.SelectMany(n => n).Where(n => n > 5).Select(n => new { num = n*2});

            //// Query Syntax : Use Multiple From 
            //var r1 = from fn in names
            //         from sn in fn.Split(' ')                  
            //         orderby sn.Length descending
            //         select sn;
            //var r2 = names.SelectMany(sn => sn.ToArray());
            #endregion
            #region 8.Cast Operators( Cast , OfType )  - Imidiate Execution 
            //ArrayList values = new ArrayList() { 1, 2, 3, "aymna", 'l', 5.5, "sayed", 4,5 };

            //var li = values.Cast<int>(); // Exeption when Can't To Cast 
            //li = values.OfType<int>(); // filter and get type that you want 
            //List<Product> prd = ProductList.Where(p=>p.UnitsInStock == 0).ToList();
            //Product[] prde = ProductList.Where(p=>p.UnitsInStock == 0).ToArray();
            foreach(int i in li) { 
                Console.WriteLine(i);
            }
            #endregion
            #region 9.Set Operators(Distinct , Union , Intersect , Execpt , Concat , SeqenceEqul)
            // List<int> list = new List<int>() { 1,2,3,4,5,6,7,8,9,10,1,2,3,4,5,6,7,8,9,10,22,5,8,9,8,8,8,8,};
            //  List<int> list2 = new List<int>() { 1,2,3,4,5,6,7,8,9,10,1,-1 -5,-9,-8,50,100,-9,99,78,55,20,25};
            // // var Result =  list.Distinct(); 
            //  var Result = list.Union(list2);
            // Result  = list.Intersect(list2);
            // Result = list2.Except(list);
            //  Result = list2.Concat(list2); 
            // var Resul = list.SequenceEqual(list2); // Checks if two sequences are identical in terms of elements and order.
            //Console.WriteLine(Resul);

            #endregion
            #region 10.Quantifiers (Any , All ,SeqenceEqul), retrun boolean
            //var Result = ProductList.Any();
            //Result = ProductList.Any(p=>p.UnitPrice>200);
            //Result = ProductList.All(p => p.UnitsInStock == 0);

            // Console.WriteLine(Result);
            #endregion
            #region 11.Zip
            // input 2 Seq , one Combined output seq
            //var r = Nums.Zip(words, (n, w) => new {number = n , word = w});
            //var result = Nums.Zip(ProductList, (n, a) => new {n  ,  a.ProductName});
            //var list  = Enumerable.Range(0,11);
            //var Result = ProductList.Zip(list,(fn , i) => new {i , name = fn.ProductName});
            #endregion
            #region 12.Grouping
            //var result = from p in ProductList
            //             where p.UnitsInStock > 0
            //             group p by p.Category
            //             into prdgroup
            //             where prdgroup.Count() > 10
            //             orderby prdgroup.Count() descending
            //             select prdgroup;

            //result = ProductList.Where(p => p.UnitsInStock > 0).GroupBy(p => p.Category).OrderByDescending(p=>p.Count());
            //foreach (var ProductG in result)
            //{
            //    Console.WriteLine(ProductG.Key);
            //    foreach (var prd in ProductG)
            //    {
            //        Console.WriteLine($"..{prd.ProductName}");
            //    }
            //}

            #endregion
            #region 13. Let / Into  - Introducing new range varible in qurey syntax(restart qurey
            //  var res = from p in ProductList
            //            select new { p, Price = p.UnitPrice * 1.5m }
            //            into prd
            //            where prd.Price > 50
            //            select new {prd.p.ProductName, prd.Price};

            //var res1 =  from p in ProductList
            //            let n = new { p, Price = p.UnitPrice * 1.5m }
            //            where n.Price > 50
            //            select new { p.ProductName, n.Price };

            //var result = from p in ProductList
            //             let n = p.UnitPrice * .9m
            //             select new { p.ProductName, Discount = n , PriceOld = p.UnitPrice };

            //var res = from p in ProductList
            //          select new { p.ProductName, Price = p.UnitPrice * 1.9m }
            //          into taxprd
            //          where taxprd.Price > 100
            //          select taxprd;

            #endregion
            #region 14.Join 
            //var students = new List<Student> {
            //    new Student { StudentId = 1, Name = "John" },
            //    new Student { StudentId = 2, Name = "Jane" },
            //    new Student { StudentId = 3, Name = "Sam" }
            //};

            //var enrollments = new List<Enrollment> {
            //    new Enrollment { StudentId = 1, CourseName = "Math" },
            //    new Enrollment { StudentId = 2, CourseName = "Science" },
            //    new Enrollment { StudentId = 4, CourseName = "History" } // This student does not exist in students list
            //};

            //var res = from student in students
            //          join enroll in enrollments  
            //          on student.StudentId equals enroll.StudentId
            //          select new {student.Name , enroll.CourseName};

            #endregion
            // Expression Trees: Learn about how LINQ queries are represented internally.
            //Asynchronous LINQ: Explore how to work with async LINQ operations using ToListAsync, FirstOrDefaultAsync, etc.
            //foreach (var name in res)
            //{
            //    Console.WriteLine(name);
            //}



        }
    }

    //internal class Student
    //{
    //    public int StudentId { get; set; }
    //    public string Name { get; set; }
    //}

    //internal class Enrollment
    //{
    //    public int StudentId { get; set; }
    //    public string CourseName { get; set; }
    //}
}
