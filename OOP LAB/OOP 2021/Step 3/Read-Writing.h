#pragma once
#include <stdlib.h>
#include <iostream>
#include <fstream>
#include <string>

#include "Engine.h"
#include "Tank.h"

#define MAX_SIZE 200

using namespace std;

class PrintClass {
public:
	string Commands[MAX_SIZE];
	int sayac = 0;
	ifstream indata;
	ofstream outdata;
	string line;
	void PrintMethod() {

		indata.open("input.txt");
		if (indata.is_open())
		{
			while (getline(indata, line))
			{
				cout << line << '\n';
				Commands[sayac] = line;
				sayac++;
			}
			indata.close();
		}
		else cout << "Unable to open file";
	}

	void WritingMethod(string fonksiyondangelen) {
		outdata.open("output.txt");
		if (!outdata) { // file couldn't be opened
			cerr << "Error: file could not be opened" << endl;
			exit(1);
		}

		outdata << fonksiyondangelen << endl;

		outdata.close();
	}

	void Commandsmethod() {
		int i = 0;

		for (i = 0; i <= sayac; i++) {
			cout << Commands[i] << endl;
		}
	}
};