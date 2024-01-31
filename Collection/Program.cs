
using Collection;
using System.Collections;

//MyList<string> myList1 = new MyList<string>();
//myList1.Add("a");
//myList1.Add("b");
//myList1.Add("c");
//myList1.Add("d");
//myList1.Add("e");
//foreach (var item in myList1)
//{
//    Console.WriteLine(item);
//}



//===============================================================

//ArrayList arrayList = new ArrayList();
//arrayList.Add(1);
//arrayList.Add("Abdulla");
//arrayList.Add("Amin");
//arrayList.Add("Revan");
//arrayList.Add(4);
//arrayList.RemoveAt(0);
//Console.WriteLine(arrayList.Contains("Abdulla"));

//Console.WriteLine(arrayList.IndexOf("Revan"));
//arrayList.Reverse();
////arrayList.Sort();
////arrayList.RemoveRange(0, arrayList.Count);

//foreach (var item in arrayList)
//{
//    Console.WriteLine(item);
//}



//SortedList sortedList = new SortedList();
//sortedList.Add("pb302",10);
//sortedList.Add("p404", 20);
//sortedList.Add("b123", 30);
//sortedList.Add("pd12", 40);
//sortedList.Add("rb34", 50);
//sortedList.Remove("pd12");
////sortedList.Contains("pb302");
//sortedList.GetByIndex(0);
//Console.WriteLine(sortedList.IndexOfKey("pb302"));
//Console.WriteLine(sortedList.IndexOfValue("pd12"));

//foreach (var item in sortedList)
//{
//    Console.WriteLine(item.ToString());
//}


//Queue queue = new Queue();
//queue.Enqueue("abdulla");
//queue.Enqueue(1);
//queue.Enqueue("ibrahim");
//queue.Enqueue("hikmet");
//queue.Enqueue("abbas");
//Console.WriteLine(queue.Peek());
//Console.WriteLine(queue.Dequeue());
//foreach (var item in queue)
//{
//    Console.WriteLine(item);
//}



//=============================================

//List<int> list1 = new List<int>();
//list1.Add(1);
//list1.Add(2);
//list1.Add(3);
//list1.Add(4);
//list1.Add(5);
//list1.Remove(5);
//Console.WriteLine(list1.Contains(5));

//foreach (int i in list1)
//{
//    Console.WriteLine(i);
//}


//===============================================

//List<string> list2 = new List<string>();
//list2.Add("a");
//list2.Add("b");
//list2.Add("c");
//list2.Add("d");
//list2.Add("e");
//list2.RemoveAt(0);
//list2.RemoveAt(3);
//Console.WriteLine(list2.Contains("e"));
//foreach (string i in list2)
//{
//    Console.WriteLine(i);
//}


//====================================================================
//string[] names = new string[] {"ramin","murad","alim"};

//List<string> values = new List<string>(names);

//foreach (string name in names)
//{
//    Console.WriteLine(name);
//}

//===================================================

Dictionary<string,int> keyValuePairs = new Dictionary<string,int>();
keyValuePairs.Add("Farid Abdullayev",19);
keyValuePairs.Add("Rafiq Samedov", 31);
keyValuePairs.Add("Gunay Emirahov", 14);
keyValuePairs.Add("Ibrahim Abdullayev", 14);

foreach (var item in keyValuePairs)
{
    Console.WriteLine($"Adi: {item.Key} - Yasi: {item.Value}");
}
