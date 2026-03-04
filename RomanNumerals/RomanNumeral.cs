using System.Text;

namespace RomanNumerals;

public class RomanNumeral
{
    public int Value;
    public String Representation;
    public RomanNumeral(int value)
    {
        if (value <= 0 || value >= 4000)
            throw new ArgumentOutOfRangeException(nameof(value), "Value must be between 1 and 3999");
        this.Value = value;
        this.Representation = CreateRepresentation(value);
    }
    
    private static string CreateRepresentation(int value)
    {
        string[][] translatingArray =
        [
            ["", "I", "II", "III", "IV", "V", "VI", "VII", "VIII", "IX"],
            ["", "X", "XX", "XXX", "XL", "L", "LX", "LXX", "LXXX", "XC"],
            ["", "C", "CC", "CCC", "CD", "D", "DC", "DCC", "DCCC", "CM"],
            ["", "M", "MM", "MMM"],
        ];
        
        var result = new StringBuilder();
        var i = 0;

        while (value > 0)
        {
            var digit = value % 10;
            result.Insert(0, translatingArray[i][digit]);
            i++;
            value /= 10;
        }

        return result.ToString();
    }
    
    
}