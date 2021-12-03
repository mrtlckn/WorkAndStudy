#include <stdlib.h>
#include <iostream>
#include <list>
#include "Engine.h"
using namespace std;
Engine::Engine() {
	this->fuel_per_second = 5.5;
	/*this->status = 0;
	this->internal_tank_capacity = 55.0;*/
}
void Engine::set_fuel_per_second(double Fuel_per_second)
{	
	fuel_per_second = 5.5; // It will always 5.5
}
double Engine::get_fuel_per_second() {return fuel_per_second; }
void Engine::set_status(bool Status) { status = Status; }
bool Engine::get_status() { return status; }
void Engine::set_internal_tank_capacity(double Internal_tank_capacity) { internal_tank_capacity = Internal_tank_capacity; }
double Engine::get_internal_tank_capacity() { return internal_tank_capacity; } //end-GetSetMethods


void Engine::start_engine() {
	if (health > 20) {
		//If engine health is lower or equal 20 percent engine can be stopped but doesn’t start
		if (get_fuel_per_second() == 5.5) {
			cout << "dogru";
		}
	}
}
void Engine::stop_engine(){
	if (get_fuel_quantity() == 0) {//Engine stops when there is no fuel in connected fuel tank.	
		status = 0;
		cout << "Motor Durdu";
	}
	//if (disconnect_fuel_tank_from_engine(get_tank_id()) == 0) {// Engine stops when a fuel tank disconnected from engine.
	//	status = 0;
	//}
}
void Engine::print_fuel_tank_count(){}
void Engine::list_connected_tanks(){}
void Engine::wait(int second){}
void Engine::stop_simulation(){}

void Engine::change_engine_block(){}
void Engine::repair_engine(){}
void Engine::full_throttle(int second) {}
void Engine::engine_health(double heat, double health){
		//hotter than 130C will damage engine 1 percent health (130 >)
		//while engine is stopped engine cools down to 20C (1 secs = 1C),
		//while engine running idle engine cools down or heats up to 90C (1 secs = 1C),
		//ile full throttle engine heats up (no max limit) (1secs = 5C) also damages 
		//the engine if the engine is cooler than 90C (1 percent per seconds),
		//full throttle also consumes 5 times more than fuel consumption of idle mode

}
void Engine::engine_repair(double health){
	if (status = 0) {
		//Repairand change engine commands shouldn’t work while engine is running.
		if (health != 0) {
			//Engine can be repaired if health is NOT 0 percent.
		}
		if (health = 0) {
			//Engine block can be changed if health is 0 percent (simply reset engine properties).
		}
	}
}
