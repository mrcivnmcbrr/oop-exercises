#include <iostream>
using namespace std;
int main ()
{
    int num;
	
    cout << "- - - - M U L T I P L I C A T I O N  T A B L E - - - -" <<endl;
    
	cout << "\nEnter a number: ";
    cin >> num;

    for (int i = 1; i <= 10; ++i) 
	{
        cout << num << " * " << i << " = " << num * i << endl;
    }


	
	
	system("pause");
	return 0;
}
