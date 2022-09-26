#include <iostream>
using namespace std;
int main ()
{
	system ("color 47");
	
	string sn, fn, ln, course, de;
	char ans;
	
	cout << "Welcome to the Student Portal of San Beda University-Manila." <<endl;
	cout << "------------------------------------------------------------" <<endl;
	cout <<endl;
	
	cout << "Enter your Student Number: ";
	getline (cin, sn);
	cout << "\nEnter your First Name: ";
	getline (cin, fn);
	cout << "\nEnter your Last Name: ";
	getline (cin, ln);
	cout << "\nEnter your Course: ";
	getline (cin, course);
	cout << "\nEnter Date Enrolled: ";
	getline (cin, de);
	
	cout << "\n\nDo you want to proceed? <Y/N>: ";
	cin >> ans;

	if (ans == 'Y' || ans == 'y')
		{
		cout << " \n\n- - - - S T U D E N T  S U M M A R Y - - - - " << endl;
		cout <<endl;
		cout << "Student Number: " <<sn <<endl;
		cout << "First Name: " <<fn <<endl;
		cout << "Last Name: " <<ln <<endl;
		cout << "Course: " <<course <<endl;
		cout << "Date Enrolled: " <<de <<endl;
		}
		
	else 
		{
			cout << "Thank you ... Have a nice day!" <<endl; 
		}
	system ("pause");
	return 0;
}
