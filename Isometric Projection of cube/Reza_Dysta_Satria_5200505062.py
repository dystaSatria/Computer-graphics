
import pygame as pyg
from pygame.locals import *
from OpenGL.GL import *
from OpenGL.GLU import *

verticies = [
    [1, -1, -1],    
    [0, 0, -1], 
    [-1, 1, -1],    
    [-1, -1, -1], 
    [1, -1, 1],     
    [-1, -1, 1],    
    [-1, 0, 0],     
    [-1, 0, -1],    
    [0, -1, 0],     
    [-1, -1, 0],    
    [0, -1, -1],    
    [-0.5, 0, 0],   
    [0, 0, -0.5],   
    [0, -0.5, 0],   
]

noktalar = [
    [0,3],
    [2,3],
    [5,3],
    [6,7],
    [7,1],
    [8,9],
    [8,10],
    [10, 1],
    [9, 6],
    [6,11],
    [1,12],
    [12,11],
    [13,12],
    [13,11],
    [13,8],
    ]

def kup():
    glBegin(GL_LINES)
    for nokta in noktalar:
        for deger in nokta:
            glVertex3fv(verticies[deger])
    glEnd()

pyg.init()
display = (800,600)
pyg.display.set_mode(display, DOUBLEBUF|OPENGL)

gluPerspective(45, (display[0]/display[1]), 0.1, 50.0)

glTranslatef(0.0,0.0, -5)

glRotatef(120,1,0,1)

glRotatef(20,0,1,1)

glClear(GL_COLOR_BUFFER_BIT|GL_DEPTH_BUFFER_BIT)
kup()
pyg.display.flip()
input("Bitti")
