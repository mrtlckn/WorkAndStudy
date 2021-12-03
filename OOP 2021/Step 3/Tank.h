#pragma once

class Tank {
private:
	double capacity;
	double fuel_quantity;
	bool broken;
	int tank_id, quantity;

public:
	void set_capacity(double Capacity);
	double get_capacity();
	void set_fuel_quantity(bool Fuel_quantity);
	bool get_fuel_quantity();
	void set_broken(int Broken);
	int get_broken(); //end-GetSetMethods

	
	void add_fuel(int Tank_id, int Quantity);

	void add_fuel_tank(int Capacity);
	void list_fuel_tanks();
	void remove_fuel_tank(int Tank_id);
	bool connect_fuel_tank_to_engine(int Tank_id);
	bool disconnect_fuel_tank_from_engine(int Tank_id);
	void open_valve(int Tank_id);
	void close_valve(int Tank_id);
	void break_fuel_tank(int Tank_id);
	void repair_fuel_tank(int Tank_id);

	void print_total_fuel_quantity();
	void print_total_consumed_fuel_quantity();
	void print_tank_info(int Tank_id);
	void fill_tank(int Tank_id, double Fuel_quantity);

	Tank();



};