#include "Deque.h"

///------------------------------------------------------
/// Default constructor
/// 
Deque::Deque() {
	// Fill this in
	head = NULL;
	tail = NULL;
} //end-Deque

///------------------------------------------------------
/// Destructor
/// 
Deque::~Deque() {
	// Fill this in
	while (head != NULL) {
		head = head->next;
		delete head;
	}
} //end-~Deque

///------------------------------------------------------
/// Adds a new item to the front of the Deque
/// 
void Deque::AddFront(int item) {
	// Fill this in
	DequeNode* node = new DequeNode(item);
	if (head == NULL) {
		// This is the first node to be inserted
		head = tail = node;
	}
	else {
		node->next = head;
		head->prev = node;
		
		head = node;
	}
	
} //end-AddFront

///------------------------------------------------------
/// Adds a new item to the end of the Deque
/// 
void Deque::AddRear(int item) {
	// Fill this in
	DequeNode* node = new DequeNode(item);
	if (tail == NULL) {
		// This is the first node to be inserted
		head = tail = node;
	}
	else {
		node->prev = tail;
		tail->next = node;
		tail = node;
	}
	
} //end-AddRear

///------------------------------------------------------
/// Remove and return the item at the front of the Deque
/// If the Deque is empty, throw an exception
/// 
int Deque::RemoveFront() {
	int temp;
	if (head != NULL) {
		if (head == tail) {
			temp = head->item;
			delete head;
			head = tail = NULL;
		}
		else {
			temp = head->item;
			head = head->next;
			delete head->prev;
			head->prev = NULL;
			// deallocate the memory taken by temp
		}
	}

	return temp;
	
} //end-RemoveFront

///------------------------------------------------------
/// Remove and return the item at the rear of the Deque
/// If the Deque is empty, throw an exception
/// 
int Deque::RemoveRear() {
	int temp;
	if (head != NULL) {
		if (head == tail) {
			temp = head->item;
			delete head;
			head = NULL;
		}
		else {
			temp = tail->item;
			tail = tail->prev;
			delete tail->next;
			tail->next = NULL;
		}
	}
	return temp;

} //end-RemoveRear

///------------------------------------------------------
/// Return the item at the front of the Deque (do not remove the item)
/// If the Deque is empty, throw an exception
/// 
int Deque::Front() {
	// Fill this in
	int temp;
	if (head != NULL) {
		temp = head->item;
	}
	return temp;
	
} //end-Front

///------------------------------------------------------
/// Return the item at the rear of the Deque (do not remove the item)
/// If the Deque is empty, throw an exception
/// 
int Deque::Rear() {
	int temp;
	if (tail != NULL) {
		temp = tail->item;
	}
	return temp;
} //end-Rear
