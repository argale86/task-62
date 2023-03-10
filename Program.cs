//Заполнить массив спирально
Console.WriteLine("Введите кол-во элементов по горизонтали в массиве:");
int m = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите кол-во элементов по вертикали в массиве:");
int n = Convert.ToInt32(Console.ReadLine());
int [ , ] mas = new int [m,n];
int m1 = m;
int n1 = n;
int mstart = 0;
int nstart = 0;
int buf = 1;
double countmas = 0;
double number = m * n;
do
{
    int count1 = mstart;
    int count2 = nstart;
    do
    {
        mas [mstart,count2] = buf;
        count2++;
        buf++;
        countmas++;
    }
    while (count2 < n1);
    count2--;
    count1++;
    do
    {
        mas [count1,count2] = buf;
        count1++;
        buf++;
        countmas++;
    }
    while (count1 < m1);
    count1--;
    count2--;
    do
    {
        mas [count1,count2] = buf;
        count2--;
        buf++;
        countmas++;
    }
    while (count2 > (nstart - 1));
    if (countmas < number)
    {
        count2++;
        count1--;
        do
        {
            mas [count1,count2] = buf;
            count1--;
            buf++;
            countmas++;
        }
        while (count1 > mstart);
    }
    mstart++;
    nstart++;
    n1--;
    m1--;
}
while (countmas < number);
Console.WriteLine();
Console.WriteLine("Результирующий массив:");
for (int count3 = 0; count3 < m; count3++)
{
    for (int count4 = 0; count4 < n; count4++)
    {
       Console.Write(" " + mas[count3,count4] + " ");
    }
    Console.WriteLine();
}
Console.WriteLine();
