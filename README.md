# LeetCode Problem Solutions in C#

## Introduction
🚀 Welcome to my LeetCode Problem Solutions repository! Ready to embark on a coding adventure? You're in the right place!
<br /> 🌟 Here, you'll find a treasure trove of C# solutions to LeetCode problems. Dive into diverse algorithmic challenges, explore different topics, and level up your coding skills with a dash of fun! Happy coding! 🎉
<br /> If you find this repository helpful, please consider giving it a ⭐️!

## Table of Contents

- [Arrays & Hashing](#arrays-&-hashing)
- [Two Pointers](#two-pointers)
- [Sliding Window](#sliding-window)
- [Stack](#stack)
- [Binary Search](#binary-search)
- [Linked List](#linked-list)

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
| [26. Remove Duplicates from Sorted Array](AlgorithmsAndDS/AlgorithmsAndDS/TwoPointers/Easy/RemoveDuplicatesFromSortedArray.cs) | Easy | O(n) | O(1) | - Maintain index to replace <br /> - Next item should be greater then previous |
| [88. Merge Sorted Array](AlgorithmsAndDS/AlgorithmsAndDS/TwoPointers/Easy/MergeSortedArray.cs) | Easy | O(n+m) | O(1) | - Merge arrays in reverse order <br /> - Three pointers (last item of arr1, last item of arr2, last item of result arr)  <br /> - Compare values |
| [125. Valid Palindrome](AlgorithmsAndDS/AlgorithmsAndDS/TwoPointers/Easy/ValidPalindrome.cs) | Easy | O(N) | O(1) | - Two pointers (start, end) <br /> - Move each pointer untill value will be letter or digit  <br /> - If values are not equal - return false |
| [283. Move Zeroes](AlgorithmsAndDS/AlgorithmsAndDS/TwoPointers/Easy/MoveZeroes.cs) | Easy | O(N) | O(1) | - Maintain index to replace <br /> - Iterate array, swap non zero value with index to replace position  <br /> - Update index to replace |
| [344. Reverse String](AlgorithmsAndDS/AlgorithmsAndDS/TwoPointers/Easy/ReverseString.cs) | Easy | O(N) | O(1) | - Two pointers (start, end) <br /> - Swap chars |
| [680. Valid Palindrome II](AlgorithmsAndDS/AlgorithmsAndDS/TwoPointers/Easy/ValidPalindromeII.cs) | Easy | O(N) | O(1) | - Two pointers (start, end) <br /> - Move each pointer while values are equal  <br /> - If values are not equal - 2 options available: skip left character or right <br /> - Use helper method to check both options |
| [1768. Merge Strings Alternately](AlgorithmsAndDS/AlgorithmsAndDS/TwoPointers/Easy/MergeStringsAlternately.cs) | Easy | O(N) | O(n+m) | - Iterate to the end of smaller string, building result <br /> - Iterate larger string |

## Sliding Window

| Problem | Complexity | Time Complexity | Space Complexity | Solution Hints |
| ------- | ---------- | --------------- | ---------------- | -------------- |
| [1984. Minimum Difference Between Highest and Lowest of K Scores](AlgorithmsAndDS/AlgorithmsAndDS/SlidingWindow/Easy/MinimumDifferenceBetweenHighestAndLowestOfKScores.cs) | Easy | O(nlog(n)) | O(1) | - Sort array <br /> - Create sliding window of size k  <br /> - Calculate min diff between first and last items of window <br /> - Iterate and update min value |

## Stack

| Problem | Complexity | Time Complexity | Space Complexity | Solution Hints |
| ------- | ---------- | --------------- | ---------------- | -------------- |
| [20. Valid Parentheses](AlgorithmsAndDS/AlgorithmsAndDS/Stacks/Easy/ValidParentheses.cs) | Easy | O(n) | O(n) | - Push open braces to stack <br /> - If current item is closing breace, it should be the same type as top of the stack  <br /> - If it's true pop value and continue, otherwise - false |
| [682. Baseball Game](AlgorithmsAndDS/AlgorithmsAndDS/Stacks/Easy/BaseballGame.cs) | Easy | O(n) | O(n) | - Push digits to stack <br /> - During operation, pop items, modify stack, calculateresult |

## Binary Search

| Problem | Complexity | Time Complexity | Space Complexity | Solution Hints |
| ------- | ---------- | --------------- | ---------------- | -------------- |
| [35. Search Insert Position](AlgorithmsAndDS/AlgorithmsAndDS/BinarySearch/Easy/SearchInsertPosition.cs) | Easy | O(log(n)) | O(1) | - Binary search while l <= r <br /> - Insert position will be left pointer |
| [704. Binary Search](AlgorithmsAndDS/AlgorithmsAndDS/BinarySearch/Easy/BinarySearch.cs) | Easy | O(log(n)) | O(1) | - Two pointers (start, end) in sorted array <br /> - Calculate mid, if mid == target than return <br /> - Update left or right pointer according to mid |
| [374. Guess Number Higher or Lower](AlgorithmsAndDS/AlgorithmsAndDS/BinarySearch/Easy/GuessNumberHigherOrLower.cs) | Easy | O(log(n)) | O(1) | - Binary search while l <= r <br /> - To compare mid value use guess function |
| [441. Arranging Coins](AlgorithmsAndDS/AlgorithmsAndDS/BinarySearch/Easy/ArrangingCoins.cs) | Easy | O(log(n)) | O(1) | - Binary search while start <= end <br /> - Calculate sum of range 1...mid using formula: S = (n/2) * (1 + n) <br /> - Compare sum and n and update pointers <br /> - Since at the end start > end, start will start pointing to a value greater than the desired result. Return end as it will point to the correct value. |

## Linked List

| Problem | Complexity | Time Complexity | Space Complexity | Solution Hints |
| ------- | ---------- | --------------- | ---------------- | -------------- |
| [21. Merge Two Sorted Lists](AlgorithmsAndDS/AlgorithmsAndDS/LinkedLists/Easy/MergeTwoSortedLists.cs) | Easy | O(n) | O(1) | Create dummy node, iterate while list1 & list2 != null, fill values, then do not forget larger list values |
| [206. Reverse Linked List](AlgorithmsAndDS/AlgorithmsAndDS/LinkedLists/Easy/ReverseLinkedList.cs) | Easy | O(n) | O(1) | Create two nodes, prev = null, curr = head <br /> - Iterate while curr != null and reverse pointers to prev node <br /> - Return prev node as new head |
