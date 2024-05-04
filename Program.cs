internal class Program
{
    private static void Main(string[] args)
    {
        int []arr = { 2, 3, 4, 5,};
        int x = int.Parse(Console.ReadLine());
        for (int i = 0; i < arr.Length; i++) {
            if (arr[i] == x) {
                for (int j = i; j < arr.Length-1; j++) {
                    arr[j] = arr[j + 1];
                }
                arr[arr.Length -1] = 0;
            }
        }
        for (int i = 0; i < arr.Length; i++) {
            Console.Write(arr[i] + " ");
        }
    }
}