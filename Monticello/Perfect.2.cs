'From Squeak3.9.1 of 2 March 2008 [latest update: #7075] on 19 April 2009 at 6:19:27 pm'!!Integer methodsFor: '*perfect' stamp: 'on 4/19/2009 18:19'!divisors	^ (1 to: self - 1 ) select: [ :each | (self rem: each) = 0 ]! !!Integer methodsFor: '*perfect' stamp: 'on 4/19/2009 18:19'!isPerfect	^ self > 1 and: [self divisors sum = self]! !!PerfectTest methodsFor: 'running' stamp: 'on 4/19/2009 18:17'!testPerfectBoundary	self assert: 0 isPerfect not.	self assert: 1 isPerfect not.! !