# CANivore nanoFramework Example Project
This is the example project that uses the ESP32 on CANivore for basic NanoFramework functionality

## Installation requirements
To use this project, you will need to install NanoFramework.
This can be accomplished by following the guide provided by NanoFramework here: https://docs.nanoFramework.net/content/getting-started-guides/getting-started-managed.html

Once NanoFramework is installed, you will need to install the CANivore-specific firmware for CAN functionality.
This can be accomplished by running the following command in powershell, installing the provided .bin file in this repository: `nanoff.exe --update --target ESP32_WROOM_32 --clrfile "nanoCLR.bin" --serialport <CANivore COM Port>`.

After that, you will be able to create new NanoFramework projects, and install all the nanoFramework packages through nuget.
CTR Electronics also provides a nuget package for CANivore functionality, available here: https://www.nuget.org/packages/ctre.canivore

This repository also contains an example project with the nuget packages already configured, so all you need to do is open the project and connect to the device.

## Current Support
This is the initial release of this project, features will be steadily added as development continues.

For now, the feature list is limited to:
 - Connecting to CANivore and verifying connection
 - Sending CAN frame
 - Wi-Fi through NanoFramework
