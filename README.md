# Affordance Judgement

## Introduction
This project is to explore human affordance judgement in mobile AR and how cognitive cue influence affordance judgement in Real World and in AR condition. 
### 1. Mobile AR
	What's the critical threshold?(given by estimation from participants) 
  
	Is the threshold closer to Real World(1.3*shoulder width) or Hololens?
### 2. Provide AR cue
	Does AR cue change affordance judgement?
  
		- Does Real World affordance change with changing AR cue?
    
		- Does AR object affordance judgement change with changing AR cue?
    
    Repeat in Hololens.

## Platform
Unity 2019.2.9f1

Android 9

ARCore SDK 1.15.0

## Interaction
*Surface Detection*

Hold the smart phone upright and start the app. Scan the environment and there will be triangular grids on the floor when the system detect that surface. Hit a specific point on the detected area and a pair of poles will show up on that point with 1m gap width.

*Move Virtual Poles*

Click on button 'Inward' or 'Outward' to make the two poles change 5cm increments inward or outward. Input your shoulder width on upper left corner. You can click the button 'Go!' when you think you have adjust the gap between two poles to right let you pass through without turning your shoulder. The system will show 'You went through successfully!' when the gap width is larger than or equal to your shoulder width; and show 'Poles fell down!' when your input shoulder width is larger than the gap width of poles.

*Show the Cue*

There is a button 'Cue' under the input field. When you click on that button, there will be a bar with your shoulder width size showing in your left. You can use that as a cue to help you estimate the minimum gap letting you go through.

## Limitation
The height of the poles looks higher than the defined scale of z axis. And moving too fast may lead to drift of virtual objects sometimes.

## How to run the code
Download AJ20200213.apk from AJ20200213/APP file and install it on an Android phone. Then run the app by referencing the interaction description.
