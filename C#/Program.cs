Console.WriteLine("Enter quantity word");
int size = Convert.ToInt32(Console.ReadLine());

string[] array = CreatArray(size);
PrintArray(array);
PrintM(array);
string[] CreatArray ( int size ){
    string[] arr = new string[size];

    for ( int i = 0 ; i < size ; i++){
        Console.WriteLine("Enter word");
        arr[i] = Convert.ToString(Console.ReadLine());
    }
    return arr;

}
void PrintArray(string[] arr){
    Console.Write("[");
    for (int i = 0; i < arr.Length; i++){
        if (i < arr.Length - 1 ) Console.Write($"{arr[i]},");
        else Console.Write($"{arr[i]}");
    }
    Console.Write("]--->");
}
void PrintM(string[] arr){
     Console.Write("[");
    for (int i = 0; i < arr.Length; i++){
        if (arr[i].Length < 4 ) Console.Write($"{arr[i]},");
    }
    Console.WriteLine("]--->");    
}
