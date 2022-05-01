( Counting DNA Nucleotides )

( 
   PROBLEM
   A string is simply an ordered collection of symbols selected from some
   alphabet and formed into a word; the length of a string is the number of
   symbols that it contains.
  
   An example of a length 21 DNA string [whose alphabet contains the symbols
   'A', 'C', 'G' and 'T'] is "ATGCTTCAGAAAGGTCTTACG".
  
      Given:
         A DNA string `s' of length at most 1000 nt
      Return:
         Four integers [separated by spaces] counting the respective number of
         times that the symbols 'A', 'C', 'G' and 'T' occur in `s'.
  
   SAMPLE DATASET
      Input:
      << AGCTTTTCATTCTGACTGCAACGGGCAATATGTCTCTGTGTGGATTAAAAAAAGAGTGTCTGATAGCAGC
   
      Output:
      >> 20 12 17 21

   AUTHOR : José Antonio Verde Jiménez  <joseaverde@protonmail.com>
)

\ There is a maximum of 1000 characters per string.
1000 CONSTANT MAX-LENGTH

\ The first cell contains the length, the next `length' byte cells contain the
\ actual string.
VARIABLE DNA-STRING MAX-LENGTH 1 + ALLOT

VARIABLE NT-COUNT 3 CELLS ALLOT
: NT-A NT-COUNT 0 CELLS + ;
: NT-C NT-COUNT 1 CELLS + ;
: NT-G NT-COUNT 2 CELLS + ;
: NT-T NT-COUNT 3 CELLS + ;

: DNA ( -- )
   \ Input and store the length of the string in the first cell of the variable
   NT-COUNT 4 CELLS 0 FILL
   DNA-STRING 1 CELLS + MAX-LENGTH ACCEPT 
   DNA-STRING !
   DNA-STRING @ 0 DO
      DNA-STRING 1 CELLS I + + C@
      CASE
         [CHAR] A OF 1 NT-A +! ENDOF
         [CHAR] C OF 1 NT-C +! ENDOF
         [CHAR] G OF 1 NT-G +! ENDOF
         [CHAR] T OF 1 NT-T +! ENDOF
         ." Invalid character: " DNA-STRING 1 CELLS I + + C@ . CR 1 ABORT
      ENDCASE
   LOOP

   CR NT-A ?  NT-C ?  NT-G ?  NT-T ? CR
;

DNA BYE
