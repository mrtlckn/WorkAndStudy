#include<iostream>
#include <string>
#include<stack>
#include<math.h>
#include<sstream>
#include<vector>

using namespace std;

///----------------------------------------------------------------------------------
/// Given an expression in infix-notation, converts it to a string in post-fix notation 
/// 
string Infix2Postfix(string& s) {
    // Fill this in
    stack <char> st;
    string result;
    for (int i = 0; i < s.size(); i++)
    {
        while (s[i] >= '0' && s[i] <= '9')
        {
            result.push_back(s[i]);
            i++;
        }
        result.push_back(' ');

        if (s[i] == '(')
        {
            st.push(s[i]);
        }
        else if (s[i] == ')')
        {
            while (st.top() != '(')
            {
                result.push_back(st.top());
                result.push_back(' ');
                st.pop();
            }
            st.pop();
        }
        else if (s[i] == '+' || s[i] == '-')
        {
            if (st.empty() || st.top() == '(')
            {
                st.push(s[i]);
            }
            else
            {
                while (st.top() == '+' || st.top() == '-' || st.top() == '*' || st.top() == '/' || st.top() == '(')
                {
                    while (!st.empty() || st.top() != '(')
                    {
                        //cout << st.top() << "";
                        result.push_back(st.top());
                        result.push_back(' ');
                        st.pop();
                        if (st.empty() || st.top() == '(')
                        {
                            break;
                        }
                    }
                    if (st.empty() || st.top() == '(')
                    {
                        break;
                    }
                }
                st.push(s[i]);
            }


        }
        else if (s[i] == '*' || s[i] == '/')
        {
            st.push(s[i]);
        }
    }
    while (!st.empty())
    {
        result.push_back(st.top());
        st.pop();
    }
    return result;
} // end-Infix2Postfix

  ///----------------------------------------------------------------------------------
  /// Given a string in post-fix notation, evaluates it and returns the result
  /// 
int EvaluatePostfixExpression(string& s) {
    stack <int>numbers;
    int final;

    for (int i = 0; i < s.length(); i++)
    {
        if (s[i] >= '0' && s[i] <= '9')//for finding numbers 
        {
            string item;
            while (s[i] >= '0' && s[i] <= '9')
            {
                item.push_back(s[i]);
                i++;
            }
            stringstream ss(item);
            int numbers_;
            ss >> numbers_;
            numbers.push(numbers_);//
        }
        if (s[i] == '+' || s[i] == '-' || s[i] == '*' || s[i] == '/')
        {
            if (s[i] == '+')
            {
                int sum = 0;
                sum += numbers.top();
                numbers.pop();
                sum += numbers.top();
                numbers.pop();
                numbers.push(sum);
            }
            if (s[i] == '-')
            {
                double sum = 0.0;
                sum -= numbers.top();
                numbers.pop();
                sum += numbers.top();
                numbers.pop();
                numbers.push(sum);
            }
            if (s[i] == '*')
            {
                double sum = 1;
                sum *= numbers.top();
                numbers.pop();
                sum *= numbers.top();
                numbers.pop();
                numbers.push(sum);
            }
            if (s[i] == '/')
            {
                double sum = 1;
                sum /= numbers.top();
                numbers.pop();
                sum *= numbers.top();
                numbers.pop();
                numbers.push(sum);
            }
        }
    }
    final = numbers.top();
    return final;
} // end-EvaluatePostfixExpression