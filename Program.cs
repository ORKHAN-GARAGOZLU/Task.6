namespace Task._6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Task 1

            /* a massivinin(a[0], a[1] ....a[n])  | a[i] | < c sertini odeyen elementlerini cap etmek
            (c deyisheninin qiymeti istifadeciden sorushulur, hemcinin a massivinin elementleri de) */

            //l1:
            //    Console.Write("Massivin elementleri ile muqayise olunacaq C: ");

            //    double c;
            //    if (!double.TryParse(Console.ReadLine(), out c))
            //    {
            //        Console.WriteLine("Eded daxil edilmeyib");
            //        goto l1;
            //    }
            //l2:
            //    Console.Write("Massivin uzunlugu: ");
            //    int n;
            //    if (!int.TryParse(Console.ReadLine(), out n) || n <= 0)
            //    {
            //        Console.WriteLine("Eded daxil edilmeyib");
            //        goto l2;
            //    }

            //    double[] a = new double[n];


            //    for (int i = 0; i < a.Length; i++)
            //    {
            //    l3:
            //        Console.Write($"[{i + 1}]=");
            //        if (!double.TryParse(Console.ReadLine(), out a[i]))
            //        {
            //            Console.WriteLine("Eded daxil edilmeyib");
            //            goto l3;
            //        }
            //    }

            //    for (int i = 0; i < a.Length; i++)
            //    {
            //        if (a[i] < c)
            //        {
            //            Console.WriteLine($"{c} > {a[i]}");
            //        }
            //        else if (a[i] == c)
            //        {
            //            Console.WriteLine($"{c} = {a[i]}");
            //        }
            //        else
            //        {
            //            Console.WriteLine($"{c} < {a[i]}");
            //        }

            //    }

            #endregion

            #region Task 2

            /* a massivinin(a[0], a[1] ....a[n])  | a[i] | < c sertini odeyen elementlerinin ededi ortasini tapmaq */

            //l1:
            //    Console.Write("Massivin elementleri ile muqayise olunacaq C: ");

            //    double c;
            //    if (!double.TryParse(Console.ReadLine(), out c))
            //    {
            //        Console.WriteLine("Eded daxil edilmeyib");
            //        goto l1;
            //    }
            //l2:
            //    Console.Write("Massivin uzunlugu: ");
            //    int n;
            //    if (!int.TryParse(Console.ReadLine(), out n) || n <= 0)
            //    {
            //        Console.WriteLine("Eded daxil edilmeyib");
            //        goto l2;
            //    }

            //    double[] a = new double[n];


            //    for (int i = 0; i < a.Length; i++)
            //    {
            //    l3:
            //        Console.Write($"[{i + 1}]=");
            //        if (!double.TryParse(Console.ReadLine(), out a[i]))
            //        {
            //            Console.WriteLine("Eded daxil edilmeyib");
            //            goto l3;
            //        }
            //    }
            //    double edediOrta = 0;
            //    double sum = 0;
            //    double count = 0;
            //    for (int i = 0; i < a.Length; i++)
            //    {
            //        if (a[i] < c)
            //        {
            //            Console.WriteLine($"{c} > {a[i]}");
            //            sum += a[i];
            //            count++;
            //            edediOrta = sum / count;

            //        }
            //        else if (a[i] == c)
            //        {
            //            Console.WriteLine($"{c} = {a[i]}");
            //        }
            //        else
            //        {
            //            Console.WriteLine($"{c} < {a[i]}");
            //        }

            //    }
            //    Console.WriteLine($"Reqemlerin cemi: {sum}");
            //    Console.WriteLine($"Ededi orta : {edediOrta}");


            #endregion

            #region Task 3
            /* a massivinin(a[0], a[1] ....a[n])  | a[i] | > c sertini odeyen elementlerinin hendesi ortasini tapmaq */

            //l1:
            //    Console.Write("Massivin elementleri ile muqayise olunacaq C: ");

            //    double c;
            //    if (!double.TryParse(Console.ReadLine(), out c))
            //    {
            //        Console.WriteLine("Eded daxil edilmeyib");
            //        goto l1;
            //    }
            //l2:
            //    Console.Write("Massivin uzunlugu: ");
            //    int n;
            //    if (!int.TryParse(Console.ReadLine(), out n) || n <= 0)
            //    {
            //        Console.WriteLine("Eded daxil edilmeyib");
            //        goto l2;
            //    }

            //    double[] a = new double[n];


            //    for (int i = 0; i < a.Length; i++)
            //    {
            //    l3:
            //        Console.Write($"[{i + 1}]=");
            //        if (!double.TryParse(Console.ReadLine(), out a[i]))
            //        {
            //            Console.WriteLine("Eded daxil edilmeyib");
            //            goto l3;
            //        }
            //    }
            //    double hendesiOrta = 0;
            //    double sum = 1;
            //    double count = 0;
            //    for (int i = 0; i < a.Length; i++)
            //    {
            //        if (a[i] > c)
            //        {
            //            Console.WriteLine($"{c} < {a[i]}");
            //            sum *= a[i];
            //            count++;
            //            hendesiOrta = Math.Pow(sum, 1 / count);
            //        }
            //        else if (a[i] == c)
            //        {
            //            Console.WriteLine($"{c} = {a[i]}");
            //        }
            //        else
            //        {
            //            Console.WriteLine($"{c} > {a[i]}");

            //        }

            //    }
            //    Console.WriteLine($"Reqemlerin hasili: {sum}");
            //    Console.WriteLine($"Hendesi orta : {hendesiOrta}");
            #endregion

            #region Task 4
            /* a massivinin(a[0], a[1] ....a[n])  | a[i] | > c sertini odeyen elementlerini coxdan aza dogru siralamaq */

            //l1:
            //    Console.Write("Massivin elementleri ile muqayise olunacaq C: ");

            //    double c;
            //    if (!double.TryParse(Console.ReadLine(), out c))
            //    {
            //        Console.WriteLine("Eded daxil edilmeyib");
            //        goto l1;
            //    }
            //l2:
            //    Console.Write("Massivin uzunlugu: ");
            //    int n;
            //    if (!int.TryParse(Console.ReadLine(), out n) || n <= 0)
            //    {
            //        Console.WriteLine("Eded daxil edilmeyib");
            //        goto l2;
            //    }

            //    double[] a = new double[n];


            //    for (int i = 0; i < a.Length; i++)
            //    {
            //    l3:
            //        Console.Write($"[{i + 1}]=");
            //        if (!double.TryParse(Console.ReadLine(), out a[i]))
            //        {
            //            Console.WriteLine("Eded daxil edilmeyib");
            //            goto l3;
            //        }
            //    }

            //    Array.Sort(a);
            //    Array.Reverse(a);

            //    for (int i = 0; i < a.Length; i++)
            //    {
            //        if (a[i] > c)
            //        {
            //            Console.WriteLine($"{c} < {a[i]}");
            //            ;
            //        }
            //        else if (a[i] == c)
            //        {
            //            Console.WriteLine($"{c} = {a[i]}");
            //        }
            //        else
            //        {
            //            Console.WriteLine($"{c} > {a[i]}");

            //        }

            //    }


            #endregion

            #region Task 5
            /* a massivinin(a[0], a[1] ....a[n])  | a[i] | < c sertini odeyen elementler icinden maximum elementi tapmaq */

            //l1:
            //    Console.Write("Massivin elementleri ile muqayise olunacaq C: ");

            //    int c;
            //    if (!int.TryParse(Console.ReadLine(), out c))
            //    {
            //        Console.WriteLine("Eded daxil edilmeyib");
            //        goto l1;
            //    }
            //l2:
            //    Console.Write("Massivin uzunlugu: ");
            //    int n;
            //    if (!int.TryParse(Console.ReadLine(), out n) || n <= 0)
            //    {
            //        Console.WriteLine("Eded daxil edilmeyib");
            //        goto l2;
            //    }

            //    int[] a = new int[n];


            //    for (int i = 0; i < a.Length; i++)
            //    {
            //    l3:
            //        Console.Write($"[{i + 1}]=");
            //        if (!int.TryParse(Console.ReadLine(), out a[i]))
            //        {
            //            Console.WriteLine("Eded daxil edilmeyib");
            //            goto l3;
            //        }
            //    }
            //    int max = int.MinValue;
            //    for (int i = 0; i < a.Length; i++)
            //    {
            //        if (a[i] < c)
            //        {
            //            Console.WriteLine($"{c} > {a[i]}");
            //            if (max < a[i])
            //                max = a[i];


            //        }
            //        else if (a[i] == c)
            //        {
            //            Console.WriteLine($"{c} = {a[i]}");
            //        }
            //        else
            //        {
            //            Console.WriteLine($"{c} < {a[i]}");

            //        }

            //    }
            //    Console.WriteLine($"c den kicik maximum element {max}");

            #endregion

            #region Task 6
            /* X(n) ve Y(n) deye 2 massiv verilmishdir/ Ele x[i] elementi tapmaq lazimdir ki 
            x[i] = y[i] ^ 2(eyni indexdeki x elementi hemin indexdeki y elementin kvadratina beraber olsun) */

            //l1:
            //    Console.Write("X Massivin uzunlugu: ");
            //    int n;
            //    if (!int.TryParse(Console.ReadLine(), out n) || n <= 0)
            //    {
            //        Console.WriteLine("Eded daxil edilmeyib");
            //        goto l1;
            //    }

            //    int[] x = new int[n];


            //    for (int i = 0; i < x.Length; i++)
            //    {
            //    l2:
            //        Console.Write($"[{i + 1}]=");
            //        if (!int.TryParse(Console.ReadLine(), out x[i]))
            //        {
            //            Console.WriteLine("Eded daxil edilmeyib");
            //            goto l2;
            //        }

            //    }

            //l3:
            //    Console.Write("Y Massivin uzunlugu: ");
            //    int n1;
            //    if (!int.TryParse(Console.ReadLine(), out n1) || n <= 0)
            //    {
            //        Console.WriteLine("Eded daxil edilmeyib");
            //        goto l3;
            //    }

            //    int[] y = new int[n1];


            //    for (int i = 0; i < y.Length; i++)
            //    {
            //    l4:
            //        Console.Write($"[{i + 1}]=");
            //        if (!int.TryParse(Console.ReadLine(), out y[i]))
            //        {
            //            Console.WriteLine("Eded daxil edilmeyib");
            //            goto l4;
            //        }

            //    }
            //    for (int i = 0; i < x.Length && i < y.Length; i++)
            //    {
            //        if (Math.Pow(y[i], 2) == x[i])
            //        {
            //            Console.WriteLine($"X[{i}] ({x[i]}) - Y[{i}]'nin ({y[i]}) kvadratına beraberdir.");

            //        }

            //    }



            #endregion

            #region Task 7
            /* a massivinin(a[0], a[1] ....a[n]) en kicik ve en boyuk elementlerinin hendesi ve ededi ortasini tapmali */

            //l1:
            //    Console.Write("Massivin uzunlugu: ");
            //    int n;
            //    if (!int.TryParse(Console.ReadLine(), out n) || n <= 0)
            //    {
            //        Console.WriteLine("Eded daxil edilmeyib");
            //        goto l1;
            //    }

            //    double[] a = new double[n];

            //    for (int i = 0; i < a.Length; i++)
            //    {
            //    l2:
            //        Console.Write($"[{i + 1}]=");
            //        if (!double.TryParse(Console.ReadLine(), out a[i]))
            //        {
            //            Console.WriteLine("Eded daxil edilmeyib");
            //            goto l2;
            //        }
            //    }
            //    double max = a[0];
            //    double min = a[0];
            //    for (int i = 0; i < a.Length; i++)
            //    {
            //        if (max < a[i])
            //            max = a[i];
            //        if (min > a[i])
            //            min = a[i];
            //        Console.WriteLine(a[i]);
            //    }
            //    Console.WriteLine($"Massivin max elementi: {max}");
            //    Console.WriteLine($"Massivin min elementi: {min}");
            //    double edediOrta = (min + max) / 2;
            //    Console.WriteLine($"Edediorta: {edediOrta}");
            //    double hendesiOrta = ((min * max) * 0.5);
            //    Console.WriteLine($"Hendesiorta: {hendesiOrta}");

            #endregion

            #region Task 8
            /* Heriri 14 elementli 2 massivin uygun elementlerini bir birine vurub
            alinan musbet hasillerden yeni massiv duzeltmeli */


            //Console.WriteLine("X massivi");

            //double[] x = new double[5];

            //for (int i = 0; i < x.Length; i++)
            //{
            //l2:
            //    Console.Write($"[{i + 1}]=");
            //    if (!double.TryParse(Console.ReadLine(), out x[i]))
            //    {
            //        Console.WriteLine("Eded daxil edilmeyib");
            //        goto l2;
            //    }

            //}

            //Console.WriteLine("Y massivi");

            //double[] y = new double[5];

            //for (int i = 0; i < y.Length; i++)
            //{
            //l4:
            //    Console.Write($"[{i + 1}]=");
            //    if (!double.TryParse(Console.ReadLine(), out y[i]))
            //    {
            //        Console.WriteLine("Eded daxil edilmeyib");
            //        goto l4;
            //    }

            //}
            //double[] yeni = new double[0];
            //int say = 0;
            //for (int i = 0; i < x.Length; i++)
            //{
            //    for (int j = 0; j < y.Length; j++)
            //    {
            //        if (x[i] == y[j] && x[i] > 0 && y[i] > 0)
            //        {
            //            double len = x[i] * x[i];
            //            Array.Resize(ref yeni, say + 1);
            //            yeni[say] = len;
            //            say++;
            //        }
            //    }
            //}

            //Console.WriteLine("Yeni massiv:");
            //for (int i = 0; i < yeni.Length; i++)
            //{
            //    Console.WriteLine(yeni[i]);
            //}


            #endregion

            #region Task 9
            /* 25 elementli massivin ilk 8 elementini kvadrata yukseltmeli,qalanini ise 4 - e bolub
            yeni iki massiv duzeltmeli */

            //Console.WriteLine("25 elementli massiv");

            //double[] x = new double[25];

            //for (int i = 0; i < x.Length; i++)
            //{
            //l2:
            //    Console.Write($"[{i + 1}]=");
            //    if (!double.TryParse(Console.ReadLine(), out x[i]))
            //    {
            //        Console.WriteLine("Eded daxil edilmeyib");
            //        goto l2;
            //    }
            //}

            //double[] y = new double[8];
            //double[] z = new double[17];

            //for (int i = 0; i < x.Length; i++)
            //{
            //    if (i < 8)
            //    {
            //        y[i] = x[i] * x[i];
            //    }
            //    else
            //    {
            //        z[i - 8] = x[i] / 4;
            //    }
            //}

            //Console.WriteLine("Ilk 8 in kvadratinin elementleri:");
            //for (int i = 0; i < y.Length; i++)
            //{
            //    Console.Write($"{y[i]} ");
            //}

            //Console.WriteLine("Diger 4-e bolunmus elementler:");
            //for (int i = 0; i < z.Length; i++)
            //{
            //    Console.Write($"{z[i]}  ");
            //}
            #endregion

            #region Task 10
            /* X(n) massivinden ancaq menfi elementlerin maximum elementi tapin */

            //l1:
            //    Console.Write("Massivin uzunlugu: ");
            //    int n;
            //    if (!int.TryParse(Console.ReadLine(), out n) || n <= 0)
            //    {
            //        Console.WriteLine("Uygun eded daxil edilmeyib");
            //        goto l1;
            //    }

            //    int[] a = new int[n];


            //    for (int i = 0; i < a.Length; i++)
            //    {
            //    l2:
            //        Console.Write($"[{i + 1}]=");
            //        if (!int.TryParse(Console.ReadLine(), out a[i]))
            //        {
            //            Console.WriteLine("Eded daxil edilmeyib");
            //            goto l2;
            //        }
            //    }
            //    int max = int.MinValue;
            //    foreach (int item in a)
            //    {
            //        if (item < 0)
            //        {
            //            if (max < item)
            //                max = item;



            //        }
            //    }
            //    Console.WriteLine($"Maximum menfi element: {max}");

            #endregion

            #region Task 11
            /* X(n) massivinin elementlerini random olaraq 0 - 100 arasi ededlerle doldurub,
            sonra ise azalma sirasina gore duzmeli */

            //l1:
            //    Console.Write("Massivin uzunlugu: ");
            //    int n;
            //    if (!int.TryParse(Console.ReadLine(), out n) || n <= 0)
            //    {
            //        Console.WriteLine("Eded daxil edilmeyib");
            //        goto l1;
            //    }


            //    int Min = 0;
            //    int Max = 100;

            //    int[] x = new int[n];

            //    Random randNum = new Random();

            //    for (int i = 0; i < x.Length; i++)
            //    {

            //        x[i] = randNum.Next(Min, Max);

            //    }
            //    Array.Sort(x);
            //    Array.Reverse(x);
            //    foreach (int i in x)
            //    {
            //        Console.WriteLine(i);
            //    }


            #endregion

            #region Task 12
            /* X(20) massivinin ilk yarisinin ededi ortasini ikinci yarisinin hendesi ortasini tapmaq */

            //l2:
            //    Console.WriteLine("Massivin uzunlugu: ");

            //    double[] x = new double[20];

            //    for (int i = 0; i < x.Length; i++)
            //    {
            //    l3:
            //        Console.Write($"[{i + 1}]=");
            //        if (!double.TryParse(Console.ReadLine(), out x[i]))
            //        {
            //            Console.WriteLine("Eded daxil edilmeyib");
            //            goto l3;
            //        }
            //    }
            //    double sum = 0;
            //    double sum2 = 1;
            //    double divide = x.Length / 2;
            //    double count = 0;
            //    double count2 = 0;

            //    for (int i = 0; i < divide; i++)
            //    {
            //        sum += x[i];
            //        count++;
            //    }

            //    for (int i = (int)divide; i < x.Length; i++)
            //    {
            //        sum2 *= x[i];
            //        count2++;
            //    }

            //    double edediOrta = (double)sum / count;
            //    double hendesiOrta = Math.Pow(sum2, 1.0 / count2);

            //    Console.WriteLine($"Ilk yarinin ededi ortasi: {edediOrta}");
            //    Console.WriteLine($"Ikinci yarinin hendesi ortasi: {hendesiOrta}");


            #endregion


        }

    }
}