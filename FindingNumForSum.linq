<Query Kind="Program" />

void Main()
{
	List<int>integers=new List<int>(){1,2,3,4,5,6,7,8,9};
	Console.WriteLine("Enter your number");
	int num=Convert.ToInt32(Console.ReadLine());
	int isFound=0;
	for(int i=0;i<integers.Count;i++)
	{
	  for(int j=i+1;j<integers.Count;j++)
	  {
	     int sum=integers[i]+integers[j];
		if(sum==num)
		{
		isFound=1;
		 Console.WriteLine("To get"+" "+num+" "+"we can add"+" "+" "+integers[i]+"and"+integers[j]);
		 break;
		}
	  }
	}
	
	
	if(isFound==0)
	Console.WriteLine("Not found");
	
}

// You can define other methods, fields, classes and namespaces here