<Query Kind="Program" />

void Main()
{

   List<int>number=new List<int>(){20,12,18,16,10};
	int a=number[0],b=0,c=0,d=0;
	for(int i=0;i<number.Count;i++)
	{
	  b=number[i];
	 
	  for(int j=i;j<number.Count;j++)
	  {
	       if (number[j]<number[i] && number[j]<a)
	          {
	            a=number[j];
		        d=j;
		      }
			  c=b;
	 
	 
	  }
	   number[i]=a;
	  number[d]=c;
	 
	  
    }
	
	for(int i=0;i<number.Count;i++)
	{
	  Console.WriteLine(number[i]);
	}
}

	// You can define other methods, fields, classes and namespaces here
