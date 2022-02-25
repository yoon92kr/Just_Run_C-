
// 배열 객체
static void Code004() {

int[][] A = new int[3][]; 

//각 1차 배열 요소당 서로 다른 크기의 배열 할당 가능하다
A[0] = new int[2]; 
A[1] = new int[3] { 1, 2, 3 }; 
A[2] = new int[4] { 1, 2, 3, 4 }; 

A[0][0] = 1; 
A[0][1] = 2;

for(int i = 0 ; i < A.Length ; i++) {

    for(int j = 0 ; j < A[i].Length ; j++) {
        Console.WriteLine(A[i][j]);
    }
}

}
