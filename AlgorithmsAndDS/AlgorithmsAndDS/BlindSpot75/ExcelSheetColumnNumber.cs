namespace AlgorithmsAndDS.BlindSpot75;

public static class ExcelSheetColumnNumber
{
    public static int TitleToNumber(string columnTitle) {
        if (columnTitle.Length == 0)
        {
            return 0;
        }

        var result = 0;

        foreach (var letter in columnTitle)
        {
            result *= 26;
            result += letter - 'A' + 1;
        }

        return result;
    }
}