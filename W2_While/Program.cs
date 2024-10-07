
// Task 1
// Konsol ekranına 10 kere "Kendime inanıyorum, ben bu yazılım işini hallederim!" yazdırınız.

int i = 0;
while (i < 10)
{
    Console.WriteLine("Kendime inanıyorum, ben bu yazılım işini hallederim!");
    i++;
}

// -------------------------------------------------------------------------------------------

// Task 2
// 1 ile 20 arasındaki sayıları konsol ekranına yazdırınız.

int k = 1;
while (k <= 20)
{
    Console.WriteLine(k);
    k++;
}

// -------------------------------------------------------------------------------------------

// Task 3
// 1 ile 20 arasındaki çift sayıları konsol ekranına yazdırınız.

int j = 1;
while (j < 20)
{
    if (j % 2 == 0)
    {
        Console.WriteLine(j);
    }
    j++;
}

// -------------------------------------------------------------------------------------------

// Task 4
// 50 ile 150 arasındaki sayıların toplamını ekrana yazdırınız.

int total = 0;
int l = 50;
while (l < 150)
{
    total += l;
    l++;
}
Console.WriteLine("Total = " + total);

// -------------------------------------------------------------------------------------------

// Task 5
// 1 ile 120 arasındaki tek ve çift sayıların toplamlarını ayrı ayrı ekrana yazdırınız.

int oddTotal = 0;
int evenTotal = 0;
int t = 1;
while (t < 120)
{
    if (t % 2 == 0)
    {
        evenTotal += t;
    }
    else
    {
        oddTotal += t;
    }
    t++;
}
Console.WriteLine("Total of odd numbers: " + oddTotal);
Console.WriteLine("Total of even numbers: " + evenTotal);