Problem: Given an array of integers, return indices of the two numbers such that they add up to a specific target.

You may assume that each input would have exactly one solution.
Example:
Given nums = [2, 7, 11, 15], target = 9,
Because nums[0] + nums[1] = 2 + 7 = 9,
return [0, 1].

The solution was figured out after a brute force solution which was O(n^2) time and O(1) space complexity.
This solution is O(n) since we traverse the array containing n elements once.
The space is O(n) since we have a dictionary which stores at most n elements.
The idea is to go through all the elements and check if the dictionary has the complement of the target - nums[i]. When we insert an element in the dictionary we store the value at i because we want to return the indices in the array that add up to the target. We know that if we have a key of target-nums[i] then we can return the indice of target - num[i] and i. we add 1 since the indices are zero based.