// var sonlar = Console.ReadLine()!
//     .Split(' ')
//     .Select(int.Parse)
//     .ToArray();

// Console.WriteLine(sonlar[2]);

//Ikki o'lchamli array

int[,] array = 
{
    {1, 2, 3},
    {4, 5, 6},
    {7, 8, 9},
    {10, 11, 12},    
};

//ikki o'lchamli arrayning qatorlari soni
Console.WriteLine(array.GetLength(0));

//ikki o'lchamli arrayning ustunlari soni
Console.WriteLine(array.GetLength(1));

Console.WriteLine(array.Length);
for(int i = 0; i < array.GetLength(0); i++)
{
    for(int j = 0; j < array.GetLength(1); j++)
    {
        Console.Write(array[i, j] + " ");
    }
    Console.WriteLine();
}


//bu yerda 3 soni ikki o'lchamli arrayning qatorlari sonini bildiradi
//4 soni esa ustunlari sonini bildiradi
int[,] array2 = new int[3, 4];

int[,] array1 = { 
	{ 2, 5, 7 },
	{ 4, 1, 8 },
	{ 6, 3, 9 }
};

int sum = 0;

for(int i = 0; i < array.GetLength(0); i++)
{
    sum += array1[i , i];
    // for(int j = 0; j < array.GetLength(1); j++)
    // {
    //     if(i == j)
    //     {
    //         sum += array1[i, j];
    //     }
    // }
}

Console.WriteLine(sum);


//bir o'lchamli arrayning elementlarini tartiblash
int[] sonlar = {3, 1, -2, 7, 9}; // -2, 1, 3, 7, 9

for(int i = 0; i < sonlar.Length - 1; i++)
{
    for(int j = i + 1; j < sonlar.Length; j++)
    {
        if(sonlar[i] > sonlar[j])
        {
            //swap
            int t = sonlar[i];
            sonlar[i] = sonlar[j];
            sonlar[j] = t;
        }
    }
}

for(int i = 0; i < sonlar.Length; i++)
{
    Console.Write(sonlar[i] + " " );
}