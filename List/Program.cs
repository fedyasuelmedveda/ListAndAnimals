namespace List
{
    internal class Program
    {
        static void Main(string[] args)
        {
            CustomList<string> arrayOfStrings= new CustomList<string>(2);
            arrayOfStrings.AddElement("This is the house that jack built.");
            Console.WriteLine(arrayOfStrings.GetSize());
            arrayOfStrings.AddElement("And this is the corn,");
            Console.WriteLine(arrayOfStrings.GetSize());
            arrayOfStrings.AddElement("that lay in the house,");
            Console.WriteLine(arrayOfStrings.GetSize());
            CustomList<int> arrayOfInts= new CustomList<int>(2);
            for (int i = 11; i < 33; i++)
            {

                arrayOfInts.AddElement(i);
                Console.WriteLine($"Added element: {i}");
                Console.WriteLine($"Number of elements: {arrayOfInts.GetNumberOfElements()}");
                Console.WriteLine($"Size of array: {arrayOfInts.GetSize()}");
            }
            for(int i = 5; i < 15; i++)
            {
                arrayOfInts.DeleteElementByIndex(i);
            }
            for(int i = 0; i < arrayOfInts.GetNumberOfElements(); i++)
            {
                Console.WriteLine($"Element with index {i}: {arrayOfInts[i]}");
                Console.WriteLine($"Number of elements: {arrayOfInts.GetNumberOfElements()}");
                Console.WriteLine($"Size of array: {arrayOfInts.GetSize()}");
            }
            for(int i = 25; i < 33; i++)
            {
                arrayOfInts.FindAndDeleteElement(i);
            }
            for (int i = 0; i < arrayOfInts.GetNumberOfElements(); i++)
            {
                Console.WriteLine($"Element with index {i}: {arrayOfInts[i]}");
                Console.WriteLine($"Number of elements: {arrayOfInts.GetNumberOfElements()}");
                Console.WriteLine($"Size of array: {arrayOfInts.GetSize()}");
            }
            Console.WriteLine("The end.");
        }
    }
}