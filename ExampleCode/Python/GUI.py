from Tkinter import *
import json
import urllib2
import requests,sys

master = Tk()

def callback():
    data = json.load(urllib2.urlopen('http://rsense-dev.cs.uml.edu/api/v1/projects/683'))
    print data

b = Button(master, text="OK", command=callback)
b.pack()

mainloop()