-- PROBLEM
-- A string is simply an ordered collection of symbols selected from some
-- alphabet and formed into a word; the length of a string is the number of
-- symbols it contains.
--
-- An example of a length 21 DNA string (whose alphabet contains the symbols
-- 'A', 'C', 'G' and 'T') is "ATGCTTCAGAAAGGTCTTACG".
--
--    Given: A DNA string `s' of length at most 1000 nt.
--    Return: Four integers (separated by spaces) counting the respective
--    number of times that the symbols 'A', 'C', 'G' and 'T' occur in `s'.
--
-- SAMPLE
--    << AGCTTTTCATTCTGACTGCAACGGGCAATATGTCTCTGTGTGGATTAAAAAAAGAGTGTCTGATAGCAGC
--    >> 20 12 17 21
--
-- https://rosalind.info/problems/dna/
--
package Bioinformatics_Stronghold.DNA is

   type Nucleotide_Type is ('A', 'C', 'G', 'T');
   type Count_Array is array (Nucleotide_Type) of Natural with
      Default_Component_Value => 0;

   function DNA (DNA_String : String) return Count_Array;

   procedure Test (Name : String := "");

end Bioinformatics_Stronghold.DNA;
