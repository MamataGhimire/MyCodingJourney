#include <iostream>
using namespace std;
int main() {
   
   int num[]={-2,-3,-1,-4,-6};
   int size=sizeof(num)/sizeof(num[0]);
   int maxi=num[0];
   int sum=0;
  for(int i=0;i<size;i++)
  {
       sum=sum+num[i];
       if(maxi<sum)
       {
           maxi=sum;
       }
       
       if(sum<0)
       {
           sum=0;
       }
       
  }
  cout<<maxi;
  

    return 0;
}
