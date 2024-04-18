namespace CW1804
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /* IntArrayList list = new IntArrayList();
             list.Add(1);
             list.Add(2);
             list.Add(3);
             list.Add(0);
             list.Add(0);
             list.Add(0);
             list.Add(0);


             list.GetElements();*/

            /* StringArrayList strs = new StringArrayList();
             strs.Add("a");
             strs.Add("b");
             strs.GetElements();

             ObjectArrayList obj = new ObjectArrayList(typeof(Int32));
             obj.Add(342);
             obj.Add(true);
             obj.Add("asav");
             obj.GetType();*/

            var students = new student { };
            {
                new student
                {
                    Name = "Nurlan",
                    Surname = "Abbasov"
                };
                new student
                {
                    Name = "Ali",
                    Surname = "Mirzeyev"
                };
            };

            GenericList<student> intArr = new GenericList<student>();
            intArr.GetElements();
        }
    }
    class IntArrayList
    {
        int[] _arr;


        public int Capacity { get; set; } = 5;
        public int Count { get; private set; } = 0;
        public IntArrayList()
        {
            _arr = new int[Capacity];
        }
        public IntArrayList(int capacity)
        {
            Capacity = capacity;
            _arr = new int[Capacity];
        }
        public void Add(int value)
        {
            if (_arr.Length == Count)
            {
                Array.Resize(ref _arr, Count + Capacity);
            }
            _arr[Count] = value;
            Count++;
        }
        public void GetElements()
        {
            for (int i = 0; i < Count; i++)
            {
                Console.WriteLine(_arr[i]);
            }
        }
    }
    class StringArrayList
    {
        string[] _arr;
        public int Capacity { get; set; } = 5;
        public int Count { get; private set; } = 0;
        public StringArrayList()
        {
            _arr = new string[Capacity];
        }
        public StringArrayList(int capacity)
        {
            Capacity = capacity;
            _arr = new string[Capacity];
        }
        public void Add(string value)
        {
            if (_arr.Length == Count)
            {
                Array.Resize(ref _arr, Count + Capacity);
            }
            _arr[Count] = value;
            Count++;
        }
        public void GetElements()
        {
            for (int i = 0; i < Count; i++)
            {
                Console.WriteLine(_arr[i]);
            }
        }
    }
    class ObjectArrayList
    {
        object[] _arr;


        public int Capacity { get; set; } = 5;
        public int Count { get; private set; } = 0;
        private Type _listType;
        public ObjectArrayList(Type listType)
        {
            _arr = new object[Capacity];
            _listType = listType;
        }
        public ObjectArrayList(int capacity, Type listType)
        {
            Capacity = capacity;
            _arr = new object[Capacity];
        }
        public void Add(object value)
        {

            if (value.GetType().Name == _listType.Name)
            {
                if (_arr.Length == Count)
                {
                    Array.Resize(ref _arr, Count + Capacity);
                }
                _arr[Count] = value;
                Count++;
            }

        }
        public void GetElements()
        {
            for (int i = 0; i < Count; i++)
            {
                Console.WriteLine(_arr[i]);
            }
        }
    }
    class student
    {
        public string Name { get; set; }
        public string Surname { get; set; }
        public override string ToString()
        {
            return Name + " " + Surname;
        }
    }
    class GenericList<T>
    {
        T[] _arr;


        public int Capacity { get; set; } = 5;
        public int Count { get; private set; } = 0;
        private Type _listType;
        public GenericList(int capacity)
        {
            _arr = new T[Capacity];
            Count = capacity;
        }
        public GenericList(T[] arr, int capacity = 5)
        {
            Capacity = capacity;
            _arr = arr;
            Count = arr.Length;

        }
        public void Add(T value)
        {
            if (_arr.Length == Count)
            {
                Array.Resize(ref _arr, Count + Capacity);
            }
            _arr[Count] = value;
            Count++;
        }
        public void GetElements()
        {
            for (int i = 0; i < Count; i++)
            {
                Console.WriteLine(_arr[i]);
            }
        }
    }
}
}
