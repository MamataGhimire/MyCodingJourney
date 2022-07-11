<Query Kind="Program" />

void Main()
{
	
	List<string>name=new List<string>(){"salina","seema","nabina","monica","sneha","sam"};
	 int count=0;
	 string sname=name[0];
	for(int i=0;i<name.Count;i++)
	{
	  if(name[i].Length<sname.Length)
	  {
	  		sname=name[i];
	  }
	  
	}
	
	
	Console.WriteLine(sname);
}

// You can define other methods, fields, classes and namespaces here
