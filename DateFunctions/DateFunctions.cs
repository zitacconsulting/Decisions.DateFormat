using DecisionsFramework.Design.Flow;
using System.Globalization;

namespace Zitac.DateFunctions.Steps;

[AutoRegisterMethodsOnClass(true, "Data", "Dates")]
public class DateSteps
{
    public static string DateByCulture(DateTime date, string cultureCode, DateFormatType formatType)
    {

        // Create a CultureInfo object based on the provided culture code
        CultureInfo culture = new CultureInfo(cultureCode);

        // Get the string format corresponding to the enum value
        string format = GetFormatString(formatType);

        // Return the formatted date as a string using the specified format and culture
        return date.ToString(format, culture);
    }
    static string GetFormatString(DateFormatType formatType)
    {
        switch (formatType)
        {
            case DateFormatType.ShortDate:
                return "d";  // Short date
            case DateFormatType.LongDate:
                return "D";  // Long date
            case DateFormatType.ShortTime:
                return "t";  // Short time
            case DateFormatType.LongTime:
                return "T";  // Long time
            case DateFormatType.FullDateTime:
                return "F";  // Full date/time (long)
            case DateFormatType.GeneralDateTimeShort:
                return "g";  // General date/time (short)
            case DateFormatType.GeneralDateTimeLong:
                return "G";  // General date/time (long)
            default:
                throw new ArgumentException("Invalid format type.");
        }
    }
}


