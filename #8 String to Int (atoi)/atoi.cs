 public static int MyAtoi(string str) {
        //1. Check if the string is null or length 0 to return
        if(str==null || str.Length==0)
            return 0;
        int sign=1, total=0, index=0, digit;
        
        //2. Remove Spaces
        while(str[index] == ' ' && index < str.Length)
            { index ++; }
        
        //3. Grab the sign so we know if it is '+' or '-'
        if(str[index] == '+' || str[index] == '-')
        {
            sign = str[index] == '+' ? 1 : -1;
            index++;
        }
        //4. loop through get each digit
        //Add to total.
        //Extra safe check would be to check overflow.
        while(index < str.Length)
        {
            digit = str[index] - '0';
            if(digit < 0 || digit > 9) break;
            //check if total will be overflow after 10 times and add digit
            if(int.MaxValue/10 < total || int.MaxValue/10 == total && int.MaxValue %10 < digit)
                return sign == 1 ? int.MaxValue : int.MinValue;
            total = total*10+digit;
            index++;
        }
        return sign*total;
    }