public static string Convert(string s, int numRows) {
         if (s == null || s.Length == 0 || numRows == 0) { return string.Empty; }
            if (numRows == 1) { return s; }

            string[] zigzag = new string[numRows];

            int row = 0;
            bool down = true;
            for (int i = 0; i < s.Length; i++)
            {
                zigzag[row] += s[i].ToString();
                if (row == numRows - 1) { row--; down = false; }
                else if (row == 0) { row++; down = true; }
                else if (down) { row++; }
                else if (!down) { row--; }
            }
            StringBuilder returnString = new StringBuilder();
            for (int i = 0; i < zigzag.Length; i++)
                returnString.Append(zigzag[i]);
            return returnString.ToString();
    }