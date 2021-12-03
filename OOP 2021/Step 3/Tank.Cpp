#include <stdlib.h>
#include <iostream>
#include "Tank.h"
using namespace std;
Tank::Tank() {
	this->fuel_quantity = 0;
	this->broken = 0;
	this->capacity = 0;
}
void Tank::set_capacity(double Capacity) { capacity = Capacity; }
double Tank::get_capacity() { return capacity; }

void Tank::set_fuel_quantity(bool Fuel_quantity) { fuel_quantity = Fuel_quantity; }
bool Tank::get_fuel_quantity() { return fuel_quantity; }

void Tank::set_broken(int Broken) { broken = Broken; }
int Tank::get_broken() { return broken; }

void Tank::add_fuel(int Tank_id, int Quantity) {}

void Tank::add_fuel_tank(int Capacity) {}
void Tank::list_fuel_tanks() {}
void Tank::remove_fuel_tank(int Tank_id) {}
bool Tank::connect_fuel_tank_to_engine(int Tank_id) {
	cout << "Motora baglandý " << Tank_id;
	return 1;
}
bool Tank::disconnect_fuel_tank_from_engine(int Tank_id) {
	cout << "Motor Stop etti " << Tank_id;
	return 0;
}
void Tank::open_valve(int Tank_id) {
	cout << Tank_id << ". tankin vanasý acildi." << endl;
}
void Tank::close_valve(int Tank_id) {
	cout << Tank_id << ". tankin vanasý kapandi." << endl;
}
void Tank::break_fuel_tank(int Tank_id) {}
void Tank::repair_fuel_tank(int Tank_id) {}

void Tank::print_total_fuel_quantity(){}
void Tank::print_total_consumed_fuel_quantity(){}
void Tank::print_tank_info(int Tank_id){}
void Tank::fill_tank(int Tank_id, double Fuel_quantity){}