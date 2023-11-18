


////RunsALot();

////Console.ReadLine();

////static void RunsALot()
////{
////    long total = 0;
////    int test = 0;

////    for (int i = -1000; i < 1000; i++)
////    {
////        total += i;
////        try
////        {
////            test = 5 / i;
////        }
////        catch
////        {
////            Console.WriteLine("There was an exception.");
////        }
////    }

////    Console.WriteLine($"The total is { total }");
//}


for (int i = 1; i < 101; i++)
{
    Console.WriteLine(i);

    if (i == 73)
    {
        throw new Exception();
    }
}

Console.ReadLine();