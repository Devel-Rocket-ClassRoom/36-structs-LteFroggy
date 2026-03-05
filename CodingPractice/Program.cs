using Q1_1;
using Q1_2;
using Q1_3;
using Q3_2;
using Q4_1;
using Q8_1;
using System;

// 1-1. 기본 구조체 선언
{
    Point p;
    p.X = 100;
    p.Y = 200;
    Console.WriteLine($"X : {p.X}, Y : {p.Y}");
    Console.WriteLine();
    Console.WriteLine();
}

// 1-2. 다양한 타입의 필드를 가진 구조체
{
    Product p;
    p.Id = 1;
    p.Title = "좋은 책";
    p.Price = 10000;
    Console.WriteLine($"번호 : {p.Id}");
    Console.WriteLine($"상품명 : {p.Title}");
    Console.WriteLine($"가격 : {p.Price:N0}");
    Console.WriteLine();
    Console.WriteLine();
}

// 1-3. 명함 정보 구조체
{
    BusinessCard businessCard;
    businessCard.Name = "홍길동";
    businessCard.Age = 21;
    businessCard.Address = "서울시";
    Console.WriteLine($"{businessCard.Name}, {businessCard.Age}, {businessCard.Address}");
    Console.WriteLine();
    Console.WriteLine();
}

// 2-1. 구조체 생성자
{
    Q2_1.Point p = new Q2_1.Point(100, 200);
    Console.WriteLine($"X : {p.X}, Y : {p.Y}");
    Console.WriteLine();
    Console.WriteLine();
}

// 3-1. 구조체 배열 사용
{
    BusinessCard[] businessCards = new BusinessCard[] {
        new BusinessCard("홍길동", 17),
        new BusinessCard("백두산", 102),
        new BusinessCard("임꺽정", 31)
    };

    foreach ( BusinessCard businessCard in businessCards ) {
        Console.WriteLine($"{businessCard.Name}은(는) {businessCard.Age}살입니다.");
        Console.WriteLine();
        Console.WriteLine();
    }
}

// 3-2. 성적 관리 프로그램
{
    Score score1 = new Score("홍길동", 100, 90);
    Score score2 = new Score("백두산", 80, 90);
    Score score3 = new Score("임꺽정", 80, 70);

    Console.WriteLine($"이름     총점   평균");
    Console.WriteLine($"{score1.Name} {score1.Total, 5} {score1.Average, 5}");
    Console.WriteLine($"{score2.Name} {score2.Total, 5} {score2.Average, 5}");
    Console.WriteLine($"{score3.Name} {score3.Total, 5} {score3.Average, 5}");
    Console.WriteLine();
    Console.WriteLine();
}

// 4-1. 구조체를 함수에 전달하기
{
    void IndividualMethod(string name, int age) {
            Console.WriteLine($"이름 : {name}, 나이 : {age}");
    }
    void StructMethod(Member member) {
            Console.WriteLine($"이름 : {member.Name}, 나이 : {member.Age}");
    }

    Member member = new Member("백두산", 100);

    IndividualMethod("홍길동", 21);
    StructMethod(member);
    Console.WriteLine();
    Console.WriteLine();
}

// 5-1. 구조체 안에 구조체
{
    Q5_1.Student[] students = new Q5_1.Student[] {
        new Q5_1.Student(1, "홍길동", new Q5_1.Score(100, 90)),
        new Q5_1.Student(1, "백두산", new Q5_1.Score(90, 80)),
        new Q5_1.Student(1, "임꺽정", new Q5_1.Score(80, 70))
    };
    
    foreach ( Q5_1.Student student in students ) {
        Console.WriteLine($"{student.Num} - {student.Name} : {student.Score.Kor}, {student.Score.Eng}");
    }
    Console.WriteLine();
    Console.WriteLine();
}

// 6-1. 문자 종류 확인과 변환
{
    char cVal = 'a';
    
    if (Char.IsLower('A')) Console.WriteLine($"A는 대문자");
    if (Char.IsLower('a')) Console.WriteLine($"a는 소문자");
    if (Char.IsDigit('1')) Console.WriteLine($"1은 숫자");
    if (Char.IsWhiteSpace(' ')) Console.WriteLine($" 는 공백 문자");
    Console.WriteLine(Char.ToLower('a'));
    Console.WriteLine(Char.ToUpper('A'));
    Console.WriteLine();
    Console.WriteLine();
}

// 7-1. 날짜와 시간 다루기
{
    DateTime birthDay = new DateTime(1998, 3, 28);
    Console.WriteLine($"현재 : {DateTime.Now}");
    Console.WriteLine($"생일 : {birthDay:yyyy년 MM월 dd일}");
    Console.WriteLine($"일주일 후 : {DateTime.Now.AddDays(7):d}");
    Console.WriteLine($"나이 : {DateTime.Now.Year - birthDay.Year}세");
    Console.WriteLine();
    Console.WriteLine();
}

// 8-1. 구조체의 값 복사
{
    void ManipulatePointStruct(PointStruct ps) {
        ps.X = 100;
        ps.Y = 100;
    }
    PointStruct ps = new PointStruct(10, 20);
    ManipulatePointStruct(ps);
    Console.WriteLine($"p1.X = {ps.X}");
    Console.WriteLine($"p1.Y = {ps.Y}");
    Console.WriteLine();
    Console.WriteLine();
}