Factory example based on the previous 'Factory Method' Scenario: Store information about a Point in Cartesian (x,y), but also initialize the point from Polar Cordinates (rho and theta). 

Similar to builder Pattern, all 'Point' creating functions can be separated of the 'Point' class, making it a factory.

Then, unlike the previous example in 'Factory_Method', the constructor of 'Point' can't be hidden by private or protected. It needs to be externally accessible. 
