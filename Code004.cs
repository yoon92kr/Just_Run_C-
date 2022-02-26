
// 문자열
static void Code005() {

// C#의 문자열은, Immutable Type 으로 값 초기화 후, 재설정이 불가능하다.
// 즉, string var1 = "hello" 선언 이후, var1 = "world"를 실행하면 첫 var1의 메모리 주소와 다른 주소를 새로 할당하게 된다.
// 계속해서 문자열을 추가해햐하는 경우,  System.Text 클래스의 Mutable 타입인 StringBuilder를 사용한다.


StringBuilder var1 = new StringBuilder();

for (int i = 1; i <= 26; i++) {
    var1.Append(i.ToString());
    var1.Append(System.Environment.NewLine);
    }
string var2 = var1.ToString();
 Console.WriteLine(var2);


}
