struct Help
{    
      static public int ZotD (string text)
   {
        int d;
        bool flag;
        do
        {
            Console.Write(text);
            flag = int.TryParse(Console.ReadLine(), out d);
        }
        while (!flag);
        return d;
   }
}