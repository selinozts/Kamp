namespace GenericsIntro
{
    internal class MyList<T>
    {
        private T[] items;

        //constructor- bir class "new" dediğinde çalışan metot
        public MyList()
        {
            items = new T[0];
        }

        public void Add(T item)
        {
            //geçici dizi
            T[] tempArray = items;
            items = new T[items.Length + 1];
            for (int i = 0; i < tempArray.Length; i++)
            {
                items[i] = tempArray[i];
            }

            items[items.Length - 1] = item;
        }

        public int Count
        {
            get { return items.Length; }
        }

        // public int Count2 => items.Length;
    }
}
