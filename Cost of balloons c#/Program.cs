using System;

class Program
{
    static void Main()
    {
        int t = int.Parse(Console.ReadLine());  // عدد حالات الاختبار

        while (t-- > 0)
        {
            // قراءة تكلفة البالونات الخضراء والبنفسجية
            string[] costs = Console.ReadLine().Split();
            int greenCost = int.Parse(costs[0]);
            int purpleCost = int.Parse(costs[1]);

            // قراءة عدد المشاركين
            int n = int.Parse(Console.ReadLine());

            int firstScenarioCost = 0, secondScenarioCost = 0;

            // حساب تكلفة السيناريوهات
            for (int i = 0; i < n; i++)
            {
                string[] status = Console.ReadLine().Split();
                int problem1 = int.Parse(status[0]);
                int problem2 = int.Parse(status[1]);

                // السيناريو الأول: المشكلة الأولى (بالون أخضر) والثانية (بالون بنفسجي)
                firstScenarioCost += problem1 * greenCost + problem2 * purpleCost;

                // السيناريو الثاني: المشكلة الأولى (بالون بنفسجي) والثانية (بالون أخضر)
                secondScenarioCost += problem1 * purpleCost + problem2 * greenCost;
            }

            // طباعة أقل تكلفة
            Console.WriteLine(Math.Min(firstScenarioCost, secondScenarioCost));
        }
    }
}

