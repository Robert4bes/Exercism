public static class PhoneNumber
{
    public static (bool IsNewYork, bool IsFake, string LocalNumber) Analyze(string phoneNumber)
    {
        string[] subs = phoneNumber.Split('-');
        return (subs[0].Equals("212"), subs[1].Equals("555"), subs[2]);
    }

    public static bool IsFake((bool IsNewYork, bool IsFake, string LocalNumber) phoneNumberInfo)
    {
        if (phoneNumberInfo.IsNewYork)
        {
            if (phoneNumberInfo.IsFake)
                return true;
            else
                return false;
        }
        else
            return false;
    }
}
