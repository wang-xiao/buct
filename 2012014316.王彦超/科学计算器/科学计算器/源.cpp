#include<iostream>
#include<string>
#include<sstream>
#include<stddef.h>
#include<math.h>
#include<ctype.h>
#include<iomanip>
#include<stdlib.h>
#include<Windows.h>
using namespace std;

template<class T>
class calculator
{
public:
	calculator();
	calculator(const calculator& cal);
	calculator(const string& str);
	calculator(const char* c_str);
	template<class U>
	calculator(const U& u);
	string GetFormula();
	T Result();
	calculator operator = (const calculator& cal);
	template<class X, class U>
	X lexical_cast(U u);
private:
	T dummyCal(const string& str);
	T analyse();
	T ops(T lhs, T rhs, char op);
	string formula;
	T value;
};

template<class T>
calculator<T>::calculator() : formula(""), value(T())
{
}

template<class T>
calculator<T>::calculator(const calculator& cal) : formula(cal.formula), value(cal.value)
{
}

template<class T>
calculator<T>::calculator(const string& str) : formula(str)
{
	value = analyse();
}

template<class T>
calculator<T>::calculator(const char* c_str) : formula(string(c_str))
{
	value = analyse();
}

template<class T>
template<class U>
calculator<T>::calculator(const U& u)
{
	formula = u.formula;
	value = analyse();
}

template<class T>
inline string calculator<T>::GetFormula()
{
	return formula;
}

template<class T>
T inline calculator<T>::Result()
{
	return value;
}

template<class T>
calculator<T> calculator<T>::operator = (const calculator& cal)
{
	formula = cal.formula;
	value = cal.value;
	return *this;
}

template<class T>
T calculator<T>::ops(T lhs, T rhs, char op)
{
	switch (op)
	{
	case '+':
		return lhs + rhs;
	case '-':
		return lhs - rhs;
	case '*':
		return lhs * rhs;
	case '/':
		return lhs / rhs;
	case '%':
		return static_cast<T>(static_cast<int>(lhs) % static_cast<int>(rhs));
	case '^':
		return static_cast<T>(pow(static_cast<double>(lhs), static_cast<double>(rhs)));
	default:
		return 0;
	}
}

template<class T>
T calculator<T>::dummyCal(const string& str)
{
	string temp(str);
	temp.erase(0, temp.find_first_not_of(' '));
	size_t opPos;
	while ((opPos = temp.find_first_of("*/%^")) != string::npos || (opPos = temp.find_first_of("+-", 1)) != string::npos)
	{
		size_t lhsValPos = temp.find_last_not_of("0123456789.", opPos - 1) == string::npos ? 0 : temp.find_last_not_of("0123456789.", opPos - 1) + 1;
		if (temp[0] == '-' && temp.find_last_of("+-*/%^") != 0)
		{
			--lhsValPos;
		}
		size_t rhsValPos = temp.find_first_not_of("0123456789.", opPos + 2) == string::npos ? temp.size() - 1 : temp.find_first_not_of("0123456789.", opPos + 2) - 1;
		string LopR(temp, lhsValPos, rhsValPos - lhsValPos + 1);
		istringstream isstrm(LopR);
		T lhsVal, rhsVal;
		char op;
		isstrm >> lhsVal >> op >> rhsVal;
		T result = ops(lhsVal, rhsVal, op);
		temp.erase(lhsValPos, rhsValPos - lhsValPos + 1);
		temp.insert(lhsValPos, lexical_cast<string>(result));
		if (temp[0] == '-' && temp.find_last_of("+-*/%^") == 0)
		{
			break;
		}
		if (temp.find('e') != string::npos)
		{
			size_t ePos = temp.find('e');
			if (temp.find_first_of("+-*/%^", ePos) == string::npos && (temp.find_last_of('-', ePos) == 0 || temp.find_last_of("+-*/%^", ePos) == string::npos))
			{
				break;
			}
		}
	}
	return lexical_cast<T>(temp);
}

template<class T>
T calculator<T>::analyse()
{
	string temp1 = formula;
	while (temp1.find_first_of("()") != string::npos)
	{
		size_t rhsBracket = temp1.find(')');
		size_t lhsBracket = temp1.rfind('(', rhsBracket);
		string sResult(temp1, lhsBracket + 1, rhsBracket - lhsBracket - 1);
		T partResult = dummyCal(sResult);
		temp1.erase(lhsBracket, rhsBracket - lhsBracket + 1);
		temp1.insert(lhsBracket, lexical_cast<string>(partResult));
	}
	istringstream sstrm(temp1);
	T test;
	while (sstrm >> test);
	if (temp1 != lexical_cast<string>(test))
	{
		return dummyCal(temp1);
	}
	return lexical_cast<T>(temp1);
}

template<class T>
template<class X, class U>
X calculator<T>::lexical_cast(U u)
{
	stringstream sstrm;
	sstrm << u;
	X x;
	sstrm >> x;
	return x;
}

void title()
{
	cout.fill('=');
	cout << setw(24) << '=' << "计算器" << setw(24) << '=' << '\n' << endl;
	cout.fill(' ');
	cout << setw(18) << ' ' << "C清屏, X退出, N继续" << setw(12) << ' ' << endl;
	cout << "\n操作: 加 +\t减 -\t乘 *\t除 /\t模 %\t乘方 ^\n";
	cout << "\n请输入任意计算式:\n";
}

int main()
{
	title();
	string formula;
	int count = 1;
	while (1)
	{
		cout << "\n式子" << count << " : ";
		string input;
		cin >> input;
		if (input.find_first_not_of("CNXcnx0123456789.+-*/%^()") != string::npos)
		{
			cout << "输入中有错误, 请重新输入!\n";
			cin.clear();
			continue;
		}
		if (input.find_first_of("Cc") != string::npos)
		{
			system("cls");
			formula.clear();
			count = 1;
			title();
		}
		else if (input.find_first_of("Xx") != string::npos)
		{
			break;
		}
		else
		{
			formula += input;
			calculator<double> cal(formula);
			++count;
			cout << "结果" << count << " : " << formula << " = " << cal.Result() << endl;
			formula = cal.lexical_cast<string>(cal.Result());
		}
	}
	cout << "程序结束..." << endl;
	Sleep(3000);
	return 0;
}