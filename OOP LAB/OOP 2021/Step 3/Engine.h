#pragma once
#include "Tank.h"


class Engine: Tank{
private:
	double fuel_per_second=5.5;
	bool status;
	double internal_tank_capacity;
	double heat;
	double health;
	//internal tank(unlimited) ekle
	//with list instead of array


public:
	void set_fuel_per_second(double Fuel_per_second);
	double get_fuel_per_second();
	void set_status(bool Status);
	bool get_status();
	void set_internal_tank_capacity(double Internal_tank_capacity);
	double get_internal_tank_capacity();//end-GetSetMethods

	Engine(
	);//SRP yap
	void start_engine();
	void stop_engine();
	void print_fuel_tank_count();
	void list_connected_tanks();
	
	void wait(int seconds);
	void stop_simulation();

	void change_engine_block();
	void repair_engine();
	void full_throttle(int seconds);
	void engine_health(double heat, double health);
	void engine_repair(double health);

};