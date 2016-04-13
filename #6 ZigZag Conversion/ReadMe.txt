The string "PAYPALISHIRING" is written in a zigzag pattern on a given number of rows like this: (you may want to display this pattern in a fixed font for better legibility)

P   A   H   N
A P L S I I G
Y   I   R
And then read line by line: "PAHNAPLSIIGYIR"
Write the code that will take a string and make this conversion given a number of rows:

string convert(string text, int nRows);
convert("PAYPALISHIRING", 3) should return "PAHNAPLSIIGYIR".

This was a tricky problem. We know that were getting the number of rows incoming. So this tells us that we need to create an array with the number of rows coming in. The trick to this problem is having a bool to tell us whether we need to go down and an outside variable for the row. This will let us go in the zigzag type pattern as we iterate through the original string array. For instance, We know on the first instance when row is zero that we will need to append to the row and set down to true to follow the constraints of the problem. We also know that when we go down we increase the row and if we are not down then we decrease the row. This will create the zigzag pattern we need. Finally, we iterate through the array that we filled in and return that string. I used a string builder since it's mutable