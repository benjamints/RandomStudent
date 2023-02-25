using System.Text;

namespace RandomStudent.Generator;

public static class AddressGenerator
{
    private static readonly Random _rnd = new Random();

    private static readonly string[] _district;
    private static readonly string[] _warn;
    private static readonly string[] _street;

    static AddressGenerator()
    {
        _district = new string[]
        {
            "Bình Thạnh", "Bình Chánh", "Quận 1", "Quận 2"
        };
        _warn = new string[]
        {
            "Cầu Ông Lãnh", "Cầu Kho", "Bến Nghé", "Đa Kao", "Phạm Ngũ Lão"
        };
        _street = new string[]
        {
            "Trần Hưng Đạo", "Nguyễn Thái Học", "Cô Giang", "Cô Bắc", "Hồ Hảo Hớn"
        };
    }

    public static string Gen()
    {
        StringBuilder sb = new StringBuilder();

        sb.Append(_rnd.Next(1, 50));
        sb.Append(" ");
        sb.Append(_street.GetValue(_rnd.Next(_street.Length - 1)));
        sb.Append(", ");
        sb.Append(_warn.GetValue(_rnd.Next(_warn.Length - 1)));
        sb.Append(", ");
        sb.Append(_district.GetValue(_rnd.Next(_district.Length - 1)));

        return sb.ToString();
    }
}