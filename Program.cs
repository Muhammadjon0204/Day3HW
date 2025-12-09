//Task1
/*
void PropertyNum(int n)
{
    int ecnt=0 , ocnt=0 , dcnt=0 , summ=0;
    for(int i=n ; i>0 ; i /= 10)
    {
        summ+=i%10;
        dcnt++;
        if ((i % 10) % 2 == 0)
        {
            ecnt++;
        }
        else
        {
            ocnt++;
        }
    }
    Console.WriteLine($"Even count : {ecnt}");
    Console.WriteLine($"Odd count : {ocnt}");
    Console.WriteLine($"Digit count : {dcnt}");
    Console.WriteLine($"Summa : {summ}");
}
Console.Write("Vvedite chislo : ");
int n=Convert.ToInt32(Console.ReadLine());

PropertyNum(n);  */

//Task2
/*
void Arifmetika(double a , double b)
{
    double Add=a+b;
    Console.WriteLine($"Add : {Add}");
    double sub=a-b;
    Console.WriteLine($"Substrack : {sub}");
    double mul=a*b;
    System.Console.WriteLine($"Multiply : {mul}");
    double div=a/b;
    System.Console.WriteLine($"Division : {div}");
}

System.Console.Write("Vvedite 1 chislo : ");
int a=Convert.ToInt32(Console.ReadLine());
System.Console.Write("Vvedite 2 chislo : ");
int b=Convert.ToInt32(Console.ReadLine());
Arifmetika(a,b);  */


//Task3

/*
void SumD(int n)
{
    int max=int.MinValue;
    int min=int.MaxValue;
    for(int i=n ; i>0 ; i /= 10)
    {
        int d=i%10;
        if (d > max)
        {
            max=d;
        }
        if (i < min)
        {
            min=d;
        }
    }
    int summ=min+max;
    System.Console.WriteLine($"{min} + {max} = {summ}");
}

System.Console.Write("Vvedite chislo : ");
int n=Convert.ToInt32(Console.ReadLine());
SumD(n);  */


//Task4

/*
void PowN(int a , int b)
{
    int pown=1;
    for(int i=1 ; i<=b ; i++)
    {
        pown*=a;
    }
 System.Console.WriteLine($"Pow b of a : {pown}");
}

System.Console.Write("Vvedite chislo : ");
int a=Convert.ToInt32(Console.ReadLine());
System.Console.Write("Vvedite stepen : ");
int b=Convert.ToInt32(Console.ReadLine());
PowN(a,b);   */


//TASK 5

/*
void SwapN(ref int a , ref int b)
{
    int temp=a;
    a=b;
    b=temp;
    System.Console.WriteLine($"{a} and {b}");
}

System.Console.Write("Vvedite 1 chislo : ");
int a=Convert.ToInt32(Console.ReadLine());
System.Console.Write("Vvedite 2 chislo : ");
int b=Convert.ToInt32(Console.ReadLine());
SwapN(ref a,ref b); */


//Task6
/*
 void divN(int n)
{
    for(int i=1 ; i<=n ; i++)
    {
        if (n % i == 0)
        {
            System.Console.Write($" {i} ");
        }
    }
}

System.Console.Write("Vvedite chislo : ");
int n=Convert.ToInt32(Console.ReadLine());
divN(n);   */


//Task7 

/*
void Array(ref int[] arr, ref int a)
{
    for (int i = 0; i < arr.Length; i++)
    {
        arr[i] += a;
    }
}

System.Console.Write("Vvedite razmer massiva: ");
int n = Convert.ToInt32(Console.ReadLine());

System.Console.WriteLine("Vvedite massiv:");
int[] arr = new int[n];
for (int i = 0; i < n; i++)
{
    arr[i] = Convert.ToInt32(Console.ReadLine());
}

System.Console.Write("Vvedite slagaemoe: ");
int a = Convert.ToInt32(Console.ReadLine());

Array(ref arr, ref a);

System.Console.WriteLine("Resultat:");
foreach (var item in arr)
{
    Console.Write(item + " ");
}  */    


//Task8

/*
int Minimum(int a , int b, int c ,int d)
{
    int min = a;

    if (b < min) min = b;
    if (c < min) min = c;
    if (d < min) min = d;

    return min;
}

System.Console.WriteLine("Vvedite 4 chisla : ");
int a=Convert.ToInt32(Console.ReadLine());
int b=Convert.ToInt32(Console.ReadLine());
int c=Convert.ToInt32(Console.ReadLine());
int d=Convert.ToInt32(Console.ReadLine());

int res=Minimum(a,b,c,d);
System.Console.WriteLine($"Minimum : {res}");   */


//Task9

/*
int MinV(int v1 , int v2)
{
    int minim=v1;
    if (v2 < minim)
    {
        minim=v2;
    }
    return minim;
}

System.Console.WriteLine("Vvedite 2 znacheiya : ");
int a=Convert.ToInt32(Console.ReadLine());
int b=Convert.ToInt32(Console.ReadLine());
int res=MinV(a,b);
System.Console.WriteLine($"Minimalniy : {res}");   */


//Task10

/*
int MaxV(int v1 , int v2)
{
    int maxim=v1;
    if (v2 > maxim)
    {
        maxim=v2;
    }
    return maxim;
}

System.Console.WriteLine("Vvedite 2 znacheiya : ");
int a=Convert.ToInt32(Console.ReadLine());
int b=Convert.ToInt32(Console.ReadLine());
int res=MaxV(a,b);
System.Console.WriteLine($"Minimalniy : {res}");   */

