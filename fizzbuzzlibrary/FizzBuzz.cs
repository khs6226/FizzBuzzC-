namespace fizzbuzzlibrary;
public class FizzBuzz
{
  public string GetResult(int nmbr)
  {
    string result = "";

    if (nmbr > 100) throw new Exception("Number exceeds 100");
    if (nmbr < 0) throw new Exception("Negative number not allowed");


    for (int ndx = 1; ndx < nmbr + 1; ndx++)
    {
      if (ndx % 15 == 0)
      {
        result += "fizzbuzz ";
      }
      else
      if (ndx % 3 == 0)
      {
        result += "fizz ";
      }
      else
      if (ndx % 5 == 0)
      {
        result += "buzz ";
      }
      else
      {
        result += ndx.ToString() + " ";
      }
    }
    return result;
  }
}
