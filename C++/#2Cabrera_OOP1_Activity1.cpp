#include <iostream>
using namespace std;
int main ()
{
	system ("color 30");
	
	string name, id, pt;
	float rate, hr, net, ts, np, mg, sss, hdmf, ph, td, tax;

	
	 cout << " - - - - H R  D E P A R T M E N T  P A Y R O L L  S Y S T E M - - - - " <<endl;
	 cout << endl;
	 
	 cout << "Enter Name: ";
	 getline (cin, name);
	 cout << "\nEnter Employee ID: ";
	 getline (cin, id);
	 cout << "\nEnter Position Title: ";
	 getline (cin, pt);
	 
	 cout << "\n\nEnter Rate: ";
	 cin >> rate; 
	 cout << "\nEnter Work Hours: ";
	 cin >> hr;
	 
	 cout <<endl;
	 cout << "- - - - D E D U C T I O N S - - - -";
	 cout <<endl;
	 cout << "\nSSS: 150";
	 cout << "\nHDMF: 100";
	 cout << "\nPhil Health: 50";
	 cout <<endl;
	 cout <<endl;
	 
	 cout << "- - - - T O T A L  S A L A R Y - - - -" <<endl;
	 
	ts = (hr * rate); 
	tax = .20 * ts;
	 
	 sss = 150;
	 hdmf = 100;
	 ph = 50;
	 
	 mg = (sss+ hdmf +ph); 
	
	 cout << "Total Salary: Php " <<ts <<endl;
	 
	 cout << "\n- - - - N E T  P A Y - - - -" <<endl;
	 
	 
	 td = mg + tax;
	
	 np = ts - (mg + tax);
	 
	 cout << "Net Pay: Php " <<np <<endl;
	 
	 system ("pause");
	 system ("cls");
	 
	 cout << "- - - - S U M M A R Y - - - -" <<endl;
	 cout << endl;
	 cout << "Employee Name: " <<name <<endl;
	 cout << "\nEmployee ID: " <<id <<endl;
	 cout << "\nTotal Salary: Php " <<ts <<endl;
	 cout << "\nTotal Deductions: Php " <<td <<endl;
	 cout << "\nNet Pay: Php " <<np <<endl;
	 
	 
	
	
	

	system ("pause");
	return 0;
}
