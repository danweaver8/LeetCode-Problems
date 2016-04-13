Reverse digits of an integer.

Example1: x = 123, return 321
Example2: x = -123, return -321

The idea here is to go through each integer. We have to take the result and mod it by 10 and multiple the result * 10. This gives us the reversal of each digit. I used a long in this problem to avoid a scenario causing the int to overflow. I do one last check to see if the number has overflowed for an int. If this is the case then we just need to return 0. The space complexity is O(Log n). Space Complexity O(1)