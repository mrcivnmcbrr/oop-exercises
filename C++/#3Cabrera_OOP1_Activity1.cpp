#include <iostream>
using namespace std;
int main ()
{
	string  name;
	int age, bdate;
	
	cout << " - - - - S A N  B E D A  L A W  S C H O O L - - - - " <<endl;
	cout << "\nEnter Student Name: ";
	getline (cin, name);
	cout << "\nEnter Year of Brith: "; 
	cin >> bdate;
	
	age = (2020 - bdate);
	
	
	
	if (age <= 17)
	{
		cout << "\nAge: " <<age <<endl;
		cout << "\nYou are not eligible to vote!" <<endl;
	}
	else 
	{
		cout << "\nAge: " <<age <<endl;
		cout << "\nYou are eligible to vote." <<endl;
	}
	
	
	
	
	system ("pause");
	return 0; 
}
