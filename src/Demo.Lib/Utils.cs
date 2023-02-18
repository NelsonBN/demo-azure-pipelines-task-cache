namespace Demo.Lib;

public class Utils
{
    public static string? GetCountry(string iso2)
    {
        if(!PowerUtils.Globalization.UtilsGlobalization.IfExistISO2(iso2))
        {
            return null;
        }

        return $"Demo: {PowerUtils.Globalization.UtilsGlobalization.GetEnglishName(iso2)}";
    }
}
