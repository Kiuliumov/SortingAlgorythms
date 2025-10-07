public class Program{
     static void BubbleSort(int[] arr){
        for(int i = 0; i < arr.Length - 1; i++){
            for(int j = 0; j < arr.Length - i - 1; j++){
                if(arr[j] > arr[j + 1]){
                    (arr[j], arr[j+1]) = (arr[j + 1], arr[j]);
                }
            }
        }
    }


    static void Main(){
        int[] arr = {8, 5, 6, 4, 3, 6, 8, 9};
        BubbleSort(arr);
        foreach(int i in arr){
            Console.Write(i + " ");
        }

    }
}