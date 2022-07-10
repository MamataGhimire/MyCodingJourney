<Query Kind="Program" />

void Main()
{
	List<int>num=new List<int>(){-1,-2,-3,-4,0,0,0,0,1,4,5,6};
	int negative=0;
	int positive=0;
	int equal=0;
	 
	 for(int i=0;i<num.Count;i++)
	 {
	   if(num[i]<0)
	   {
	     negative++;
	   }
	    if(num[i]>0)
	   {
	     positive++;
	   }
	    if(num[i]==0)
	   {
	     equal++;
	   }
	 }
	 Console.WriteLine("negative integer ="+" "+negative);
	 Console.WriteLine("positive integer ="+" "+positive);
	 Console.WriteLine("number of integer equal to 0="+" "+equal);
}

// You can define other methods, fields, classes and namespaces here