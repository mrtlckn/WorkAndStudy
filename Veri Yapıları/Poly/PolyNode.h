//152120171030	Ahmet Tel�eken
//152120171036	Mehmet Cemil Karada�
#ifndef _POLYNODE_H_
#define _POLYNODE_H_

// Each polynomial node consists of a coefficient and an exponent
struct PolyNode {
	double coef;             // Coefficient
	int exp;                 // Exponent
	struct PolyNode* next;   // Next polynomial node
}; //end-PolyNode

#endif