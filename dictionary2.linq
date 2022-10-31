<Query Kind="Program" />

void Main()
{
 List<char>letter=new List<char>{'a','f','t','c','b'};
 
 for(char i='a';i<='z';i++)
 {
  char let=i;
   for(int j=0;j<letter.Count;j++)
   {
    if(let==letter[j])
	{
	 Console.WriteLine(letter[j]);
	}
   }
  
  
 }
  
}

// You can define other methods, fields, classes and namespaces here