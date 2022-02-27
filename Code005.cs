
// 반복문
static void Code006() {

    string[,,] array = new string[,,]
    {
        {{"1", "2"}, {"11", "22"}},
        {{"3", "4"}, {"33", "44"}}
    };

    int x = array.GetLength(0) - 1;
        
    Console.WriteLine("while 문을 활용한 3차 배열 객체 출력");
    while(x >= 0) {
        int y = array.GetLength(1) - 1;
        while(y >= 0) {
            int z = array.GetLength(2) - 1;
            while(z >= 0) {

                if(array[x,y,z] != null) {
                    Console.WriteLine(array[x,y,z]);
                }
                z--;

            }
            y--;
        }
        x--;
    }

     Console.WriteLine("for 문을 활용한 3차 배열 객체 출력");
    // Length와 GetLength의 차이는 전체의 길이인지, 해당 차원의 길이를 반환하는지 차이가 있다
    for (int i = 0 ; i < array.GetLength(0) ; i++) {

        for (int j = 0 ; j < array.GetLength(1) ; j++) {

            for (int k = 0 ; k < array.GetLength(2) ; k++) {

                Console.WriteLine(array[i,j,k]);

            }
        }
    }

    Console.WriteLine("foreach 문을 활용한 3차 배열 객체 출력");
    foreach(var i in array) {
        Console.WriteLine(i);
    }
}
