# LeetCode Problem Solutions in C#

## Introduction
🚀 Welcome to my LeetCode Problem Solutions repository! Ready to embark on a coding adventure? You're in the right place!
🌟 Here, you'll find a treasure trove of C# solutions to LeetCode problems. Dive into diverse algorithmic challenges, explore different topics, and level up your coding skills with a dash of fun! Happy coding! 🎉
If you find this repository helpful, please consider giving it a ⭐️!

## Table of Contents

- [Arrays & Hashing](#arrays-&-hashing)
- [Two Pointers](#two-pointers)
- [Sliding Window](#sliding-window)

## Arrays & Hashing

| Problem | Complexity | Time Complexity | Space Complexity | Solution Hints |
| ------- | ---------- | --------------- | ---------------- | -------------- |
| [217. Contains Duplicate](AlgorithmsAndDS/AlgorithmsAndDS/ArraysAndHashing/Easy/ContainsDuplicate.cs) | Easy | O(N) | O(N) | - Write values to **Hash Set** \n - If already exists - true, otherwise - false |
| [242. Valid Anagram](AlgorithmsAndDS/AlgorithmsAndDS/ArraysAndHashing/Easy/ValidAnagram.cs) | Easy | O(N) | O(N) | - Save counts of chars of s1 in **Dict** \n - Iterate s2, check that every char exists in dict and decrease count \n - Iterate Dict and check that all count = 0 |
| [290. Word Pattern](AlgorithmsAndDS/AlgorithmsAndDS/ArraysAndHashing/Easy/IsSubsequence.cs) | Easy | O(N) | O(1) | - Hint |
| [392. Is Subsequence](AlgorithmsAndDS/AlgorithmsAndDS/ArraysAndHashing/Easy/WordPattern.cs) | Easy | O(N) | O(N) | - Use two indexes for interation s1 and s2. \n - Iterate s1 index when chars equals |
| [1299. Replace Elements with Greatest Element on Right Side](AlgorithmsAndDS/AlgorithmsAndDS/ArraysAndHashing/Easy/ReplaceElementsWithGreatestElementOnRightSide.cs) | Easy | O(N) | O(N) | - For the last iten, greatest = -1, for second from end = last item \n - Iterate array from end, set greatest (at first is last item) \n - Update greatest var if current is greater |
| [1929. Concatenation of Array](AlgorithmsAndDS/AlgorithmsAndDS/ArraysAndHashing/Easy/ConcatenationOfArray.cs) | Easy | O(N) | O(N) | - Create array with n*2 length \n - Fill values to i and i+n positions |

## Two Pointers

| Problem | Complexity | Time Complexity | Space Complexity | Solution Hints |
| ------- | ---------- | --------------- | ---------------- | -------------- |

## Sliding Window

| Problem | Complexity | Time Complexity | Space Complexity | Solution Hints |
| ------- | ---------- | --------------- | ---------------- | -------------- |
