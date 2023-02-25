using RandomStudent.Models;

var students = Enumerable.Range(1, 10).Select(e => new Student()).ToArray();
for (int i = 0; i < students.Length; ++i)
{
    Console.WriteLine($"Điểm trung bình của học sinh thứ {i + 1}: {students[i].Grade}");
}
Console.WriteLine();

var threeHighest = (
    from student in students
    orderby student.Grade
    select student
).Take(3);

foreach (var student in threeHighest)
{
    Console.WriteLine($"Thông tin của học sinh");
    Console.WriteLine($"- Mã số sinh viên: {student.Id}");
    Console.WriteLine($"- Họ và tên: {student.Name}");
    Console.WriteLine($"- Điểm: {student.Grade}");
    Console.WriteLine($"- Địa chỉ: {student.Address}");
    Console.WriteLine();
}