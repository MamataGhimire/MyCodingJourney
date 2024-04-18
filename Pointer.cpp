#include <iostream>
using namespace std;
int main() {
    
    int M=2;
    int *ptr=&M;
    
    cout<<"Value of M:"<<*ptr<<endl;
    cout<<"location of M:"<<&ptr;
    
    return 0;
}
