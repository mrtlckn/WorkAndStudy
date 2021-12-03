//152120171030	Ahmet Telçeken
//152120171036	Mehmet Cemil Karadaþ
#include<iostream>
#include <stdio.h>
#include<string>
#include<sstream>
#include<math.h>


#include "Poly.h"
using namespace std;
// ------------------------------------------------ -
// Creates a polynomial from an expression.
// Returns a pointer to the first PolyNode in the list (head of the list)
//
// Expression will be of the following sort:
// Ex1: 2.3x^4 + 5x^3 - 2.64x - 4
// Ex2: -4.555x^10 - 45.44
// Ex3: x^6 + 2x^4 - x^3 - 6.3x + 4.223 
// Ex4: 34
// Ex5: -x+1
// Ex6: -3x^4    +   4x
// Ex7: -2x  - 5
//
PolyNode *CreatePoly(char *expr){	
	PolyNode* head = NULL;
	PolyNode* tail = new PolyNode;
	string temp;
	string x;
	temp = expr;
	for (int i = 0; temp[i] != '\0'; i++)
	{
		if (temp[i] && temp[i] != ' ')		
			x.append(temp, i, 1);		
	}
	for (int i = 0; x[i] != '\0'; i++)
	{
		int sign = -1, flg = 0;
		int exps;
		double coefs;
		string exp, coef;

		//In this part,we find coefficient
		while (x[i] == '-' || x[i] == '+' || i == 0)
		{
			flg = 88;
			while (x[i] != 'x' && x[i])
			{
				coef.append(x, i, 1);
				i++;
				sign += 1;
				flg++;
			}
			if (sign == -1)
			{
				sign++;
				break;
			}
		}
		if (flg == 89 && x[i - 1] != '-')
		{
			if (x[i - 1] != '+')
			{
				sign++;
			}
		}
		if (sign == 0)
		{
			if (x[0] == 'x' && i == 0)
			{
				coefs = 1;
			}
			else if (x[i - 1] == '-')
			{
				coefs = -1;
			}
			else
			{
				coefs = 1;
			}

		}
		else if (flg == 88)
		{
			coefs = 1;
		}
		else
		{
			stringstream ss(coef);
			ss >> coefs;
		}


		int flg2 = -1;
		while (x[i] == 'x' || x[i] == '^')
		{
			i++;
			flg2 += 1;
			if (x[i] == 'x' || x[i] == '^')
			{
				flg = 99;
			}
		}
		if (flg2 == -1)
		{
			exps = 0;
		}
		else if (flg2 == 0)
		{
			exps = 1;
		}
		else if (flg == 99)
		{
			while (x[i] != '+' && x[i] != '-')
			{
				exp.append(x, i, 1);
				i++;
			}
			stringstream ss(exp);
			ss >> exps;
		}
		PolyNode* node = new PolyNode;
		node->coef = coefs;
		node->exp = exps;
		node->next = NULL;
		if (head == NULL)
		{
			head = node;
			tail = node;
		}
		else
		{
			tail->next = node;
			tail = tail->next;
		}
		i--;
	}
	return head;
} //end-CreatePoly

/// -------------------------------------------------
/// Walk over the poly nodes & delete them
///
void DeletePoly(PolyNode* poly) {
	// Fill this in
	while (poly)
	{
		PolyNode* pointer = poly;
		poly = poly->next;
		delete pointer;
	}
	
} // end-DeletePoly
	
//-------------------------------------------------
// Adds a node (coefficient, exponent) to poly. If there already 
// is a node with the same exponent, then you simply add the coefficient
// to the existing coefficient. If not, you add a new node to polynomial
// Returns a pointer to the possibly new head of the polynomial.
//
PolyNode* AddNode(PolyNode *head, double coef, int exp){
	// Fill this in
	PolyNode* node = new PolyNode();
	node->coef = coef;
	node->exp = exp;
	node->next = NULL;

	//Liste boþsa baþa döndü
	if (head == NULL)
		return node;
	else if (head->exp == exp) {
		head->coef += coef;
		if (head->coef == 0)
			return head->next;
	}
	else if (head->exp < exp) {
		node->next = head;
		return node;
	}
	else {
		PolyNode* trv = head;
		while (trv != NULL) {
			//Liste Sonuna gelindi
			if (trv->next == NULL) {
				trv->next = node;
				break;
			}
			//ayný üs bulununca
			else if (trv->next->exp == exp) {
				trv->next->coef += coef;
				if (trv->next->coef == 0)
					trv->next = trv->next->next;
				break;
			}
			else if (trv->next->exp < exp) {
				node->next = trv->next;
				trv->next = node;
				break;
			}
			trv = trv->next;
		}
	}
	return head;
}
// end-AddNode

//-------------------------------------------------
// Adds two polynomials and returns a new polynomial that contains the result
// Computes: poly3 = poly1 + poly2 and returns poly3
//
PolyNode *Add(PolyNode *poly1, PolyNode *poly2){
	// Fill this in
	struct PolyNode* ptr1 = poly1;
	struct PolyNode* ptr2 = poly2;
	struct PolyNode* poly3 = NULL;
	while (ptr1 != NULL && ptr2 != NULL) {
		if (ptr1->exp == ptr2->exp) {
			poly3 = AddNode(poly3, ptr1->coef + ptr2->coef, ptr1->coef);
			ptr1 = ptr1->next;
			ptr2 = ptr2->next;
		}
		else if (ptr1->exp > ptr2->exp) {
			poly3 = AddNode(poly3, ptr1->coef, ptr1->exp);
			ptr1 = ptr1->next;
		}
		else if (ptr1->exp < ptr2->exp) {
			poly3 = AddNode(poly3, ptr2->coef, ptr2->exp);
			ptr2 = ptr2->next;
		}
		while (ptr1 != NULL) {
			poly3 = AddNode(poly3, ptr1->coef, ptr1->exp);
			ptr1 = ptr1->next;
		}
		while (ptr2 != NULL) {
			poly3 = AddNode(poly3, ptr2->coef, ptr2->exp);
			ptr2 = ptr2->next;
		}

	}
	return poly3;
} //end-Add

//-------------------------------------------------
// Subtracts poly2 from poly1 and returns the resulting polynomial
// Computes: poly3 = poly1 - poly2 and returns poly3
//
PolyNode *Subtract(PolyNode *poly1, PolyNode *poly2){
	PolyNode* subtract = NULL;

	while (poly1 != NULL)
	{
		subtract = AddNode(subtract, poly1->coef, poly1->exp);
		poly1 = poly1->next;
	}

	while (poly2 != NULL)
	{
		subtract = AddNode(subtract, -poly2->coef, poly2->exp);
		poly2 = poly2->next;
	}
	return subtract;
} //end-Substract

//-------------------------------------------------
// Multiplies poly1 and poly2 and returns the resulting polynomial
// Computes: poly3 = poly1 * poly2 and returns poly3
//
PolyNode *Multiply(PolyNode *poly1, PolyNode *poly2){
	PolyNode* multiply = NULL;
	PolyNode* temp = poly2;


	while (poly1 != NULL)
	{
		poly2 = temp;
		while (poly2 != NULL)
		{

			multiply = AddNode(multiply, poly1->coef * poly2->coef, poly1->exp + poly2->exp);
			poly2 = poly2->next;
		}

		poly1 = poly1->next;
	}

	return multiply;
} //end-Multiply

//-------------------------------------------------
// Evaluates the polynomial at a particular "x" value and returns the result
//
double Evaluate(PolyNode *poly, double x){
	double y = 0;

	while (poly != NULL)
	{
		y += poly->coef * pow(x, poly->exp);
		poly = poly->next;
	}
	return y;
} //end-Evaluate

//-------------------------------------------------
// Computes the derivative of the polynomial and returns it
// Ex: poly(x) = 3x^4 - 2x + 1-->Derivative(poly) = 12x^3 - 2
//
PolyNode *Derivative(PolyNode* poly){
	PolyNode* temp = poly;

	while (temp != NULL)
	{
		if (temp->exp == 0)
		{
			temp->coef = 0;
			break;
		}
		double c;
		c = temp->exp * temp->coef;
		temp->coef = c;
		temp->exp--;
		temp = temp->next;
	}

	return poly;
} //end-Derivative

//-------------------------------------------------
// Plots the polynomial in the range [x1, x2].
// -39<=x1<x2<=39
// -12<=y<=12
// On the middle of the screen you gotta have x & y axis plotted
// During evaluation, if "y" value does not fit on the screen,
// then just skip it. Otherwise put a '*' char depicting the curve
//
void Plot(PolyNode *poly, int x1, int x2){
	for (int y = 12; y >= -12; y--)
	{
		for (int x = x1; x < x2; x++)
		{
			if (x % 5 == 0 && y == 0)
			{
				cout << "+";
			}
			else if (y % 5 == 0 && x == 0)
			{
				cout << "+";
			}
			else if (x == 0)
			{
				cout << "|";
			}
			else if (y == 0)
			{
				cout << "-";
			}
			else if (nearbyint(Evaluate(poly, x)) == y)
			{
				cout << "*";
			}
			else
			{
				cout << " ";
			}
		}
		cout << endl;
	}
} //end-Plot

//-------------------------------------------------
// Prints a polynomial in a nicely formatted manner
//
void Print(PolyNode *poly){
	if (poly == NULL){printf("<NULL>\n"); return;}

	printf("<");
	PolyNode *p = poly;
	while (p != NULL){
		if (p->exp == 0){
			printf("%+-3.1f", p->coef);

		} else if (p->exp == 1){
			if (p->coef == 1.0) printf("+x ");
			else if (p->coef == -1.0) printf("-x ");
			else printf("%+-3.1fx ", p->coef);

		} else {
			if (p->coef == 1.0) printf("+x^%-2d ", p->exp);
			else if (p->coef == -1.0) printf("-x^%-2d ", p->exp);
			else printf("%+-3.1fx^%-2d ", p->coef, p->exp);
		} //end-else

		p = p->next;
	} // end-while

	printf(">\n");	
} //end-Print	
