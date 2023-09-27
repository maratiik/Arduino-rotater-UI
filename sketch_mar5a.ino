#include <Stepper.h>

#define STEPS 200
Stepper stepper(STEPS, 2, 3);
#define motorInterfaceType 1;
String data;
bool checkManualControl = 0;


void setup()
{
  Serial.begin(9600);
  Serial.setTimeout(20);
  stepper.setSpeed(1000);
}

void loop()
{

  if(Serial.available() > 0)
  {
    data = Serial.readString();
    
    if(data == "a")
      stepper.step(800);
    else if(data == "mnl_on")
      manualControl();
    else
      prog(data);
  }
}

void prog(String str)
{
  //Serial.println("Program started to execute");
  int space;
  float value;
  int steps;
  String command;
  float totalAngle = 0;

  while(str.length() > 0)
  {
    space = str.indexOf('_');
    command = str.substring(0, space);
    str.remove(0, space + 1);

    if(command.substring(0, 3) == "spd") // set Speed (spdVALUE)
    {
      command.remove(0, 3);
      value = command.toInt();
      stepper.setSpeed(value * 4);
      //Serial.print("Speed set to ");
      //Serial.println(value);
    }

    if(command.substring(0, 3) == "rot") // rotate (rotVALUE)
    {
      command.remove(0, 3);
      value = command.toFloat();
      steps = 800 * value / 360;
      stepper.step(steps);
      //Serial.print("Rotated ");
      //Serial.println(value);

      totalAngle += value; // the sum of all rotations for reset if needed
    }

    if(totalAngle >= 360) // keeping totalAngle from -359 to +359
      totalAngle -= 360;
    if(totalAngle <= -360)
      totalAngle += 360;

    if(command.substring(0, 3) == "dly") // delay (dlyVALUE)
    {
      command.remove(0, 3);
      value = command.toFloat();
      delay(value);
      //Serial.print("Delayed ");
      //Serial.println(value);
    }

    if(command.substring(0, 3) == "rst") // reset (rst)
    {
      command.remove(0, 3);
      steps = 800 * totalAngle / 360;
      stepper.step(-steps);
      //Serial.print("Reseted ");
      //Serial.println(-totalAngle);
      totalAngle = 0;
    }

    if(command.substring(0, 3) == "zro") // set zero (zro)
    {
      command.remove(0, 3);
      totalAngle = 0;
    }
  }
}

void manualControl()
{
  //Serial.println("Program started to execute");
  int space;
  float value;
  int steps;
  float totalAngle = 0;
  while(1)
  {
    if(Serial.available() > 0)
    {
      String data = Serial.readString();
      
      if(data == "mnl_off") // Manual Control OFF
      {
        return;
      }

      if(data.substring(0, 3) == "spd") // Set speed
      {
        data.remove(0, 3);
        value = data.toInt();
        stepper.setSpeed(value * 4);
      }

      if(data.substring(0, 3) == "rot") // Rotate
      {
        data.remove(0, 3);
        value = data.toFloat();
        steps = 800 * value / 360;
        stepper.step(steps);

        totalAngle += value;
      }

      if(totalAngle >= 360) // Keeping totalAngle from -359 to +359
      totalAngle -= 360;
      if(totalAngle <= -360)
        totalAngle += 360;

      if(data == "rst") // Reset
      {
        steps = 800 * totalAngle / 360;
        stepper.step(-steps);

        totalAngle = 0;
      }

      if(data == "zro_") // Set Zero
      {
        totalAngle = 0;
      }
    }
  }
}
