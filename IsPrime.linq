<Query Kind="Program" />

void Main()
{
	Console.WriteLine("your number");
	int num=Convert.ToInt32(Console.ReadLine());
	List<int>prime=new List<int>();
	for(int i=2;i<num;i++)
	{ int Count=0;
	  for(int j=2;j<i;j++)
	  {
	        if(i%j==0 & i!=j)
	         {
	           Count=1;
	         }
	  }
	  if(Count==0)
	  {
	    prime.Add(i);
	  }
	  Count=0;
	
	}
	prime.Add(num);
	
	for(int i=0;i<prime.Count;i++)
	{
	  Console.WriteLine(prime[i]);
	}
}




// You can define other methods, fields, classes and namespaces here