using System;

public class Nomor1
{
    public static void Main()
    {
        Console.Write("Masukkan Nilai Input : ");
        string nilai = Console.ReadLine();
        int n1 = Convert.ToInt32(nilai);
        for (int i = 1; i <= n1; i++)
        {
            if (Odd(i))
            {
                Console.Write(i);
            }
        }
        Console.Write(System.Environment.NewLine);
        for (int j = 1; j <= n1; j++)
        {
            if (Even(j))
            {
                Console.Write(j);
            }
        }
    }
    public static bool Odd(int value)
    {
        return value % 2 != 0;
    }
    public static bool Even(int value)
    {
        return value % 2 == 0;
    }
}