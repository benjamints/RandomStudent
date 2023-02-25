using System.Text;

namespace RandomStudent.Generator;

public static class NameGenerator
{
    private static readonly Random _rnd = new Random();

    private static readonly string[] _firstName;
    private static readonly string[] _middleName;
    private static readonly string[] _lastName;

    static NameGenerator()
    {
        _firstName = new string[]
        {
            "Hiếu",
            "Hậu",
            "Sương",
            "Vinh"
        };
        _middleName = new string[]
        {
            "Văn",
            "Thị",
        };
        _lastName = new string[]
        {
            "Võ",
            "Nguyễn",
            "Trần",
            "Dương"
        };
    }

    public static string Gen()
    {
        StringBuilder sb = new StringBuilder();

        sb.Append(_lastName.GetValue(_rnd.Next(_lastName.Length - 1)));
        sb.Append(" ");
        sb.Append(_middleName.GetValue(_rnd.Next(_middleName.Length - 1)));
        sb.Append(" ");
        sb.Append(_firstName.GetValue(_rnd.Next(_firstName.Length - 1)));

        return sb.ToString();
    }
}