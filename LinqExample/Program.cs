

//// See https://aka.ms/new-console-template for more information



//1.Display Student Information
 

var States  = FakeData.GetState();
var Talulkas =FakeData.GetTalukas();
var districts =FakeData.GetDistricts();
var Standard  = FakeData.GetStandard();
var Students =FakeData.GetStudents();


var student = from stud in Students

              join stand in Standard
              on stud.StandardID equals stand.StandardID
              join dist in districts
              on stud.StandardID equals dist.StateId


              select new
              {
                  stud.StudentID,
                  stud.StudentName,
                  stud.TalukaId,
                  stand.StandardName
              };
foreach (var item in student.TakeLast(10))
{
    Console.WriteLine(item);
}

//var student = from stud in Students

//              join stand in Standard
//              on stud.StandardID equals stand.StandardID
//              join dist in districts
//              on stud.StandardID equals dist.StateId


//              select new
//              {
//                  stud.StudentID,
//                  stud.StudentName,
//                  stud.TalukaId,
//                  stand.StandardName
//              };
//foreach (var item in student.Take(10))
//{
//    Console.WriteLine(item);
//}




//var state = (from stud in Students
//             join stat in States
//             on stud.StandardID equals stat.StateId
//             select stat.StateName)
//             .Max();

//foreach (var item in state)
//{
//    Console.Write(item);
//}

//var state = (from stud in Students
//             join stat in States
//             on stud.StandardID equals stat.StateId
//             select stat.StateName)
//             .Min();

//foreach (var item in state)
//{
//    Console.Write(item);
//}


//var student = from stud in Students

//              join stand in Standard
//              on stud.StandardID equals stand.StandardID
//              join dist in districts
//              on stud.StandardID equals dist.StateId
//              //where(stud.StudentName.EndsWith("z")) 
//              where stand.StandardName.EndsWith('D') 

//              select new
//              {
//                  stud.StudentID,
//                  stud.StudentName,
//                  stud.TalukaId,
//                  stand.StandardName
//              };
//foreach (var item in student)
//{
//    Console.WriteLine(item);
//}


//var taluka2 = Students.GroupBy(x => x.TalukaId);

//foreach (var item in taluka2)
//{
//    foreach (var item2 in item)
//    {
//       Console.WriteLine( item2.TalukaId+" "+item2.StudentName);
//    }
//}





//var taluka = from tal in Talulkas
//             join stud in Students
//             on tal.TalukaId equals stud.TalukaId
//             select new
//             {
//                 tal.TalukaId,
//                 stud.StudentName
//             };

//foreach (var item in taluka)
//{
//    foreach (var tal  in item)
//    {

//    }
//}










//Console.WriteLine("Hello, World!");
//string[] names = { "Bill", "StAve", "James", "Mohan" };

//// LINQ Query 

////foreach(string name in names)
////{
////    if(name.StartsWith("moh"))
////            Console.WriteLine(name); //James,Mohan
////}

////var myLinqQuery = names.Where(n => n.StartsWith("Moh"));

////var myLinqQuery2 = from name in names
////                   where name.Contains('a')
////                   select name;
///*
// * 
// * 
// * 
// * 
// * 
// * 
// */ 




////var myLinqQuery3 = names.GroupBy(x => x.Contains('a'));

////foreach(var index in myLinqQuery3)
////{

////   foreach(var Data in index)
////    {
////        Console.WriteLine(Data);
////    }
////   Console.WriteLine();
////}


////// Query execution
////foreach (var name in myLinqQuery3)
////    Console.Write(name + " ");




//////Joins


//IList<string> strList1 = new List<string>() {
//    "One",
//    "Two",
//    "Three",
//    "Four"
//};

//IList<string> strList2 = new List<string>() {
//    "One",
//    "Two",
//    "Five",
//    "Six"
//};

//var innerJoin = strList1.Join(strList2,
//                      str1 => str1,
//                      str2 => str2,
//                      (str1, str2) => str1);



//IList<Student> studentList = new List<Student>() {
//    new Student() { StudentID = 1, StudentName = "John", StandardID =1 },
//    new Student() { StudentID = 2, StudentName = "Moin", StandardID =1 },
//    new Student() { StudentID = 3, StudentName = "Bill", StandardID =2 },
//    new Student() { StudentID = 4, StudentName = "Ram" , StandardID =2 },
//    new Student() { StudentID = 5, StudentName = "Ron"  }
//};

//IList<Standard> standardList = new List<Standard>() {
//    new Standard(){ StandardID = 1, StandardName="Standard A"},
//    new Standard(){ StandardID = 2, StandardName="Standard B"},
//    new Standard(){ StandardID = 3, StandardName="Standard C"}
//};

////var innerJoin2 = studentList.Join(// outer sequence 
////                      standardList,  // inner sequence 
////                      student => student.StandardID,    // outerKeySelector
////                      standard => standard.StandardID,  // innerKeySelector
////                      (student, standard) => new  // result selector
////                      {
////                          StudentName = student.StudentName,
////                          StandardName = standard.StandardName
////                      });

////foreach (var standard in innerJoin2)
////{
////    Console.WriteLine(standard.StudentName + "  " + standard.StandardName);
////}




//var innerJoin3 = from student in studentList
//                 join stand in standardList
//                 on student.StandardID equals stand.StandardID
//                 select new
//                 {
//                     StudentName = student.StudentName,
//                     StandardName= stand.StandardName,
//                 };

//foreach(var student in innerJoin3)
//{
//    Console.WriteLine(student.StudentName +","+student.StandardName);
//}



