<Query Kind="Program" />

void Main()
{
	List<string>name=new List<string>{"hydrogen","helium","lithium","berylium","boron","cardon","nitrogen","oxygen","fluorine",
	"neon","sodium","magnesium","aluminum","silicon","phosporus","sulphur","chloine","argon","potassium","calcium"};
	Console.WriteLine("enter your atomic num");
	int number=Convert .ToInt32(Console.ReadLine());
	
	
	int protons=number;
	int electron=number;
	int neutron=0;
	if(number==1||number==4||number==7||number==18)
	{ 
	   if(number==4) neutron=5;
	   if(number==7) neutron=7;
	   if(number==18) neutron=22;
	}
	else
	{
	  if(number%2==0)  neutron=number;
	  else neutron=number+1;
	}
	
	int At_Mass=protons+neutron;
	
	Console.WriteLine("your element is"+" "+name[number-1]);
	Console.WriteLine(" no.of protons="+" "+protons);
	Console.WriteLine(" no.of electrons="+" "+electron);
	Console.WriteLine(" no.of neutron="+" "+neutron);
	Console.WriteLine("Atomic mass="+" "+At_Mass);
	
	
	

	 
	

	
}

// You can define other methods, fields, classes and namespaces here