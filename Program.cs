﻿string[] deletingofElements(string[]array){
    int count = 0;
    for(int i =0; i<array.Length; i++)
    {
        if (array[i].Length <=3)
        {
            count++;
        }
    }
    string[] newarray = new string[count];
    int j =0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i].Length <= 3)
        {
            newarray[j] = array[i];
            j++;
        }
    }
    return newarray;
}
string[] arrayofStrings = {"hello", "my", "friend", "234", ":-)", "homework", "12"};
string[] finalArray = deletingofElements(arrayofStrings);
Console.WriteLine($"{string.Join(" ", finalArray)}");