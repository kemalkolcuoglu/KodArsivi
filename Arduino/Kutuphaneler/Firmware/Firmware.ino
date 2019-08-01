// Include Libraries
#include "Arduino.h"
#include "DCMDriverL298.h"
#include "NewPing.h"


// Pin Definitions
#define DCMOTOR_PIN_ENA	6
#define DCMOTOR_PIN_INT1	2
#define DCMOTOR_PIN_INT2	3
#define DCMOTOR_PIN_ENB	5
#define DCMOTOR_PIN_INT3	4
#define DCMOTOR_PIN_INT4	7
#define HCSR04_PIN_TRIG	8
#define HCSR04_PIN_ECHO	9

// Global variables and defines

// Constructors
DCMDriverL298 dcMotor(DCMOTOR_PIN_ENA,DCMOTOR_PIN_INT1,DCMOTOR_PIN_INT2,DCMOTOR_PIN_ENB,DCMOTOR_PIN_INT3,DCMOTOR_PIN_INT4);
NewPing hcsr04(HCSR04_PIN_TRIG,HCSR04_PIN_ECHO);




// define vars for testing menu
#define TIMEOUT 10000       //define timeout of 10 sec
char menuOption = 0;
long time0;
/* This code sets up the essentials for your circuit to work. It runs first every time your circuit is powered with electricity. */
void setup() {
    // Setup Serial which is useful for debugging
    // Use the Serial Monitor to view printed messages
    Serial.begin(9600);
    while (!Serial) ; // wait for serial port to connect. Needed for native USB
    Serial.println("start");
    
    
}

/* This code is the main logic of your circuit. It defines the interaction between the components you selected. After setup, it runs over and over again, in an eternal loop. */
void loop() {
    // Read data from serial monitor if received
    while (Serial.available()) {
        char c = Serial.read();
        if (isAlphaNumeric(c)) {
          menuOption = c;
          printselection();
          time0 = millis();
    }}
    
    if(menuOption == '1' && testTimeout()) {
    //DCMDriverL298 - Test Code
    //Start both motors. note that rotation direction is determined by the motors connection to the driver.
    //You can change the speed by setting a value between 0-255, and set the direction by changing between 1 and 0.
    dcMotor.setMotorA(200,1);
    dcMotor.setMotorB(200,0);
    delay(2000);
    //Stop both motors
    dcMotor.stopMotors();
    delay(2000);
    
    }
    else if(menuOption == '2' && testTimeout()) {
    //HCSR04 - Test Code
    // Read distance measurment from UltraSonic sensor           
    int hcsr04Dist = hcsr04.ping_cm();
    delay(10);
    Serial.print(F("Distance: ")); Serial.print(hcsr04Dist); Serial.println(F("[cm]"));
    
    }
    
    
    else
        menu();
  
    
}


// This is a menu function for selecting the components to be tested
// Follow serial monitor for instrcutions
char menu()
{
    Serial.println(F("\nWhich component would you like to test?"));    
    Serial.println(F("(1) DCMDriverL298"));
    Serial.println(F("(2) HCSR04"));
    Serial.println(F("(menu) send anything else or press on board reset button\n"));
    while (!Serial.available());
    delay(20);

}

// This section is used to print the selected option to the serial monitor
void printselection()
{
    if(menuOption == '1') 	Serial.println(F("Now Testing DCMDriverL298"));
    else if(menuOption == '2') 	Serial.println(F("Now Testing HCSR04"));
    else  Serial.println(F("illegal input!"));
    Serial.println();
}

// This is a testTimeout function for the testing duration of a component
// Time out value is set by testTimeout which is defined before setup(), you can change it to make testing duration shorter/longer
bool testTimeout()
{
    if (millis() - time0 > TIMEOUT)
        return false;
    else
        return true;
}


/*******************************************************

*    Circuito.io is an automatic generator of schematics and code for off
*    the shelf hardware combinations.

*    Copyright (C) 2016 Roboplan Technologies Ltd.

*    This program is free software: you can redistribute it and/or modify
*    it under the terms of the GNU General Public License as published by
*    the Free Software Foundation, either version 3 of the License, or
*    (at your option) any later version.

*    This program is distributed in the hope that it will be useful,
*    but WITHOUT ANY WARRANTY; without even the implied warranty of
*    MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.  See the
*    GNU General Public License for more details.

*    You should have received a copy of the GNU General Public License
*    along with this program.  If not, see <http://www.gnu.org/licenses/>.

*    In addition, and without limitation, to the disclaimers of warranties 
*    stated above and in the GNU General Public License version 3 (or any 
*    later version), Roboplan Technologies Ltd. ("Roboplan") offers this 
*    program subject to the following warranty disclaimers and by using 
*    this program you acknowledge and agree to the following:
*    THIS PROGRAM IS PROVIDED ON AN "AS IS" AND "AS AVAILABLE" BASIS, AND 
*    WITHOUT WARRANTIES OF ANY KIND EITHER EXPRESS OR IMPLIED.  ROBOPLAN 
*    HEREBY DISCLAIMS ALL WARRANTIES, EXPRESS OR IMPLIED, INCLUDING BUT 
*    NOT LIMITED TO IMPLIED WARRANTIES OF MERCHANTABILITY, TITLE, FITNESS 
*    FOR A PARTICULAR PURPOSE, NON-INFRINGEMENT, AND THOSE ARISING BY 
*    STATUTE OR FROM A COURSE OF DEALING OR USAGE OF TRADE. 
*    YOUR RELIANCE ON, OR USE OF THIS PROGRAM IS AT YOUR SOLE RISK.
*    ROBOPLAN DOES NOT GUARANTEE THAT THE PROGRAM WILL BE FREE OF, OR NOT 
*    SUSCEPTIBLE TO, BUGS, SECURITY BREACHES, OR VIRUSES. ROBOPLAN DOES 
*    NOT WARRANT THAT YOUR USE OF THE PROGRAM, INCLUDING PURSUANT TO 
*    SCHEMATICS, INSTRUCTIONS OR RECOMMENDATIONS OF ROBOPLAN, WILL BE SAFE 
*    FOR PERSONAL USE OR FOR PRODUCTION OR COMMERCIAL USE, WILL NOT 
*    VIOLATE ANY THIRD PARTY RIGHTS, WILL PROVIDE THE INTENDED OR DESIRED
*    RESULTS, OR OPERATE AS YOU INTENDED OR AS MAY BE INDICATED BY ROBOPLAN. 
*    YOU HEREBY WAIVE, AGREE NOT TO ASSERT AGAINST, AND RELEASE ROBOPLAN, 
*    ITS LICENSORS AND AFFILIATES FROM, ANY CLAIMS IN CONNECTION WITH ANY OF 
*    THE ABOVE. 
********************************************************/