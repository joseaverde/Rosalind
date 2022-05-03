( Rabbits and Recurrence Relations )

( 
   PROBLEM
   A sequence is an ordered collection of objects [usually numbers], which are
   allowed to repeat. Sequences can be finite or infinite. Two examples are the
   finite sequence [1, 4, 2, 1] and the infinite sequence of odd numbers
   [1,3,5,7,9...]. We use the notation `a_n' to represent the `n'-th term of a
   sequence

   A recurrence relation is a way of defining the terms of a sequence with
   respect to the values of previous terms. In the case of Fibonacci's rabbits
   from the introduction, any given month will contain the rabbits that were
   alive the previous month plus any new offspring. A key observaction is that
   the number of offspring in any month is equal to the number of rabbits that
   were alive two months prior. As a result, if F_n represents the number of
   rabbit pairs alive after the `n'-th month, then we obtain the Fibonacci
   sequence having the terms F_n that are defined by the recurrence relation:

                      | F_n = F_[n-1] + F_[n-2]
                      { F_1 = 1
                      | F_2 = 1

   Although the sequence bears Fibonacci's name, it was known to Indian
   mathematicians over two millennia ago.

   When finding the `n'-th term of a sequence defined by a recursive relation,
   we can simply use the recurrence relation to generate terms for
   progressively larger values of `n'. This problem introduces us to the
   computational technique of dynamic programming, which successively builds up
   solutions by using the answers of smaller cases.

      Given:
         Positive integers n <= 40 and k <= 5

      Return:
         The total number of rabbit pairs that will be present after `n' months
         if we begin with 1 pair and in each pair of reporduction-age rabbbits
         produces a litter of k rabbit pairs [instead of only 1 pair].

   SAMPLE
      Input:
      << 5 3
      Output:
      >> 19

   AUTHOR : José Antonio Verde Jiménez  <joseaverde@protonmail.com>
)

: FIB ( n k -- f )
   \ The stack will contain ( n k newborn old )
   1 0
   3 PICK 1- 0 DO
      \ Olds give birth and are the new newborns
      2 PICK OVER * -ROT
      \ The newborns grow to be adults
      +
   LOOP
   + ROT DROP SWAP DROP
;


29 2 FIB . CR BYE
