# unity-corgi-engine-joystick
Controlling the Corgi Engine Joystick for Unity Games by dragging the half of the screen


this is a small script in c# used for the Corgi Engine in Unity to control the joystick on mobile by dragging your finger on any place on the middle of the screen.

To make it work create a new panel to fill the half of the screen and set it under the UICamera in your Unity Scene.

attach the HalfScreenTouch  script with the panel fill the objects with: 
  - UICamera as TargetCamera
  - Joystick knob as joystick
  - Joystick knob as joystickTransform
  
  ![2019-03-28_11-20-55](https://user-images.githubusercontent.com/5835334/55138082-0719b380-514c-11e9-9ea8-40e131212868.png)
