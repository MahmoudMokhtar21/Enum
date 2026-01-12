






Console.WriteLine((int)Month.feb);

Console.WriteLine((int)month1.feb);

var day = (DAY.fri | DAY.sun);
if(day.HasFlag(DAY.weekend))
{
    Console.WriteLine("enjoy ur weekend");
}

var day2 = "jan";

//if(Enum.TryParse(day2,out Month month)) // 1st way
if(Enum.IsDefined(typeof(Month),day2))
{
    Console.WriteLine(day2);
}
else
{
    Console.WriteLine("invalid voucher");
}



//=================================
var day3 = 4;

if (Enum.IsDefined(typeof(Month), day3))
{
    Console.WriteLine((Month)day3); // will print string name = 4 ==> may
}
else
{
    Console.WriteLine("invalid voucher");
}





foreach (var month in Enum.GetValues(typeof(Month)))
{ Console.WriteLine($"{month.ToString()} = {(int)month}"); }

enum Month
{
           // without inserting
    jan,   // 0
    feb,   // 1
    mar,   // 2
    apr,   // 3
    may,   // 4
    jun,   // 5
    jul,   // 6
    aug,   // 7
    sep,   // 8
    oct,   // 9
    nov,   // 10
    dec    // 11
}


enum month1
{
    // with inserting
    jan = 5,   // 5
    feb,   // 6
    mar,   // 7
    apr,   // 8
    may,   // 9
    jun,   // 10
    jul,   // 11
    aug,   // 12
    sep,   // 13
    oct,   // 14
    nov,   // 15
    dec    // 16
}


[Flags]
enum DAY
{
    none = 0b_0000_0000, // 0
    sun  = 0b_0000_0001, // 1
    sat  = 0b_0000_0010, // 2
    mon  = 0b_0000_0100, // 4
    tue  = 0b_0000_1000, // 8
    wed  = 0b_0001_0000, // 16
    trs  = 0b_0010_0000, // 32
    fri  = 0b_0100_0000, // 64

    weekend = fri | sun ,
    busday  = sat | mon | tue | wed | trs
}