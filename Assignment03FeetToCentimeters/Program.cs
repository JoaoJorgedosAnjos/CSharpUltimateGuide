const double InchesInCentimeters = 2.54;
const double FeetToCentimeter = 12 * InchesInCentimeters;

double ValueFeet = 5 * FeetToCentimeter;
double ValueInches = 7 * InchesInCentimeters;

var Sum = ValueInches + ValueFeet;

Console.WriteLine($"{Sum} cm");
Console.WriteLine("teste");