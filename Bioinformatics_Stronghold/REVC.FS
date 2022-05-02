( Complementing a Strand of DNA )

( 
   PROBLEM
   In DNA strings, symbols 'A' and 'T' are complements of each other, as are
   'C' and 'G'.

   The reverse complement of DNA string `s' is the string is `sc' formed by
   reversing the symbols of `s', then taking the complement of each symbol
   [e.g., the reverse complement of "GTCA" is "TGAC"].

      Given:
         A DNA string `s' of length at most 1000 bp.

      Return:
         The reverse complement `sc' of s.
)

1000 CONSTANT MAX-LENGTH
VARIABLE DNA-STRING MAX-LENGTH ALLOT

: REVC ( -- )
   DNA-STRING 1 CELLS + MAX-LENGTH ACCEPT  DNA-STRING !
   CR
   -1 DNA-STRING @ 1- DO
      DNA-STRING 1 CELLS I + + C@
      CASE
         [CHAR] A OF [CHAR] T EMIT ENDOF
         [CHAR] T OF [CHAR] A EMIT ENDOF
         [CHAR] C OF [CHAR] G EMIT ENDOF
         [CHAR] G OF [CHAR] C EMIT ENDOF
         ." Error unknown character!" 1 ABORT
      ENDCASE
   1 -LOOP
   CR
;

REVC BYE
