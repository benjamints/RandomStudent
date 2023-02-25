using RandomStudent.Generator;

namespace RandomStudent.Models;

public class Student
{
    public string Id { get; init; } = IdGenerator.Gen();
    public string Name { get; init; } = NameGenerator.Gen();
    public double Grade { get; init; } = GradeGenerator.Gen();
    public string Address { get; init; } = AddressGenerator.Gen();
}