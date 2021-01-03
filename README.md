# fy6800_fm_changer

FM Modulation Controller for Feeltech FY6800 Signal Generator

The procedure for setting the source to CH2 with FM modulation is as follows.  
* Select FM in Modulation Mode
* Set Source to CH2
* Enable CH2 in SG mode (make the signal output from CH2)
* Return to Modulation Mode and set BIAS to the desired modulation level.
At this time, the amplitude set in CH2 has no effect on any value.
When BIAS is 1kHz, the deviation is 1kHz with p-p. [ not (p-p)/2 ].

To change the modulation frequency, you need to change the frequency of CH2 in signal generation mode and then return to Modulation Mode.    
If you want to change continuously, this is a lot of work.   
So, I made this application that specializes in operating FM modulation.  

for more infomation (Japanese):   
http://blog.nomulabo.com/article/473701821.html
