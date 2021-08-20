using System;

namespace ConsoleAppExample001
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            /*
             در اين فايل تمرين هاي فصل دوم کتاب
            » آموزش کاربردي زبان برنامه نويسي C# «
            که مربوط به ConsoleApp ها مي باشند را حل مي کنيم. اين تمرين ها شامل موارد زير مي باشد:
            1- برنامه اي بنويسيد که طول و عرض مستطيلي را از صفحه کليد خوانده و مساحت و محيط آن را محاسبه و در خروجي با پيام هاي مناسبي نمايش دهد.
            2- برنامه اي بنويسيد که سه عدد صحيح را از صفحه کليد خوانده و ميانگين آن ها را در خروجي نمايش دهد.
            3- برنامه اي بنويسيد که قيمت يک کالا را از صفحه کليد خوانده و قيمت نهايي آن را با احتساب 15 درصد تخفيف محاسبه و در خروجي نمايش دهد.
            4- قطعه برنامه اي بنويسيد که يک عدد دورقمي صحيح را از صفحه کليد خوانده و مقلوب (وارون) آن را در خروجي نمايش دهد.
            5- با استفاده از عملگر :؟ قطعه برنامه اي بنويسيد که يک عدد صحيح از صفحه کليد خوانده و زوج يا فرد بودن آن را تشخيص
            و با پيغام مناسبي در خروجي نمايش دهد.
             */

            string MainMsg = @"
Dar in barname mikhahim tamrinhaye zir ra anjam dahim. baraye entekhab harkodam , lotfan shomare an ra vared namaeed:
1- Barnamei benevisid ke tool va arz mostatili ra az safhe kelid khande va masahat va mohit an ra hesab namayad va dar khoroji ba peygham haye monaseb namayesh dahad.
2- Barnamei benevisid ke 3 addad sahih ra az safhe kelid khande va miangin anha ra dar  khoroji namayesh dahad.
3- Barnamei benevisid ke gheymat yek kala ra az safhe kelid khande va gheymat nahaee an ra ba ehtesabe 15 darsad takhfif mohasebe va dar khoroji namayesh dahad.
4- Barnamei benevisid ke yek adad 2 raghami sahih ra az safhe kelid khande va mahjlob (varoon) an ra dar khoroji namayesh dahad.
5- Barnamei benevisid ke yek adad sahih az safhe kelid khande va zooj ya fard boodan an ra ba komak amalgar :? tashkhis dahad va ba peygham monaseb dar khoroji namayesh dahad.";
            Console.WriteLine(MainMsg);

            Console.WriteLine("Lotfan adad tamrin marboote ra vared namaeed:");
            int n;
            if (Int32.TryParse(Console.ReadLine(), out n) == false)
            {
                Console.WriteLine("Lotfan shomare tamrin ra be soorat adad sahih vared namaeed...");
            }

            switch (n)
            {
                case 1:
                    Exercise1();
                    break;

                case 2:
                    Exercise2();
                    break;

                case 3:
                    Exercise3();
                    break;

                case 4:
                    Exercise4();
                    break;

                case 5:
                    Exercise5();
                    break;

                default:
                    Console.WriteLine("Lotfan shomare tamrin ra be dorosti vared namaeed...");
                    break;
            }

            static void Exercise1()
            {
                StartPlan("Exercise1");
                Console.WriteLine("Dar in barname ba vared kardan tool va arz meghdar masahat va mohit mostatil ra hesab mikonim.");
                int Tool, Arz;
                Console.Write("Tool: ");
                //از این دستور برای تبدیل ورودی به عدد صحیح و همچنین کنترل نوع آن استفااده می کنیم
                if (Int32.TryParse(Console.ReadLine(), out Tool) == false)
                {
                    Console.WriteLine("Lotfan meghdar tool ra be sorat adad sahih vared namaeed...");
                };

                Console.Write("Arz: ");
                if (Int32.TryParse(Console.ReadLine(), out Arz) == false)
                {
                    Console.WriteLine("Lotfan meghdar arz ra be sorat adad sahih vared namaeed...");
                };

                int Perimeter, Area;

                Area = Tool * Arz;
                Perimeter = (Tool + Arz) * 2;

                string PrintMsg = "\n\n\n\nTool: " + Tool.ToString() + "\nArz: " + Arz.ToString() +
                    "\nMohit: " + Perimeter.ToString() + "\nMasahat: " + Area.ToString();
                Console.WriteLine(PrintMsg);
                ExitPlan();
            }

            static void Exercise2()
            {
                StartPlan("Exercise2");

                Console.WriteLine("Lotfan 3 adad sahih vared namaeed ta miangin anha ra hesab konim.");

                int a, b, c;

                Console.Write("Adad aval: ");
                a = Convert.ToInt32(Console.ReadLine());

                Console.Write("Adad dovom: ");
                b = Convert.ToInt32(Console.ReadLine());

                Console.Write("Adad sevom: ");
                c = Convert.ToInt32(Console.ReadLine());

                string PrintMsg = "\n\n\nAdad aval: " + a.ToString() +
                    "\nAdad dovom: " + b.ToString() +
                    "\nAdad sevom: " + c.ToString() +
                    "\n\nMiangin: " + ((a + b + c) / 3).ToString();
                Console.WriteLine(PrintMsg);

                ExitPlan();
            }

            static void Exercise3()
            {
                StartPlan("Exercise3");

                Console.WriteLine("Gheymat yek kala ra vared namaeed ta gheymat an ra ba 15 darsad takhfif moshahede namaeed.\n\n");
                Console.Write("Gheymat Kala: ");
                int Gheymat = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Gheymat mahsool barabar ast ba " + (Gheymat * 0.85).ToString());

                ExitPlan();
            }

            static void Exercise4()
            {
                StartPlan("Exercise4");

                Console.WriteLine("Lotfan yek adad 2 raghami vared namaeed ta maghlob an ra mohasebe va namayesh dahim.\n\n");
                Console.Write("Number: ");
                int n = Convert.ToInt32(Console.ReadLine());
                int r = ((n % 10) * 10 + n / 10);
                Console.WriteLine("Maghloob adad " + n.ToString() + " barabar ast ba " + r.ToString());

                ExitPlan();
            }

            static void Exercise5()
            {
                StartPlan("Exercise5");

                Console.WriteLine("Yek adad sahih vared namaeed ta zoj ya fard boodan an ra moshakhas namaeem.\n\n");

                Console.Write("Lotfan yek adad sahih vared namaeed: ");
                int a = Convert.ToInt32(Console.ReadLine());
                string r = (a % 2) == 0 ? "Zooj" : "Fard";
                Console.WriteLine("\n\nAdad " + a.ToString() + " yek adad " + r + " mibashad.");

                ExitPlan();
            }
            Console.ReadKey();

            //کارهای لازم برای ورود به یک تمرین را انجام می دهد و عنوان فرم را تغییر می دهد
            static void StartPlan(string FormTitle)
            {
                Console.Clear();
                Console.Title = FormTitle;
            }

            //کارهای لازم برای خروج را انجام می دهد
            static void ExitPlan()
            {
                Console.WriteLine("\n\n Press any key to terminate");
                Console.ReadLine(); // pause screen!
            }
        }
    }
}