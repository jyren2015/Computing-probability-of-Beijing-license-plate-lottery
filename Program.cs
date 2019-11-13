using System;
using System.Collections.Generic;
using System.Threading;

namespace c_test
{
    class Program
    {
        public class Computing{
            private int TotalNumber;
            private int QuotaNumber;
            private int[] myNumber;
            private int baseline;
            public int LukyNumber = 0;

            public Computing(int TotalNumber, int QuotaNumber, int[] myNumber){
                this.TotalNumber = TotalNumber;
                this.QuotaNumber = QuotaNumber;
                this.myNumber = myNumber;
            }

            public void setBaseline(int baseline){
                this.baseline = baseline;
            }

            public void Thread1() {
                Console.WriteLine("Thread1 Starts");

                Predicate<int> match = null;
                int Seed;
                int num2 = 0;
                int pickNumber;
                int TotalNumber = this.TotalNumber;
                int QuotaNumber = this.QuotaNumber;
                int[] myNumber = this.myNumber;
                int count = 0;
                int begin = this.baseline + 0;
                int end = this.baseline + 20000;
                for(Seed = begin; Seed <end; Seed ++)
                {
                    Random random = new Random(Seed);
                    int num = (Convert.ToInt64((int) (TotalNumber * 10)) >= 0x100000000L) ? TotalNumber : (TotalNumber * 10);
                    List<int> list = new List<int>();
                    while (num2 < num)
                    {
                        pickNumber = random.Next(TotalNumber);
                        if (match == null)
                        {
                            match = p => p == pickNumber;
                        }
                        if (!list.Exists(match))
                        {
                            list.Add(pickNumber + 1);
                        }
                        if (list.Count == QuotaNumber)
                        {
                            for(int i = 0; i < myNumber.Length; i++)
                            {
                                if (list.Contains(myNumber[i]))
                                {
                                    Console.WriteLine("中签啦！中签种子为：{0}", Seed);
                                    count = count + 1;
                                }
                            }
                            break;
                        }
                        num2++;
                    }
                }
                Console.WriteLine("Thread1 Over, 从{0}到{1}共{2}个号码", begin, end, count);
                this.LukyNumber = this.LukyNumber + count;
            }

            public void Thread2() {
                Console.WriteLine("Thread2 Starts");

                Predicate<int> match = null;
                int Seed;
                int num2 = 0;
                int pickNumber;
                int TotalNumber = this.TotalNumber;
                int QuotaNumber = this.QuotaNumber;
                int[] myNumber = this.myNumber;
                int count = 0;
                int begin = this.baseline + 20000;
                int end = this.baseline + 40000;
                for(Seed = begin; Seed <end; Seed ++)
                {
                    Random random = new Random(Seed);
                    int num = (Convert.ToInt64((int) (TotalNumber * 10)) >= 0x100000000L) ? TotalNumber : (TotalNumber * 10);
                    List<int> list = new List<int>();
                    while (num2 < num)
                    {
                        pickNumber = random.Next(TotalNumber);
                        if (match == null)
                        {
                            match = p => p == pickNumber;
                        }
                        if (!list.Exists(match))
                        {
                            list.Add(pickNumber + 1);
                        }
                        if (list.Count == QuotaNumber)
                        {
                            for(int i = 0; i < myNumber.Length; i++)
                            {
                                if (list.Contains(myNumber[i]))
                                {
                                    Console.WriteLine("中签啦！中签种子为：{0}", Seed);
                                    count = count + 1;
                                }
                            }
                            break;
                        }
                        num2++;
                    }
                }
                Console.WriteLine("Thread2 Over, 从{0}到{1}共{2}个号码", begin, end, count);
                this.LukyNumber = this.LukyNumber + count;
            }

            public void Thread3() {
                Console.WriteLine("Thread3 Starts");

                Predicate<int> match = null;
                int Seed;
                int num2 = 0;
                int pickNumber;
                int TotalNumber = this.TotalNumber;
                int QuotaNumber = this.QuotaNumber;
                int[] myNumber = this.myNumber;
                int count = 0;
                int begin = this.baseline + 40000;
                int end = this.baseline + 60000;
                for(Seed = begin; Seed <end; Seed ++)
                {
                    Random random = new Random(Seed);
                    int num = (Convert.ToInt64((int) (TotalNumber * 10)) >= 0x100000000L) ? TotalNumber : (TotalNumber * 10);
                    List<int> list = new List<int>();
                    while (num2 < num)
                    {
                        pickNumber = random.Next(TotalNumber);
                        if (match == null)
                        {
                            match = p => p == pickNumber;
                        }
                        if (!list.Exists(match))
                        {
                            list.Add(pickNumber + 1);
                        }
                        if (list.Count == QuotaNumber)
                        {
                            for(int i = 0; i < myNumber.Length; i++)
                            {
                                if (list.Contains(myNumber[i]))
                                {
                                    Console.WriteLine("中签啦！中签种子为：{0}", Seed);
                                    count = count + 1;
                                }
                            }
                            break;
                        }
                        num2++;
                    }
                }
                Console.WriteLine("Thread3 Over, 从{0}到{1}共{2}个号码", begin, end, count);
                this.LukyNumber = this.LukyNumber + count;
            }

            public void Thread4() {
                Console.WriteLine("Thread4 Starts");

                Predicate<int> match = null;
                int Seed;
                int num2 = 0;
                int pickNumber;
                int TotalNumber = this.TotalNumber;
                int QuotaNumber = this.QuotaNumber;
                int[] myNumber = this.myNumber;
                int count = 0;
                int begin = this.baseline + 60000;
                int end = this.baseline + 80000;
                for(Seed = begin; Seed <end; Seed ++)
                {
                    Random random = new Random(Seed);
                    int num = (Convert.ToInt64((int) (TotalNumber * 10)) >= 0x100000000L) ? TotalNumber : (TotalNumber * 10);
                    List<int> list = new List<int>();
                    while (num2 < num)
                    {
                        pickNumber = random.Next(TotalNumber);
                        if (match == null)
                        {
                            match = p => p == pickNumber;
                        }
                        if (!list.Exists(match))
                        {
                            list.Add(pickNumber + 1);
                        }
                        if (list.Count == QuotaNumber)
                        {
                            for(int i = 0; i < myNumber.Length; i++)
                            {
                                if (list.Contains(myNumber[i]))
                                {
                                    Console.WriteLine("中签啦！中签种子为：{0}", Seed);
                                    count = count + 1;
                                }
                            }
                            break;
                        }
                        num2++;
                    }
                }
                Console.WriteLine("Thread4 Over, 从{0}到{1}共{2}个号码", begin, end, count);
                this.LukyNumber = this.LukyNumber + count;
            }

            public void Thread5() {
                Console.WriteLine("Thread5 Starts");

                Predicate<int> match = null;
                int Seed;
                int num2 = 0;
                int pickNumber;
                int TotalNumber = this.TotalNumber;
                int QuotaNumber = this.QuotaNumber;
                int[] myNumber = this.myNumber;
                int count = 0;
                int begin = this.baseline + 80000;
                int end = this.baseline + 100000;
                for(Seed = begin; Seed <end; Seed ++)
                {
                    Random random = new Random(Seed);
                    int num = (Convert.ToInt64((int) (TotalNumber * 10)) >= 0x100000000L) ? TotalNumber : (TotalNumber * 10);
                    List<int> list = new List<int>();
                    while (num2 < num)
                    {
                        pickNumber = random.Next(TotalNumber);
                        if (match == null)
                        {
                            match = p => p == pickNumber;
                        }
                        if (!list.Exists(match))
                        {
                            list.Add(pickNumber + 1);
                        }
                        if (list.Count == QuotaNumber)
                        {
                            for(int i = 0; i < myNumber.Length; i++)
                            {
                                if (list.Contains(myNumber[i]))
                                {
                                    Console.WriteLine("中签啦！中签种子为：{0}", Seed);
                                    count = count + 1;
                                }
                            }
                            break;
                        }
                        num2++;
                    }
                }
                Console.WriteLine("Thread5 Over, 从{0}到{1}共{2}个号码", begin, end, count);
                this.LukyNumber = this.LukyNumber + count;
            }
        }

        static void Main(string[] args)
        {
            int TotalNumber = 17099033;//the totalNumber of the serial number,for example:17099033
            int QuotaNumber = 6383;//the totalNumber of quota
            int[] myNumber = {000000, 111111, 222222};//your codes which you find via the FindCode.py
            Computing computing = new Computing(TotalNumber, QuotaNumber, myNumber);

            for(int i = 0;i < 10;i++){
                computing.setBaseline(i*100000);
                ThreadStart thread1 = new ThreadStart(computing.Thread1);
                Thread childThread1 = new Thread(thread1);
                childThread1.Start();

                ThreadStart thread2 = new ThreadStart(computing.Thread2);
                Thread childThread2 = new Thread(thread2);
                childThread2.Start();

                ThreadStart thread3 = new ThreadStart(computing.Thread3);
                Thread childThread3 = new Thread(thread3);
                childThread3.Start();

                ThreadStart thread4 = new ThreadStart(computing.Thread4);
                Thread childThread4 = new Thread(thread4);
                childThread4.Start();

                ThreadStart thread5 = new ThreadStart(computing.Thread5);
                Thread childThread5 = new Thread(thread5);
                childThread5.Start();
                
                childThread1.Join();
                childThread2.Join();
                childThread3.Join();
                childThread4.Join();
                childThread5.Join();
            }
            Console.WriteLine("共计：{0}", computing.LukyNumber);
            Double probability = computing.LukyNumber/1000000D;
            Console.WriteLine("中签概率为：{0:F6}", probability);
        }
    }
}
