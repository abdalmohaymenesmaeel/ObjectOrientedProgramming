//int x = 10;
//int y = 0;
//while (y<x)
//{
//    Console.WriteLine(y);
//    y++;
//}
/*int x = 0;
do
{
    x++;
    Console.WriteLine(x);
    string stop = Console.ReadLine();
    if (stop == "s")
    {
        break;
    }
} while (true);*/
/*int i = 0;
for (;;)
{
    i++;
    Console.WriteLine(i);
    if (i==1000)
    {
        break;
    }
}
for (int j = 0; ; j++)
{
    Console.WriteLine(j);
    if (j < 1000)
    {
        break ;
    }
}*/

/*int t=0;
int y = 0;
while (t<10 && y <20)
{
    Console.WriteLine($"T:{t},Y:{y}");
    t++;
    y+=3;
}*/

/*for (int i = 0,j=9; i < 10 && j >=0; i++,j--)
{
    //Console.WriteLine($"I:{i},J:{j}");
    //Console.WriteLine("I:"+i+",J:"+j);
    for (int k = 0; k < 10; k++)
    {
        if (i == k || k==j)
        {
            Console.Write(" ");
        }
        else
        {
            Console.Write("*");
        }
    }
    Console.WriteLine("");
}*/
/*int[] arr = new int[6];
arr[0] = 10;
arr[1] = 11;
arr[2] = 12;
arr[3] = 13;
arr[4] = 14;
Console.WriteLine(arr.Length);
for (int i = 0; i < arr.Length; i++)
{
    Console.WriteLine(arr[i]);
}*/
/*Console.WriteLine("Enter Your Marks");
int nOM=Convert.ToInt32(Console.ReadLine());
int[] arrMarks=new int[nOM];
for (int i = 0; i < nOM; i++)
{
    Console.WriteLine($"Enter Mark {i+1}:");
    int Mark=Convert.ToInt32(Console.ReadLine());
    arrMarks[i]=Mark;
}
int total = 0;
int maxNumer = arrMarks[0];
int minNumer = arrMarks[0];
for (int i = 0; i < nOM; i++)
{
    if (arrMarks[i]>maxNumer)
    {
        maxNumer = arrMarks[i];
    }
    if (arrMarks[i] < minNumer)
    {
        minNumer = arrMarks[i];
    }
    total+=arrMarks[i];
    //Console.WriteLine(arrMarks[i]);
}
Console.WriteLine("Your Average is:"+Convert.ToDouble(total)/ Convert.ToDouble(nOM));
Console.WriteLine($"Your Total is:{total}" );
Console.WriteLine($"Max Number is:{maxNumer}");
Console.WriteLine($"Min Number is:{minNumer}");
Console.WriteLine($"Count Numbers is {arrMarks.Length}");
*/
/*int[,] arr1 = 
{
    {3,5,5 },
    {4,5,6 },
    {5,6,7 },
    {6,7,8 },
    {7,8,9 },
};*/
/*int[,] arr = new int[3, 4];
arr[0, 0] = 67;
arr[0, 1] = 65;
arr[0, 2] = 68;
arr[0, 3] = 78;

arr[1, 0] = 69;
arr[1, 1] = 69;
arr[1, 2] = 68;
arr[1, 3] = 71;

arr[2, 0] = 55;
arr[2, 1] = 91;
arr[2, 2] = 95;
arr[2, 3] = 76;*/
//Console.WriteLine(arr1.Length);
/*for (int i = 0; i < 3; i++)
{
    for (int j = 0; j < 4; j++)
    {
        Console.Write(arr[i,j]+",");
    }
    Console.WriteLine("");
}*/

/*int[] arr = new int[] {3,5,6 ,8,2,3};
foreach (int item in arr)
{
    Console.Write(item+",");
}*/
/*int[,] arr2 = {
                { 3,4,6,7},
                { 3,4,6,7},    
                { 4,5,6,7},
            };
foreach (var item in arr2)
{
    Console.Write(item);
}*/
Index i1 = 3;  // number 3 from beginning
Index i2 = ^4; // number 4 from end
int[] a = { 0, 1, 2, 3, 4, 5, 6, 7, 8, 9 };
Console.WriteLine($"{a[i1]}, {a[i2]}"); // "3, 6"

var slice = a[i1..i2]; // { 3, 4, 5 }
int[,] ar = new int[14, 5];
Console.WriteLine(ar.GetLength(0));
