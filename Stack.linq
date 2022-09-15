<Query Kind="Program" />

void Main()
{
	int[] arry= new int[100] ;
	for(int i=0;i<5;i++)
	{
	 int  num=Convert. ToInt32(Console.ReadLine());
	 push(arry,num);
	}
	pop(arry);
	
}



// You can define other methods, fields, classes and namespaces here
void push(int[] arry,int num)
{
  for(int i=0;i<100;i++)
  {
    if(arry[i]==0)
	{
	  arry[i]=num;
	  break;
	}
	
  }
}

void pop(int[] arry)
{
   for(int i=0;i<100;i++)
  {
    if(arry[i]==0)
	{
	  Console.WriteLine(arry[i-1]);
	  break;
	}
	
  }
}

