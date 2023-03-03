<Query Kind="Program" />

void Main()
{
	
	Stack<int> myStack = new Stack<int>();
myStack.Push(22);
myStack.Push(29);
myStack.Push(12);
myStack.Push(14);
 List<int>number=new List<int>();

 for(int i=0;i<myStack.Count;i++)
 {
 int mini=myStack.ElementAt(i);
    for(int j=0;j>myStack.Count;j++)
	{
	 if(mini>=myStack.ElementAt(j));
	 mini=myStack.ElementAt(j);
	}
	number.Add(mini);
	
	
	
 }
 
 
 
 
 
 
 
 
 
 
 
	
}

// You can define other methods, fields, classes and namespaces here