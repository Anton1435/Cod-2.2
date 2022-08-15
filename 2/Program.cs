//1 Вид методов (ни чего не возвращают и ни чего не получают)
//void Method1()   // скобочки пустые.
//{
  //  Console.WriteLine("Автор ....");   //например вывод на экран
//}
//Method1();    ///вызов метода(обезательнокруглые скобки)

// Вид 2
//void Method2(string)    // Ни чего не возвращаю но принимают аргументы.
//{
  //  Console.WriteLine(msg);
//}
//Method2(msg ,"Текс сообщения");

//void Method21(string msg, int count)
//{
  //  int i = 0;
   // while(i<count)
    //{
     ///   Console.WriteLine(msg);
        //i++;
    //}
///}
//Method21("Текст",4);     ///// 4- означает сколько раз хотите увидеть это сообщение
//Method21(count: 4,msg: "Текст");     /// именованые аргументы,можно писать не по прядку

/// Вид 3     Что то возвращают но ни чего не принемают

//int Method3()
//{
  //  return DateTime.Now.Year;
//}
//int year = Method3();
//Console.WriteLine(year);       /// Вызвали текущий год

///Вид 4     Что то принимают и что то возвращают

//string Method4(int count,string text)
//{
    //int i = 0;
    //string result = String.Empty;   ///// результат пока пустой строкой

    //while(i<count)
    //{
       // result = result + text;
     //   i++;
   // }
  //  return result;
//}
//string res = Method4(10, " gfdg");
//Console.WriteLine(res);


/// Использование "for"

//string Method4(int count,string text)
//{
    //string result = String.Empty;   ///// результат пока пустой строкой
    //for (int i = 0; i < count; i++)
    //{
      //  result = result + text;
    //}
  //  return result;
//}
//string res = Method4(10, " gfdg");
//Console.WriteLine(res);


/// Таблица умножения 5х5

//for (int i = 2; i <= 10; i++)
//{
  //  for (int j = 0; j <= 10; j++)
    //{
      //   Console.WriteLine($"{i}x{j}= {i*j}");
    //}
    // Console.WriteLine();
//}

///   Пограмма обработки текста.
///Дан текс.В тексте нужно все пробелы заменить черточками,
///маленькие буквы "к"заменить большими "К",а большие "С" 
///заменить на маленькие"с"

//string text = "-Я думаю, - сказал князь,улыбаясь, - что, "
          //  + "неужели бы вас послали вместо нашего милого Винценгероде,"
            //+" вы бы взяли приступом согласия прусского короля. "
            //+" Вы так красноречивы. Вы дадите мне чаю?";
/// string s = "qwerty"
///             0123
///  s[3]  = r

//string RepLace(string text, char oldValue, char newValue)    ////оldValue старое на новое  newValue
//{
    //string result = String.Empty;  /// пустая строка

    //int length = text.Length;
    //for (int i = 0; i < length; i++)
    //{
       // if (text[i] == oldValue) result = result + $"{newValue}";
      //  else result = result + $"{text[i]}";
    //}

  //   return result;
     
//}
//string newText = RepLace(text, ' ', '|');

//Console.WriteLine(newText);

//Console.WriteLine();
//newText = RepLace(text, 'к', 'К');
//Console.WriteLine(newText);


///// Упорядочить данные в вутри массива(алгоритм метода выбора мах мин)
/////  суть даны числа 68321457 должно получится 12345678

//int[] arr ={6,8,3,2,1,4,5,7};

//void PrintArray(int[] array)         ////первый метод вывода на экран
//{
  //  int count = array.Length;
   /// for (int i = 0; i < count; i++)
    //{
     //   Console.Write($"{array[i]}");
    //}
    //Console.WriteLine();
///}

///void SelectionSort(int[] array)
//{
  //  for (int i = 0; i < array.Length; i++)
   // {
     //   int minPosition = i;
        
      //  for (int j = i + 1; j < array.Length -1; j++)
       // {
         //   if(array[j]< array[minPosition])  minPosition = j;
        //}

        //int temporary = array[i];          /////переменили местами
        //array[i] = array[minPosition];      ////переменили местами
        //array[minPosition] = temporary;
    //}
//}

//PrintArray(arr);
//SelectionSort(arr);

//PrintArray(arr);
