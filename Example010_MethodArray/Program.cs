int[] array = {12, 24, 32, 43, 54, 26, 74, 82};

int n = array.Length;
int find = 43;
int index = 0;

while (index<n){

    if (array[index] == find){
        Console.WriteLine(index);
        break; //оператор "Прерви". Закончить выполнение цикла при достижении этой строчки
    }
    
    index = index+1;
}