namespace MY_ARRAY
{
    internal class MyArray : IMath, IOutput, ISort
    {
        private List<int> ints = new List<int>() { 1, 3, 5, 7, 9, 10, 8, 6, 4, 2 };

        // Program in which all inheritance methods execute
        public void Program()
        {
            Console.WriteLine("IMath methods:");
            Console.WriteLine($"  Average: {Avg()}");
            Console.WriteLine($"  Max: {Max()}");
            Console.WriteLine($"  Min: {Min()}");
            Console.WriteLine($"  Search value: {Search(10)}\n\n"); // For example I chose number 10

            Console.WriteLine("IOutput methods:");
            Console.WriteLine($"  Show: {IShow()}");
            Console.WriteLine($"  Show info: {IShow("Hello World")}\n");


            Console.WriteLine("ISort methods: ");
            SortAsc();
            Console.WriteLine("Array after ascending:");  PrintArray();

            SortDesc();
            Console.WriteLine("Array after descending");  PrintArray();
        }


        // IMath methods
        public float Avg()
        {
            float avg = 0;
            ints.ForEach(x => avg += x);
            avg /= ints.Count();
            return avg;
        }
        public int Max()
        {
            return ints.Max();
        }
        public int Min()
        {
            return ints.Min();
        }
        public bool Search(int valueToSearch)
        {
            if (findValue(valueToSearch)) return true;
            return false;
        }
        


        // IOutput methods
        public string IShow()
        {
            return "I haven't any information";
        }
        public string IShow(string info)
        {
            return info;
        }
        

        // ISort methods
        public void SortAsc()
        {
            ints = ints.OrderBy(x => x).ToList();
        }
        public void SortDesc()
        {
            ints = ints.OrderByDescending(x => x).ToList();
        }
        

        // Another functions        
        private void PrintArray() // Print List
        {
            Console.Write("Array: [ ");
            for (int i = 0; i < ints.Count(); i++)
            {
                Console.Write(ints[i] + " ");
            }
            Console.WriteLine("]\n");
        }
        
        private bool findValue(int value)// Function for "Search"
        {
            foreach(var num in ints)
            {
                if (num == value) return true;
            } return false;
        }
    }
}
