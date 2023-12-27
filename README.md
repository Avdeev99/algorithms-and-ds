# LeetCode Problem Solutions in C#

## Introduction
🚀 Welcome to my LeetCode Problem Solutions repository! Ready to embark on a coding adventure? You're in the right place!
<br /> 🌟 Here, you'll find a treasure trove of C# solutions to LeetCode problems. Dive into diverse algorithmic challenges, explore different topics, and level up your coding skills with a dash of fun! Happy coding! 🎉
<br /> If you find this repository helpful, please consider giving it a ⭐️!

## Table of Contents

- [Arrays & Hashing](#arrays-&-hashing)
- [Two Pointers](#two-pointers)
- [Sliding Window](#sliding-window)

## Arrays & Hashing

| Problem | Complexity | Time Complexity | Space Complexity | Solution Hints |
| ------- | ---------- | --------------- | ---------------- | -------------- |
| [217. Contains Duplicate](AlgorithmsAndDS/AlgorithmsAndDS/ArraysAndHashing/Easy/ContainsDuplicate.cs) | Easy | O(N) | O(N) | - Write values to **Hash Set** <br /> - If already exists - true, otherwise - false |
| [242. Valid Anagram](AlgorithmsAndDS/AlgorithmsAndDS/ArraysAndHashing/Easy/ValidAnagram.cs) | Easy | O(N) | O(N) | - Save counts of chars of s1 in **Dict** <br /> - Iterate s2, check that every char exists in dict and decrease count <br /> - Iterate Dict and check that all count = 0 |
| [290. Word Pattern](AlgorithmsAndDS/AlgorithmsAndDS/ArraysAndHashing/Easy/IsSubsequence.cs) | Easy | O(N) | O(1) | - Hint |
| [392. Is Subsequence](AlgorithmsAndDS/AlgorithmsAndDS/ArraysAndHashing/Easy/WordPattern.cs) | Easy | O(N) | O(N) | - Use two indexes for interation s1 and s2. <br /> - Iterate s1 index when chars equals |
| [1299. Replace Elements with Greatest Element on Right Side](AlgorithmsAndDS/AlgorithmsAndDS/ArraysAndHashing/Easy/ReplaceElementsWithGreatestElementOnRightSide.cs) | Easy | O(N) | O(N) | - For the last iten, greatest = -1, for second from end = last item <br /> - Iterate array from end, set greatest (at first is last item) <br /> - Update greatest var if current is greater |
| [1929. Concatenation of Array](AlgorithmsAndDS/AlgorithmsAndDS/ArraysAndHashing/Easy/ConcatenationOfArray.cs) | Easy | O(N) | O(N) | - Create array with n*2 length <br /> - Fill values to i and i+n positions |

## Two Pointers

| Problem | Complexity | Time Complexity | Space Complexity | Solution Hints |
| ------- | ---------- | --------------- | ---------------- | -------------- |
| [125. Valid Palindrome](AlgorithmsAndDS/AlgorithmsAndDS/TwoPointers/Easy/ValidPalindrome.cs) | Easy | O(N) | O(1) | - Two pointers (start, end) <br /> - Move each pointer untill value will be letter or digit  <br /> - If values are not equal - return false |
| [680. Valid Palindrome II](AlgorithmsAndDS/AlgorithmsAndDS/TwoPointers/Easy/ValidPalindromeII.cs) | Easy | O(N) | O(1) | - Two pointers (start, end) <br /> - Move each pointer while values are equal  <br /> - If values are not equal - 2 options available: skip left character or right <br /> - Use helper method to check both options |
| [1768. Merge Strings Alternately](AlgorithmsAndDS/AlgorithmsAndDS/TwoPointers/Easy/MergeStringsAlternately.cs) | Easy | O(N) | O(n+m) | - Iterate to the end of smaller string, building result <br /> - Iterate larger string |

## Sliding Window

| Problem | Complexity | Time Complexity | Space Complexity | Solution Hints |
| ------- | ---------- | --------------- | ---------------- | -------------- |
| [1984. Minimum Difference Between Highest and Lowest of K Scores](AlgorithmsAndDS/AlgorithmsAndDS/SlidingWindow/Easy/MinimumDifferenceBetweenHighestAndLowestOfKScores.cs) | Easy | O(nlog(n)) | O(1) | - Sort array <br /> - Create sliding window of size k  <br /> - Calculate min diff between first and last items of window <br /> - Iterate and update min value |
