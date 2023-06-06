/*
//Программа которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.
Console.Write("Введите трехзначное число ");
int Number = Convert.ToInt32(Console.ReadLine());
int NumberA = Number / 10;
int NumberTwo = NumberA % 10;
Console.WriteLine( "" + Number + "->" + NumberTwo);
*/

/*
//Программа, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.
Console.Write("Введите число: ");
int Number = Convert.ToInt32(Console.ReadLine());
int P = 0;
if(Number < 100)
  {
    Console.WriteLine(  "Третей цыфры нет ->" + Number ); 
   
  }        
  else
  {
    if(Number < 1000)
      {
       P = 10;
      }
      else
      {   if(Number <10000 )
          P = 100;
          else
          {
          P= 1000;
          }
      }
  int NumberA = Number / P;
  
   int NumberThree = (Number - (NumberA * P )) / (P /10);

   Console.WriteLine(Number + "->" + NumberThree);
  }
  */

 /*
  //Программа, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным
  Console.Write("Введите цыфру: ");
  int Number = Convert.ToInt32(Console.ReadLine());
  if (Number == 6 || Number == 7)
  {
    Console.WriteLine("Это  выходной");
  }
  else
  {
  Console.WriteLine("Это не выходной");
  }
  */