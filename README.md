# MinDrives

As of late, your usually high-performance computer has been acting rather sluggish. You come to 
realize that while you have plenty of free disk space on your machine, it is split up over many hard 
drives. You decide that the secret to improving performance is to consolidate all the data on your 
computer onto as few hard drives as possible. 
Given a Integer() used, representing the amount of disk space used on each drive, and a 
corresponding Integer() total , representing the total capacity of each drive mentioned in used, you 
should attempt to pack the data onto as few hard drives as possible. You may assume that the data 
consists of very small files, such that splitting it up and moving parts of it onto different hard 
drives never presents a problem. Return the minimum number of hard drives that still contain data 
after the consolidation is complete.

Solution:

In order to get the fewest hard drives possible, we must relocate the data, filling up from the bigest hard drive to the smalest. The solution contains the class DiskSpace which contains one method called MinDrive that does exactly this thing. First it sorts the total array descendings. Afterwards it calculates the sum of Used Space. Finally it uses a for loop to add the size of each hard drive, begining from the largest, until we reach the used sum.
