using System;

namespace STOS
{

    class Stack
    {


        public int empty = 1337;
        public int[] storage = new int[10];

        public void ClearStorage()
        {
            for (int i = 0; i < 10; i++)
            {

                storage[i] = empty;

            }
        }

        private void SortStorage()
        {

            int memorya = 0;
            int memoryb = 0;
            bool sorted = true;

            while (sorted == true)
            {
                sorted = false;

                for (int i = 0; i < 10; i++)
                {



                    if (i == 9) { }
                    else if (storage[i + 1] == 0 && i != 9)
                    {
                        memorya = storage[i];
                        memoryb = storage[i + 1];
                        storage[i] = memoryb;
                        storage[i + 1] = memorya;

                        sorted = true;

                    }
                    else if (storage[i] == empty && storage[i + 1] != empty && i != 9)
                    {
                        memorya = storage[i];
                        memoryb = storage[i + 1];
                        storage[i] = memoryb;
                        storage[i + 1] = memorya;

                        sorted = true;

                    }
                    else if (storage[i] < storage[i + 1] && storage[i] != 0 && storage[i + 1] != empty)
                    {

                        memorya = storage[i];
                        memoryb = storage[i + 1];
                        storage[i] = memoryb;
                        storage[i + 1] = memorya;

                        sorted = true;


                    }

                }

            }


        }

        public void AddToStorage(int getLine)
        {
            if (storage[9] == empty)
            {
                storage[9] = getLine;

                SortStorage();

                Console.WriteLine(":)");
            }
            else
            {
                Console.WriteLine(":(");
            }
        }

        public void OutOfStorage()
        {
            int outLine;
            int i = 0;
            outLine = storage[i];
            while (outLine == empty)
            {
                if (i == 0)
                {
                    Console.WriteLine(":(");
                    break;
                }
                outLine = storage[i];

                i++;
            }

            if (outLine != empty)
            {
                Console.WriteLine(storage[i]);
                storage[i] = empty;

                SortStorage();
            }
        }


    }

    class Program
    {
        static void Main(string[] args)
        {
            Stack stack = new Stack();
            stack.ClearStorage();

            string line = "something";

            while (line != null)
            {


                 line = Console.ReadLine();

                if (Equals(line , "+"))
                {

                    string sLine = Console.ReadLine();
                    int obj = int.Parse(sLine);
                    stack.AddToStorage(obj);


                }
                else if ( Equals(line , "-"))
                {
                    stack.OutOfStorage();
                }
            }
        }
    }
}
