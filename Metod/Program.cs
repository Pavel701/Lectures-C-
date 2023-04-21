// void Metod1(){

//     System.Console.WriteLine("Автор\t Шипунов П.Н.");
// }
//Metod1();

// void Metod2(string msg){

// Console.WriteLine(msg);
// }
// Metod2(msg: "Text meseger");

// void Metod22(string msg, int count)
// {
// int i = 0;
// while(i < count)
// {
//     System.Console.WriteLine(msg);
//     i++;
// }
// }
// //Metod22(msg: "Text mesenger", count: 3);

// int Metod3()
// {
//     return DateTime.Now.Year;

// }
// int year = Metod3();
// System.Console.WriteLine(year);

// string Method4(int count, string text)
// {
// int i = 0;
// string result = String.Empty; // Пустая строка
// while(i < count)
// {
// result = result + text;
// i++;
// }
// return result;

// }
/////////////////////////////////////////////////////////////////////////////////////////
// string Method4(int count, string text)
// {

// string result = String.Empty; // Пустая строка
// for(int i = 0; i < count; i++) // Цикл for
// {
// result = result + text;
// }
// return result;
// }
// string res = Method4(5, " Z");
// System.Console.WriteLine(res); //result 
//////////////////////////////////////////////////////////////////////////////


// int sum = 0;       
// int[] arr = new int[8] { 2, 7, 7, 1, 8, 4, 6, 3 }; //Элементы массива:

// for (int i = 0; i < arr.Length; i++) {
// System.Console.Write($" {arr [i]}");

//     }
//  for (int i = 0; i < arr.Length; i++)
//   {
//    sum += arr[i];
   
//     }
//    System.Console.WriteLine();
//    Console.WriteLine($"Сумма элементов массива: {sum} ");

int sum = 0;
int[] arr = { 1, 2, 3, 4, 5 };
foreach (int element in arr)
{
 Console.Write($" {element}");
}

for (int i = 0; i < arr.Length; i++)
{
sum += arr[i];
   
}
System.Console.WriteLine();
Console.WriteLine($"Сумма элементов массива: {sum} ");
