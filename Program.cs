// Задача 60 Устройство для формирования и вывода 3мерного массива
int m=3;
int n=3;
int p=3;
int[,,] array=new int[m,n,p];
void PrintArray(int[,,] arr1)
    {
    for (int i1=0; i1<arr1.GetLength(0);i1++)
            {
            for (int j1=0;j1<arr1.GetLength(1);j1++)
                {
                for (int k1=0;k1<arr1.GetLength(2);k1++)
                     Console.Write("{0:d2} ", arr1[i1,j1,k1]+ "("+i1+","+j1+","+k1+")");
                Console.WriteLine();
                }
            }
            Console.WriteLine();
    }
int [,,] CreateArray(int m1,int n1, int p1)
    {   int temp=10;
        int[,,] arr3=new int[m1,n1,p1];
        int q=0;
        int [] IfUnique=new int [m1*n1*p1];
        for (int i2=0; i2<m1;i2++)
            for (int j2=0;j2<n1;j2++)
                for (int k2=0;k2<p1;k2++)
                {  
                    while (Array.IndexOf(IfUnique,temp)>=0)
                        temp=new Random().Next (10,100);
                    IfUnique[q]=temp;
                    q++;
                 arr3[i2,j2,k2]=temp;
                 }
    return arr3;
    }
array=CreateArray(m,n,p);
Console.WriteLine("Массив уникальных двузначных чисел");
PrintArray(array);
Console.WriteLine();