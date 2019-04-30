/*
Write a function to convert a name into initials. This kata strictly takes two words with one space in between them.
The output should be two capital letters with a dot seperating them.
It should look like this:

Sam Harris => S.H

Patrick Feeney => P.F
*/

public class Kata
{
  public static string AbbrevName(string name)
  {
    
    // Split the string into components within a new variable in uppercase letters
    var names = name.ToUpper().Split(' ');
    
    // Return the Characters from index 0 of each componenet within names
    return string.Join(".", names[0][0], names[1][0]);
  }
}