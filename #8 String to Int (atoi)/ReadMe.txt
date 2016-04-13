Implement atoi to convert a string to an integer.

Hint: Carefully consider all possible input cases. If you want a challenge, please do not see below and ask yourself what are the possible input cases.

Notes: It is intended for this problem to be specified vaguely (ie, no given input specs). You are responsible to gather all the input requirements up front.

We have a few steps to do in this problem. The first one is to do a safety check. We need to check if there is anything entered in the string to convert. Next, the problem specified there could be whitespace so we have to iterate the string to get to the first char of non whitespace. There may or may not be a '+' or '-' so we also need to check for that condition. Finally, we have to loop through the rest of the string. We need to check if a digit is within the 0-9. We can also do a detection of an overflow by checking if(int.MaxValue/10 < total || int.MaxValue/10 == total && int.MaxValue %10 < digit). Finally we just take the total and multiply by 10 and add the digit. This builds the number up in order. Lastly, we take the sign * total that we return. Time complexity O(n) space O(1)