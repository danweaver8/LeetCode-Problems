public static int RomanToInt(string s) {
        int romInt = 0, prevRomInt=0, curRomInt=0;
        Dictionary<char,int> romanInt = new Dictionary<char,int>();
        romanInt.Add('I', 1);
        romanInt.Add('V',5);
        romanInt.Add('X',10);
        romanInt.Add('L',50);
        romanInt.Add('C',100);
        romanInt.Add('D',500);
        romanInt.Add('M',1000);
        
        prevRomInt = romanInt[s[s.Length-1]];
        romInt+=prevRomInt;
        for(int i=s.Length-2; i>=0; i--)
        {
            curRomInt = romanInt[s[i]];
            if(curRomInt>=prevRomInt)
                romInt+= curRomInt;
            else
                romInt-= curRomInt;
            prevRomInt = curRomInt;
        }
        
        return romInt;
    }