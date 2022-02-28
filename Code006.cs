
// yield 
// 호출자에게 사전에 생성된 컬렉션을 하나씩 리턴할때 사용
static void Code007() {

    static IEnumerable<int> getNumber() {
        yield return 1;
        yield return 2;
        yield return 3;
    }

    foreach(int a in getNumber()) {
        System.Console.WriteLine(a);
    }


}
