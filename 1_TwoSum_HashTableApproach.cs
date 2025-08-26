// Problem Statement:
// Given an array of integers nums and an integer target, return indices of the two numbers such that they add up to target.
// You may assume that each input would have exactly one solution, and you may not use the same element twice.
// You can return the answer in any order.
using System.Collections;
public class Solution
{
    public int[] TwoSum(int[] nums, int target)
    {
        Hashtable h1 = new Hashtable();
        int compliment = 0;
        for (int i = 0; i < nums.Length; i++) { 
            compliment = target - nums[i];
            if (h1.ContainsKey(compliment)) return new int[] { (int)h1[compliment], i };
            if (!h1.ContainsKey(nums[i])) h1[nums[i]] = i;
        }
        return Array.Empty<int>();
    }
}