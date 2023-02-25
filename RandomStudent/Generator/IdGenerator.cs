
using System.Text;

namespace RandomStudent.Generator;

public static class IdGenerator{
    private static readonly Random _rnd = new Random();

    public static string Gen(){
        StringBuilder sb = new StringBuilder();

        sb.Append(_rnd.Next(15000000, 22999999));
        
        return sb.ToString();
    }

}