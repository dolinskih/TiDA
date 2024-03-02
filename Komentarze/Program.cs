using Komentarze.Classes;

///Stworzenie testowej tablicy intów
int[] testArray = [1, 7, 3, 9, 6];

///Inicjalizacja klasy Sorts
Sorts sorts = new Sorts();

///Zdefiniowanie posortowanej tablicy intów z użyciem meotdy QuickSortArray z klasy Sorts
int[] quickSortedTestArray = sorts.QuickSortArray(testArray, 0, testArray.Length-1);

///Wypisanie posortowanej zawartości tablicy
foreach (int i in quickSortedTestArray)
{
    Console.Write($"{i} ");
}