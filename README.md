# Unexpected Behavior with Mutable Variables and References in F#

This example demonstrates a potential pitfall when working with mutable variables and references in F#.  A function that modifies a mutable variable referenced by a reference does not automatically update the value that the reference refers to outside of the function's scope.  This can lead to unexpected results if not handled properly.

The `bug.fs` file contains the code exhibiting the problem.  The solution, `bugSolution.fs`, demonstrates how to correctly update the value and reference, fixing the bug.

## How to reproduce
1.  Compile and run the code in `bug.fs` using a F# compiler.
2.  Observe that the output is 2 1, not the expected 2 2.

## Solution
The solution involves correctly managing the reference within the function, ensuring that the modified value is also reflected back to the reference.