<Query Kind="Program" />

void Main()
{
  List<int>Value=new List<int>(){1,4,6,8,12,13,4,67};
    int minimum= Value[0];
		   int maximum=Value[0];
  for(int i=1;i<Value.Count;i++)
  {
    if(Value[i]<minimum)
	{
	   minimum=Value[i];
	}
	if(Value[i]>maximum)
	{
	  maximum=Value[i];
	}
  }
    
	Console.WriteLine("minimum="+minimum);
	Console.WriteLine("maximum="+maximum);
	
  
  
  }

// You can define other methods, fields, classes and namespaces here