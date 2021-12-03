//152120171030	Ahmet Telçeken
//152120171036	Mehmet Cemil Karadaþ
#ifndef _POLYNODE_H_
#define _POLYNODE_H_

// Each polynomial node consists of a coefficient and an exponent
struct PolyNode {
	double coef;             // Coefficient
	int exp;                 // Exponent
	struct PolyNode* next;   // Next polynomial node
}; //end-PolyNode

#endif