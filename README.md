# MajorityElement-in-C-Sharp

In this program, a function for the Majority Element problem is implemented, an interview question by Google.

When initially solving for the function, assumptions made were for the most part in-line with the original question's assumptions:
1) The array is always non-empty,
2) the majority element always exists in the array,
3) the majority element is the element that appears more than the floor(n/2) times.

Given these assumptions, no check was made as to whether the majority element actually appears more than floor(n/2) times; however, a check can easily be added at the end of the function.
