public static class LogAnalysis 
{
    // TODO: define the 'SubstringAfter()' extension method on the `string` type
    public static string SubstringAfter(this string str, string targetString)
    {
        int start = str.IndexOf(targetString) + targetString.Length;
        return str.Substring(start, str.Length - start);
    }
    
    // TODO: define the 'SubstringBetween()' extension method on the `string` type
    public static string SubstringBetween(this string str, string startString, string endString)
    {
        int start = str.IndexOf(startString) + startString.Length;
        int end = str.IndexOf(endString);
        return str.Substring(start, end - start);
    }
    
    // TODO: define the 'Message()' extension method on the `string` type
    public static string Message(this string str)
    {
        return str.SubstringAfter(" ");
    }

    // TODO: define the 'LogLevel()' extension method on the `string` type
    public static string LogLevel(this string str)
    {
        return str.SubstringBetween("[", "]");
    }
}