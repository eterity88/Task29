// Задача 29: Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.
// 1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19]
// 6, 1, 33 -> [6, 1, 33]



{  
    int[] arr = new int[8]; 
    int i;  
  
    Console.Write("Введите 8 элементов массива :\n");  
    for(i=0; i<8; i++)  
    {  
	    Console.Write("элемент - {0} : ",i);
	    arr[i] = Convert.ToInt32(Console.ReadLine());  		
    }  
   
    {  
        Console.WriteLine($"Массив: [{String.Join(",",arr)}]");
    } }
   

