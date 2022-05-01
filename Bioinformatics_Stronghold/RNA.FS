( Transcribing DNA into RNA )

( 
   PROBLEM
   An RNA string is a string formed form the alphabet 'A', 'C', 'G' and 'U'.

   Given a DNA string `t' corresponding to a coding strand, its transcribed RNA
   string `u' is formed by replacing all occurrences of 'T' in `t' with 'U' in
   `u'.

      Given:
         A DNA string `t' having length at most 1000 nt
      Return:
         The transccribed RNA string of `t'

   SAMPLE DATASET
      Input:
      << GATGGAACTTGACTACGTAAATT

      Output:
      >> GAUGGAACUUGACUACGUAAAUU

   AUTHOR : José Antonio Verde Jiménez  <joseaverde@protonmail.com>
)

1000 CONSTANT MAX-LENGTH
VARIABLE DNA-STRING MAX-LENGTH CELLS ALLOT

: RNA
   DNA-STRING 1 CELLS + MAX-LENGTH ACCEPT DNA-STRING !
   CR
   DNA-STRING @ 0 DO
      DNA-STRING 1 CELLS I + + C@
      DUP [CHAR] T = IF
         DROP [CHAR] U
      THEN
      EMIT
   LOOP
   CR
;

RNA BYE
