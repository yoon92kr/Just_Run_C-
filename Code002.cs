// 자료형
static void Code002()
{
int var1 = 10;
float var2 = 10.0f;
double var3 = 10.0d;
char var4 = 'a';
string var5 = "abc";
bool var6= true;

// 보통 정수나 날짜 타입같은 Value Type은 NULL 값을 가질 수 없는데 C#에서는 Nullable Type이라고 Value Type이 NULL을 가질 수 있게 한다
// 물음표를 타입 뒤에 붙이면 Nullable Type이 되며 Nullable Type을 다시 Value Type으로 변환 하기 위해서는 .Value속성을 사용한다
int? var7 = null;
Nullable<int> var8 = null;

var7 = 10;
int var9 = var7.Value;
}

// 상수
static void Code003() {
    
    // 자바와 달리(final) C#에서는 const 키워드를 사용한다
    const float var1 = 3.14f;

}
