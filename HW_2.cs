using System.Collections;
using System.Diagnostics;

var commonwatch = new Stopwatch();
commonwatch.Start();

var stopwatch = new Stopwatch();

var list=new List<int>();
var arrayList = new ArrayList();
var linkedList = new LinkedList<int>();

//сравниваем длительность заполнения списков
stopwatch.Start();
for (var i=0; i<1000000; i++)
{
    list.Add(i);
}
stopwatch.Stop();
Console.WriteLine($"Длительность заполнения List: {stopwatch.ElapsedMilliseconds}");

stopwatch.Start();
for (var i=0; i<1000000; i++)
{
    arrayList.Add(i);
}
stopwatch.Stop();
Console.WriteLine($"Длительность заполнения ArrayList: {stopwatch.ElapsedMilliseconds}");

stopwatch.Start();
for (var i=0; i<1000000; i++)
{
    linkedList.AddLast(i);
}
stopwatch.Stop();
Console.WriteLine($"Длительность заполнения LinkedList: {stopwatch.ElapsedMilliseconds}");

//сравниваем время поиска 496753-го элемента и вывода его на экран
stopwatch.Start();
var xList = list.Find(x=>x==496752);
//var xList = list[496752];
//у этих двух видов поиска одиноковая длительность
Console.WriteLine(xList);
stopwatch.Stop();
Console.WriteLine($"Длительность поиска и вывода 496753-го элемента у List: {stopwatch.ElapsedMilliseconds}");

stopwatch.Start();
var xArrayList = arrayList[496752];
Console.WriteLine(xArrayList);
stopwatch.Stop();
Console.WriteLine($"Длительность поиска и вывода 496753-го элемента у ArrayList: {stopwatch.ElapsedMilliseconds}");

stopwatch.Start();
var xLinkedList = linkedList.Find(496752);
Console.WriteLine(xLinkedList.Value);
stopwatch.Stop();
Console.WriteLine($"Длительность поиска и вывода 496753-го элемента у LinkedList: {stopwatch.ElapsedMilliseconds}");

//сравниваем время поиска и вывода всех элементов, делящихся на 777
stopwatch.Start();
foreach(var i in list)
    if (i % 777 == 0 && i!=0)
    {
        string is777 = i == 777 ? string.Format("{0}", i):", " + i;
        Console.Write(is777);
    }
Console.WriteLine();
stopwatch.Stop();
Console.WriteLine($"Длительность поиска и вывода делящихся на 777 элементов у List: {stopwatch.ElapsedMilliseconds}");

stopwatch.Start();
foreach(int i in arrayList)
    if (i % 777 == 0 && i!=0)
    {
        string is777 = i == 777 ? i.ToString() :", " + i;
        Console.Write(is777);
    }
Console.WriteLine();
stopwatch.Stop();
Console.WriteLine($"Длительность поиска и вывода делящихся на 777 элементов у ArrayList: {stopwatch.ElapsedMilliseconds}");

stopwatch.Start();
foreach(var i in linkedList)
    if (i % 777 == 0 && i!=0)
    {
        string is777 = i == 777 ? i.ToString() :", " + i;
        Console.Write(is777);
    }
Console.WriteLine();
stopwatch.Stop();
Console.WriteLine($"Длительность поиска и вывода делящихся на 777 элементов у LinkedList: {stopwatch.ElapsedMilliseconds}");

commonwatch.Stop();
Console.WriteLine($"Время выполнения всего задания: {commonwatch.ElapsedMilliseconds}");

