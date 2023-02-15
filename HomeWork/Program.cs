string[] myArray = new string[] {"hello","2","world",":-)"};//Задаем массив на старте
PrintArray(myArray);
Console.WriteLine("-------------------------------");
string[] myArray2 = NewArray(myArray);
PrintArray(myArray2);

string[] NewArray(string[] array){
    int count = 0;
    for(int i = 0; i < array.Length; i++){//Цикл подсчета строк с количеством элементов < или = 3м
        if(array[i].Length <= 3){
            count++;
        }
    }
    string[] resultArray = new string[count];
    count = 0;
    for(int i = 0; i < array.Length; i++){//Цикл заполнения нового массива строками с количеством элементов < или = 3м
        if(array[i].Length <= 3){
            resultArray[count] = array[i];
            count++;
        }
    }
    return resultArray;
}


void PrintArray(string[] array){
    Console.WriteLine($"[{String.Join(",", array)}]");
}