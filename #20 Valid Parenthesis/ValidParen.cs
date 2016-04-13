public static bool IsValid(string s) {
    if (s.Length == 0) return true;
            Stack<char> ValidParen = new Stack<char>();
            for(int i=0; i<s.Length;i++)
            {
                switch(s[i])
                {
                    case '(':
                        ValidParen.Push(s[i]);
                        break;
                    case '{':
                        ValidParen.Push(s[i]);
                        break;
                    case '[':
                        ValidParen.Push(s[i]);
                        break;
                    case ')':
                        if (ValidParen.Count == 0 || ValidParen.Peek() != '(')
                            return false;
                        else
                            ValidParen.Pop();
                        break;
                    case ']':
                        if (ValidParen.Count == 0 || ValidParen.Peek() != '[')
                            return false;
                        else
                            ValidParen.Pop();
                        break;
                    case '}':
                        if (ValidParen.Count == 0 || ValidParen.Peek() != '{')
                            return false;
                        else
                            ValidParen.Pop();
                        break;
                }
            }

            return ValidParen.Count==0;
    }