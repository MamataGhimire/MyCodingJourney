<Query Kind="Program" />

void Main()
{
	Console.WriteLine("your number");
	int num=Convert.ToInt32(Console.ReadLine());
	List<int>PrimeNum=new List<int>();
	List<int>Factors=new List<int>();
	PrimeNum=Num(num);
	int i=0;
	while(num!=1)
	{
	  
	  while(num%PrimeNum[i]==0)
	  {
	    num=num/PrimeNum[i];
		Factors.Add(PrimeNum[i]);
	  }
	 
	  if(num==1)
	  {
	    break;
	  }
	  i++;
	}
	
	for(int j=0;j<Factors.Count;j++)
	{
		
	 Console.WriteLine(Factors[j]);
	}
}

// You can define other methods, fields, classes and namespaces here





List<int> Num(int num)
{

List<int>prime=new List<int>();
	for(int i=2;i<num;i++)
	{ int Count=0;
	  for(int j=2;j<=i;j++)
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
	
	return prime;
	
	
}

