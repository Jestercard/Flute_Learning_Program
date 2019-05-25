*****MIDI INSTRUMENT PROJECT*****

Note that this project is ongoing.

Purpose: To develop hardware and software that can be used for both live performance and as a teaching aid for beginners.

General Components:

1)Hardware that simulates playing a flute.
- Buttons along a tube that correspond with pads and keys
- Sensors that detect change in breath direction as well as speed
- Has onboard circuitry to allow for 2nd component (see below).
2)Software that interprets commands on hardware and conveys them as MIDI messages (ITMP).
- Uses Arduino Uno as platform: https://store.arduino.cc/usa/arduino-uno-rev3
- Uses Hiduino to program Arduino to be MIDI compliant: https://github.com/ddiakopoulos/hiduino
- Least amount of latency between input and output
- Has 2 modes that allow for MIDI messages to be sent based on patterns or by individual button presses
3)Software that interprets MIDI messages and displays feedback via monitor
- Shows the keys that are being pressed and corresponding note
- Develop challenges to help teach note skills

Component 1 - Hardware

 Will have a button corresponding with every key and lever on a standard flute
 Microphones sense change in air speed, which can be used when changing octaves.
 All buttons will be placed alongside a tube (likely PVC until final design is nailed down) and wires will run down the tube connecting to the Arduino at the end. The Arduino will be covered and will have the ability to connect to a computer via a USB cable (wireless option possible in the future).

Component 2 - Input to MIDI Program (ITMP)

 Majority of this will be written within the Arduino IDE: https://www.arduino.cc/en/Main/Software
 C-based, very similar to C++. Language Glossary: https://www.arduino.cc/reference/en/

 Output of Arduino will be MIDI data. Hiduino is to only be used to make an Arduino to be recognized as a MIDI device instead of serial. This will allow the device to be connected to any computer and played on most any Digital Audio Workstation and synthesizers. Check out blog post here: https://cachrecording.wixsite.com/cachrecording/midi-controller

Component 3 - Flute Learning Program

 Majority of this will be written within Code::Blocks.
 C++ language using the Windows API.
 Program will be run externally on a computer and will accept MIDI messages as input. This will allow for individual note presses to be picked up and sent, rather than patterns recognized.
 There will be the free play option. Basically it will take an input and display it on screen.
 There will be challenges to where someone has to play along with the patterns on a screen and be scored based on how well it was followed. Challenges will vary in difficulty.
 There will be options menu to adjust window size and other various settings.