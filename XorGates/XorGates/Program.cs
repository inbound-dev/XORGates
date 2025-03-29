using System.Text;
using System.Xml.XPath;

string string1 = "10000";
string string2 = "11000";
string string3 = "10100";
string string4 = "10010";

Console.WriteLine("Tripple Input XOR:");
Console.WriteLine(TrippleXOR(string1, string2, string3));

Console.WriteLine("");

Console.WriteLine("Quad Input XOR:");
Console.WriteLine(QuadXOR(string1, string2, string3, string4));

static string QuadXOR(string input1, string input2, string input3, string input4)
{
    StringBuilder output = new StringBuilder(input1.Length);

    for (int i = 0; i < input1.Length; i++)
    {
        int bit1 = input1[i] - '0';
        int bit2 = input2[i] - '0';
        int bit3 = input3[i] - '0';
        int bit4 = input4[i] - '0';

        int xorResult = bit1 ^ bit2 ^ bit3 ^ bit4; // XOR of 4 bits

        output.Append(xorResult);
    }

    return output.ToString();
}

// tripple input XOR gate
static string TrippleXOR(string input1, string input2, string input3)
{
    StringBuilder output = new StringBuilder(input1.Length);

    for (int i = 0; i < input1.Length; i++)
    {
        int bit1 = input1[i] - '0';
        int bit2 = input2[i] - '0';
        int bit3 = input3[i] - '0';

        int xorResult = bit1 ^ bit2 ^ bit3; // XOR of 4 bits

        output.Append(xorResult);
    }
    return output.ToString();
}