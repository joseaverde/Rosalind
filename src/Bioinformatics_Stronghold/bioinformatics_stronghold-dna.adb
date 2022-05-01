with Ada.Text_IO;

package body Bioinformatics_Stronghold.DNA is

   function DNA (DNA_String : String) return Count_Array is
      Nucleotide : Nucleotide_Type;
   begin
      return Count : Count_Array
      do
         for Char of DNA_String loop
            case Char is
               when 'A' => Nucleotide := 'A';
               when 'C' => Nucleotide := 'C';
               when 'G' => Nucleotide := 'G';
               when 'T' => Nucleotide := 'T';
               when others => raise Constraint_Error with "Invalid Nucleotide";
            end case;
            Count(Nucleotide) := Count(Nucleotide) + 1;
         end loop;
      end return;
   end DNA;

   procedure Test (Name : String := "") is
      Count : Count_Array;
      File : Ada.Text_IO.File_Type;
   begin
      if Name = "" then
         Count := DNA(Ada.Text_IO.Get_Line);
      else
         Ada.Text_IO.Open(
            File => File,
            Name => Name,
            Mode => Ada.Text_IO.In_File);
         Count := DNA(Ada.Text_IO.Get_Line(File));
         Ada.Text_IO.Close(File);
      end if;
      for C of Count loop
         Ada.Text_IO.Put(C'Image);
      end loop;
      Ada.Text_IO.New_Line;
   end Test;

end Bioinformatics_Stronghold.DNA;
