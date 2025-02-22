# F# Mutable Variable Swap Bug

This repository demonstrates a common pitfall in F# when working with mutable variables and functions.  The `swap` function, intended to exchange the values of two mutable variables, doesn't behave as expected due to pass-by-reference semantics.  The solution shows how to correctly implement a swap function that works as intended.

## Bug
The original `bug.fs` file contains a function that attempts to swap two mutable variables.  However, because mutable variables are passed by reference, the function modifies the original variables directly, leading to unexpected results.

## Solution
The `bugSolution.fs` file demonstrates the correct approach using a tuple to achieve the desired swap functionality.  This approach avoids the issue of pass-by-reference by passing values instead of references. 