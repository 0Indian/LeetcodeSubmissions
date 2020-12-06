public class Solution {
    int max = Int32.MaxValue;
    int min = Int32.MinValue;
    public int MyAtoi(string s) 
    {
        if(string.IsNullOrEmpty(s)) return 0;
        
            string str = s;
            long res = 0;
            var sign = 1;            
            str = str.Trim();
            if (string.IsNullOrEmpty(str)) return 0;
            int index = 0;
            if (str[0] == '+' || str[0] =='-')
            {
                sign = str[0] == '+' ? 1 : -1;
                index++;
            }
            while (index<str.Length)
            {
                if (char.IsNumber(str[index]))
                {
                    res = res * 10 + str[index] - '0';
                    if (res * sign > int.MaxValue) return int.MaxValue;
                    if (res * sign < int.MinValue) return int.MinValue;
                }
                else
                {
                    break;
                }
                index++;
            }
            return (int)res * sign;
    }
}
