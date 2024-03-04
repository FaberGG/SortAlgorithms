using System;

class MergeSort
{
    static void Main()
    {
        int[] arr = { 12, 11, 13, 5, 6, 7 };
        Console.WriteLine("Arreglo original:");
        PrintArray(arr);

        MergeSortAlgorithm(arr, 0, arr.Length - 1);

        Console.WriteLine("\nArreglo ordenado:");
        PrintArray(arr);
    }

    static void MergeSortAlgorithm(int[] arr, int left, int right)
    {
        if (left < right)
        {
            // Encuentra el punto medio del arreglo
            int middle = (left + right) / 2;

            // Ordena la primera y segunda mitad
            MergeSortAlgorithm(arr, left, middle);
            MergeSortAlgorithm(arr, middle + 1, right);

            // Combina las mitades ordenadas
            Merge(arr, left, middle, right);
        }
    }

    static void Merge(int[] arr, int left, int middle, int right)
    {
        int n1 = middle - left + 1;
        int n2 = right - middle;

        int[] leftArray = new int[n1];
        int[] rightArray = new int[n2];

        // Copia los datos a los arreglos temporales leftArray[] y rightArray[]
        for (int i = 0; i < n1; ++i)
            leftArray[i] = arr[left + i];

        for (int j = 0; j < n2; ++j)
            rightArray[j] = arr[middle + 1 + j];

        // Combina los arreglos temporales

        // Índices iniciales de los subarreglos
        int i = 0, j = 0;

        // Índice inicial del arreglo combinado
        int k = left;

        while (i < n1 && j < n2)
        {
            if (leftArray[i] <= rightArray[j])
            {
                arr[k] = leftArray[i];
                i++;
            }
            else
            {
                arr[k] = rightArray[j];
                j++;
            }
            k++;
        }

        // Copia los elementos restantes de leftArray[], si hay alguno
        while (i < n1)
        {
            arr[k] = leftArray[i];
            i++;
            k++;
        }

        // Copia los elementos restantes de rightArray[], si hay alguno
        while (j < n2)
        {
            arr[k] = rightArray[j];
            j++;
            k++;
        }
    }

    static void PrintArray(int[] arr)
    {
        foreach (var item in arr)
        {
            Console.Write(item + " ");
        }
        Console.WriteLine();
    }
}
