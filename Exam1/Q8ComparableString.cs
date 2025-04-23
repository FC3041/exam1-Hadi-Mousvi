namespace Exam1;

public class Q8StringLengthComparer : IComparer<string>
{
    public int Compare(string? x, string? y)
    {
        int L1 = 0;
        int L2 = 0;
        if(x != null)
            L1 = x.Length;
        else
            L1 = -1;


        if(y != null)
            L2 = y.Length;
        else 
            L2 = -1;


        if(L1 < L2)
            return -10;

        else if(L1 > L2)
            return 10;
        
        if(L1 == L2)
        {
            if(x==null && y==null)
                return 0;
            else
            {
                if(x[0].CompareTo(y[0])==0)
                    return x[1].CompareTo(y[1]);
                return x[0].CompareTo(y[0]);
            }
        }
        throw new NotImplementedException();
    }
}

public class Q8ComparableString
{
    public static bool operator <( Q8ComparableString CStr1,Q8ComparableString CStr2) => CStr1.StrAskeys < CStr2.StrAskeys;
    public static bool operator >( Q8ComparableString CStr1,Q8ComparableString CStr2) => CStr1.StrAskeys > CStr2.StrAskeys;
    public static bool operator ==(Q8ComparableString CStr1,Q8ComparableString CStr2) => CStr1.StrAskeys == CStr2.StrAskeys;
    public static bool operator !=(Q8ComparableString CStr1,Q8ComparableString CStr2) => CStr1.StrAskeys != CStr2.StrAskeys;

    private double StrAskeys = 0;
    public string Str;
    public Q8ComparableString(string s)
    {
        this.Str = s;
        if(s==null)
            this.StrAskeys = -10;
        else
        {
            foreach(var c in this.Str)
            {
                this.StrAskeys += (double)c;
            }
        }
    }
}