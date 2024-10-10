using InsertionSort;

int[] inteiros = {0, 3, 5, 4, 2, 1};

InsertionSort.InsertionSort.Print(inteiros);
InsertionSort.InsertionSort.Sort<int>(inteiros);
InsertionSort.InsertionSort.Print(inteiros);

Console.WriteLine("\nLetras");
char[] chars = { 'o', 'i', 'a', 'e', 'u'};
InsertionSort.InsertionSort.Print(chars);
InsertionSort.InsertionSort.Sort(chars);
InsertionSort.InsertionSort.Print(chars);
