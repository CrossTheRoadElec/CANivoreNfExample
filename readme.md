# CANivore Nanoframework Example Project
This is the example project that uses the ESP32 on CANivore for basic Nanoframework functionality

## Installation requirements
In order to use this project, you will need to install Nanoframework.
This can be accomplished by following the guide provided by Nanoframework here: https://docs.nanoframework.net/content/getting-started-guides/getting-started-managed.html

Once Nanoframework is installed, you will need to install the CANivore-specific firmware for CAN functionality.
This can be accomplished by running the following command in powershell, installing the provided .bin file in this repository: `nanoff.exe --update --target ESP32_WROOM_32 --clrfile "nanoCLR.bin" --serialport <CANivore COM Port>`.

After that, you will be able to create new Nanoframework projects, and install all the nanoframework packages through nuget.
CTR Electronics also provides a nuget package for CANivore functionality, available here: https://www.nuget.org/packages/ctre.canivore

This repository also contains an example project with the nuget packages already configured, so all you need to do is open the project and connect to the device.

## Current Support
This project is still in its early stages of development, and there is very little support currently.

The support amounts to the following:
 - Connecting to CANivore and verifying connection
 - Sending CAN frames

